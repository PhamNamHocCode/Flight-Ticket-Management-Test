using DAO.Airport;
using DAO.CabinClass;
using DAO.Flight;
using GUI.Components.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Features.Flight.SubFeatures
{
    public partial class FlightListControl : UserControl
    {
        private DataTable _airportData;
        private bool _isUpdatingComboBoxes = false;

        public FlightListControl()
        {
            InitializeComponent();
        }
        #region Data Loading
        private void LoadFlightData()
        {
            try
            {
                // Tải danh sách chuyến bay (đã JOIN)
                DataTable dtFlights = FlightDAO.Instance.GetFlightDetailsForDisplay();
                danhSachChuyenBay.DataSource = dtFlights;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chuyến bay: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FlightCreateControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            danhSachChuyenBay.AutoGenerateColumns = false;

            LoadInitialData();

            LoadFlightData();
        }
        private void timChuyenBay_Click(object sender, EventArgs e)
        {
            // TODO: Bổ sung logic lọc (filter) vào câu SQL
            // Hiện tại, nó chỉ tải lại toàn bộ danh sách
            LoadFlightData();
        }
        private void LoadInitialData()
        {
            try
            {
                // 1. Tải và gán danh sách Hạng vé
                DataTable dtCabinClasses = CabinClassDAO.Instance.GetAllCabinClasses();
                if (danhSachChuyenBay.Columns["Column7"] is DataGridViewComboBoxColumn cbColumn)
                {
                    cbColumn.DataSource = dtCabinClasses;
                    cbColumn.DisplayMember = "class_name";
                    cbColumn.ValueMember = "class_id";
                }

                // 2. Tải danh sách Sân bay
                _airportData = AirportDAO.Instance.GetAllAirportsForComboBox();

                // 3. Gán dữ liệu cho ComboBox "Nơi cất cánh"
                noiCatCanh.DataSource = _airportData.Copy();
                noiCatCanh.DisplayMember = "DisplayName";
                noiCatCanh.ValueMember = "airport_id";

                // 4. Gán dữ liệu cho ComboBox "Nơi hạ cánh"
                noiHaCanh.DataSource = _airportData.Copy();
                noiHaCanh.DisplayMember = "DisplayName";
                noiHaCanh.ValueMember = "airport_id";

                // 5. Xóa lựa chọn mặc định
                noiCatCanh.SelectedIndex = -1;
                noiHaCanh.SelectedIndex = -1;

                // 6. Gán dữ liệu cho ComboBox "Hành trình bay"
                khuHoi_MotChieu.Items.Clear();
                khuHoi_MotChieu.Items.Add("Một chiều");
                khuHoi_MotChieu.Items.Add("Khứ hồi");

                // 7. Gán sự kiện để xử lý logic (Một chiều/Khứ hồi)
                khuHoi_MotChieu.SelectedIndexChanged -= khuHoi_MotChieu_SelectedIndexChanged;
                khuHoi_MotChieu.SelectedIndexChanged += khuHoi_MotChieu_SelectedIndexChanged;

                // 8. Đặt giá trị mặc định và kích hoạt logic (để tắt "Ngày về")
                khuHoi_MotChieu.SelectedIndex = 0; // Chọn "Một chiều"
                UpdateNgayVeStatus(); // Cập nhật trạng thái Enabled/Disabled

                // 9. Chặn chọn ngày quá khứ cho cả 2 control
                dateTimeNgayDi.MinDate = DateTime.Today;
                dateTimeNgayVe.MinDate = DateTime.Today;

                // 10. Gán sự kiện khi "Ngày đi" thay đổi
                dateTimeNgayDi.DateTimePicker.ValueChanged -= dateTimeNgayDi_ValueChanged;
                dateTimeNgayDi.DateTimePicker.ValueChanged += dateTimeNgayDi_ValueChanged;

                // 11. Gán sự kiện khi "Nơi cất cánh" và "Nơi hạ cánh" thay đổi
                noiCatCanh.SelectedIndexChanged -= noiCatCanh_SelectedIndexChanged;
                noiCatCanh.SelectedIndexChanged += noiCatCanh_SelectedIndexChanged;

                noiHaCanh.SelectedIndexChanged -= noiHaCanh_SelectedIndexChanged;
                noiHaCanh.SelectedIndexChanged += noiHaCanh_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu ban đầu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        private void dateTimeNgayDi_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeNgayVe_Load(object sender, EventArgs e)
        {

        }

        private void noiCatCanh_Load(object sender, EventArgs e)
        {
        }

        private void noiHaCanh_Load(object sender, EventArgs e)
        {
        }

        private void danhSachChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Được gọi khi người dùng thay đổi lựa chọn Một chiều/Khứ hồi
        /// </summary>
        private void khuHoi_MotChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNgayVeStatus();
        }

        /// <summary>
        /// Logic chính: Cập nhật trạng thái của control "Ngày về"
        /// </summary>
        private void UpdateNgayVeStatus()
        {
            string selectedValue = khuHoi_MotChieu.SelectedItem?.ToString() ?? "";

            if (selectedValue == "Một chiều")
            {
                dateTimeNgayVe.Enabled = false;
            }
            else // "Khứ hồi"
            {
                dateTimeNgayVe.Enabled = true;
            }
        }

        /// <summary>
        /// Được gọi khi giá trị (ngày) của control "Ngày đi" thay đổi
        /// </summary>
        private void dateTimeNgayDi_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDepartureDate = dateTimeNgayDi.Value;
            dateTimeNgayVe.MinDate = selectedDepartureDate;

            if (dateTimeNgayVe.Value < selectedDepartureDate)
            {
                dateTimeNgayVe.Value = selectedDepartureDate;
            }
        }

        /// <summary>
        /// Xử lý khi người dùng chọn "Nơi cất cánh"
        /// </summary>
        private void noiCatCanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingComboBoxes) return;

            object selectedValue = noiCatCanh.SelectedItem;
            if (selectedValue == null)
            {
                FilterAirportDataSource(noiHaCanh, null);
                return;
            }

            var selectedAirportId = ((DataRowView)selectedValue)[noiCatCanh.ValueMember];
            FilterAirportDataSource(noiHaCanh, selectedAirportId);
        }

        /// <summary>
        /// Xử lý khi người dùng chọn "Nơi hạ cánh"
        /// </summary>
        private void noiHaCanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingComboBoxes) return;

            object selectedValue = noiHaCanh.SelectedItem;
            if (selectedValue == null)
            {
                FilterAirportDataSource(noiCatCanh, null);
                return;
            }

            var selectedAirportId = ((DataRowView)selectedValue)[noiHaCanh.ValueMember];
            FilterAirportDataSource(noiCatCanh, selectedAirportId);
        }

        /// <summary>
        /// Phương thức trợ giúp: Lọc và gán lại DataSource cho một ComboBox
        /// </summary>
        private void FilterAirportDataSource(UnderlinedComboBox comboBoxToUpdate, object idToExclude)
        {
            object currentSelection = comboBoxToUpdate.SelectedItem;
            _isUpdatingComboBoxes = true;

            try
            {
                DataView dv = new DataView(_airportData);

                if (idToExclude != null && idToExclude != DBNull.Value)
                {
                    dv.RowFilter = string.Format("{0} <> {1}",
                                                 _airportData.Columns[comboBoxToUpdate.ValueMember].ColumnName,
                                                 idToExclude);
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }

                comboBoxToUpdate.DataSource = dv;
                comboBoxToUpdate.DisplayMember = "DisplayName";
                comboBoxToUpdate.ValueMember = "airport_id";

                if (currentSelection != null)
                {
                    var currentId = ((DataRowView)currentSelection)[comboBoxToUpdate.ValueMember];
                    if (idToExclude == null || !currentId.Equals(idToExclude))
                    {
                        comboBoxToUpdate.SelectedValue = currentId;
                    }
                    else
                    {
                        comboBoxToUpdate.SelectedIndex = -1;
                    }
                }
                else
                {
                    comboBoxToUpdate.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc danh sách sân bay: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isUpdatingComboBoxes = false;
            }
        }
    }
}
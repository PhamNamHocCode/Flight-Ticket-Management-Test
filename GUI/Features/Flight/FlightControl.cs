using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Components.Buttons; // Cần thêm
using GUI.Features.Flight.SubFeatures;

namespace GUI.Features.Flight
{
    public partial class FlightControl : UserControl
    {
        // Khai báo các UserControl con (các tab)
        private FlightCreateControl flightCreateControl;
        private FlightDetailControl flightDetailControl;
        private FlightListControl flightListControl;

        // Lưu tab đang được chọn
        private int _currentIndex = 0;

        public FlightControl()
        {
            InitializeComponent(); // Hàm này được gọi từ file .Designer.cs

            // Khởi tạo các UserControl con
            flightCreateControl = new FlightCreateControl { Dock = DockStyle.Fill };
            flightDetailControl = new FlightDetailControl { Dock = DockStyle.Fill };
            flightListControl = new FlightListControl { Dock = DockStyle.Fill };

            // Thêm các UserControl con vào các Panel host (đã được tạo trong Designer)
            panelFlightCreate.Controls.Add(flightCreateControl);
            panelFlightDetail.Controls.Add(flightDetailControl);
            panelFlightList.Controls.Add(flightListControl);
        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            // Đảm bảo control tự lấp đầy khi được load
            this.Dock = DockStyle.Fill;

            // Hiển thị tab đầu tiên (Danh sách)
            SwitchTab(0);
        }

        private void buttonDanhSachChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(0);
        }

        private void buttonTaoMoiChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(1);
        }

        /// <summary>
        /// Hàm chính xử lý việc chuyển tab
        /// </summary>
        void SwitchTab(int index)
        {
            if (_currentIndex == index && panelTabs.Controls.Count > 0)
                return; // Không cần làm gì nếu đã ở tab đó

            _currentIndex = index;

            // 1. Cập nhật giao diện các nút tab
            RebuildTabButtons();

            // 2. Ẩn/Hiện các panel nội dung
            // (Chúng ta theo logic gốc của bạn: 0=Create, 1=List, 2=Detail)

            // Ẩn tất cả
            panelFlightCreate.Visible = false;
            panelFlightList.Visible = false;
            panelFlightDetail.Visible = false;

            // Chỉ hiện thị panel tương ứng
            switch (index)
            {
                case 0: // Tab Danh sách (FlightCreateControl)
                    panelFlightCreate.Visible = true;
                    panelFlightCreate.BringToFront();
                    break;
                case 1: // Tab Tạo mới (FlightListControl)
                    panelFlightList.Visible = true;
                    panelFlightList.BringToFront();
                    break;
                case 2: // Tab Chi tiết (Detail)
                    panelFlightDetail.Visible = true;
                    panelFlightDetail.BringToFront();
                    break;
            }
        }

        /// <summary>
        /// Vẽ lại các nút tab (Primary/Secondary)
        /// </summary>
        private void RebuildTabButtons()
        {
            panelTabs.SuspendLayout();
            panelTabs.Controls.Clear();

            // Nút "Danh sách"
            buttonDanhSachChuyenBay = (_currentIndex == 0)
                ? new PrimaryButton("Danh sách")
                : new SecondaryButton("Danh sách");

            // Nút "Tạo mới"
            buttonTaoMoiChuyenBay = (_currentIndex == 1)
                ? new PrimaryButton("Tạo mới")
                : new SecondaryButton("Tạo mới");

            // Gán lại sự kiện
            buttonDanhSachChuyenBay.Click += buttonDanhSachChuyenBay_Click;
            buttonTaoMoiChuyenBay.Click += buttonTaoMoiChuyenBay_Click;

            // Thêm lại vào FlowLayoutPanel
            panelTabs.Controls.Add(buttonDanhSachChuyenBay);
            panelTabs.Controls.Add(buttonTaoMoiChuyenBay);

            panelTabs.ResumeLayout(false);
        }
    }
}
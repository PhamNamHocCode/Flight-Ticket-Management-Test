using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Components.Buttons; // Cần thiết để dùng Primary/Secondary Button
using GUI.Features.Flight.SubFeatures;

namespace GUI.Features.Flight
{
    // Đảm bảo đây là 'partial class' để liên kết với file .Designer.cs
    public partial class FlightControl : UserControl
    {
        // Khai báo các UserControl con (các tab)
        private FlightListControl flightListControl;
        private FlightCreateControl flightCreateControl;
        // (Bạn có thể thêm flightDetailControl ở đây khi cần)

        // Khai báo các nút để có thể gán lại sự kiện
        private Button buttonDanhSach;
        private Button buttonTaoMoi;

        public FlightControl()
        {
            InitializeComponent(); // Hàm này gọi file .Designer.cs
            InitializeSubControls(); // Hàm tự viết để khởi tạo các UserControl con
        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            // Đảm bảo control tự lấp đầy khi được load
            this.Dock = DockStyle.Fill;
            // Hiển thị tab đầu tiên (Danh sách)
            SwitchTab(0);
        }

        /// <summary>
        /// Khởi tạo các UserControl con và thêm vào panelContent
        /// </summary>
        private void InitializeSubControls()
        {
            // Khởi tạo
            flightListControl = new FlightListControl
            {
                Dock = DockStyle.Fill,
                Visible = true // Ẩn ban đầu
            };

            flightCreateControl = new FlightCreateControl
            {
                Dock = DockStyle.Fill,
                Visible = true // Ẩn ban đầu
            };

            // Thêm vào panelContent
            panelContent.Controls.Add(flightListControl);
            panelContent.Controls.Add(flightCreateControl);
        }

        /// <summary>
        /// Hàm chính xử lý việc chuyển tab
        /// </summary>
        /// <param name="index">0 = Danh sách, 1 = Tạo mới</param>
        private void SwitchTab(int index)
        {
            // 1. Ẩn/Hiện các panel nội dung
            flightListControl.Visible = (index == 0);
            flightCreateControl.Visible = (index == 1);

            // 2. Cập nhật giao diện các nút tab (theo style của dự án)
            RebuildTabButtons(index);
        }

        /// <summary>
        /// Vẽ lại các nút tab (Primary/Secondary) để cập nhật style
        /// </summary>
        private void RebuildTabButtons(int activeIndex)
        {
            // Xóa các nút cũ khỏi panelButton
            panelButton.Controls.Clear();

            // Tạo lại nút "Danh sách"
            if (activeIndex == 0)
                buttonDanhSach = new PrimaryButton("Danh sách");
            else
                buttonDanhSach = new SecondaryButton("Danh sách");

            // Tạo lại nút "Tạo mới"
            if (activeIndex == 1)
                buttonTaoMoi = new PrimaryButton("Tạo mới");
            else
                buttonTaoMoi = new SecondaryButton("Tạo mới");

            // Gán lại sự kiện Click
            buttonDanhSach.Click += (sender, e) => SwitchTab(0);
            buttonTaoMoi.Click += (sender, e) => SwitchTab(1);

            // Thêm lại các nút vào panelButton
            panelButton.Controls.Add(buttonDanhSach);
            panelButton.Controls.Add(buttonTaoMoi);
        }
    }
}
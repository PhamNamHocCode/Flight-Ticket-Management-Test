using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Components.Buttons;
using GUI.Features.Flight.SubFeatures;

namespace GUI.Features.Flight
{
    public partial class FlightControlold : UserControl
    {
        // Khai báo các UserControl con (các tab)
        private FlightCreateControl flightCreateControl;
        private FlightDetailControl flightDetailControl;
        private FlightListControl flightListControl;

        // Lưu tab đang được chọn
        private int _currentIndex = 0;

        public FlightControlold()
        {
            InitializeComponent();

            // Khởi tạo các UserControl con
            flightCreateControl = new FlightCreateControl { Dock = DockStyle.Fill };
            flightDetailControl = new FlightDetailControl { Dock = DockStyle.Fill };
            flightListControl = new FlightListControl { Dock = DockStyle.Fill };

            // Thêm các UserControl con vào các Panel host (đã được tạo trong Designer)
            panelFlightCreate.Controls.Add(flightCreateControl);
            panelFlightDetail.Controls.Add(flightDetailControl);
            panelFlightList.Controls.Add(flightListControl);

            panelFlightCreate.Visible = true;
            panelFlightDetail.Visible = true;
        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            // Đảm bảo control tự lấp đầy khi được load
            this.Dock = DockStyle.Fill;
            SwitchTab(0);
        }

        private void buttonDanhSachChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(0); // 0 = Danh sách
        }

        private void buttonTaoMoiChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(1); // 1 = Tạo mới
        }

        /// <summary>
        /// Hàm chính xử lý việc chuyển tab
        /// </summary>
        void SwitchTab(int index)
        {
            // Không cần làm gì nếu đã ở tab đó
            if (_currentIndex == index && panelTabs.Controls.Count > 0)
                return;

            _currentIndex = index;

            // 1. Cập nhật giao diện các nút tab
            RebuildTabButtons();

            // 2. Ẩn/Hiện các panel nội dung
            panelFlightCreate.Visible = false;
            panelFlightList.Visible = false;
            panelFlightDetail.Visible = false;
            // Chỉ hiện thị panel tương ứng
            switch (index)
            {
                case 0: // Tab "Danh sách" -> hiển thị panelFlightList
                    panelFlightList.Visible = true;
                    panelFlightList.BringToFront();
                    break;
                case 1: // Tab "Tạo mới" -> hiển thị panelFlightCreate
                    panelFlightCreate.Visible = true;
                    panelFlightCreate.BringToFront();
                    break;
                case 2: // Tab Chi tiết (Detail)
                    panelFlightDetail.Visible = true;
                    panelFlightDetail.BringToFront();
                    break;
            }
            panelTabs.BringToFront();
        }

        /// <summary>
        /// Vẽ lại các nút tab (Primary/Secondary)
        /// </summary>
        private void RebuildTabButtons()
        {
            panelTabs.SuspendLayout();

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
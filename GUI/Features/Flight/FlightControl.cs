using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Components.Buttons;
using GUI.Features.Flight.SubFeatures;

namespace GUI.Features.Flight
{
    public partial class FlightControl : UserControl
    {
        private FlightCreateControl flightCreateControl;
        private FlightDetailControl flightDetailControl;
        private FlightListControl flightListControl;

        private int _currentIndex = 0;

        public FlightControl()
        {
            InitializeComponent();

            flightCreateControl = new FlightCreateControl { Dock = DockStyle.Fill };
            flightDetailControl = new FlightDetailControl { Dock = DockStyle.Fill };
            flightListControl = new FlightListControl { Dock = DockStyle.Fill };

            panelContent.Controls.Add(panelFlightList);
            panelContent.Controls.Add(panelFlightCreate);
            panelContent.Controls.Add(panelFlightDetail);

            panelFlightCreate.Controls.Add(flightCreateControl);
            panelFlightDetail.Controls.Add(flightDetailControl);
            panelFlightList.Controls.Add(flightListControl);

            panelFlightCreate.Visible = false;
            panelFlightDetail.Visible = false;
        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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
        void SwitchTab(int index)
        {
            if (_currentIndex == index && panelTabs.Controls.Count > 0)
                return;

            _currentIndex = index;

            panelFlightCreate.Visible = false;
            panelFlightList.Visible = false;
            panelFlightDetail.Visible = false;
            switch (index)
            {
                case 0:
                    panelFlightList.Visible = true;
                    break;
                case 1:
                    panelFlightCreate.Visible = true;
                    break;
                case 2:
                    panelFlightDetail.Visible = true;
                    break;
            }
            panelTabs.BringToFront();
        }

        private void danhSachChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(0);
        }

        private void taoMoiChuyenBay_Click(object sender, EventArgs e)
        {
            SwitchTab(1);
        }
    }
}
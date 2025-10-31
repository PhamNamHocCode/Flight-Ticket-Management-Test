using GUI.Components.Buttons;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Features.Flight
{
    partial class FlightControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTabs = new FlowLayoutPanel();
            buttonDanhSachChuyenBay = new Button();
            buttonTaoMoiChuyenBay = new Button();
            panelContent = new Panel();
            panelFlightList = new Panel();
            panelFlightDetail = new Panel();
            panelFlightCreate = new Panel();
            panelTabs.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelTabs
            // 
            panelTabs.AutoSize = true;
            panelTabs.BackColor = Color.White;
            panelTabs.Controls.Add(buttonDanhSachChuyenBay);
            panelTabs.Controls.Add(buttonTaoMoiChuyenBay);
            panelTabs.Dock = DockStyle.Top;
            panelTabs.Location = new Point(0, 0);
            panelTabs.Name = "panelTabs";
            panelTabs.Padding = new Padding(24, 12, 0, 0);
            panelTabs.Size = new Size(572, 41);
            panelTabs.TabIndex = 0;
            // 
            // buttonDanhSachChuyenBay
            // 
            buttonDanhSachChuyenBay.Location = new Point(27, 15);
            buttonDanhSachChuyenBay.Name = "buttonDanhSachChuyenBay";
            buttonDanhSachChuyenBay.Size = new Size(75, 23);
            buttonDanhSachChuyenBay.TabIndex = 0;
            buttonDanhSachChuyenBay.Text = "Danh sách chuyến bay";
            buttonDanhSachChuyenBay.UseVisualStyleBackColor = true;
            buttonDanhSachChuyenBay.Click += buttonDanhSachChuyenBay_Click_1;
            // 
            // buttonTaoMoiChuyenBay
            // 
            buttonTaoMoiChuyenBay.Location = new Point(108, 15);
            buttonTaoMoiChuyenBay.Name = "buttonTaoMoiChuyenBay";
            buttonTaoMoiChuyenBay.Size = new Size(75, 23);
            buttonTaoMoiChuyenBay.TabIndex = 1;
            buttonTaoMoiChuyenBay.Text = "Tạo mới chuyến bay";
            buttonTaoMoiChuyenBay.UseVisualStyleBackColor = true;
            buttonTaoMoiChuyenBay.Click += buttonTaoMoiChuyenBay_Click_1;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelFlightList);
            panelContent.Controls.Add(panelFlightDetail);
            panelContent.Controls.Add(panelFlightCreate);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 41);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(572, 276);
            panelContent.TabIndex = 1;
            // 
            // panelFlightList
            // 
            panelFlightList.Dock = DockStyle.Fill;
            panelFlightList.Location = new Point(0, 0);
            panelFlightList.Name = "panelFlightList";
            panelFlightList.Size = new Size(572, 276);
            panelFlightList.TabIndex = 1;
            // 
            // panelFlightDetail
            // 
            panelFlightDetail.Dock = DockStyle.Fill;
            panelFlightDetail.Location = new Point(0, 0);
            panelFlightDetail.Name = "panelFlightDetail";
            panelFlightDetail.Size = new Size(572, 276);
            panelFlightDetail.TabIndex = 2;
            // 
            // panelFlightCreate
            // 
            panelFlightCreate.Dock = DockStyle.Fill;
            panelFlightCreate.Location = new Point(0, 0);
            panelFlightCreate.Name = "panelFlightCreate";
            panelFlightCreate.Size = new Size(572, 276);
            panelFlightCreate.TabIndex = 0;
            // 
            // FlightControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelTabs);
            Name = "FlightControl";
            Size = new Size(572, 317);
            Load += FlightControl_Load;
            panelTabs.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Khai báo các biến control
        private FlowLayoutPanel panelTabs; // Đổi từ Panel sang FlowLayoutPanel
        private Button buttonDanhSachChuyenBay;
        private Panel panelContent;
        private Panel panelFlightDetail;
        private Panel panelFlightCreate;
        private Button buttonTaoMoiChuyenBay;
        private Panel panelFlightList;
    }
}
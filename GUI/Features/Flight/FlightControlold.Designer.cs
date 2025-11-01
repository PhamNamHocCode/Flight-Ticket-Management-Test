using GUI.Components.Buttons;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Features.Flight
{
    partial class FlightControlold
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
            panelTabs = new Panel();
            panelFlightList = new Panel();
            panelFlightCreate = new Panel();
            panelFlightDetail = new Panel();
            danhSachChuyenBay = new SecondaryButton();
            taoMoiChuyenBay = new SecondaryButton();
            panelTabs.SuspendLayout();
            SuspendLayout();
            // 
            // panelTabs
            // 
            panelTabs.Controls.Add(taoMoiChuyenBay);
            panelTabs.Controls.Add(danhSachChuyenBay);
            panelTabs.Location = new Point(0, 0);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(1106, 97);
            panelTabs.TabIndex = 0;
            // 
            // panelFlightList
            // 
            panelFlightList.Location = new Point(119, 262);
            panelFlightList.Name = "panelFlightList";
            panelFlightList.Size = new Size(200, 100);
            panelFlightList.TabIndex = 1;
            // 
            // panelFlightCreate
            // 
            panelFlightCreate.Location = new Point(487, 289);
            panelFlightCreate.Name = "panelFlightCreate";
            panelFlightCreate.Size = new Size(200, 100);
            panelFlightCreate.TabIndex = 2;
            // 
            // panelFlightDetail
            // 
            panelFlightDetail.Location = new Point(390, 452);
            panelFlightDetail.Name = "panelFlightDetail";
            panelFlightDetail.Size = new Size(200, 100);
            panelFlightDetail.TabIndex = 3;
            // 
            // danhSachChuyenBay
            // 
            danhSachChuyenBay.AutoSize = true;
            danhSachChuyenBay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            danhSachChuyenBay.BackColor = Color.White;
            danhSachChuyenBay.BorderColor = Color.FromArgb(40, 40, 40);
            danhSachChuyenBay.BorderThickness = 2;
            danhSachChuyenBay.CornerRadius = 22;
            danhSachChuyenBay.EnableHoverEffects = true;
            danhSachChuyenBay.FlatAppearance.BorderSize = 0;
            danhSachChuyenBay.FlatStyle = FlatStyle.Flat;
            danhSachChuyenBay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            danhSachChuyenBay.ForeColor = Color.FromArgb(155, 209, 243);
            danhSachChuyenBay.HoverBackColor = Color.FromArgb(155, 209, 243);
            danhSachChuyenBay.HoverBorderColor = Color.FromArgb(0, 92, 175);
            danhSachChuyenBay.HoverForeColor = Color.White;
            danhSachChuyenBay.Icon = null;
            danhSachChuyenBay.IconSize = new Size(22, 22);
            danhSachChuyenBay.IconSpacing = 10;
            danhSachChuyenBay.Location = new Point(22, 48);
            danhSachChuyenBay.Name = "danhSachChuyenBay";
            danhSachChuyenBay.NormalBackColor = Color.White;
            danhSachChuyenBay.NormalBorderColor = Color.FromArgb(40, 40, 40);
            danhSachChuyenBay.NormalForeColor = Color.FromArgb(155, 209, 243);
            danhSachChuyenBay.Padding = new Padding(24, 10, 24, 10);
            danhSachChuyenBay.PreferredMaxWidth = 0;
            danhSachChuyenBay.PressedBackColor = Color.FromArgb(120, 191, 239);
            danhSachChuyenBay.PressedBorderColor = Color.FromArgb(31, 111, 178);
            danhSachChuyenBay.PressedForeColor = Color.White;
            danhSachChuyenBay.Size = new Size(245, 46);
            danhSachChuyenBay.TabIndex = 0;
            danhSachChuyenBay.Text = "Danh sách chuyến bay";
            danhSachChuyenBay.TextAlign = ContentAlignment.MiddleLeft;
            danhSachChuyenBay.UseVisualStyleBackColor = false;
            danhSachChuyenBay.WordWrap = false;
            // 
            // taoMoiChuyenBay
            // 
            taoMoiChuyenBay.AutoSize = true;
            taoMoiChuyenBay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            taoMoiChuyenBay.BackColor = Color.White;
            taoMoiChuyenBay.BorderColor = Color.FromArgb(40, 40, 40);
            taoMoiChuyenBay.BorderThickness = 2;
            taoMoiChuyenBay.CornerRadius = 22;
            taoMoiChuyenBay.EnableHoverEffects = true;
            taoMoiChuyenBay.FlatAppearance.BorderSize = 0;
            taoMoiChuyenBay.FlatStyle = FlatStyle.Flat;
            taoMoiChuyenBay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            taoMoiChuyenBay.ForeColor = Color.FromArgb(155, 209, 243);
            taoMoiChuyenBay.HoverBackColor = Color.FromArgb(155, 209, 243);
            taoMoiChuyenBay.HoverBorderColor = Color.FromArgb(0, 92, 175);
            taoMoiChuyenBay.HoverForeColor = Color.White;
            taoMoiChuyenBay.Icon = null;
            taoMoiChuyenBay.IconSize = new Size(22, 22);
            taoMoiChuyenBay.IconSpacing = 10;
            taoMoiChuyenBay.Location = new Point(269, 48);
            taoMoiChuyenBay.Name = "taoMoiChuyenBay";
            taoMoiChuyenBay.NormalBackColor = Color.White;
            taoMoiChuyenBay.NormalBorderColor = Color.FromArgb(40, 40, 40);
            taoMoiChuyenBay.NormalForeColor = Color.FromArgb(155, 209, 243);
            taoMoiChuyenBay.Padding = new Padding(24, 10, 24, 10);
            taoMoiChuyenBay.PreferredMaxWidth = 0;
            taoMoiChuyenBay.PressedBackColor = Color.FromArgb(120, 191, 239);
            taoMoiChuyenBay.PressedBorderColor = Color.FromArgb(31, 111, 178);
            taoMoiChuyenBay.PressedForeColor = Color.White;
            taoMoiChuyenBay.Size = new Size(228, 46);
            taoMoiChuyenBay.TabIndex = 1;
            taoMoiChuyenBay.Text = "Tạo mới chuyến bay";
            taoMoiChuyenBay.TextAlign = ContentAlignment.MiddleLeft;
            taoMoiChuyenBay.UseVisualStyleBackColor = false;
            taoMoiChuyenBay.WordWrap = false;
            // 
            // FlightControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFlightDetail);
            Controls.Add(panelFlightCreate);
            Controls.Add(panelFlightList);
            Controls.Add(panelTabs);
            Name = "FlightControl";
            Size = new Size(1106, 624);
            Load += FlightControl_Load;
            panelTabs.ResumeLayout(false);
            panelTabs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Các nút bấm này sẽ được khởi tạo trong file .cs
        // Chúng ta khai báo chúng ở đây để partial class có thể thấy chúng
        private Button buttonDanhSachChuyenBay;
        private Button buttonTaoMoiChuyenBay;
        private Panel panelTabs;
        private SecondaryButton taoMoiChuyenBay;
        private SecondaryButton danhSachChuyenBay;
        private Panel panelFlightList;
        private Panel panelFlightCreate;
        private Panel panelFlightDetail;
    }
}
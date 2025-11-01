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
            this.panelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.AutoSize = true;
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(24, 12, 0, 0);
            this.panelButton.Size = new System.Drawing.Size(1124, 12);
            this.panelButton.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1124, 639);
            this.panelContent.TabIndex = 1;
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelButton);
            this.Name = "FlightControl";
            this.Size = new System.Drawing.Size(1124, 651);
            this.Load += new System.EventHandler(this.FlightControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Các panel-cha được định nghĩa ở đây
        private System.Windows.Forms.FlowLayoutPanel panelButton;
        private System.Windows.Forms.Panel panelContent;
    }
}
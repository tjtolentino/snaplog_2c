namespace SnapLog
{
    partial class formConfig
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SettingsGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // SettingsGrid
            // 
            this.SettingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsGrid.Location = new System.Drawing.Point(0, 0);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.Size = new System.Drawing.Size(284, 262);
            this.SettingsGrid.TabIndex = 0;
            // 
            // formConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SettingsGrid);
            this.Name = "formConfig";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.PropertyGrid SettingsGrid;
    }
}

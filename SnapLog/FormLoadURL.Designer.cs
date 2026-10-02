namespace SnapLog
{
    partial class FormLoadURL
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
            this.Button1 = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button1.Location = new System.Drawing.Point(0, 215);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(248, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Open";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listFiles
            // 
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.listFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 16;
            this.listFiles.Location = new System.Drawing.Point(0, 0);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(248, 212);
            this.listFiles.Sorted = true;
            this.listFiles.TabIndex = 1;
            // 
            // FormLoadURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 238);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLoadURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load URL List";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLoadURL_Load);
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ListBox listFiles;
    }
}

namespace SnapLog
{
    partial class FormTraceRoute
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
            this.components = new System.ComponentModel.Container();
            this.listTrace = new System.Windows.Forms.ListView();
            this.colTTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrRefreshData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listTrace
            // 
            this.listTrace.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listTrace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTTL,
            this.colHost,
            this.colTimeout});
            this.listTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTrace.FullRowSelect = true;
            this.listTrace.GridLines = true;
            this.listTrace.HotTracking = true;
            this.listTrace.HoverSelection = true;
            this.listTrace.Location = new System.Drawing.Point(0, 0);
            this.listTrace.Margin = new System.Windows.Forms.Padding(4);
            this.listTrace.Name = "listTrace";
            this.listTrace.Size = new System.Drawing.Size(369, 504);
            this.listTrace.TabIndex = 1;
            this.listTrace.UseCompatibleStateImageBehavior = false;
            this.listTrace.View = System.Windows.Forms.View.Details;
            // 
            // colTTL
            // 
            this.colTTL.Text = "Hop";
            this.colTTL.Width = 50;
            // 
            // colHost
            // 
            this.colHost.Text = "Host";
            this.colHost.Width = 200;
            // 
            // colTimeout
            // 
            this.colTimeout.Text = "Time";
            this.colTimeout.Width = 60;
            // 
            // tmrRefreshData
            // 
            this.tmrRefreshData.Enabled = true;
            this.tmrRefreshData.Interval = 1000;
            this.tmrRefreshData.Tick += new System.EventHandler(this.tmrRefreshData_Tick);
            // 
            // FormTraceRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 504);
            this.Controls.Add(this.listTrace);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTraceRoute";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trace Route Results";
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.ListView listTrace;
        internal System.Windows.Forms.ColumnHeader colTTL;
        internal System.Windows.Forms.ColumnHeader colHost;
        internal System.Windows.Forms.ColumnHeader colTimeout;
        protected internal System.Windows.Forms.Timer tmrRefreshData;
    }
}

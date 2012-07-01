namespace Release_v2
{
    partial class StorageWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_orders = new System.Windows.Forms.ListBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_orders
            // 
            this.lb_orders.FormattingEnabled = true;
            this.lb_orders.Location = new System.Drawing.Point(13, 13);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(259, 212);
            this.lb_orders.TabIndex = 0;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(13, 227);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(259, 23);
            this.bt_refresh.TabIndex = 1;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // StorageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.lb_orders);
            this.Name = "StorageWindow";
            this.Text = "StorageWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_orders;
        private System.Windows.Forms.Button bt_refresh;
    }
}
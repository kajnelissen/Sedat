﻿namespace Release_v2
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
            this.SuspendLayout();
            // 
            // lb_orders
            // 
            this.lb_orders.FormattingEnabled = true;
            this.lb_orders.Location = new System.Drawing.Point(13, 13);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(259, 238);
            this.lb_orders.TabIndex = 0;
            // 
            // StorageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_orders);
            this.Name = "StorageWindow";
            this.Text = "StorageWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_orders;
    }
}
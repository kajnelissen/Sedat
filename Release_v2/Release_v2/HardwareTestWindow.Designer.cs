namespace Release_v2
{
    partial class HardwareTestWindow
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
            this.lb_HWtest = new System.Windows.Forms.ListBox();
            this.btn_goedkeuring = new System.Windows.Forms.Button();
            this.btn_afgekeurd = new System.Windows.Forms.Button();
            this.cbl_HWtestcomponenten = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_verzend_testrapport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lb_HWtest
            //
            this.lb_HWtest.FormattingEnabled = true;
            this.lb_HWtest.Location = new System.Drawing.Point(25, 41);
            this.lb_HWtest.Name = "lb_HWtest";
            this.lb_HWtest.Size = new System.Drawing.Size(166, 225);
            this.lb_HWtest.TabIndex = 0;
            this.lb_HWtest.SelectedIndexChanged += new System.EventHandler(this.lb_HWtest_SelectedIndexChanged);
            //
            // btn_goedkeuring
            //
            this.btn_goedkeuring.Location = new System.Drawing.Point(73, 303);
            this.btn_goedkeuring.Name = "btn_goedkeuring";
            this.btn_goedkeuring.Size = new System.Drawing.Size(75, 23);
            this.btn_goedkeuring.TabIndex = 1;
            this.btn_goedkeuring.Text = "Goedkeuren";
            this.btn_goedkeuring.UseVisualStyleBackColor = true;
            this.btn_goedkeuring.Click += new System.EventHandler(this.btn_goedkeuring_Click);
            //
            // btn_afgekeurd
            //
            this.btn_afgekeurd.Location = new System.Drawing.Point(170, 303);
            this.btn_afgekeurd.Name = "btn_afgekeurd";
            this.btn_afgekeurd.Size = new System.Drawing.Size(75, 23);
            this.btn_afgekeurd.TabIndex = 2;
            this.btn_afgekeurd.Text = "Afkeuren";
            this.btn_afgekeurd.UseVisualStyleBackColor = true;
            this.btn_afgekeurd.Click += new System.EventHandler(this.btn_afgekeurd_Click);
            //
            // cbl_HWtestcomponenten
            //
            this.cbl_HWtestcomponenten.FormattingEnabled = true;
            this.cbl_HWtestcomponenten.Location = new System.Drawing.Point(226, 41);
            this.cbl_HWtestcomponenten.Name = "cbl_HWtestcomponenten";
            this.cbl_HWtestcomponenten.Size = new System.Drawing.Size(120, 94);
            this.cbl_HWtestcomponenten.TabIndex = 3;
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(226, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 81);
            this.textBox1.TabIndex = 4;
            //
            // btn_verzend_testrapport
            //
            this.btn_verzend_testrapport.Location = new System.Drawing.Point(226, 156);
            this.btn_verzend_testrapport.Name = "btn_verzend_testrapport";
            this.btn_verzend_testrapport.Size = new System.Drawing.Size(75, 23);
            this.btn_verzend_testrapport.TabIndex = 5;
            this.btn_verzend_testrapport.Text = "Verzend";
            this.btn_verzend_testrapport.UseVisualStyleBackColor = true;
            //
            // HardwareTestWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 369);
            this.Controls.Add(this.btn_verzend_testrapport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbl_HWtestcomponenten);
            this.Controls.Add(this.btn_afgekeurd);
            this.Controls.Add(this.btn_goedkeuring);
            this.Controls.Add(this.lb_HWtest);
            this.Name = "HardwareTestWindow";
            this.Text = "HardwareTestWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_HWtest;
        private System.Windows.Forms.Button btn_goedkeuring;
        private System.Windows.Forms.Button btn_afgekeurd;
        private System.Windows.Forms.CheckedListBox cbl_HWtestcomponenten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_verzend_testrapport;
    }
}
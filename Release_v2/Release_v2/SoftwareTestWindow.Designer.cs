namespace Release_v2
{
    partial class SoftwareTestWindow
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
            this.lb_SWTest = new System.Windows.Forms.ListBox();
            this.cbl_SWtestcomponenten = new System.Windows.Forms.CheckedListBox();
            this.btn_SWgoedkeuring = new System.Windows.Forms.Button();
            this.btn_SWafkeuring = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_verzendSWtestrapport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lb_SWTest
            //
            this.lb_SWTest.FormattingEnabled = true;
            this.lb_SWTest.Location = new System.Drawing.Point(25, 65);
            this.lb_SWTest.Name = "lb_SWTest";
            this.lb_SWTest.Size = new System.Drawing.Size(137, 238);
            this.lb_SWTest.TabIndex = 0;
            this.lb_SWTest.SelectedIndexChanged += new System.EventHandler(this.lb_SWTest_SelectedIndexChanged);
            //
            // cbl_SWtestcomponenten
            //
            this.cbl_SWtestcomponenten.FormattingEnabled = true;
            this.cbl_SWtestcomponenten.Location = new System.Drawing.Point(207, 65);
            this.cbl_SWtestcomponenten.Name = "cbl_SWtestcomponenten";
            this.cbl_SWtestcomponenten.Size = new System.Drawing.Size(120, 94);
            this.cbl_SWtestcomponenten.TabIndex = 1;
            //
            // btn_SWgoedkeuring
            //
            this.btn_SWgoedkeuring.Location = new System.Drawing.Point(67, 326);
            this.btn_SWgoedkeuring.Name = "btn_SWgoedkeuring";
            this.btn_SWgoedkeuring.Size = new System.Drawing.Size(75, 23);
            this.btn_SWgoedkeuring.TabIndex = 2;
            this.btn_SWgoedkeuring.Text = "Goedkeuren";
            this.btn_SWgoedkeuring.UseVisualStyleBackColor = true;
            this.btn_SWgoedkeuring.Click += new System.EventHandler(this.btn_SWgoedkeuring_Click);
            //
            // btn_SWafkeuring
            //
            this.btn_SWafkeuring.Location = new System.Drawing.Point(173, 326);
            this.btn_SWafkeuring.Name = "btn_SWafkeuring";
            this.btn_SWafkeuring.Size = new System.Drawing.Size(75, 23);
            this.btn_SWafkeuring.TabIndex = 3;
            this.btn_SWafkeuring.Text = "Afkeuren";
            this.btn_SWafkeuring.UseVisualStyleBackColor = true;
            this.btn_SWafkeuring.Click += new System.EventHandler(this.btn_SWafkeuring_Click);
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(207, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 82);
            this.textBox1.TabIndex = 4;
            //
            // btn_verzendSWtestrapport
            //
            this.btn_verzendSWtestrapport.Location = new System.Drawing.Point(207, 185);
            this.btn_verzendSWtestrapport.Name = "btn_verzendSWtestrapport";
            this.btn_verzendSWtestrapport.Size = new System.Drawing.Size(75, 23);
            this.btn_verzendSWtestrapport.TabIndex = 5;
            this.btn_verzendSWtestrapport.Text = "Verzend";
            this.btn_verzendSWtestrapport.UseVisualStyleBackColor = true;
            //
            // SoftwareTestWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 381);
            this.Controls.Add(this.btn_verzendSWtestrapport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_SWafkeuring);
            this.Controls.Add(this.btn_SWgoedkeuring);
            this.Controls.Add(this.cbl_SWtestcomponenten);
            this.Controls.Add(this.lb_SWTest);
            this.Name = "SoftwareTestWindow";
            this.Text = "SoftwareTestWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_SWTest;
        private System.Windows.Forms.CheckedListBox cbl_SWtestcomponenten;
        private System.Windows.Forms.Button btn_SWgoedkeuring;
        private System.Windows.Forms.Button btn_SWafkeuring;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_verzendSWtestrapport;
    }
}
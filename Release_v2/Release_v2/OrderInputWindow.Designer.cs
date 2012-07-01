namespace Release_v2
{
    partial class OrderInputWindow
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
            this.bt_orderPlaatsen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_soort = new System.Windows.Forms.ComboBox();
            this.cb_cpu = new System.Windows.Forms.ComboBox();
            this.cb_gpu = new System.Windows.Forms.ComboBox();
            this.cb_ssd = new System.Windows.Forms.ComboBox();
            this.tb_overige = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_opmerkingen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_orderPlaatsen
            // 
            this.bt_orderPlaatsen.Location = new System.Drawing.Point(12, 322);
            this.bt_orderPlaatsen.Name = "bt_orderPlaatsen";
            this.bt_orderPlaatsen.Size = new System.Drawing.Size(245, 23);
            this.bt_orderPlaatsen.TabIndex = 0;
            this.bt_orderPlaatsen.Text = "Order plaatsen";
            this.bt_orderPlaatsen.UseVisualStyleBackColor = true;
            this.bt_orderPlaatsen.Click += new System.EventHandler(this.bt_orderPlaatsen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soort order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "GPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SSD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Overige";
            // 
            // cb_soort
            // 
            this.cb_soort.FormattingEnabled = true;
            this.cb_soort.Items.AddRange(new object[] {
            "desktop",
            "laptop"});
            this.cb_soort.Location = new System.Drawing.Point(102, 14);
            this.cb_soort.Name = "cb_soort";
            this.cb_soort.Size = new System.Drawing.Size(155, 21);
            this.cb_soort.TabIndex = 7;
            // 
            // cb_cpu
            // 
            this.cb_cpu.FormattingEnabled = true;
            this.cb_cpu.Items.AddRange(new object[] {
            "Intel® Core™ i3-2100 Processor",
            "Intel® Core™ i5-2400 Processor",
            "Intel® Core™ i7-3770K Processor"});
            this.cb_cpu.Location = new System.Drawing.Point(102, 53);
            this.cb_cpu.Name = "cb_cpu";
            this.cb_cpu.Size = new System.Drawing.Size(155, 21);
            this.cb_cpu.TabIndex = 8;
            // 
            // cb_gpu
            // 
            this.cb_gpu.FormattingEnabled = true;
            this.cb_gpu.Items.AddRange(new object[] {
            "GPU1",
            "GPU2",
            "GPU3"});
            this.cb_gpu.Location = new System.Drawing.Point(102, 91);
            this.cb_gpu.Name = "cb_gpu";
            this.cb_gpu.Size = new System.Drawing.Size(155, 21);
            this.cb_gpu.TabIndex = 9;
            // 
            // cb_ssd
            // 
            this.cb_ssd.FormattingEnabled = true;
            this.cb_ssd.Items.AddRange(new object[] {
            "SSD1",
            "SSD2",
            "SSD3"});
            this.cb_ssd.Location = new System.Drawing.Point(102, 130);
            this.cb_ssd.Name = "cb_ssd";
            this.cb_ssd.Size = new System.Drawing.Size(155, 21);
            this.cb_ssd.TabIndex = 10;
            // 
            // tb_overige
            // 
            this.tb_overige.Location = new System.Drawing.Point(102, 164);
            this.tb_overige.Name = "tb_overige";
            this.tb_overige.Size = new System.Drawing.Size(155, 20);
            this.tb_overige.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Opmerkingen";
            // 
            // tb_opmerkingen
            // 
            this.tb_opmerkingen.Location = new System.Drawing.Point(12, 226);
            this.tb_opmerkingen.Multiline = true;
            this.tb_opmerkingen.Name = "tb_opmerkingen";
            this.tb_opmerkingen.Size = new System.Drawing.Size(245, 90);
            this.tb_opmerkingen.TabIndex = 12;
            // 
            // OrderInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 357);
            this.Controls.Add(this.tb_opmerkingen);
            this.Controls.Add(this.tb_overige);
            this.Controls.Add(this.cb_ssd);
            this.Controls.Add(this.cb_gpu);
            this.Controls.Add(this.cb_cpu);
            this.Controls.Add(this.cb_soort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_orderPlaatsen);
            this.Name = "OrderInputWindow";
            this.Text = "OrderInputWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_orderPlaatsen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_soort;
        private System.Windows.Forms.ComboBox cb_cpu;
        private System.Windows.Forms.ComboBox cb_gpu;
        private System.Windows.Forms.ComboBox cb_ssd;
        private System.Windows.Forms.TextBox tb_overige;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_opmerkingen;
    }
}
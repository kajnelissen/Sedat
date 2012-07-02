namespace Gui
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_bevestigOrder = new System.Windows.Forms.Label();
            this.tb_overige = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ssd = new System.Windows.Forms.ComboBox();
            this.cb_gpu = new System.Windows.Forms.ComboBox();
            this.cb_cpu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_orderPlaatsen = new System.Windows.Forms.Button();
            this.lb_opmerkingen = new System.Windows.Forms.Label();
            this.tb_opmerkingen = new System.Windows.Forms.TextBox();
            this.cb_soort = new System.Windows.Forms.ComboBox();
            this.lb_soort = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cl_ComponentenInOrder = new System.Windows.Forms.CheckedListBox();
            this.btn_assemblage_voltooid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_OrderHwBouwen = new System.Windows.Forms.ListBox();
            this.lb_binnenkomend = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_afgekeurd = new System.Windows.Forms.Button();
            this.btn_akkoord = new System.Windows.Forms.Button();
            this.cl_hwTestComponenten = new System.Windows.Forms.CheckedListBox();
            this.btn_sendTest = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_testrapportHw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_TestOrders = new System.Windows.Forms.ListBox();
            this.lb_TOrders = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cl_ComponentenInstall = new System.Windows.Forms.CheckedListBox();
            this.btn_Bevestig_Installatie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_OrderToInstall = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cl_testComponentenSw = new System.Windows.Forms.CheckedListBox();
            this.btn_swAfgekeurd = new System.Windows.Forms.Button();
            this.btn_swGoed = new System.Windows.Forms.Button();
            this.bt_verstuurRapport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_TestrapportSw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_swTestOrders = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lb_testrapporten = new System.Windows.Forms.Label();
            this.bt_testOpenen = new System.Windows.Forms.Button();
            this.tb_testrapporten = new System.Windows.Forms.TextBox();
            this.tb_goedkeuring = new System.Windows.Forms.TextBox();
            this.bt_afkeuren = new System.Windows.Forms.Button();
            this.bt_goedkeuren = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(25, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_bevestigOrder);
            this.tabPage1.Controls.Add(this.tb_overige);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cb_ssd);
            this.tabPage1.Controls.Add(this.cb_gpu);
            this.tabPage1.Controls.Add(this.cb_cpu);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bt_orderPlaatsen);
            this.tabPage1.Controls.Add(this.lb_opmerkingen);
            this.tabPage1.Controls.Add(this.tb_opmerkingen);
            this.tabPage1.Controls.Add(this.cb_soort);
            this.tabPage1.Controls.Add(this.lb_soort);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order invoeren";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_bevestigOrder
            // 
            this.lb_bevestigOrder.AutoSize = true;
            this.lb_bevestigOrder.Location = new System.Drawing.Point(280, 358);
            this.lb_bevestigOrder.Name = "lb_bevestigOrder";
            this.lb_bevestigOrder.Size = new System.Drawing.Size(0, 13);
            this.lb_bevestigOrder.TabIndex = 13;
            // 
            // tb_overige
            // 
            this.tb_overige.Location = new System.Drawing.Point(252, 200);
            this.tb_overige.Name = "tb_overige";
            this.tb_overige.Size = new System.Drawing.Size(121, 20);
            this.tb_overige.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Overige";
            // 
            // cb_ssd
            // 
            this.cb_ssd.FormattingEnabled = true;
            this.cb_ssd.Items.AddRange(new object[] {
            "SSD1",
            "SSD2",
            "SSD3"});
            this.cb_ssd.Location = new System.Drawing.Point(252, 153);
            this.cb_ssd.Name = "cb_ssd";
            this.cb_ssd.Size = new System.Drawing.Size(121, 21);
            this.cb_ssd.TabIndex = 10;
            // 
            // cb_gpu
            // 
            this.cb_gpu.FormattingEnabled = true;
            this.cb_gpu.Items.AddRange(new object[] {
            "GPU1",
            "GPU2",
            "GPU3"});
            this.cb_gpu.Location = new System.Drawing.Point(252, 114);
            this.cb_gpu.Name = "cb_gpu";
            this.cb_gpu.Size = new System.Drawing.Size(121, 21);
            this.cb_gpu.TabIndex = 9;
            // 
            // cb_cpu
            // 
            this.cb_cpu.FormattingEnabled = true;
            this.cb_cpu.Items.AddRange(new object[] {
            "Intel® Core™ i3-2100 Processor",
            "Intel® Core™ i5-2400 Processor",
            "Intel® Core™ i7-3770K Processor"});
            this.cb_cpu.Location = new System.Drawing.Point(252, 76);
            this.cb_cpu.Name = "cb_cpu";
            this.cb_cpu.Size = new System.Drawing.Size(121, 21);
            this.cb_cpu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SSD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "GPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU";
            // 
            // bt_orderPlaatsen
            // 
            this.bt_orderPlaatsen.Location = new System.Drawing.Point(111, 349);
            this.bt_orderPlaatsen.Name = "bt_orderPlaatsen";
            this.bt_orderPlaatsen.Size = new System.Drawing.Size(118, 23);
            this.bt_orderPlaatsen.TabIndex = 4;
            this.bt_orderPlaatsen.Text = "Order plaatsen";
            this.bt_orderPlaatsen.UseVisualStyleBackColor = true;
            this.bt_orderPlaatsen.Click += new System.EventHandler(this.bt_orderPlaatsen_Click);
            // 
            // lb_opmerkingen
            // 
            this.lb_opmerkingen.AutoSize = true;
            this.lb_opmerkingen.Location = new System.Drawing.Point(108, 254);
            this.lb_opmerkingen.Name = "lb_opmerkingen";
            this.lb_opmerkingen.Size = new System.Drawing.Size(70, 13);
            this.lb_opmerkingen.TabIndex = 3;
            this.lb_opmerkingen.Text = "Opmerkingen";
            // 
            // tb_opmerkingen
            // 
            this.tb_opmerkingen.Location = new System.Drawing.Point(111, 270);
            this.tb_opmerkingen.Multiline = true;
            this.tb_opmerkingen.Name = "tb_opmerkingen";
            this.tb_opmerkingen.Size = new System.Drawing.Size(398, 61);
            this.tb_opmerkingen.TabIndex = 2;
            // 
            // cb_soort
            // 
            this.cb_soort.FormattingEnabled = true;
            this.cb_soort.Items.AddRange(new object[] {
            "Laptop",
            "Desktop"});
            this.cb_soort.Location = new System.Drawing.Point(252, 34);
            this.cb_soort.Name = "cb_soort";
            this.cb_soort.Size = new System.Drawing.Size(160, 21);
            this.cb_soort.TabIndex = 1;
            // 
            // lb_soort
            // 
            this.lb_soort.AutoSize = true;
            this.lb_soort.Location = new System.Drawing.Point(108, 42);
            this.lb_soort.Name = "lb_soort";
            this.lb_soort.Size = new System.Drawing.Size(61, 13);
            this.lb_soort.TabIndex = 0;
            this.lb_soort.Text = "Soort Order";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cl_ComponentenInOrder);
            this.tabPage2.Controls.Add(this.btn_assemblage_voltooid);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lb_OrderHwBouwen);
            this.tabPage2.Controls.Add(this.lb_binnenkomend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hardware Bouwen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cl_ComponentenInOrder
            // 
            this.cl_ComponentenInOrder.FormattingEnabled = true;
            this.cl_ComponentenInOrder.Location = new System.Drawing.Point(266, 51);
            this.cl_ComponentenInOrder.Name = "cl_ComponentenInOrder";
            this.cl_ComponentenInOrder.Size = new System.Drawing.Size(120, 94);
            this.cl_ComponentenInOrder.TabIndex = 5;
            // 
            // btn_assemblage_voltooid
            // 
            this.btn_assemblage_voltooid.Location = new System.Drawing.Point(29, 361);
            this.btn_assemblage_voltooid.Name = "btn_assemblage_voltooid";
            this.btn_assemblage_voltooid.Size = new System.Drawing.Size(115, 23);
            this.btn_assemblage_voltooid.TabIndex = 4;
            this.btn_assemblage_voltooid.Text = "Assamblage Voltooid";
            this.btn_assemblage_voltooid.UseVisualStyleBackColor = true;
            this.btn_assemblage_voltooid.Click += new System.EventHandler(this.btn_assemblage_voltooid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Omschrijving";
            // 
            // lb_OrderHwBouwen
            // 
            this.lb_OrderHwBouwen.FormattingEnabled = true;
            this.lb_OrderHwBouwen.Location = new System.Drawing.Point(29, 51);
            this.lb_OrderHwBouwen.Name = "lb_OrderHwBouwen";
            this.lb_OrderHwBouwen.Size = new System.Drawing.Size(172, 290);
            this.lb_OrderHwBouwen.TabIndex = 1;
            this.lb_OrderHwBouwen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_binnenkomend
            // 
            this.lb_binnenkomend.AutoSize = true;
            this.lb_binnenkomend.Location = new System.Drawing.Point(26, 19);
            this.lb_binnenkomend.Name = "lb_binnenkomend";
            this.lb_binnenkomend.Size = new System.Drawing.Size(118, 13);
            this.lb_binnenkomend.TabIndex = 0;
            this.lb_binnenkomend.Text = "Binnenkomende Orders";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_afgekeurd);
            this.tabPage3.Controls.Add(this.btn_akkoord);
            this.tabPage3.Controls.Add(this.cl_hwTestComponenten);
            this.tabPage3.Controls.Add(this.btn_sendTest);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.tb_testrapportHw);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lb_TestOrders);
            this.tabPage3.Controls.Add(this.lb_TOrders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hardwaretest";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_afgekeurd
            // 
            this.btn_afgekeurd.Location = new System.Drawing.Point(471, 305);
            this.btn_afgekeurd.Name = "btn_afgekeurd";
            this.btn_afgekeurd.Size = new System.Drawing.Size(75, 23);
            this.btn_afgekeurd.TabIndex = 17;
            this.btn_afgekeurd.Text = "Afgekeurd";
            this.btn_afgekeurd.UseVisualStyleBackColor = true;
            this.btn_afgekeurd.Click += new System.EventHandler(this.btn_afgekeurd_Click);
            // 
            // btn_akkoord
            // 
            this.btn_akkoord.Location = new System.Drawing.Point(376, 306);
            this.btn_akkoord.Name = "btn_akkoord";
            this.btn_akkoord.Size = new System.Drawing.Size(75, 23);
            this.btn_akkoord.TabIndex = 16;
            this.btn_akkoord.Text = "Akkoord";
            this.btn_akkoord.UseVisualStyleBackColor = true;
            this.btn_akkoord.Click += new System.EventHandler(this.btn_akkoord_Click);
            // 
            // cl_hwTestComponenten
            // 
            this.cl_hwTestComponenten.FormattingEnabled = true;
            this.cl_hwTestComponenten.Location = new System.Drawing.Point(233, 45);
            this.cl_hwTestComponenten.Name = "cl_hwTestComponenten";
            this.cl_hwTestComponenten.Size = new System.Drawing.Size(120, 94);
            this.cl_hwTestComponenten.TabIndex = 15;
            // 
            // btn_sendTest
            // 
            this.btn_sendTest.Location = new System.Drawing.Point(233, 306);
            this.btn_sendTest.Name = "btn_sendTest";
            this.btn_sendTest.Size = new System.Drawing.Size(121, 23);
            this.btn_sendTest.TabIndex = 14;
            this.btn_sendTest.Text = "Verstuur Testrapport";
            this.btn_sendTest.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(233, 160);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Testrapport";
            // 
            // tb_testrapportHw
            // 
            this.tb_testrapportHw.Location = new System.Drawing.Point(233, 186);
            this.tb_testrapportHw.Multiline = true;
            this.tb_testrapportHw.Name = "tb_testrapportHw";
            this.tb_testrapportHw.Size = new System.Drawing.Size(359, 113);
            this.tb_testrapportHw.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Omschrijving";
            // 
            // lb_TestOrders
            // 
            this.lb_TestOrders.FormattingEnabled = true;
            this.lb_TestOrders.Location = new System.Drawing.Point(59, 45);
            this.lb_TestOrders.Name = "lb_TestOrders";
            this.lb_TestOrders.Size = new System.Drawing.Size(120, 277);
            this.lb_TestOrders.TabIndex = 7;
            this.lb_TestOrders.SelectedIndexChanged += new System.EventHandler(this.lb_TestOrders_SelectedIndexChanged);
            // 
            // lb_TOrders
            // 
            this.lb_TOrders.AutoSize = true;
            this.lb_TOrders.Location = new System.Drawing.Point(59, 29);
            this.lb_TOrders.Name = "lb_TOrders";
            this.lb_TOrders.Size = new System.Drawing.Size(84, 13);
            this.lb_TOrders.TabIndex = 0;
            this.lb_TOrders.Text = "Te testen orders";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cl_ComponentenInstall);
            this.tabPage4.Controls.Add(this.btn_Bevestig_Installatie);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.lb_OrderToInstall);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Software Installeren";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cl_ComponentenInstall
            // 
            this.cl_ComponentenInstall.FormattingEnabled = true;
            this.cl_ComponentenInstall.Location = new System.Drawing.Point(270, 70);
            this.cl_ComponentenInstall.Name = "cl_ComponentenInstall";
            this.cl_ComponentenInstall.Size = new System.Drawing.Size(120, 94);
            this.cl_ComponentenInstall.TabIndex = 6;
            // 
            // btn_Bevestig_Installatie
            // 
            this.btn_Bevestig_Installatie.Location = new System.Drawing.Point(271, 311);
            this.btn_Bevestig_Installatie.Name = "btn_Bevestig_Installatie";
            this.btn_Bevestig_Installatie.Size = new System.Drawing.Size(119, 23);
            this.btn_Bevestig_Installatie.TabIndex = 5;
            this.btn_Bevestig_Installatie.Text = "Bevestig Installatie";
            this.btn_Bevestig_Installatie.UseVisualStyleBackColor = true;
            this.btn_Bevestig_Installatie.Click += new System.EventHandler(this.btn_Bevestig_Installatie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders to install";
            // 
            // lb_OrderToInstall
            // 
            this.lb_OrderToInstall.FormattingEnabled = true;
            this.lb_OrderToInstall.Location = new System.Drawing.Point(76, 70);
            this.lb_OrderToInstall.Name = "lb_OrderToInstall";
            this.lb_OrderToInstall.Size = new System.Drawing.Size(120, 264);
            this.lb_OrderToInstall.TabIndex = 0;
            this.lb_OrderToInstall.SelectedIndexChanged += new System.EventHandler(this.lb_OrderToInstall_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cl_testComponentenSw);
            this.tabPage5.Controls.Add(this.btn_swAfgekeurd);
            this.tabPage5.Controls.Add(this.btn_swGoed);
            this.tabPage5.Controls.Add(this.bt_verstuurRapport);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.tb_TestrapportSw);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.lb_swTestOrders);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(671, 404);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Softwaretest";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cl_testComponentenSw
            // 
            this.cl_testComponentenSw.FormattingEnabled = true;
            this.cl_testComponentenSw.Location = new System.Drawing.Point(243, 68);
            this.cl_testComponentenSw.Name = "cl_testComponentenSw";
            this.cl_testComponentenSw.Size = new System.Drawing.Size(120, 94);
            this.cl_testComponentenSw.TabIndex = 26;
            // 
            // btn_swAfgekeurd
            // 
            this.btn_swAfgekeurd.Location = new System.Drawing.Point(467, 329);
            this.btn_swAfgekeurd.Name = "btn_swAfgekeurd";
            this.btn_swAfgekeurd.Size = new System.Drawing.Size(75, 23);
            this.btn_swAfgekeurd.TabIndex = 25;
            this.btn_swAfgekeurd.Text = "Afgekeurd";
            this.btn_swAfgekeurd.UseVisualStyleBackColor = true;
            this.btn_swAfgekeurd.Click += new System.EventHandler(this.btn_swAfgekeurd_Click);
            // 
            // btn_swGoed
            // 
            this.btn_swGoed.Location = new System.Drawing.Point(354, 329);
            this.btn_swGoed.Name = "btn_swGoed";
            this.btn_swGoed.Size = new System.Drawing.Size(91, 23);
            this.btn_swGoed.TabIndex = 24;
            this.btn_swGoed.Text = "Goedgekeurd";
            this.btn_swGoed.UseVisualStyleBackColor = true;
            this.btn_swGoed.Click += new System.EventHandler(this.btn_swGoed_Click);
            // 
            // bt_verstuurRapport
            // 
            this.bt_verstuurRapport.Location = new System.Drawing.Point(243, 329);
            this.bt_verstuurRapport.Name = "bt_verstuurRapport";
            this.bt_verstuurRapport.Size = new System.Drawing.Size(77, 23);
            this.bt_verstuurRapport.TabIndex = 23;
            this.bt_verstuurRapport.Text = "Verstuur Testrapport";
            this.bt_verstuurRapport.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Testrapport";
            // 
            // tb_TestrapportSw
            // 
            this.tb_TestrapportSw.Location = new System.Drawing.Point(243, 209);
            this.tb_TestrapportSw.Multiline = true;
            this.tb_TestrapportSw.Name = "tb_TestrapportSw";
            this.tb_TestrapportSw.Size = new System.Drawing.Size(359, 113);
            this.tb_TestrapportSw.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Omschrijving";
            // 
            // lb_swTestOrders
            // 
            this.lb_swTestOrders.FormattingEnabled = true;
            this.lb_swTestOrders.Location = new System.Drawing.Point(69, 68);
            this.lb_swTestOrders.Name = "lb_swTestOrders";
            this.lb_swTestOrders.Size = new System.Drawing.Size(120, 277);
            this.lb_swTestOrders.TabIndex = 16;
            this.lb_swTestOrders.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Te testen orders";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lb_testrapporten);
            this.tabPage6.Controls.Add(this.bt_testOpenen);
            this.tabPage6.Controls.Add(this.tb_testrapporten);
            this.tabPage6.Controls.Add(this.tb_goedkeuring);
            this.tabPage6.Controls.Add(this.bt_afkeuren);
            this.tabPage6.Controls.Add(this.bt_goedkeuren);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(671, 404);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Beheer";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lb_testrapporten
            // 
            this.lb_testrapporten.AutoSize = true;
            this.lb_testrapporten.Location = new System.Drawing.Point(53, 252);
            this.lb_testrapporten.Name = "lb_testrapporten";
            this.lb_testrapporten.Size = new System.Drawing.Size(124, 13);
            this.lb_testrapporten.TabIndex = 6;
            this.lb_testrapporten.Text = "Geuploade testrapporten";
            // 
            // bt_testOpenen
            // 
            this.bt_testOpenen.Location = new System.Drawing.Point(56, 364);
            this.bt_testOpenen.Name = "bt_testOpenen";
            this.bt_testOpenen.Size = new System.Drawing.Size(145, 23);
            this.bt_testOpenen.TabIndex = 5;
            this.bt_testOpenen.Text = "Testrapport openen";
            this.bt_testOpenen.UseVisualStyleBackColor = true;
            this.bt_testOpenen.Click += new System.EventHandler(this.bt_testOpenen_Click);
            // 
            // tb_testrapporten
            // 
            this.tb_testrapporten.Location = new System.Drawing.Point(56, 277);
            this.tb_testrapporten.Multiline = true;
            this.tb_testrapporten.Name = "tb_testrapporten";
            this.tb_testrapporten.Size = new System.Drawing.Size(479, 70);
            this.tb_testrapporten.TabIndex = 4;
            // 
            // tb_goedkeuring
            // 
            this.tb_goedkeuring.Location = new System.Drawing.Point(56, 70);
            this.tb_goedkeuring.Multiline = true;
            this.tb_goedkeuring.Name = "tb_goedkeuring";
            this.tb_goedkeuring.Size = new System.Drawing.Size(479, 95);
            this.tb_goedkeuring.TabIndex = 3;
            // 
            // bt_afkeuren
            // 
            this.bt_afkeuren.Location = new System.Drawing.Point(187, 199);
            this.bt_afkeuren.Name = "bt_afkeuren";
            this.bt_afkeuren.Size = new System.Drawing.Size(75, 23);
            this.bt_afkeuren.TabIndex = 2;
            this.bt_afkeuren.Text = "Afkeuren";
            this.bt_afkeuren.UseVisualStyleBackColor = true;
            this.bt_afkeuren.Click += new System.EventHandler(this.bt_afkeuren_Click);
            // 
            // bt_goedkeuren
            // 
            this.bt_goedkeuren.Location = new System.Drawing.Point(56, 199);
            this.bt_goedkeuren.Name = "bt_goedkeuren";
            this.bt_goedkeuren.Size = new System.Drawing.Size(75, 23);
            this.bt_goedkeuren.TabIndex = 1;
            this.bt_goedkeuren.Text = "Goedkeuren";
            this.bt_goedkeuren.UseVisualStyleBackColor = true;
            this.bt_goedkeuren.Click += new System.EventHandler(this.bt_goedkeuren_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders dat gekeurd moeten worden.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cb_soort;
        private System.Windows.Forms.Label lb_soort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lb_opmerkingen;
        private System.Windows.Forms.TextBox tb_opmerkingen;
        private System.Windows.Forms.Label lb_binnenkomend;
        private System.Windows.Forms.Label lb_TOrders;
        private System.Windows.Forms.Button bt_orderPlaatsen;
        private System.Windows.Forms.Label lb_testrapporten;
        private System.Windows.Forms.Button bt_testOpenen;
        private System.Windows.Forms.TextBox tb_testrapporten;
        private System.Windows.Forms.TextBox tb_goedkeuring;
        private System.Windows.Forms.Button bt_afkeuren;
        private System.Windows.Forms.Button bt_goedkeuren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_overige;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_ssd;
        private System.Windows.Forms.ComboBox cb_gpu;
        private System.Windows.Forms.ComboBox cb_cpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_assemblage_voltooid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_OrderHwBouwen;
        private System.Windows.Forms.Button btn_sendTest;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_testrapportHw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lb_TestOrders;
        private System.Windows.Forms.CheckedListBox cl_ComponentenInOrder;
        private System.Windows.Forms.CheckedListBox cl_hwTestComponenten;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox cl_ComponentenInstall;
        private System.Windows.Forms.Button btn_Bevestig_Installatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_OrderToInstall;
        private System.Windows.Forms.Button btn_swAfgekeurd;
        private System.Windows.Forms.Button btn_swGoed;
        private System.Windows.Forms.Button bt_verstuurRapport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_TestrapportSw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lb_swTestOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox cl_testComponentenSw;
        private System.Windows.Forms.Label lb_bevestigOrder;
        private System.Windows.Forms.Button btn_afgekeurd;
        private System.Windows.Forms.Button btn_akkoord;
    }
}


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
            this.lb_opmerkingen = new System.Windows.Forms.Label();
            this.tb_opmerkingen = new System.Windows.Forms.TextBox();
            this.cb_soort = new System.Windows.Forms.ComboBox();
            this.lb_soort = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_afhandelen1 = new System.Windows.Forms.Button();
            this.tb_ordersinBehandeling1 = new System.Windows.Forms.TextBox();
            this.lb_gaande = new System.Windows.Forms.Label();
            this.bt_accepteren1 = new System.Windows.Forms.Button();
            this.tb_binnenkomend = new System.Windows.Forms.TextBox();
            this.lb_binnenkomend = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_hwRapport = new System.Windows.Forms.Button();
            this.bt_testAfhandelen1 = new System.Windows.Forms.Button();
            this.tb_hwTestsgaande = new System.Windows.Forms.TextBox();
            this.lb_testsGaande1 = new System.Windows.Forms.Label();
            this.bt_hwTesten = new System.Windows.Forms.Button();
            this.tb_teTestenorders1 = new System.Windows.Forms.TextBox();
            this.lb_teTesten1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bt_afhandelen2 = new System.Windows.Forms.Button();
            this.tb_ordersinBehandeling2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_accepteren2 = new System.Windows.Forms.Button();
            this.tb_hwgetesteOrders = new System.Windows.Forms.TextBox();
            this.bt_getesteOrders = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bt_swRapport = new System.Windows.Forms.Button();
            this.bt_testAfhandelen2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_swTest = new System.Windows.Forms.Label();
            this.bt_swTesten = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_teTesten2 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_goedkeuren = new System.Windows.Forms.Button();
            this.bt_afkeuren = new System.Windows.Forms.Button();
            this.tb_goedkeuring = new System.Windows.Forms.TextBox();
            this.tb_testrapporten = new System.Windows.Forms.TextBox();
            this.bt_testOpenen = new System.Windows.Forms.Button();
            this.lb_testrapporten = new System.Windows.Forms.Label();
            this.bt_orderPlaatsen = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(25, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            // lb_opmerkingen
            // 
            this.lb_opmerkingen.AutoSize = true;
            this.lb_opmerkingen.Location = new System.Drawing.Point(108, 107);
            this.lb_opmerkingen.Name = "lb_opmerkingen";
            this.lb_opmerkingen.Size = new System.Drawing.Size(70, 13);
            this.lb_opmerkingen.TabIndex = 3;
            this.lb_opmerkingen.Text = "Opmerkingen";
            // 
            // tb_opmerkingen
            // 
            this.tb_opmerkingen.Location = new System.Drawing.Point(111, 135);
            this.tb_opmerkingen.Multiline = true;
            this.tb_opmerkingen.Name = "tb_opmerkingen";
            this.tb_opmerkingen.Size = new System.Drawing.Size(398, 181);
            this.tb_opmerkingen.TabIndex = 2;
            // 
            // cb_soort
            // 
            this.cb_soort.FormattingEnabled = true;
            this.cb_soort.Location = new System.Drawing.Point(255, 50);
            this.cb_soort.Name = "cb_soort";
            this.cb_soort.Size = new System.Drawing.Size(160, 21);
            this.cb_soort.TabIndex = 1;
            // 
            // lb_soort
            // 
            this.lb_soort.AutoSize = true;
            this.lb_soort.Location = new System.Drawing.Point(108, 58);
            this.lb_soort.Name = "lb_soort";
            this.lb_soort.Size = new System.Drawing.Size(61, 13);
            this.lb_soort.TabIndex = 0;
            this.lb_soort.Text = "Soort Order";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_afhandelen1);
            this.tabPage2.Controls.Add(this.tb_ordersinBehandeling1);
            this.tabPage2.Controls.Add(this.lb_gaande);
            this.tabPage2.Controls.Add(this.bt_accepteren1);
            this.tabPage2.Controls.Add(this.tb_binnenkomend);
            this.tabPage2.Controls.Add(this.lb_binnenkomend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hardware Bouwen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_afhandelen1
            // 
            this.bt_afhandelen1.Location = new System.Drawing.Point(73, 361);
            this.bt_afhandelen1.Name = "bt_afhandelen1";
            this.bt_afhandelen1.Size = new System.Drawing.Size(138, 23);
            this.bt_afhandelen1.TabIndex = 5;
            this.bt_afhandelen1.Text = "Opdracht afhandelen";
            this.bt_afhandelen1.UseVisualStyleBackColor = true;
            this.bt_afhandelen1.Click += new System.EventHandler(this.bt_afhandelen1_Click);
            // 
            // tb_ordersinBehandeling1
            // 
            this.tb_ordersinBehandeling1.Location = new System.Drawing.Point(73, 268);
            this.tb_ordersinBehandeling1.Multiline = true;
            this.tb_ordersinBehandeling1.Name = "tb_ordersinBehandeling1";
            this.tb_ordersinBehandeling1.Size = new System.Drawing.Size(457, 75);
            this.tb_ordersinBehandeling1.TabIndex = 4;
            // 
            // lb_gaande
            // 
            this.lb_gaande.AutoSize = true;
            this.lb_gaande.Location = new System.Drawing.Point(70, 243);
            this.lb_gaande.Name = "lb_gaande";
            this.lb_gaande.Size = new System.Drawing.Size(110, 13);
            this.lb_gaande.TabIndex = 3;
            this.lb_gaande.Text = "Orders in behandeling";
            // 
            // bt_accepteren1
            // 
            this.bt_accepteren1.Location = new System.Drawing.Point(73, 183);
            this.bt_accepteren1.Name = "bt_accepteren1";
            this.bt_accepteren1.Size = new System.Drawing.Size(178, 23);
            this.bt_accepteren1.TabIndex = 2;
            this.bt_accepteren1.Text = "Assamblage accepteren";
            this.bt_accepteren1.UseVisualStyleBackColor = true;
            this.bt_accepteren1.Click += new System.EventHandler(this.bt_accepteren1_Click);
            // 
            // tb_binnenkomend
            // 
            this.tb_binnenkomend.Location = new System.Drawing.Point(73, 65);
            this.tb_binnenkomend.Multiline = true;
            this.tb_binnenkomend.Name = "tb_binnenkomend";
            this.tb_binnenkomend.Size = new System.Drawing.Size(457, 89);
            this.tb_binnenkomend.TabIndex = 1;
            // 
            // lb_binnenkomend
            // 
            this.lb_binnenkomend.AutoSize = true;
            this.lb_binnenkomend.Location = new System.Drawing.Point(70, 35);
            this.lb_binnenkomend.Name = "lb_binnenkomend";
            this.lb_binnenkomend.Size = new System.Drawing.Size(118, 13);
            this.lb_binnenkomend.TabIndex = 0;
            this.lb_binnenkomend.Text = "Binnenkomende Orders";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_hwRapport);
            this.tabPage3.Controls.Add(this.bt_testAfhandelen1);
            this.tabPage3.Controls.Add(this.tb_hwTestsgaande);
            this.tabPage3.Controls.Add(this.lb_testsGaande1);
            this.tabPage3.Controls.Add(this.bt_hwTesten);
            this.tabPage3.Controls.Add(this.tb_teTestenorders1);
            this.tabPage3.Controls.Add(this.lb_teTesten1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hardwaretest";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_hwRapport
            // 
            this.bt_hwRapport.Location = new System.Drawing.Point(225, 364);
            this.bt_hwRapport.Name = "bt_hwRapport";
            this.bt_hwRapport.Size = new System.Drawing.Size(122, 23);
            this.bt_hwRapport.TabIndex = 6;
            this.bt_hwRapport.Text = "Testrapport Uploaden";
            this.bt_hwRapport.UseVisualStyleBackColor = true;
            this.bt_hwRapport.Click += new System.EventHandler(this.bt_hwRapport_Click);
            // 
            // bt_testAfhandelen1
            // 
            this.bt_testAfhandelen1.Location = new System.Drawing.Point(62, 365);
            this.bt_testAfhandelen1.Name = "bt_testAfhandelen1";
            this.bt_testAfhandelen1.Size = new System.Drawing.Size(117, 23);
            this.bt_testAfhandelen1.TabIndex = 5;
            this.bt_testAfhandelen1.Text = "Test afhandelen.";
            this.bt_testAfhandelen1.UseVisualStyleBackColor = true;
            this.bt_testAfhandelen1.Click += new System.EventHandler(this.bt_testAfhandelen1_Click);
            // 
            // tb_hwTestsgaande
            // 
            this.tb_hwTestsgaande.Location = new System.Drawing.Point(62, 255);
            this.tb_hwTestsgaande.Multiline = true;
            this.tb_hwTestsgaande.Name = "tb_hwTestsgaande";
            this.tb_hwTestsgaande.Size = new System.Drawing.Size(494, 92);
            this.tb_hwTestsgaande.TabIndex = 4;
            // 
            // lb_testsGaande1
            // 
            this.lb_testsGaande1.AutoSize = true;
            this.lb_testsGaande1.Location = new System.Drawing.Point(59, 228);
            this.lb_testsGaande1.Name = "lb_testsGaande1";
            this.lb_testsGaande1.Size = new System.Drawing.Size(120, 13);
            this.lb_testsGaande1.TabIndex = 3;
            this.lb_testsGaande1.Text = "Hardware tests gaande.";
            // 
            // bt_hwTesten
            // 
            this.bt_hwTesten.Location = new System.Drawing.Point(62, 175);
            this.bt_hwTesten.Name = "bt_hwTesten";
            this.bt_hwTesten.Size = new System.Drawing.Size(128, 25);
            this.bt_hwTesten.TabIndex = 2;
            this.bt_hwTesten.Text = "Order Testen";
            this.bt_hwTesten.UseVisualStyleBackColor = true;
            this.bt_hwTesten.Click += new System.EventHandler(this.bt_hwTesten_Click);
            // 
            // tb_teTestenorders1
            // 
            this.tb_teTestenorders1.Location = new System.Drawing.Point(62, 57);
            this.tb_teTestenorders1.Multiline = true;
            this.tb_teTestenorders1.Name = "tb_teTestenorders1";
            this.tb_teTestenorders1.Size = new System.Drawing.Size(494, 101);
            this.tb_teTestenorders1.TabIndex = 1;
            // 
            // lb_teTesten1
            // 
            this.lb_teTesten1.AutoSize = true;
            this.lb_teTesten1.Location = new System.Drawing.Point(59, 29);
            this.lb_teTesten1.Name = "lb_teTesten1";
            this.lb_teTesten1.Size = new System.Drawing.Size(84, 13);
            this.lb_teTesten1.TabIndex = 0;
            this.lb_teTesten1.Text = "Te testen orders";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bt_afhandelen2);
            this.tabPage4.Controls.Add(this.tb_ordersinBehandeling2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.bt_accepteren2);
            this.tabPage4.Controls.Add(this.tb_hwgetesteOrders);
            this.tabPage4.Controls.Add(this.bt_getesteOrders);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Software Installeren";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bt_afhandelen2
            // 
            this.bt_afhandelen2.Location = new System.Drawing.Point(108, 354);
            this.bt_afhandelen2.Name = "bt_afhandelen2";
            this.bt_afhandelen2.Size = new System.Drawing.Size(138, 23);
            this.bt_afhandelen2.TabIndex = 11;
            this.bt_afhandelen2.Text = "Opdracht afhandelen";
            this.bt_afhandelen2.UseVisualStyleBackColor = true;
            this.bt_afhandelen2.Click += new System.EventHandler(this.bt_afhandelen2_Click);
            // 
            // tb_ordersinBehandeling2
            // 
            this.tb_ordersinBehandeling2.Location = new System.Drawing.Point(108, 261);
            this.tb_ordersinBehandeling2.Multiline = true;
            this.tb_ordersinBehandeling2.Name = "tb_ordersinBehandeling2";
            this.tb_ordersinBehandeling2.Size = new System.Drawing.Size(457, 75);
            this.tb_ordersinBehandeling2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Installatie orders in behandeling";
            // 
            // bt_accepteren2
            // 
            this.bt_accepteren2.Location = new System.Drawing.Point(108, 176);
            this.bt_accepteren2.Name = "bt_accepteren2";
            this.bt_accepteren2.Size = new System.Drawing.Size(178, 23);
            this.bt_accepteren2.TabIndex = 8;
            this.bt_accepteren2.Text = "Software installeren";
            this.bt_accepteren2.UseVisualStyleBackColor = true;
            this.bt_accepteren2.Click += new System.EventHandler(this.bt_accepteren2_Click);
            // 
            // tb_hwgetesteOrders
            // 
            this.tb_hwgetesteOrders.Location = new System.Drawing.Point(108, 58);
            this.tb_hwgetesteOrders.Multiline = true;
            this.tb_hwgetesteOrders.Name = "tb_hwgetesteOrders";
            this.tb_hwgetesteOrders.Size = new System.Drawing.Size(457, 89);
            this.tb_hwgetesteOrders.TabIndex = 7;
            // 
            // bt_getesteOrders
            // 
            this.bt_getesteOrders.AutoSize = true;
            this.bt_getesteOrders.Location = new System.Drawing.Point(105, 28);
            this.bt_getesteOrders.Name = "bt_getesteOrders";
            this.bt_getesteOrders.Size = new System.Drawing.Size(123, 13);
            this.bt_getesteOrders.TabIndex = 6;
            this.bt_getesteOrders.Text = "Hardware geteste orders";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bt_swRapport);
            this.tabPage5.Controls.Add(this.bt_testAfhandelen2);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.lb_swTest);
            this.tabPage5.Controls.Add(this.bt_swTesten);
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.lb_teTesten2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(671, 404);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Softwaretest";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bt_swRapport
            // 
            this.bt_swRapport.Location = new System.Drawing.Point(253, 358);
            this.bt_swRapport.Name = "bt_swRapport";
            this.bt_swRapport.Size = new System.Drawing.Size(122, 23);
            this.bt_swRapport.TabIndex = 13;
            this.bt_swRapport.Text = "Testrapport Uploaden";
            this.bt_swRapport.UseVisualStyleBackColor = true;
            this.bt_swRapport.Click += new System.EventHandler(this.bt_swRapport_Click);
            // 
            // bt_testAfhandelen2
            // 
            this.bt_testAfhandelen2.Location = new System.Drawing.Point(90, 359);
            this.bt_testAfhandelen2.Name = "bt_testAfhandelen2";
            this.bt_testAfhandelen2.Size = new System.Drawing.Size(117, 23);
            this.bt_testAfhandelen2.TabIndex = 12;
            this.bt_testAfhandelen2.Text = "Test afhandelen.";
            this.bt_testAfhandelen2.UseVisualStyleBackColor = true;
            this.bt_testAfhandelen2.Click += new System.EventHandler(this.bt_testAfhandelen2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 92);
            this.textBox1.TabIndex = 11;
            // 
            // lb_swTest
            // 
            this.lb_swTest.AutoSize = true;
            this.lb_swTest.Location = new System.Drawing.Point(87, 222);
            this.lb_swTest.Name = "lb_swTest";
            this.lb_swTest.Size = new System.Drawing.Size(116, 13);
            this.lb_swTest.TabIndex = 10;
            this.lb_swTest.Text = "Software tests gaande.";
            // 
            // bt_swTesten
            // 
            this.bt_swTesten.Location = new System.Drawing.Point(90, 169);
            this.bt_swTesten.Name = "bt_swTesten";
            this.bt_swTesten.Size = new System.Drawing.Size(128, 25);
            this.bt_swTesten.TabIndex = 9;
            this.bt_swTesten.Text = "Order Testen";
            this.bt_swTesten.UseVisualStyleBackColor = true;
            this.bt_swTesten.Click += new System.EventHandler(this.bt_swTesten_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(494, 101);
            this.textBox2.TabIndex = 8;
            // 
            // lb_teTesten2
            // 
            this.lb_teTesten2.AutoSize = true;
            this.lb_teTesten2.Location = new System.Drawing.Point(87, 23);
            this.lb_teTesten2.Name = "lb_teTesten2";
            this.lb_teTesten2.Size = new System.Drawing.Size(84, 13);
            this.lb_teTesten2.TabIndex = 7;
            this.lb_teTesten2.Text = "Te testen orders";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders dat gekeurd moeten worden.";
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
            // tb_goedkeuring
            // 
            this.tb_goedkeuring.Location = new System.Drawing.Point(56, 70);
            this.tb_goedkeuring.Multiline = true;
            this.tb_goedkeuring.Name = "tb_goedkeuring";
            this.tb_goedkeuring.Size = new System.Drawing.Size(479, 95);
            this.tb_goedkeuring.TabIndex = 3;
            // 
            // tb_testrapporten
            // 
            this.tb_testrapporten.Location = new System.Drawing.Point(56, 277);
            this.tb_testrapporten.Multiline = true;
            this.tb_testrapporten.Name = "tb_testrapporten";
            this.tb_testrapporten.Size = new System.Drawing.Size(479, 70);
            this.tb_testrapporten.TabIndex = 4;
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
            // lb_testrapporten
            // 
            this.lb_testrapporten.AutoSize = true;
            this.lb_testrapporten.Location = new System.Drawing.Point(53, 252);
            this.lb_testrapporten.Name = "lb_testrapporten";
            this.lb_testrapporten.Size = new System.Drawing.Size(124, 13);
            this.lb_testrapporten.TabIndex = 6;
            this.lb_testrapporten.Text = "Geuploade testrapporten";
            // 
            // bt_orderPlaatsen
            // 
            this.bt_orderPlaatsen.Location = new System.Drawing.Point(111, 339);
            this.bt_orderPlaatsen.Name = "bt_orderPlaatsen";
            this.bt_orderPlaatsen.Size = new System.Drawing.Size(75, 23);
            this.bt_orderPlaatsen.TabIndex = 4;
            this.bt_orderPlaatsen.Text = "Order plaatsen";
            this.bt_orderPlaatsen.UseVisualStyleBackColor = true;
            this.bt_orderPlaatsen.Click += new System.EventHandler(this.bt_orderPlaatsen_Click);
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lb_opmerkingen;
        private System.Windows.Forms.TextBox tb_opmerkingen;
        private System.Windows.Forms.Button bt_afhandelen1;
        private System.Windows.Forms.TextBox tb_ordersinBehandeling1;
        private System.Windows.Forms.Label lb_gaande;
        private System.Windows.Forms.Button bt_accepteren1;
        private System.Windows.Forms.TextBox tb_binnenkomend;
        private System.Windows.Forms.Label lb_binnenkomend;
        private System.Windows.Forms.Button bt_hwRapport;
        private System.Windows.Forms.Button bt_testAfhandelen1;
        private System.Windows.Forms.TextBox tb_hwTestsgaande;
        private System.Windows.Forms.Label lb_testsGaande1;
        private System.Windows.Forms.Button bt_hwTesten;
        private System.Windows.Forms.TextBox tb_teTestenorders1;
        private System.Windows.Forms.Label lb_teTesten1;
        private System.Windows.Forms.Button bt_afhandelen2;
        private System.Windows.Forms.TextBox tb_ordersinBehandeling2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_accepteren2;
        private System.Windows.Forms.TextBox tb_hwgetesteOrders;
        private System.Windows.Forms.Label bt_getesteOrders;
        private System.Windows.Forms.Button bt_swRapport;
        private System.Windows.Forms.Button bt_testAfhandelen2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_swTest;
        private System.Windows.Forms.Button bt_swTesten;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_teTesten2;
        private System.Windows.Forms.Button bt_orderPlaatsen;
        private System.Windows.Forms.Label lb_testrapporten;
        private System.Windows.Forms.Button bt_testOpenen;
        private System.Windows.Forms.TextBox tb_testrapporten;
        private System.Windows.Forms.TextBox tb_goedkeuring;
        private System.Windows.Forms.Button bt_afkeuren;
        private System.Windows.Forms.Button bt_goedkeuren;
        private System.Windows.Forms.Label label2;
    }
}


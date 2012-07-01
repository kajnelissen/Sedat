namespace Release_v2
{
    partial class SoftwareInstallWindow
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
            this.cbl_ComponentenInstall = new System.Windows.Forms.CheckedListBox();
            this.btn_Bevestig_Installatie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_OrderToInstall = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            //
            // cbl_ComponentenInstall
            //
            this.cbl_ComponentenInstall.FormattingEnabled = true;
            this.cbl_ComponentenInstall.Location = new System.Drawing.Point(278, 13);
            this.cbl_ComponentenInstall.Name = "cbl_ComponentenInstall";
            this.cbl_ComponentenInstall.Size = new System.Drawing.Size(120, 94);
            this.cbl_ComponentenInstall.TabIndex = 10;
            //
            // btn_Bevestig_Installatie
            //
            this.btn_Bevestig_Installatie.Location = new System.Drawing.Point(278, 254);
            this.btn_Bevestig_Installatie.Name = "btn_Bevestig_Installatie";
            this.btn_Bevestig_Installatie.Size = new System.Drawing.Size(119, 23);
            this.btn_Bevestig_Installatie.TabIndex = 9;
            this.btn_Bevestig_Installatie.Text = "Bevestig Installatie";
            this.btn_Bevestig_Installatie.UseVisualStyleBackColor = true;
            this.btn_Bevestig_Installatie.Click += new System.EventHandler(this.btn_Bevestig_Installatie_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-16, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orders to install";
            //
            // lb_OrderToInstall
            //
            this.lb_OrderToInstall.FormattingEnabled = true;
            this.lb_OrderToInstall.Location = new System.Drawing.Point(90, 13);
            this.lb_OrderToInstall.Name = "lb_OrderToInstall";
            this.lb_OrderToInstall.Size = new System.Drawing.Size(120, 264);
            this.lb_OrderToInstall.TabIndex = 7;
            this.lb_OrderToInstall.SelectedIndexChanged += new System.EventHandler(this.lb_OrderToInstall_SelectedIndexChanged);
            //
            // SoftwareInstallWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 326);
            this.Controls.Add(this.cbl_ComponentenInstall);
            this.Controls.Add(this.btn_Bevestig_Installatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_OrderToInstall);
            this.Name = "SoftwareInstallWindow";
            this.Text = "SoftwareInstallWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbl_ComponentenInstall;
        private System.Windows.Forms.Button btn_Bevestig_Installatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_OrderToInstall;
    }
}
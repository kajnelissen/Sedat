namespace Release_v2
{
    partial class AssemblyWindow
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
            this.btn_bevestig_assemblage = new System.Windows.Forms.Button();
            this.cbl_AssemblageComponenten = new System.Windows.Forms.CheckedListBox();
            this.lb_AssemblageOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_bevestig_assemblage
            // 
            this.btn_bevestig_assemblage.Location = new System.Drawing.Point(83, 308);
            this.btn_bevestig_assemblage.Name = "btn_bevestig_assemblage";
            this.btn_bevestig_assemblage.Size = new System.Drawing.Size(75, 23);
            this.btn_bevestig_assemblage.TabIndex = 5;
            this.btn_bevestig_assemblage.Text = "Bevestig";
            this.btn_bevestig_assemblage.UseVisualStyleBackColor = true;
            this.btn_bevestig_assemblage.Click += new System.EventHandler(this.btn_bevestig_assemblage_Click);
            // 
            // cbl_AssemblageComponenten
            // 
            this.cbl_AssemblageComponenten.FormattingEnabled = true;
            this.cbl_AssemblageComponenten.Location = new System.Drawing.Point(226, 24);
            this.cbl_AssemblageComponenten.Name = "cbl_AssemblageComponenten";
            this.cbl_AssemblageComponenten.Size = new System.Drawing.Size(120, 124);
            this.cbl_AssemblageComponenten.TabIndex = 4;
            // 
            // lb_AssemblageOrders
            // 
            this.lb_AssemblageOrders.FormattingEnabled = true;
            this.lb_AssemblageOrders.Location = new System.Drawing.Point(61, 22);
            this.lb_AssemblageOrders.Name = "lb_AssemblageOrders";
            this.lb_AssemblageOrders.Size = new System.Drawing.Size(120, 264);
            this.lb_AssemblageOrders.TabIndex = 3;
            this.lb_AssemblageOrders.SelectedIndexChanged += new System.EventHandler(this.lb_AssemblageOrders_SelectedIndexChanged);
            // 
            // AssemblyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 362);
            this.Controls.Add(this.btn_bevestig_assemblage);
            this.Controls.Add(this.cbl_AssemblageComponenten);
            this.Controls.Add(this.lb_AssemblageOrders);
            this.Name = "AssemblyWindow";
            this.Text = "Hardware assembleren";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bevestig_assemblage;
        private System.Windows.Forms.CheckedListBox cbl_AssemblageComponenten;
        private System.Windows.Forms.ListBox lb_AssemblageOrders;
    }
}
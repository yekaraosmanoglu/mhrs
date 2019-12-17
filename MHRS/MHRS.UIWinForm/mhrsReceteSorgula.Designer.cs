namespace MHRS.UIWinForm
{
    partial class mhrsReceteSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsReceteSorgula));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtReceteNo = new Guna.UI.WinForms.GunaTextBox();
            this.btnSorgula = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.pnlRecete = new Guna.UI.WinForms.GunaPanel();
            this.txtRecete = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lblDoc = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblAd = new Guna.UI.WinForms.GunaLabel();
            this.lblSoyad = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.pnlRecete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(72, 142);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Recete No";
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.BaseColor = System.Drawing.Color.White;
            this.txtReceteNo.BorderColor = System.Drawing.Color.Silver;
            this.txtReceteNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceteNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReceteNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReceteNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReceteNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReceteNo.Location = new System.Drawing.Point(150, 135);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.PasswordChar = '\0';
            this.txtReceteNo.Size = new System.Drawing.Size(160, 30);
            this.txtReceteNo.TabIndex = 1;
            // 
            // btnSorgula
            // 
            this.btnSorgula.AnimationHoverSpeed = 0.07F;
            this.btnSorgula.AnimationSpeed = 0.03F;
            this.btnSorgula.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSorgula.BorderColor = System.Drawing.Color.Black;
            this.btnSorgula.FocusedColor = System.Drawing.Color.Empty;
            this.btnSorgula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Image = null;
            this.btnSorgula.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSorgula.Location = new System.Drawing.Point(340, 135);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSorgula.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSorgula.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSorgula.OnHoverImage = null;
            this.btnSorgula.OnPressedColor = System.Drawing.Color.Black;
            this.btnSorgula.Size = new System.Drawing.Size(70, 30);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(75, 67);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(214, 10);
            this.gunaSeparator1.TabIndex = 20;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLabel9.Location = new System.Drawing.Point(67, 23);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(232, 45);
            this.gunaLabel9.TabIndex = 19;
            this.gunaLabel9.Text = "Recete Sorgula";
            // 
            // pnlRecete
            // 
            this.pnlRecete.Controls.Add(this.lblID);
            this.pnlRecete.Controls.Add(this.gunaLabel4);
            this.pnlRecete.Controls.Add(this.txtRecete);
            this.pnlRecete.Controls.Add(this.gunaLabel8);
            this.pnlRecete.Controls.Add(this.lblDoc);
            this.pnlRecete.Controls.Add(this.gunaLabel6);
            this.pnlRecete.Controls.Add(this.lblAd);
            this.pnlRecete.Controls.Add(this.lblSoyad);
            this.pnlRecete.Controls.Add(this.gunaLabel3);
            this.pnlRecete.Controls.Add(this.gunaLabel2);
            this.pnlRecete.Location = new System.Drawing.Point(22, 190);
            this.pnlRecete.Name = "pnlRecete";
            this.pnlRecete.Size = new System.Drawing.Size(692, 219);
            this.pnlRecete.TabIndex = 21;
            this.pnlRecete.Visible = false;
            // 
            // txtRecete
            // 
            this.txtRecete.BaseColor = System.Drawing.Color.White;
            this.txtRecete.BorderColor = System.Drawing.Color.Silver;
            this.txtRecete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecete.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRecete.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRecete.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRecete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecete.Location = new System.Drawing.Point(416, 41);
            this.txtRecete.MultiLine = true;
            this.txtRecete.Name = "txtRecete";
            this.txtRecete.PasswordChar = '\0';
            this.txtRecete.ReadOnly = true;
            this.txtRecete.Size = new System.Drawing.Size(233, 137);
            this.txtRecete.TabIndex = 17;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(348, 41);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel8.TabIndex = 16;
            this.gunaLabel8.Text = "Recete :";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDoc.Location = new System.Drawing.Point(191, 143);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(32, 15);
            this.lblDoc.TabIndex = 15;
            this.lblDoc.Text = "DOC";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(85, 143);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "Doktor :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAd.Location = new System.Drawing.Point(191, 73);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 15);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "AD";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoyad.Location = new System.Drawing.Point(191, 107);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(44, 15);
            this.lblSoyad.TabIndex = 13;
            this.lblSoyad.Text = "SOYAD";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(85, 107);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Hasta Soyadı :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(85, 73);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 15);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Hasta Adı :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(85, 41);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Hasta ID :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.Location = new System.Drawing.Point(191, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // mhrsReceteSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtReceteNo);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.pnlRecete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsReceteSorgula";
            this.Text = "mhrsReceteSorgula";
            this.pnlRecete.ResumeLayout(false);
            this.pnlRecete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtReceteNo;
        private Guna.UI.WinForms.GunaButton btnSorgula;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaPanel pnlRecete;
        private Guna.UI.WinForms.GunaTextBox txtRecete;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lblDoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel lblAd;
        private Guna.UI.WinForms.GunaLabel lblSoyad;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}
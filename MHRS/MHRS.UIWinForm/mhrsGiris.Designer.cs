namespace MHRS.UIWinForm
{
    partial class mhrsGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsGiris));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.txtSifre = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtKullaniciAdi = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblKaydol = new Guna.UI.WinForms.GunaLabel();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tipPassShow = new System.Windows.Forms.ToolTip(this.components);
            this.picPassChar = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassChar)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = global::MHRS.UIWinForm.Properties.Resources.login1;
            this.gunaPanel1.Controls.Add(this.cmbRol);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(350, 200);
            this.gunaPanel1.TabIndex = 11;
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BaseColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderColor = System.Drawing.Color.Transparent;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(3, 3);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.Transparent;
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.Transparent;
            this.cmbRol.Size = new System.Drawing.Size(121, 26);
            this.cmbRol.TabIndex = 4;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(304, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSifre.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSifre.Location = new System.Drawing.Point(73, 374);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(200, 29);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.LineColor = System.Drawing.Color.Gainsboro;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(73, 263);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 29);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // lblKaydol
            // 
            this.lblKaydol.AutoSize = true;
            this.lblKaydol.BackColor = System.Drawing.Color.White;
            this.lblKaydol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKaydol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKaydol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblKaydol.Location = new System.Drawing.Point(229, 465);
            this.lblKaydol.Name = "lblKaydol";
            this.lblKaydol.Size = new System.Drawing.Size(48, 15);
            this.lblKaydol.TabIndex = 3;
            this.lblKaydol.Text = "Kayıt Ol";
            this.lblKaydol.Click += new System.EventHandler(this.lblKaydol_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSifre.Location = new System.Drawing.Point(70, 341);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(30, 14);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Şifre";
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGiris.Location = new System.Drawing.Point(70, 236);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(68, 14);
            this.lblGiris.TabIndex = 12;
            this.lblGiris.Text = "Kullanıcı Adı";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGiris.Location = new System.Drawing.Point(208, 418);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(69, 34);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tipPassShow
            // 
            this.tipPassShow.ShowAlways = true;
            // 
            // picPassChar
            // 
            this.picPassChar.BackgroundImage = global::MHRS.UIWinForm.Properties.Resources.icons8_show_password_100;
            this.picPassChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPassChar.Location = new System.Drawing.Point(277, 378);
            this.picPassChar.Name = "picPassChar";
            this.picPassChar.Size = new System.Drawing.Size(33, 29);
            this.picPassChar.TabIndex = 13;
            this.picPassChar.TabStop = false;
            this.picPassChar.Click += new System.EventHandler(this.PicPassChar_Click);
            // 
            // mhrsGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.picPassChar);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKaydol);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mhrsGiris";
            this.Load += new System.EventHandler(this.mhrsGiris_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaLineTextBox txtSifre;
        private Guna.UI.WinForms.GunaLineTextBox txtKullaniciAdi;
        private Guna.UI.WinForms.GunaLabel lblKaydol;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGiris;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox picPassChar;
        private System.Windows.Forms.ToolTip tipPassShow;
    }
}
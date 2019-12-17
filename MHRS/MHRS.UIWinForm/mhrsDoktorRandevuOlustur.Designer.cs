namespace MHRS.UIWinForm
{
    partial class mhrsDoktorRandevuOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsDoktorRandevuOlustur));
            this.gunaTopBar = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.dtpTarih = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnOlustur = new Guna.UI.WinForms.GunaButton();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.gunaTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaTopBar
            // 
            this.gunaTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))));
            this.gunaTopBar.Controls.Add(this.gunaControlBox2);
            this.gunaTopBar.Controls.Add(this.gunaControlBox1);
            this.gunaTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaTopBar.Location = new System.Drawing.Point(0, 0);
            this.gunaTopBar.Name = "gunaTopBar";
            this.gunaTopBar.Size = new System.Drawing.Size(430, 30);
            this.gunaTopBar.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(340, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(49)))));
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(385, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaTopBar;
            // 
            // dtpTarih
            // 
            this.dtpTarih.BaseColor = System.Drawing.Color.White;
            this.dtpTarih.BorderColor = System.Drawing.Color.Silver;
            this.dtpTarih.CustomFormat = null;
            this.dtpTarih.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTarih.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTarih.ForeColor = System.Drawing.Color.Black;
            this.dtpTarih.Location = new System.Drawing.Point(129, 76);
            this.dtpTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpTarih.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTarih.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTarih.OnPressedColor = System.Drawing.Color.Black;
            this.dtpTarih.Size = new System.Drawing.Size(223, 30);
            this.dtpTarih.TabIndex = 3;
            this.dtpTarih.Text = "22 Ekim 2019 Salı";
            this.dtpTarih.Value = new System.DateTime(2019, 10, 22, 11, 57, 59, 109);
            this.dtpTarih.ValueChanged += new System.EventHandler(this.DtpTarih_ValueChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(67, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(32, 15);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Tarih";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(67, 135);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(37, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Seans";
            // 
            // btnOlustur
            // 
            this.btnOlustur.AnimationHoverSpeed = 0.07F;
            this.btnOlustur.AnimationSpeed = 0.03F;
            this.btnOlustur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOlustur.BorderColor = System.Drawing.Color.Black;
            this.btnOlustur.FocusedColor = System.Drawing.Color.Empty;
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Image = null;
            this.btnOlustur.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOlustur.Location = new System.Drawing.Point(192, 183);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOlustur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOlustur.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOlustur.OnHoverImage = null;
            this.btnOlustur.OnPressedColor = System.Drawing.Color.Black;
            this.btnOlustur.Size = new System.Drawing.Size(160, 42);
            this.btnOlustur.TabIndex = 7;
            this.btnOlustur.Text = "Randevu Olustur";
            this.btnOlustur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // cmbSeans
            // 
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(129, 130);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(223, 25);
            this.cmbSeans.TabIndex = 8;
            // 
            // mhrsDoktorRandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(430, 285);
            this.Controls.Add(this.cmbSeans);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.gunaTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsDoktorRandevuOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mhrsDoktorRandevuOlustur";
            this.Load += new System.EventHandler(this.MhrsDoktorRandevuOlustur_Load);
            this.gunaTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaTopBar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpTarih;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnOlustur;
        private System.Windows.Forms.ComboBox cmbSeans;
    }
}
namespace MHRS.UIWinForm
{
    partial class mhrsDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsDoktor));
            this.gunaSolPanel = new Guna.UI.WinForms.GunaPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnCikis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnHastalarim = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblKullanici = new Guna.UI.WinForms.GunaLabel();
            this.gunaTopBar = new Guna.UI.WinForms.GunaPanel();
            this.pcDoktor = new System.Windows.Forms.PictureBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaTasiyiciPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaSolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gunaTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaSolPanel
            // 
            this.gunaSolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(46)))), ((int)(((byte)(134)))));
            this.gunaSolPanel.Controls.Add(this.logo);
            this.gunaSolPanel.Controls.Add(this.btnCikis);
            this.gunaSolPanel.Controls.Add(this.gunaLabel2);
            this.gunaSolPanel.Controls.Add(this.btnHastalarim);
            this.gunaSolPanel.Controls.Add(this.gunaSeparator1);
            this.gunaSolPanel.Controls.Add(this.lblKullanici);
            this.gunaSolPanel.Location = new System.Drawing.Point(0, 30);
            this.gunaSolPanel.Name = "gunaSolPanel";
            this.gunaSolPanel.Size = new System.Drawing.Size(150, 450);
            this.gunaSolPanel.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(38, 314);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.AnimationHoverSpeed = 0.07F;
            this.btnCikis.AnimationSpeed = 0.03F;
            this.btnCikis.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCikis.BorderColor = System.Drawing.Color.Black;
            this.btnCikis.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCikis.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCikis.CheckedForeColor = System.Drawing.Color.White;
            this.btnCikis.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.CheckedImage")));
            this.btnCikis.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCikis.FocusedColor = System.Drawing.Color.Empty;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Image = global::MHRS.UIWinForm.Properties.Resources._1894665_20;
            this.btnCikis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCikis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCikis.Location = new System.Drawing.Point(1, 133);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCikis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCikis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCikis.OnHoverImage = null;
            this.btnCikis.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCikis.OnPressedColor = System.Drawing.Color.Black;
            this.btnCikis.Size = new System.Drawing.Size(150, 41);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(0, 435);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 15);
            this.gunaLabel2.TabIndex = 23;
            this.gunaLabel2.Text = "Version v14.0.3.0.0";
            // 
            // btnHastalarim
            // 
            this.btnHastalarim.AnimationHoverSpeed = 0.07F;
            this.btnHastalarim.AnimationSpeed = 0.03F;
            this.btnHastalarim.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnHastalarim.BorderColor = System.Drawing.Color.Black;
            this.btnHastalarim.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHastalarim.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHastalarim.CheckedForeColor = System.Drawing.Color.White;
            this.btnHastalarim.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnHastalarim.CheckedImage")));
            this.btnHastalarim.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHastalarim.FocusedColor = System.Drawing.Color.Empty;
            this.btnHastalarim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHastalarim.ForeColor = System.Drawing.Color.White;
            this.btnHastalarim.Image = global::MHRS.UIWinForm.Properties.Resources.list;
            this.btnHastalarim.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHastalarim.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHastalarim.Location = new System.Drawing.Point(0, 88);
            this.btnHastalarim.Name = "btnHastalarim";
            this.btnHastalarim.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHastalarim.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHastalarim.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHastalarim.OnHoverImage = null;
            this.btnHastalarim.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHastalarim.OnPressedColor = System.Drawing.Color.Black;
            this.btnHastalarim.Size = new System.Drawing.Size(150, 41);
            this.btnHastalarim.TabIndex = 21;
            this.btnHastalarim.Text = "Hastalarım";
            this.btnHastalarim.Click += new System.EventHandler(this.BtnHastalarim_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 77);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(151, 10);
            this.gunaSeparator1.TabIndex = 2;
            // 
            // lblKullanici
            // 
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKullanici.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Location = new System.Drawing.Point(3, 3);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(144, 71);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Hoşgeldin Burak";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaTopBar
            // 
            this.gunaTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))));
            this.gunaTopBar.Controls.Add(this.pcDoktor);
            this.gunaTopBar.Controls.Add(this.gunaControlBox2);
            this.gunaTopBar.Controls.Add(this.gunaControlBox1);
            this.gunaTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaTopBar.Location = new System.Drawing.Point(0, 0);
            this.gunaTopBar.Name = "gunaTopBar";
            this.gunaTopBar.Size = new System.Drawing.Size(900, 30);
            this.gunaTopBar.TabIndex = 4;
            // 
            // pcDoktor
            // 
            this.pcDoktor.Image = global::MHRS.UIWinForm.Properties.Resources.iconfinder_7_hospital_2774753;
            this.pcDoktor.Location = new System.Drawing.Point(6, 3);
            this.pcDoktor.Name = "pcDoktor";
            this.pcDoktor.Size = new System.Drawing.Size(24, 24);
            this.pcDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDoktor.TabIndex = 0;
            this.pcDoktor.TabStop = false;
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
            this.gunaControlBox2.Location = new System.Drawing.Point(810, 0);
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
            this.gunaControlBox1.Location = new System.Drawing.Point(855, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaTasiyiciPanel
            // 
            this.gunaTasiyiciPanel.Location = new System.Drawing.Point(150, 30);
            this.gunaTasiyiciPanel.Name = "gunaTasiyiciPanel";
            this.gunaTasiyiciPanel.Size = new System.Drawing.Size(750, 450);
            this.gunaTasiyiciPanel.TabIndex = 3;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaTopBar;
            // 
            // mhrsDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.gunaSolPanel);
            this.Controls.Add(this.gunaTopBar);
            this.Controls.Add(this.gunaTasiyiciPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mhrsDoktor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MhrsDoktor_FormClosed);
            this.Load += new System.EventHandler(this.mhrsDoktor_Load);
            this.gunaSolPanel.ResumeLayout(false);
            this.gunaSolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gunaTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcDoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaSolPanel;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel lblKullanici;
        private Guna.UI.WinForms.GunaPanel gunaTopBar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnHastalarim;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        public Guna.UI.WinForms.GunaPanel gunaTasiyiciPanel;
        private Guna.UI.WinForms.GunaAdvenceButton btnCikis;
        private System.Windows.Forms.PictureBox pcDoktor;
        private System.Windows.Forms.PictureBox logo;
    }
}
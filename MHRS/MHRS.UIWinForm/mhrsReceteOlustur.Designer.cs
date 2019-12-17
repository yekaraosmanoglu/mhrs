namespace MHRS.UIWinForm
{
    partial class mhrsReceteOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsReceteOlustur));
            this.gunaTopBar = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txtRecete = new Guna.UI.WinForms.GunaTextBox();
            this.btnOlustur = new Guna.UI.WinForms.GunaButton();
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
            this.gunaTopBar.TabIndex = 3;
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
            // txtRecete
            // 
            this.txtRecete.BaseColor = System.Drawing.Color.White;
            this.txtRecete.BorderColor = System.Drawing.Color.Silver;
            this.txtRecete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecete.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRecete.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRecete.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRecete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecete.Location = new System.Drawing.Point(52, 65);
            this.txtRecete.MultiLine = true;
            this.txtRecete.Name = "txtRecete";
            this.txtRecete.PasswordChar = '\0';
            this.txtRecete.Size = new System.Drawing.Size(324, 138);
            this.txtRecete.TabIndex = 4;
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
            this.btnOlustur.Location = new System.Drawing.Point(216, 219);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOlustur.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOlustur.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOlustur.OnHoverImage = null;
            this.btnOlustur.OnPressedColor = System.Drawing.Color.Black;
            this.btnOlustur.Size = new System.Drawing.Size(160, 42);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "Recete Olustur";
            this.btnOlustur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // mhrsReceteOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(430, 285);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtRecete);
            this.Controls.Add(this.gunaTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsReceteOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mhrsReceteOlustur";
            this.gunaTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaTopBar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaTextBox txtRecete;
        private Guna.UI.WinForms.GunaButton btnOlustur;
    }
}
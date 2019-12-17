namespace MHRS.UIWinForm
{
    partial class mhrsHastaReceteGecmisi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mhrsHastaReceteGecmisi));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtHastaID = new Guna.UI.WinForms.GunaTextBox();
            this.dgvReceteler = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSorgula = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteler)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(65, 101);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Hasta ID ";
            // 
            // txtHastaID
            // 
            this.txtHastaID.BaseColor = System.Drawing.Color.White;
            this.txtHastaID.BorderColor = System.Drawing.Color.Silver;
            this.txtHastaID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHastaID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHastaID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHastaID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHastaID.Location = new System.Drawing.Point(137, 93);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.PasswordChar = '\0';
            this.txtHastaID.Size = new System.Drawing.Size(160, 30);
            this.txtHastaID.TabIndex = 1;
            // 
            // dgvReceteler
            // 
            this.dgvReceteler.AllowUserToAddRows = false;
            this.dgvReceteler.AllowUserToDeleteRows = false;
            this.dgvReceteler.AllowUserToResizeColumns = false;
            this.dgvReceteler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReceteler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceteler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceteler.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceteler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceteler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceteler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceteler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceteler.ColumnHeadersHeight = 25;
            this.dgvReceteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceteler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceteler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceteler.EnableHeadersVisualStyles = false;
            this.dgvReceteler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceteler.Location = new System.Drawing.Point(54, 148);
            this.dgvReceteler.MultiSelect = false;
            this.dgvReceteler.Name = "dgvReceteler";
            this.dgvReceteler.ReadOnly = true;
            this.dgvReceteler.RowHeadersVisible = false;
            this.dgvReceteler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReceteler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceteler.Size = new System.Drawing.Size(651, 263);
            this.dgvReceteler.TabIndex = 2;
            this.dgvReceteler.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvReceteler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceteler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReceteler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReceteler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReceteler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReceteler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceteler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceteler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReceteler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReceteler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReceteler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReceteler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceteler.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvReceteler.ThemeStyle.ReadOnly = true;
            this.dgvReceteler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceteler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceteler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReceteler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReceteler.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReceteler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceteler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.FillWeight = 130.0579F;
            this.Column1.HeaderText = "Reçete ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.FillWeight = 61.84935F;
            this.Column2.HeaderText = "Reçete";
            this.Column2.MinimumWidth = 250;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 90.93712F;
            this.Column3.HeaderText = "Hasta";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 117.1556F;
            this.Column4.HeaderText = "Doktor";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.btnSorgula.Location = new System.Drawing.Point(335, 93);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSorgula.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSorgula.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSorgula.OnHoverImage = null;
            this.btnSorgula.OnPressedColor = System.Drawing.Color.Black;
            this.btnSorgula.Size = new System.Drawing.Size(87, 30);
            this.btnSorgula.TabIndex = 3;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(68, 65);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(218, 10);
            this.gunaSeparator1.TabIndex = 20;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLabel7.Location = new System.Drawing.Point(60, 26);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(236, 45);
            this.gunaLabel7.TabIndex = 19;
            this.gunaLabel7.Text = "Recete Gecmişi";
            // 
            // mhrsHastaReceteGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.dgvReceteler);
            this.Controls.Add(this.txtHastaID);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mhrsHastaReceteGecmisi";
            this.Text = "mhrsHastaReceteGecmisi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtHastaID;
        private Guna.UI.WinForms.GunaDataGridView dgvReceteler;
        private Guna.UI.WinForms.GunaButton btnSorgula;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
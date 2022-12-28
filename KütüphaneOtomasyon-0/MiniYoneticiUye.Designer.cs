namespace KütüphaneOtomasyon_0
{
    partial class MiniYoneticiUye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniYoneticiUye));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUye = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.pbKayıtSil = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.pbOduncVer = new System.Windows.Forms.PictureBox();
            this.pbAra = new System.Windows.Forms.PictureBox();
            this.txtEmanetAra = new System.Windows.Forms.TextBox();
            this.pbEmanetAra = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new KütüphaneOtomasyon_0.CircularPictureBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayıtSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduncVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmanetAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvUye);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(70, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜYE İŞLEMLERİ";
            // 
            // dgvUye
            // 
            this.dgvUye.AllowUserToAddRows = false;
            this.dgvUye.AllowUserToDeleteRows = false;
            this.dgvUye.AllowUserToOrderColumns = true;
            this.dgvUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUye.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUye.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUye.Location = new System.Drawing.Point(3, 26);
            this.dgvUye.MultiSelect = false;
            this.dgvUye.Name = "dgvUye";
            this.dgvUye.ReadOnly = true;
            this.dgvUye.RowHeadersWidth = 51;
            this.dgvUye.RowTemplate.Height = 29;
            this.dgvUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUye.Size = new System.Drawing.Size(744, 171);
            this.dgvUye.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tc";
            this.Column1.HeaderText = "TC";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uye_ad";
            this.Column2.HeaderText = "AD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "uye_soyad";
            this.Column3.HeaderText = "SOYAD";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "uye_telefon";
            this.Column4.HeaderText = "TELEFON";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvKitap);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(70, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EMANET KİTAP İŞLEMLERİ";
            // 
            // dgvKitap
            // 
            this.dgvKitap.AllowUserToAddRows = false;
            this.dgvKitap.AllowUserToDeleteRows = false;
            this.dgvKitap.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvKitap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKitap.Location = new System.Drawing.Point(3, 26);
            this.dgvKitap.MultiSelect = false;
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.ReadOnly = true;
            this.dgvKitap.RowHeadersWidth = 51;
            this.dgvKitap.RowTemplate.Height = 29;
            this.dgvKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitap.Size = new System.Drawing.Size(744, 171);
            this.dgvKitap.TabIndex = 0;
            this.dgvKitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitap_CellContentClick);
            // 
            // pbKayıtSil
            // 
            this.pbKayıtSil.BackColor = System.Drawing.Color.Transparent;
            this.pbKayıtSil.Image = ((System.Drawing.Image)(resources.GetObject("pbKayıtSil.Image")));
            this.pbKayıtSil.Location = new System.Drawing.Point(414, 299);
            this.pbKayıtSil.Name = "pbKayıtSil";
            this.pbKayıtSil.Size = new System.Drawing.Size(70, 62);
            this.pbKayıtSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKayıtSil.TabIndex = 3;
            this.pbKayıtSil.TabStop = false;
            this.pbKayıtSil.Click += new System.EventHandler(this.pbKayıtSil_Click);
            this.pbKayıtSil.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pbKayıtSil.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAra.Location = new System.Drawing.Point(295, 259);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(273, 30);
            this.txtAra.TabIndex = 4;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            this.txtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAra_KeyPress);
            // 
            // pbOduncVer
            // 
            this.pbOduncVer.BackColor = System.Drawing.Color.Transparent;
            this.pbOduncVer.Image = ((System.Drawing.Image)(resources.GetObject("pbOduncVer.Image")));
            this.pbOduncVer.Location = new System.Drawing.Point(414, 609);
            this.pbOduncVer.Name = "pbOduncVer";
            this.pbOduncVer.Size = new System.Drawing.Size(70, 62);
            this.pbOduncVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOduncVer.TabIndex = 5;
            this.pbOduncVer.TabStop = false;
            this.pbOduncVer.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pbOduncVer.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pbOduncVer.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pbAra
            // 
            this.pbAra.BackColor = System.Drawing.Color.Transparent;
            this.pbAra.Image = ((System.Drawing.Image)(resources.GetObject("pbAra.Image")));
            this.pbAra.Location = new System.Drawing.Point(574, 259);
            this.pbAra.Name = "pbAra";
            this.pbAra.Size = new System.Drawing.Size(32, 30);
            this.pbAra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAra.TabIndex = 6;
            this.pbAra.TabStop = false;
            this.pbAra.Click += new System.EventHandler(this.pbAra_Click);
            this.pbAra.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pbAra.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // txtEmanetAra
            // 
            this.txtEmanetAra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmanetAra.Location = new System.Drawing.Point(295, 573);
            this.txtEmanetAra.Name = "txtEmanetAra";
            this.txtEmanetAra.Size = new System.Drawing.Size(273, 30);
            this.txtEmanetAra.TabIndex = 7;
            this.txtEmanetAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmanetAra_KeyPress);
            // 
            // pbEmanetAra
            // 
            this.pbEmanetAra.BackColor = System.Drawing.Color.Transparent;
            this.pbEmanetAra.Image = ((System.Drawing.Image)(resources.GetObject("pbEmanetAra.Image")));
            this.pbEmanetAra.Location = new System.Drawing.Point(574, 573);
            this.pbEmanetAra.Name = "pbEmanetAra";
            this.pbEmanetAra.Size = new System.Drawing.Size(32, 30);
            this.pbEmanetAra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmanetAra.TabIndex = 8;
            this.pbEmanetAra.TabStop = false;
            this.pbEmanetAra.Click += new System.EventHandler(this.pbEmanetAra_Click);
            this.pbEmanetAra.MouseEnter += new System.EventHandler(this.pbEmanetAra_MouseEnter);
            this.pbEmanetAra.MouseLeave += new System.EventHandler(this.pbEmanetAra_MouseLeave);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(836, 12);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(34, 34);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 9;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            this.circularPictureBox1.MouseEnter += new System.EventHandler(this.circularPictureBox1_MouseEnter);
            this.circularPictureBox1.MouseLeave += new System.EventHandler(this.circularPictureBox1_MouseLeave);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "emanet_id";
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tc";
            this.Column6.HeaderText = "TC";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "kitap_ad";
            this.Column7.HeaderText = "KİTAP ADI";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "emanet_date";
            this.Column8.HeaderText = "EMANET TARİHİ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "teslim_date";
            this.Column9.HeaderText = "TESLİM TARİHİ";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // MiniYoneticiUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 700);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.pbEmanetAra);
            this.Controls.Add(this.txtEmanetAra);
            this.Controls.Add(this.pbAra);
            this.Controls.Add(this.pbOduncVer);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.pbKayıtSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniYoneticiUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniYoneticiUye";
            this.Load += new System.EventHandler(this.MiniYoneticiUye_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayıtSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOduncVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmanetAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dgvUye;
        private GroupBox groupBox2;
        private DataGridView dgvKitap;
        private PictureBox pbKayıtSil;
        private TextBox txtAra;
        private PictureBox pbOduncVer;
        private PictureBox pbAra;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtEmanetAra;
        private PictureBox pbEmanetAra;
        private CircularPictureBox circularPictureBox1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
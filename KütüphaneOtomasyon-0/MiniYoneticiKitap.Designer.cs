namespace KütüphaneOtomasyon_0
{
    partial class MiniYoneticiKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniYoneticiKitap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.cbKitapTur = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBasim = new System.Windows.Forms.MaskedTextBox();
            this.txtYayınEvi = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwTablo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TÜR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.circularPictureBox1 = new KütüphaneOtomasyon_0.CircularPictureBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSayfa);
            this.groupBox1.Controls.Add(this.cbKitapTur);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtBasim);
            this.groupBox1.Controls.Add(this.txtYayınEvi);
            this.groupBox1.Controls.Add(this.txtYazarAd);
            this.groupBox1.Controls.Add(this.txtKitapAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(47, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP EKLE";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSayfa.Location = new System.Drawing.Point(228, 250);
            this.txtSayfa.MaxLength = 4;
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(125, 27);
            this.txtSayfa.TabIndex = 5;
            this.txtSayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayfa_KeyPress);
            // 
            // cbKitapTur
            // 
            this.cbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapTur.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbKitapTur.FormattingEnabled = true;
            this.cbKitapTur.Items.AddRange(new object[] {
            "DÜNYA KLASİKLERİ",
            "AŞK",
            "ROMAN",
            "PSİKOLOJİ",
            "GENÇLİK",
            "DİN",
            "TARİH",
            "SİYASET-POLİTİKA",
            "KİŞİSEL GELİŞİM",
            "ÇOCUK",
            "MACERA-AKSİYON",
            "ŞİİR",
            "POLİSİYE",
            "FELSEFE-DÜŞÜNCE",
            "FANTASTİK",
            "KORKU-GERİLİM",
            "EDEBİYAT",
            "HİKAYE (ÖYKÜ)",
            "BİLİM-KURGU",
            "SOSYOLOJİ",
            "BİYOGRAFİ",
            "ARAŞTIRMA-İNCELEME",
            "DENEME-İNCELEME",
            "PARAPSİKOLOJİ-SPİRİTÜALİZM",
            "EKONOMİ-EMEK-İŞ DÜNYASI",
            "MANGA",
            "EĞLENCE-MİZAH",
            "TÜRK KLASİKLERİ",
            "SAĞLIK-TIP",
            "MASAL",
            "İNSAN VE TOPLUM",
            "ANI-MEKTUP-GÜNLÜK",
            "BİLİM-TEKNOLOJİ-MÜHENDİSLİK",
            "EĞİTİM",
            "ÇİZGİ-ROMAN",
            "TİYATRO",
            "YERALTI EDEBİYATI",
            "TASAVVUF-MEZHEPLER-TARİKATLAR",
            "MİTOLOJİLER",
            "HUKUK",
            "ANTROPOLOJİ-ETNOLOJİ",
            "SANAT",
            "BİLGİSAYAR-İNTERNET",
            "SPOR",
            "GEZİ",
            "KADIN-ERKEK",
            "DERGİ",
            "ANLATI",
            "ELEŞTİRİ-KURAM",
            "KADIN",
            "AİLE (KADIN, ERKEK VE ÇOCUK)",
            "EFSANELER-DESTANLAR",
            "DİLBİLİMİ-ETİMOLOJİ",
            "HOBİ",
            "SİNEMA",
            "YEMEK",
            "ANTOLOJİ",
            "DERS KİTAPLARI",
            "SÖYLEŞİ-RÖPORTAJ",
            "SENARYO-OYUN",
            "MÜZİK",
            "ÖZLÜ SÖZLER-DUVAR YAZILARI",
            "HALK EDEBİYATI",
            "İLETİŞİM-MEDYA",
            "ASTROLOJİ-FAL-RÜYA TABİRLERİ",
            "EKOLOJİ",
            "SÖZLÜK-KILAVUZ KİTAP-ANSİKLOPEDİ",
            "MODA",
            "KÜLTÜR"});
            this.cbKitapTur.Location = new System.Drawing.Point(228, 118);
            this.cbKitapTur.Name = "cbKitapTur";
            this.cbKitapTur.Size = new System.Drawing.Size(331, 28);
            this.cbKitapTur.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // txtBasim
            // 
            this.txtBasim.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBasim.Location = new System.Drawing.Point(227, 206);
            this.txtBasim.Mask = "0000";
            this.txtBasim.Name = "txtBasim";
            this.txtBasim.Size = new System.Drawing.Size(125, 27);
            this.txtBasim.TabIndex = 4;
            this.txtBasim.ValidatingType = typeof(int);
            // 
            // txtYayınEvi
            // 
            this.txtYayınEvi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYayınEvi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYayınEvi.Location = new System.Drawing.Point(228, 162);
            this.txtYayınEvi.Name = "txtYayınEvi";
            this.txtYayınEvi.Size = new System.Drawing.Size(331, 27);
            this.txtYayınEvi.TabIndex = 3;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYazarAd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYazarAd.Location = new System.Drawing.Point(228, 74);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(331, 27);
            this.txtYazarAd.TabIndex = 1;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKitapAd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKitapAd.Location = new System.Drawing.Point(228, 30);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(331, 27);
            this.txtKitapAd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "SAYFA SAYISI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "BASIM YILI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "YAYIN EVİ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "KİTAP TÜRÜ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "YAZAR ADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP ADI :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgwTablo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(47, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KİTAP LİSTELE || SİL";
            // 
            // dgwTablo
            // 
            this.dgwTablo.AllowUserToAddRows = false;
            this.dgwTablo.AllowUserToDeleteRows = false;
            this.dgwTablo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgwTablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTablo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgwTablo.Location = new System.Drawing.Point(3, 27);
            this.dgwTablo.Name = "dgwTablo";
            this.dgwTablo.ReadOnly = true;
            this.dgwTablo.RowHeadersWidth = 51;
            this.dgwTablo.RowTemplate.Height = 29;
            this.dgwTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTablo.Size = new System.Drawing.Size(784, 211);
            this.dgwTablo.TabIndex = 0;
            this.dgwTablo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTablo_RowHeaderMouseDoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "KİTAP ADI";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "YAZAR";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // TÜR
            // 
            this.TÜR.HeaderText = "Column4";
            this.TÜR.MinimumWidth = 6;
            this.TÜR.Name = "TÜR";
            this.TÜR.Width = 125;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(836, 12);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(34, 34);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 3;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            this.circularPictureBox1.MouseEnter += new System.EventHandler(this.circularPictureBox1_MouseEnter);
            this.circularPictureBox1.MouseLeave += new System.EventHandler(this.circularPictureBox1_MouseLeave);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "kitap_id";
            this.Column4.HeaderText = "ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "kitap_ad";
            this.Column5.HeaderText = "KİTAP ADI";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "yazar";
            this.Column6.HeaderText = "YAZAR";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tur";
            this.Column7.HeaderText = "TÜR";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "yayin_evi";
            this.Column8.HeaderText = "YAYIN EVİ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "basim";
            this.Column9.HeaderText = "BASIM YILI";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "sayfa";
            this.Column10.HeaderText = "SAYFA SAYISI";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // MiniYoneticiKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniYoneticiKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniYoneticiKitap";
            this.Load += new System.EventHandler(this.MiniYoneticiKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox txtBasim;
        private TextBox txtYayınEvi;
        private TextBox txtYazarAd;
        private TextBox txtKitapAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox cbKitapTur;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn TÜR;
        private TextBox txtSayfa;
        private DataGridView dgwTablo;
        private CircularPictureBox circularPictureBox1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
namespace KütüphaneOtomasyon_0
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.circularPictureBox1 = new KütüphaneOtomasyon_0.CircularPictureBox();
            this.circularPictureBox2 = new KütüphaneOtomasyon_0.CircularPictureBox();
            this.cpKapat = new KütüphaneOtomasyon_0.CircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(637, 368);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(165, 165);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 3;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            this.circularPictureBox1.MouseEnter += new System.EventHandler(this.circularPictureBox1_MouseEnter);
            this.circularPictureBox1.MouseLeave += new System.EventHandler(this.circularPictureBox1_MouseLeave);
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox2.Image")));
            this.circularPictureBox2.Location = new System.Drawing.Point(396, 368);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(165, 168);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox2.TabIndex = 4;
            this.circularPictureBox2.TabStop = false;
            this.circularPictureBox2.Click += new System.EventHandler(this.circularPictureBox2_Click_1);
            this.circularPictureBox2.MouseEnter += new System.EventHandler(this.circularPictureBox2_MouseEnter);
            this.circularPictureBox2.MouseLeave += new System.EventHandler(this.circularPictureBox2_MouseLeave);
            // 
            // cpKapat
            // 
            this.cpKapat.BackColor = System.Drawing.Color.Transparent;
            this.cpKapat.Image = ((System.Drawing.Image)(resources.GetObject("cpKapat.Image")));
            this.cpKapat.Location = new System.Drawing.Point(1154, 12);
            this.cpKapat.Name = "cpKapat";
            this.cpKapat.Size = new System.Drawing.Size(34, 34);
            this.cpKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpKapat.TabIndex = 5;
            this.cpKapat.TabStop = false;
            this.cpKapat.Click += new System.EventHandler(this.cpKapat_Click);
            this.cpKapat.MouseEnter += new System.EventHandler(this.cpKapat_MouseEnter);
            this.cpKapat.MouseLeave += new System.EventHandler(this.cpKapat_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(440, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hazırlayanlar : Ayşegül Kurtuluş Erdem Karaoğlu";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpKapat);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        private CircularPictureBox cpKapat;
        private Label label1;
    }
}
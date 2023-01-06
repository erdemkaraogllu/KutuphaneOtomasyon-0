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
            this.linkUyeOl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(637, 368);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(180, 180);
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
            this.circularPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox2.Image")));
            this.circularPictureBox2.Location = new System.Drawing.Point(396, 368);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(180, 180);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox2.TabIndex = 4;
            this.circularPictureBox2.TabStop = false;
            this.circularPictureBox2.Click += new System.EventHandler(this.circularPictureBox2_Click_1);
            this.circularPictureBox2.MouseEnter += new System.EventHandler(this.circularPictureBox2_MouseEnter);
            this.circularPictureBox2.MouseLeave += new System.EventHandler(this.circularPictureBox2_MouseLeave);
            // 
            // linkUyeOl
            // 
            this.linkUyeOl.AutoSize = true;
            this.linkUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.linkUyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkUyeOl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkUyeOl.LinkColor = System.Drawing.Color.Khaki;
            this.linkUyeOl.Location = new System.Drawing.Point(576, 584);
            this.linkUyeOl.Name = "linkUyeOl";
            this.linkUyeOl.Size = new System.Drawing.Size(69, 23);
            this.linkUyeOl.TabIndex = 6;
            this.linkUyeOl.TabStop = true;
            this.linkUyeOl.Text = "Üye Ol";
            this.linkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUyeOl_LinkClicked);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.linkUyeOl);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Anasayfa_FormClosed);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox2;
        private LinkLabel linkUyeOl;
    }
}
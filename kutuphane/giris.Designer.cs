namespace kutuphane
{
    partial class giris
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblDurum = new Label();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(84, 126);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(84, 58);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtSifre.Location = new Point(251, 119);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(206, 27);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(251, 51);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(206, 27);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDurum.ForeColor = Color.IndianRed;
            lblDurum.Location = new Point(107, 315);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 20);
            lblDurum.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "logout256_24927.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(251, 201);
            button1.Name = "button1";
            button1.Size = new Size(206, 64);
            button1.TabIndex = 7;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "logout256_24927.png");
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 404);
            Controls.Add(button1);
            Controls.Add(lblDurum);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label lblDurum;
        private Button button1;
        private ImageList ımageList1;
    }
}
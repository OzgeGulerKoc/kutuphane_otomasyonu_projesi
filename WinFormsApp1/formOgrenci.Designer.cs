namespace WinFormsApp1
{
    partial class formOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenci));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboCinsiyet = new ComboBox();
            comboSinif = new ComboBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtNo = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtOgrenciAra = new TextBox();
            groupBox3 = new GroupBox();
            btnGuncelle = new Button();
            ımageList1 = new ImageList(components);
            btnSil = new Button();
            btnKaydet = new Button();
            gridOgrenci = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOgrenci).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboCinsiyet);
            groupBox1.Controls.Add(comboSinif);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(8, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 56);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 11;
            label6.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 21);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 56);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 9;
            label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 26);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 8;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Sınıf:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "Okul No:";
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Kız", "Erkek" });
            comboCinsiyet.Location = new Point(326, 56);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(121, 28);
            comboCinsiyet.TabIndex = 5;
            // 
            // comboSinif
            // 
            comboSinif.FormattingEnabled = true;
            comboSinif.Items.AddRange(new object[] { "9", "10", "11", "12" });
            comboSinif.Location = new Point(110, 56);
            comboSinif.Name = "comboSinif";
            comboSinif.Size = new Size(121, 28);
            comboSinif.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(574, 56);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(120, 27);
            txtTelefon.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(574, 19);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(120, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(326, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 27);
            txtAd.TabIndex = 1;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(110, 20);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(121, 27);
            txtNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtOgrenciAra);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(8, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arama";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 34);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 1;
            label7.Text = "Öğrenci Adı:";
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Location = new Point(110, 31);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(121, 27);
            txtOgrenciAra.TabIndex = 0;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Location = new Point(270, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 115);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "İşlemler";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageKey = "vcsupdaterequired_93493.png";
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(312, 31);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(120, 60);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "vcsupdaterequired_93493.png");
            ımageList1.Images.SetKeyName(1, "delete_delete_exit_1577.png");
            ımageList1.Images.SetKeyName(2, "gui_save_icon_157040.png");
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "delete_delete_exit_1577.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(169, 31);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 60);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.ImageKey = "gui_save_icon_157040.png";
            btnKaydet.ImageList = ımageList1;
            btnKaydet.Location = new Point(24, 31);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 60);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // gridOgrenci
            // 
            gridOgrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOgrenci.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridOgrenci.Location = new Point(8, 240);
            gridOgrenci.Name = "gridOgrenci";
            gridOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOgrenci.Size = new Size(714, 316);
            gridOgrenci.TabIndex = 3;
            gridOgrenci.CellContentClick += gridOgrenci_CellClick;
            // 
            // formOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 568);
            Controls.Add(gridOgrenci);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formOgrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci İşlemleri";
            Load += formOgrenci_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOgrenci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboCinsiyet;
        private ComboBox comboSinif;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtNo;
        private TextBox txtOgrenciAra;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private DataGridView gridOgrenci;
        private ImageList ımageList1;
    }
}
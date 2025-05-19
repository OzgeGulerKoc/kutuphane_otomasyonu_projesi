namespace kutuphane
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
            comboCinsiyet = new ComboBox();
            comboSinif = new ComboBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtOgrenciAra = new TextBox();
            label7 = new Label();
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
            groupBox1.Controls.Add(comboCinsiyet);
            groupBox1.Controls.Add(comboSinif);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Kız", "Erkek" });
            comboCinsiyet.Location = new Point(313, 84);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(142, 23);
            comboCinsiyet.TabIndex = 11;
            // 
            // comboSinif
            // 
            comboSinif.FormattingEnabled = true;
            comboSinif.Items.AddRange(new object[] { "9", "10", "11", "12" });
            comboSinif.Location = new Point(79, 89);
            comboSinif.Name = "comboSinif";
            comboSinif.Size = new Size(137, 23);
            comboSinif.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(551, 81);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 23);
            txtTelefon.TabIndex = 9;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(551, 30);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 23);
            txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(313, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(142, 23);
            txtAd.TabIndex = 7;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(79, 36);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(137, 23);
            txtNo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 89);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 92);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 92);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Sınıf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 36);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 39);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Okul no:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOgrenciAra);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arama";
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Location = new Point(85, 35);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(145, 23);
            txtOgrenciAra.TabIndex = 1;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 0;
            label7.Text = "Öğrenci Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Location = new Point(255, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 100);
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
            btnGuncelle.Location = new Point(325, 22);
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
            ımageList1.Images.SetKeyName(0, "delete_delete_exit_1577.png");
            ımageList1.Images.SetKeyName(1, "gui_save_icon_157040 (1).png");
            ımageList1.Images.SetKeyName(2, "vcsupdaterequired_93493.png");
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "delete_delete_exit_1577.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(182, 22);
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
            btnKaydet.ImageKey = "gui_save_icon_157040 (1).png";
            btnKaydet.ImageList = ımageList1;
            btnKaydet.Location = new Point(27, 22);
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
            gridOgrenci.Location = new Point(12, 263);
            gridOgrenci.Name = "gridOgrenci";
            gridOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOgrenci.Size = new Size(710, 286);
            gridOgrenci.TabIndex = 3;
            gridOgrenci.CellClick += gridOgrenci_CellClick;
            // 
            // formOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(gridOgrenci);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formOgrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formOgrenci";
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
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboCinsiyet;
        private ComboBox comboSinif;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtNo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtOgrenciAra;
        private Label label7;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private DataGridView gridOgrenci;
        private ImageList ımageList1;
    }
}
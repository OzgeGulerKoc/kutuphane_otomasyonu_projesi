namespace kutuphane
{
    partial class formKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKitap));
            groupBox1 = new GroupBox();
            comboKitapTur = new ComboBox();
            txtSayfaSayisi = new TextBox();
            txtYayinEvi = new TextBox();
            txtYazar = new TextBox();
            txtKitapAdi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtKitapAra = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            btnGuncelle = new Button();
            ımageList1 = new ImageList(components);
            btnSil = new Button();
            btnKaydet = new Button();
            gridKitap = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridKitap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboKitapTur);
            groupBox1.Controls.Add(txtSayfaSayisi);
            groupBox1.Controls.Add(txtYayinEvi);
            groupBox1.Controls.Add(txtYazar);
            groupBox1.Controls.Add(txtKitapAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // comboKitapTur
            // 
            comboKitapTur.FormattingEnabled = true;
            comboKitapTur.Location = new Point(114, 78);
            comboKitapTur.Name = "comboKitapTur";
            comboKitapTur.Size = new Size(121, 23);
            comboKitapTur.TabIndex = 9;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(361, 75);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(126, 23);
            txtSayfaSayisi.TabIndex = 8;
            // 
            // txtYayinEvi
            // 
            txtYayinEvi.Location = new Point(589, 26);
            txtYayinEvi.Name = "txtYayinEvi";
            txtYayinEvi.Size = new Size(118, 23);
            txtYayinEvi.TabIndex = 7;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(361, 26);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(126, 23);
            txtYazar.TabIndex = 6;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(114, 26);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(121, 23);
            txtKitapAdi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 29);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Yayın Evi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 78);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 29);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 81);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Tür:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKitapAra);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Arama";
            // 
            // txtKitapAra
            // 
            txtKitapAra.Location = new Point(113, 37);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(121, 23);
            txtKitapAra.TabIndex = 1;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 44);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 0;
            label6.Text = "Kitap Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Location = new Point(296, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 96);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "İşlemler";
            // 
            // btnGuncelle
            // 
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageKey = "vcsupdaterequired_93493.png";
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(298, 21);
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
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "delete_delete_exit_1577.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(163, 21);
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
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.ImageKey = "gui_save_icon_157040 (1).png";
            btnKaydet.ImageList = ımageList1;
            btnKaydet.Location = new Point(28, 21);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 60);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // gridKitap
            // 
            gridKitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridKitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridKitap.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridKitap.Location = new Point(12, 250);
            gridKitap.Name = "gridKitap";
            gridKitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridKitap.Size = new Size(712, 249);
            gridKitap.TabIndex = 3;
            gridKitap.CellClick += gridKitap_CellClick;
            // 
            // formKitap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 511);
            Controls.Add(gridKitap);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formKitap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formKitap";
            Load += formKitap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridKitap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboKitapTur;
        private TextBox txtSayfaSayisi;
        private TextBox txtYayinEvi;
        private TextBox txtYazar;
        private TextBox txtKitapAdi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtKitapAra;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private DataGridView gridKitap;
        private ImageList ımageList1;
    }
}
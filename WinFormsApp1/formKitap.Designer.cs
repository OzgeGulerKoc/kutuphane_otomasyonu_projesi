namespace WinFormsApp1
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
            txtYayinEvi = new TextBox();
            txtSayfaSayisi = new TextBox();
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
            btnkaydet = new Button();
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
            groupBox1.Controls.Add(txtYayinEvi);
            groupBox1.Controls.Add(txtSayfaSayisi);
            groupBox1.Controls.Add(txtYazar);
            groupBox1.Controls.Add(txtKitapAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // comboKitapTur
            // 
            comboKitapTur.FormattingEnabled = true;
            comboKitapTur.Location = new Point(107, 78);
            comboKitapTur.Name = "comboKitapTur";
            comboKitapTur.Size = new Size(121, 28);
            comboKitapTur.TabIndex = 9;
            // 
            // txtYayinEvi
            // 
            txtYayinEvi.Location = new Point(577, 25);
            txtYayinEvi.Name = "txtYayinEvi";
            txtYayinEvi.Size = new Size(121, 27);
            txtYayinEvi.TabIndex = 8;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(350, 79);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(121, 27);
            txtSayfaSayisi.TabIndex = 7;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(350, 25);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(121, 27);
            txtYazar.TabIndex = 6;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(107, 25);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(121, 27);
            txtKitapAdi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 28);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Yayın Evi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 81);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 28);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Yazar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 81);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Tür:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKitapAra);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Arama";
            // 
            // txtKitapAra
            // 
            txtKitapAra.Location = new Point(107, 36);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(121, 27);
            txtKitapAra.TabIndex = 1;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 39);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 0;
            label6.Text = "Kitap Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnkaydet);
            groupBox3.Font = new Font("Segoe UI", 11F);
            groupBox3.Location = new Point(268, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(454, 100);
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
            btnGuncelle.Location = new Point(311, 26);
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
            ımageList1.Images.SetKeyName(1, "gui_save_icon_157040 (1).png");
            ımageList1.Images.SetKeyName(2, "delete_delete_exit_1577.png");
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "delete_delete_exit_1577.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(171, 26);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 60);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnkaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnkaydet.ImageKey = "gui_save_icon_157040 (1).png";
            btnkaydet.ImageList = ımageList1;
            btnkaydet.Location = new Point(29, 26);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(120, 60);
            btnkaydet.TabIndex = 0;
            btnkaydet.Text = "kaydet";
            btnkaydet.TextAlign = ContentAlignment.MiddleRight;
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // gridKitap
            // 
            gridKitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridKitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridKitap.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridKitap.Location = new Point(12, 240);
            gridKitap.Name = "gridKitap";
            gridKitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridKitap.Size = new Size(710, 259);
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
            Text = "Kitap İşlemleri";
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private GroupBox groupBox3;
        private ComboBox comboKitapTur;
        private TextBox txtYayinEvi;
        private TextBox txtSayfaSayisi;
        private TextBox txtYazar;
        private TextBox txtKitapAdi;
        private TextBox txtKitapAra;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnkaydet;
        private ImageList ımageList1;
        private DataGridView gridKitap;
    }
}
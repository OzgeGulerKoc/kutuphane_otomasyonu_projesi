namespace kutuphane
{
    partial class formOduncKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOduncKitap));
            groupBox1 = new GroupBox();
            txtAçıklama = new TextBox();
            comboKitap = new ComboBox();
            txtNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtAramaOgrenci = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnKitapAl = new Button();
            ımageList1 = new ImageList(components);
            btnSil = new Button();
            btnKitapVer = new Button();
            gridOduncKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOduncKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAçıklama);
            groupBox1.Controls.Add(comboKitap);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // txtAçıklama
            // 
            txtAçıklama.Location = new Point(467, 22);
            txtAçıklama.Multiline = true;
            txtAçıklama.Name = "txtAçıklama";
            txtAçıklama.Size = new Size(288, 69);
            txtAçıklama.TabIndex = 5;
            // 
            // comboKitap
            // 
            comboKitap.FormattingEnabled = true;
            comboKitap.Location = new Point(141, 68);
            comboKitap.Name = "comboKitap";
            comboKitap.Size = new Size(157, 23);
            comboKitap.TabIndex = 4;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(141, 28);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(157, 23);
            txtNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 31);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Açıklama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAramaOgrenci);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Kitap Arama:";
            // 
            // txtAramaOgrenci
            // 
            txtAramaOgrenci.Location = new Point(112, 33);
            txtAramaOgrenci.Name = "txtAramaOgrenci";
            txtAramaOgrenci.Size = new Size(156, 23);
            txtAramaOgrenci.TabIndex = 1;
            txtAramaOgrenci.TextChanged += txtAramaOgrenci_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 36);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Öğrenci Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnKitapAl);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnKitapVer);
            groupBox3.Location = new Point(302, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 91);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            btnKitapAl.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapAl.ImageKey = "vcsupdaterequired_93493.png";
            btnKitapAl.ImageList = ımageList1;
            btnKitapAl.Location = new Point(345, 22);
            btnKitapAl.Name = "btnKitapAl";
            btnKitapAl.Size = new Size(120, 60);
            btnKitapAl.TabIndex = 2;
            btnKitapAl.Text = "Kitap Al";
            btnKitapAl.TextAlign = ContentAlignment.MiddleRight;
            btnKitapAl.UseVisualStyleBackColor = true;
            btnKitapAl.Click += btnKitapAl_Click;
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
            btnSil.Location = new Point(198, 22);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 60);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKitapVer
            // 
            btnKitapVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapVer.ImageKey = "gui_save_icon_157040 (1).png";
            btnKitapVer.ImageList = ımageList1;
            btnKitapVer.Location = new Point(54, 22);
            btnKitapVer.Name = "btnKitapVer";
            btnKitapVer.Size = new Size(120, 60);
            btnKitapVer.TabIndex = 0;
            btnKitapVer.Text = "Kitap Ver";
            btnKitapVer.TextAlign = ContentAlignment.MiddleRight;
            btnKitapVer.UseVisualStyleBackColor = true;
            btnKitapVer.Click += btnKitapVer_Click;
            // 
            // gridOduncKitaplar
            // 
            gridOduncKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOduncKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOduncKitaplar.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridOduncKitaplar.Location = new Point(12, 229);
            gridOduncKitaplar.Name = "gridOduncKitaplar";
            gridOduncKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOduncKitaplar.Size = new Size(776, 265);
            gridOduncKitaplar.TabIndex = 3;
            gridOduncKitaplar.CellClick += gridOduncKitaplar_CellClick;
            // 
            // formOduncKitap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(gridOduncKitaplar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formOduncKitap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formOduncKitap";
            Load += formOduncKitap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOduncKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAçıklama;
        private ComboBox comboKitap;
        private TextBox txtNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtAramaOgrenci;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnKitapAl;
        private Button btnSil;
        private Button btnKitapVer;
        private DataGridView gridOduncKitaplar;
        private ImageList ımageList1;
    }
}
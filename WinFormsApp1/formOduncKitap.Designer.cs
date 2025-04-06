namespace WinFormsApp1
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
            comboKitap = new ComboBox();
            txtAciklama = new TextBox();
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
            groupBox1.Controls.Add(comboKitap);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // comboKitap
            // 
            comboKitap.FormattingEnabled = true;
            comboKitap.Location = new Point(114, 68);
            comboKitap.Name = "comboKitap";
            comboKitap.Size = new Size(121, 28);
            comboKitap.TabIndex = 5;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(481, 30);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(250, 61);
            txtAciklama.TabIndex = 4;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(114, 23);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(121, 27);
            txtNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Açıklama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAramaOgrenci);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Kitap Arama";
            // 
            // txtAramaOgrenci
            // 
            txtAramaOgrenci.Location = new Point(114, 42);
            txtAramaOgrenci.Name = "txtAramaOgrenci";
            txtAramaOgrenci.Size = new Size(121, 27);
            txtAramaOgrenci.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 45);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 0;
            label4.Text = "Öğrenci Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnKitapAl);
            groupBox3.Controls.Add(btnSil);
            groupBox3.Controls.Add(btnKitapVer);
            groupBox3.Font = new Font("Segoe UI", 11F);
            groupBox3.Location = new Point(275, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(497, 110);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            btnKitapAl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKitapAl.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapAl.ImageKey = "vcsupdaterequired_93493.png";
            btnKitapAl.ImageList = ımageList1;
            btnKitapAl.Location = new Point(348, 34);
            btnKitapAl.Name = "btnKitapAl";
            btnKitapAl.Size = new Size(120, 60);
            btnKitapAl.TabIndex = 2;
            btnKitapAl.Text = "Kitap Al";
            btnKitapAl.TextAlign = ContentAlignment.MiddleRight;
            btnKitapAl.UseVisualStyleBackColor = true;
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
            btnSil.Location = new Point(189, 34);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 60);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapVer
            // 
            btnKitapVer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKitapVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapVer.ImageKey = "gui_save_icon_157040 (1).png";
            btnKitapVer.ImageList = ımageList1;
            btnKitapVer.Location = new Point(36, 34);
            btnKitapVer.Name = "btnKitapVer";
            btnKitapVer.Size = new Size(120, 60);
            btnKitapVer.TabIndex = 0;
            btnKitapVer.Text = "Kitap Ver";
            btnKitapVer.TextAlign = ContentAlignment.MiddleRight;
            btnKitapVer.UseVisualStyleBackColor = true;
            // 
            // gridOduncKitaplar
            // 
            gridOduncKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOduncKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOduncKitaplar.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridOduncKitaplar.Location = new Point(12, 260);
            gridOduncKitaplar.Name = "gridOduncKitaplar";
            gridOduncKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOduncKitaplar.Size = new Size(760, 239);
            gridOduncKitaplar.TabIndex = 3;
            // 
            // formOduncKitap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(gridOduncKitaplar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formOduncKitap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödünç Kitap İşlemleri";
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
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtAciklama;
        private TextBox txtNo;
        private TextBox txtAramaOgrenci;
        private ComboBox comboKitap;
        private Button btnKitapAl;
        private Button btnSil;
        private Button btnKitapVer;
        private ImageList ımageList1;
        private DataGridView gridOduncKitaplar;
    }
}
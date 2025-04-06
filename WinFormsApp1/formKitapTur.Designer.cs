namespace WinFormsApp1
{
    partial class formKitapTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKitapTur));
            groupBox1 = new GroupBox();
            txtTurAdi = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGuncelle = new Button();
            ımageList1 = new ImageList(components);
            btnSil = new Button();
            btnKaydet = new Button();
            gridKitapTur = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridKitapTur).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTurAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi Girişi";
            // 
            // txtTurAdi
            // 
            txtTurAdi.Location = new Point(106, 45);
            txtTurAdi.Name = "txtTurAdi";
            txtTurAdi.Size = new Size(168, 27);
            txtTurAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Tür Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(13, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 107);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageKey = "vcsupdaterequired_93493.png";
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(273, 31);
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
            btnSil.Location = new Point(144, 31);
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
            btnKaydet.Location = new Point(14, 31);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 60);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // gridKitapTur
            // 
            gridKitapTur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridKitapTur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridKitapTur.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridKitapTur.Location = new Point(11, 245);
            gridKitapTur.Name = "gridKitapTur";
            gridKitapTur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridKitapTur.Size = new Size(411, 188);
            gridKitapTur.TabIndex = 2;
            gridKitapTur.CellClick += gridKitapTur_CellClick;
            // 
            // formKitapTur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 446);
            Controls.Add(gridKitapTur);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formKitapTur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Tür İşlemleri";
            Load += formKitapTur_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridKitapTur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTurAdi;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private DataGridView gridKitapTur;
        private ImageList ımageList1;
    }
}
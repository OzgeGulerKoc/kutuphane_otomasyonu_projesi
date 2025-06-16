namespace kutuphane
{
    partial class formAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAnaSayfa));
            btnKitap = new Button();
            ımageList1 = new ImageList(components);
            btnOgrenci = new Button();
            btnTur = new Button();
            btnOdunc = new Button();
            SuspendLayout();
            // 
            // btnKitap
            // 
            btnKitap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKitap.ImageKey = "research_books_22128.png";
            btnKitap.ImageList = ımageList1;
            btnKitap.Location = new Point(123, 96);
            btnKitap.Name = "btnKitap";
            btnKitap.Size = new Size(260, 140);
            btnKitap.TabIndex = 0;
            btnKitap.Text = "Kitap İşlemleri";
            btnKitap.TextAlign = ContentAlignment.BottomCenter;
            btnKitap.UseVisualStyleBackColor = true;
            btnKitap.Click += btnKitap_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "lightbrown_books_folders_12307.png");
            ımageList1.Images.SetKeyName(1, "lightbrown_library_folder_12274.png");
            ımageList1.Images.SetKeyName(2, "research_books_22128.png");
            ımageList1.Images.SetKeyName(3, "user_kids_avatar_user_profile_icon_149314.png");
            // 
            // btnOgrenci
            // 
            btnOgrenci.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOgrenci.ImageKey = "user_kids_avatar_user_profile_icon_149314.png";
            btnOgrenci.ImageList = ımageList1;
            btnOgrenci.Location = new Point(465, 96);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(260, 140);
            btnOgrenci.TabIndex = 1;
            btnOgrenci.Text = "Öğrenci işlemleri";
            btnOgrenci.TextAlign = ContentAlignment.BottomCenter;
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnTur
            // 
            btnTur.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTur.ImageKey = "lightbrown_books_folders_12307.png";
            btnTur.ImageList = ımageList1;
            btnTur.Location = new Point(123, 286);
            btnTur.Name = "btnTur";
            btnTur.Size = new Size(260, 140);
            btnTur.TabIndex = 2;
            btnTur.Text = "Tür İşlemleri";
            btnTur.TextAlign = ContentAlignment.BottomCenter;
            btnTur.UseVisualStyleBackColor = true;
            btnTur.Click += btnTur_Click;
            // 
            // btnOdunc
            // 
            btnOdunc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOdunc.ImageKey = "lightbrown_library_folder_12274.png";
            btnOdunc.ImageList = ımageList1;
            btnOdunc.Location = new Point(465, 286);
            btnOdunc.Name = "btnOdunc";
            btnOdunc.Size = new Size(260, 140);
            btnOdunc.TabIndex = 3;
            btnOdunc.Text = "Ödünç Alma İşlemleri";
            btnOdunc.TextAlign = ContentAlignment.BottomCenter;
            btnOdunc.UseVisualStyleBackColor = true;
            btnOdunc.Click += btnOdunc_Click;
            // 
            // formAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 576);
            Controls.Add(btnOdunc);
            Controls.Add(btnTur);
            Controls.Add(btnOgrenci);
            Controls.Add(btnKitap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Projesi";
            FormClosing += formAnaSayfa_FormClosing;
            Load += formAnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKitap;
        private Button btnOgrenci;
        private Button btnTur;
        private Button btnOdunc;
        private ImageList ımageList1;
    }
}

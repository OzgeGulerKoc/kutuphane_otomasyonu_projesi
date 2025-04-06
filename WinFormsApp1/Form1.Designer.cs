namespace WinFormsApp1
{
    partial class formAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAnasayfa));
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
            btnKitap.Location = new Point(101, 67);
            btnKitap.Margin = new Padding(3, 4, 3, 4);
            btnKitap.Name = "btnKitap";
            btnKitap.Size = new Size(258, 143);
            btnKitap.TabIndex = 1;
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
            ımageList1.Images.SetKeyName(0, "books_library_1768.png");
            ımageList1.Images.SetKeyName(1, "research_books_22128.png");
            ımageList1.Images.SetKeyName(2, "user_kids_avatar_user_profile_icon_149314.png");
            ımageList1.Images.SetKeyName(3, "person_user_customer_man_male_man_boy_people_1687.png");
            ımageList1.Images.SetKeyName(4, "User-80_icon-icons.com_57249.png");
            ımageList1.Images.SetKeyName(5, "books_97178.png");
            ımageList1.Images.SetKeyName(6, "reading_books_icon_176864.png");
            ımageList1.Images.SetKeyName(7, "lightbrown_books_folders_12307.png");
            ımageList1.Images.SetKeyName(8, "bookshelf_icon-icons.com_54414 (1).png");
            ımageList1.Images.SetKeyName(9, "lightbrown_library_folder_12274.png");
            // 
            // btnOgrenci
            // 
            btnOgrenci.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOgrenci.ImageKey = "user_kids_avatar_user_profile_icon_149314.png";
            btnOgrenci.ImageList = ımageList1;
            btnOgrenci.Location = new Point(439, 67);
            btnOgrenci.Margin = new Padding(3, 4, 3, 4);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(258, 143);
            btnOgrenci.TabIndex = 2;
            btnOgrenci.Text = "Öğrenci İşlemleri";
            btnOgrenci.TextAlign = ContentAlignment.BottomCenter;
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnTur
            // 
            btnTur.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTur.ImageKey = "lightbrown_books_folders_12307.png";
            btnTur.ImageList = ımageList1;
            btnTur.Location = new Point(101, 282);
            btnTur.Margin = new Padding(3, 4, 3, 4);
            btnTur.Name = "btnTur";
            btnTur.Size = new Size(258, 143);
            btnTur.TabIndex = 3;
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
            btnOdunc.Location = new Point(439, 282);
            btnOdunc.Margin = new Padding(3, 4, 3, 4);
            btnOdunc.Name = "btnOdunc";
            btnOdunc.Size = new Size(258, 143);
            btnOdunc.TabIndex = 4;
            btnOdunc.Text = "Ödünç Alma İşlemleri";
            btnOdunc.TextAlign = ContentAlignment.BottomCenter;
            btnOdunc.UseVisualStyleBackColor = true;
            btnOdunc.Click += btnOdunc_Click;
            // 
            // formAnasayfa
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 575);
            Controls.Add(btnOdunc);
            Controls.Add(btnTur);
            Controls.Add(btnOgrenci);
            Controls.Add(btnKitap);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "formAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Projesi";
            Load += Form1_Load;
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

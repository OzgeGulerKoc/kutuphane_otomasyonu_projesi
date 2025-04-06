using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class formAnasayfa : Form
    {

        public formAnasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur kitapTur = new formKitapTur();
            kitapTur.ShowDialog();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap oduncKitap = new formOduncKitap();
            oduncKitap.ShowDialog();
        }

    }
}

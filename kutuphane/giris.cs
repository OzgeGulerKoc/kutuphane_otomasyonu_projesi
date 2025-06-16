using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        string komutsatiri;

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblDurum.Text = "Lütfen tüm alanları doldurun.";
                return;
            }

            try
            {
                baglanti = vtIslemleri.baglan(); //Veri Tabanı bağlantı nesnesi oluşturulur
                baglanti.Open();
                komutsatiri = "SELECT * FROM kullanicilar WHERE kullanici_adi=@kadi AND sifre=@sifre";

                MySqlCommand cmd = new MySqlCommand(komutsatiri, baglanti);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    baglanti.Close();
                    formAnaSayfa ana = new formAnaSayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    lblDurum.Text = "Kullanıcı adı veya şifre hatalı.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

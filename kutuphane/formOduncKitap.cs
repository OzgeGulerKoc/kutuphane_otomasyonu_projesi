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
    public partial class formOduncKitap : Form
    {
        public formOduncKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            KitapYukle();
            Listele();
        }

        public void KitapYukle()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutsatiri = "Select * From kitaplar where kitap_id not in (select kitap_id from odunc_kitaplar where teslim_tarihi IS NULL)";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                comboKitap.DataSource = dataTable;
                comboKitap.ValueMember = "kitap_id";
                comboKitap.DisplayMember = "kitap_adi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutsatiri = "Select id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama " +
              "From kitaplar, ogrenciler, odunc_kitaplar " +
              "where ogr_no = ogrenci_no and kitaplar.kitap_id = odunc_kitaplar.kitap_id";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridOduncKitaplar.DataSource = dataTable;

                gridOduncKitaplar.Columns["id"].HeaderText = "ID";
                gridOduncKitaplar.Columns["id"].Width = 30;
                gridOduncKitaplar.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridOduncKitaplar.Columns["ogrenci_no"].Width = 40;
                gridOduncKitaplar.Columns["ad"].HeaderText = "Ad";
                gridOduncKitaplar.Columns["ad"].Width = 70;
                gridOduncKitaplar.Columns["soyad"].HeaderText = "Soyad";
                gridOduncKitaplar.Columns["soyad"].Width = 70;
                gridOduncKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                gridOduncKitaplar.Columns["kitap_adi"].Width = 100;
                gridOduncKitaplar.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridOduncKitaplar.Columns["verilis_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                gridOduncKitaplar.Columns["teslim_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["aciklama"].HeaderText = "Açıklama";
                gridOduncKitaplar.Columns["aciklama"].Width = 150;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutsatiri = "insert into odunc_kitaplar (ogr_no,kitap_id,verilis_tarihi,aciklama)" +
                    "values (@ogr_no,@kitap_id,@verilis_tarihi,@aciklama)";

                komut = new MySqlCommand(komutsatiri, baglanti);

                komut.Parameters.AddWithValue("@ogr_no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(comboKitap.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@verilis_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void Temizle()
        {
            txtNo.Clear();
            txtAçıklama.Clear();
        }

        private void gridOduncKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAçıklama.Text = gridOduncKitaplar.CurrentRow.Cells["aciklama"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komutsatiri = "delete from odunc_kitaplar where id=@id";
                komut = new MySqlCommand(komutsatiri, baglanti);

                komut.Parameters.AddWithValue("@id", gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridOduncKitaplar.CurrentRow.Cells["teslim_tarihi"].Value.ToString() != string.Empty)
                {
                    MessageBox.Show("Bu kitap teslim alınmış.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutsatiri = "update odunc_kitaplar set teslim_tarihi=@teslim_tarihi, aciklama=@aciklama where id=@id";
                komut = new MySqlCommand(komutsatiri, baglanti);

                komut.Parameters.AddWithValue("@id", int.Parse(gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString()));
                komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            OduncKitapOgrenciArama(txtAramaOgrenci.Text);
        }

        public void OduncKitapOgrenciArama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutsatiri = "SELECT id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama " +
                              "FROM kitaplar, ogrenciler, odunc_kitaplar " +
                              "WHERE ogr_no=ogrenci_no AND kitaplar.kitap_id=odunc_kitaplar.kitap_id AND ad LIKE '%" + aranacakkelime + "%'";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridOduncKitaplar.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

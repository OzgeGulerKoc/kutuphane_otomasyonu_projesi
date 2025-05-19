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
    public partial class formKitapTur : Form
    {
        public formKitapTur()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        string komutsatiri;
        MySqlCommand komut;


        private void formKitapTur_Load(object sender, EventArgs e)
        {
            TurleriListele();
        }

        public void TurleriListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutsatiri = "select * from kitap_turleri";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridKitapTur.DataSource = dataTable;

                gridKitapTur.Columns["tur_id"].HeaderText = "ID";
                gridKitapTur.Columns["tur_id"].Width = 100;
                gridKitapTur.Columns["tur_adi"].HeaderText = "Tür Adı";
                gridKitapTur.Columns["tur_adi"].Width = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)//bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); //eğer bağlantı açık değilse açılır
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kitap_turleri (tur_adi) values(@tur_adi)";

                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);

                komut.ExecuteNonQuery(); //Ekleme sorgusu çalıştırılır ve hata oluşmazsa kitap türü eklenir
                baglanti.Close(); //Bağlantı kapatılır
                txtTurAdi.Clear();

                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele(); //Eklenen Kitap türlerinin DataGridview'de görülebilmesi için veriler tekrar listelenir

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) //Bağlantı durumu kontrol edilir
                {
                    baglanti.Open(); //Eğer açık değilse bağlantı açılır
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kitap_turleri where tur_id= @tur_id";

                komut.Parameters.AddWithValue("@tur_id", gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString());

                komut.ExecuteNonQuery(); //Sorgu çalıştırılır ve hata oluşmazsa kayıt silinir.
                baglanti.Close(); //Bağlantı kapatılır
                txtTurAdi.Clear();

                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele(); //Silinen kayıtın görünmemesi için tekrar listeleme yapılır

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update kitap_turleri set tur_adi=@tur_adi where tur_id=@tur_id";

                komut.Parameters.AddWithValue("@tur_id", int.Parse(gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                TurleriListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridKitapTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTurAdi.Text = gridKitapTur.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

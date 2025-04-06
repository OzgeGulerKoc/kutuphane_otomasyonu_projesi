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

namespace WinFormsApp1
{
    public partial class formKitapTur : Form
    {
        
        public formKitapTur()
        {
            InitializeComponent();
        }

        private void formKitapTur_Load(object sender, EventArgs e)
        {
            TurleriListele();
        }

        public void TurleriListele()
        {
            try
            {
                string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
                //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.

                MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

                if (baglanti.State != ConnectionState.Open)     //bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); //eğer bağlantı açık değilse açılır
                }

                string sorguCumlesi = "select * from kitap_turleri"; //verileri listeleyecek olan SQL sorgusu yazılır
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sorguCumlesi, baglanti); //dataadapter nesnesi oluşturulur
                DataTable dataTable = new DataTable();  //Verileri tablo hâlinde saklamada kullanılan nesnedir.

                dataadapter.Fill(dataTable); //sorgu sonucunda dönen kayıtlar dataTable nesnesine aktarılır
                gridKitapTur.DataSource = dataTable; //DataTable nesnesindeki kayıtlar datagridView de listelenir.

                gridKitapTur.Columns["tur_id"].HeaderText = "ID"; //DataGridView nesnesinde sütun başlıkları listelenir
                gridKitapTur.Columns["tur_id"].Width = 100; // Sütun genişliği belirlenir

                gridKitapTur.Columns["tur_adi"].HeaderText = "Tür Adı";
                gridKitapTur.Columns["tur_adi"].Width = 100;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
                //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
                MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

                if (baglanti.State != ConnectionState.Open)     //bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); //eğer bağlantı açık değilse açılır
                }

                string komutsatiri = "insert into kitap_turleri (tur_adi) values(@tur_adi)";
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur

                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text); //Sorguda verilen parametrelerin değerleri belirlenir
                komut.ExecuteNonQuery(); //Ekleme sorgusu çalıştırılır ve hata oluşmazsa öğrenci eklenir
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

        private void gridKitapTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridView'de seçili olan Kitap türüne ait bilgiler textBox içine yazdırılır
                txtTurAdi.Text = gridKitapTur.CurrentRow.Cells["tur_adi"].Value.ToString();
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
                string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
                //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
                MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

                if (baglanti.State != ConnectionState.Open) //Bağlantı durumu kontrol edilir
                {
                    baglanti.Open(); //Eğer açık değilse bağlantı açılır
                }

                string komutsatiri = "delete from kitap_turleri where tur_id= @tur_id"; //@tur_id yerine parametre gelecektir.
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur

                komut.Parameters.AddWithValue("@tur_id", gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString());
                //Üst satırda sorguya parametre olarak DataGridView'de seçili olan tur_id bilgisi gönderilir.

                komut.ExecuteNonQuery(); //Sorgu çalıştırılır ve hata oluşmazsa öğrenci silinir.
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
                string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
                //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
                MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

                if (baglanti.State != ConnectionState.Open) //Bağlantı durumu kontrol edilir
                {
                    baglanti.Open(); //Eğer açık değilse bağlantı açılır
                }

                string komutsatiri = "update kitap_turleri set tur_adi=@tur_adi where tur_id=@tur_id"; //@tur_id yerine parametre gelecektir.
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur

                komut.Parameters.AddWithValue("@tur_id", int.Parse(gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString()));
                //Üst satırda sorguya parametre olarak DataGridView'de seçili olan tur_id bilgisi gönderilir.
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
    }
}

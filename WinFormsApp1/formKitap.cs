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
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }


        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();
        }

        public void KitapTurYukle()
        {
            string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
            //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
            MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

            try
            {
                string sorguCumlesi = "select * from kitap_turleri"; //verileri listeleyecek olan SQL sorgusu yazılır
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sorguCumlesi, baglanti); //dataadapter nesnesi oluşturulur
                DataTable dataTable = new DataTable();  //Verileri tablo hâlinde saklamada kullanılan nesnedir.

                dataadapter.Fill(dataTable); //sorgu sonucunda dönen kayıtlar dataTable nesnesine aktarılır
                comboKitapTur.DataSource = dataTable; //ComboBox nesnesinin veri kaynağı ayarlanır.
                comboKitapTur.ValueMember = "tur_id"; //Arka planda tutulup veri tabanına kaydedilecek alan belirlenir.
                comboKitapTur.DisplayMember = "tur_adi"; //Kullanıcıya gösterilecek alan belirlenir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KitapListele()
        {
            string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
            //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
            MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

            try
            {
                string komutsatiri = "select kitap_id,tur_adi,kitap_adi,yazar,yayinevi,sayfa_sayisi from kitaplar,kitap_turleri where kitaplar.tur_id=kitap_turleri.tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitap.DataSource = dataTable;

                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 30;
                gridKitap.Columns["kitap_adi"].HeaderText = "Adı";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 80;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayınevi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
                //MySQL veri tabanına bağlanmak için gerekli olan bağlantı cümlesidir.
                MySqlConnection baglanti = new MySqlConnection(baglanticumlesi); //Veri Tabanı bağlantısı oluşturuldu

                if (baglanti.State != ConnectionState.Open)//bağlantının durumu kontrol edilir
                {
                    baglanti.Open(); //eğer bağlantı açık değilse açılır
                }

                string komutsatiri = "insert into kitaplar (tur_id,kitap_adi,yazar,yayinevi,sayfa_sayisi)" +
                    "values (@tur_id,@kitap_adi,@yazar,@yayinevi,@sayfa_sayisi)";
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur
                //alttaki satırda Combobox nesnesinin arka planda tuttuğu id değeri tur_id olarak kayıt edilir.

                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle()
        {
            txtKitapAdi.Clear();
            txtSayfaSayisi.Clear();
            txtYayinEvi.Clear();
            txtYazar.Clear();
        }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridView'de seçili olan Kitaba ait bilgiler boş kutular içine yazdırılır                
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfaSayisi.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinEvi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();

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

                string komutsatiri = "delete from kitaplar where kitap_id= @kitap_id"; //@kitap_id yerine parametre gelecektir.
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur

                komut.Parameters.AddWithValue("@kitap_id", gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                //Üst satırda sorguya parametre olarak DataGridView'de seçili olan kitap_id bilgisi gönderilir.

                komut.ExecuteNonQuery(); //Sorgu çalıştırılır ve hata oluşmazsa öğrenci silinir.
                baglanti.Close(); //Bağlantı kapatılır
                Temizle();

                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele(); //Silinen kayıtın görünmemesi için tekrar listeleme yapılır

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
                //string komutsatiri = "update kitap_turleri set tur_adi=@tur_adi where tur_id=@tur_id";
                string komutsatiri = "update kitaplar set tur_id=@tur_id,kitap_adi=@kitap_adi," +
                    "yazar=@yazar,yayinevi=@yayinevi,sayfa_sayisi=@sayfa_sayisi where kitap_id=@kitap_id";
                MySqlCommand komut = new MySqlCommand(komutsatiri, baglanti); //komut çalıştırmak için MYsSqlCommand nesnesi oluşturulur

                komut.Parameters.AddWithValue("@kitap_id", int.Parse(gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapArama(txtKitapAra.Text);
        }


        public void KitapArama(string aranacakKelime)
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

                string komutsatiri = "select kitap_id,tur_adi,kitap_adi,yazar,yayinevi,sayfa_sayisi from kitaplar,kitap_turleri" +
                    "where kitaplar.tur_id=kitap_turleri.tur_id and kitap_adi like'" + aranacakKelime + "%'";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(komutsatiri, baglanti); //dataadapter nesnesi oluşturulur
                DataTable dataTable = new DataTable();  //Verileri tablo hâlinde saklamada kullanılan nesnedir.
                dataadapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


       

        //kod satırı sonu
    }
}

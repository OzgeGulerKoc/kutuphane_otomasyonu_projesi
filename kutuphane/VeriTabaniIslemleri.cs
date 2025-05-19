using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane
{
     internal class VeriTabaniIslemleri
    {
        public MySqlConnection baglan()
        {
            string baglanticumlesi = "Server=localhost;Database=kutuphane;Uid=root;Pwd=12345678";
            MySqlConnection baglanti = new MySqlConnection(baglanticumlesi);
            MySqlConnection.ClearPool(baglanti);
            return baglanti;

        }

    }
}

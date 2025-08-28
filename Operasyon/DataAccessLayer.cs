using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukDatalarIleCalismak.Operasyon
{
    public class DataAccessLayer : Base.Yardim
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            con = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS01;Initial Catalog=BuyukDatalarIleCalismak;Integrated Security=True;");


        }

        public void BaglantiAyarla()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }

        }

        public int KayitEKLE(Entities.Kisi Kisi)
        {
            int returnValue = 0;
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("KisiEkle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // Burada bunun bir stored procedure olduğunu belirtiyoruz.
                cmd.Parameters.Add("@Isim", System.Data.SqlDbType.NVarChar).Value = Kisi.Isim;
                cmd.Parameters.Add("@SoyIsim", System.Data.SqlDbType.NVarChar).Value = Kisi.Soyisim;
                cmd.Parameters.Add("@EmailAdres", System.Data.SqlDbType.NVarChar).Value = Kisi.EmailAdres;
                cmd.Parameters.Add("@TelefonNumarasi", System.Data.SqlDbType.NVarChar).Value = Kisi.Tel;
                cmd.Parameters.Add("@Resim", System.Data.SqlDbType.VarBinary).Value = Kisi.Resim;
                BaglantiAyarla();
                returnValue = cmd.ExecuteNonQuery();
                BaglantiAyarla();
            });
            return returnValue;
        }

        public SqlDataReader KisiDetayGetir(int ID) // Yularıdaki katmanlardan gelen ID değeri için parametre olarak İnteger türünde bir ID alır.
                                                    //Parametre kullanımı, ****SQL ENJEKSİYONU*** gibi GÜVENLİK AÇIKLARININ önlenmesine yardımcı olur .

        {
            TryCatchKullan(() => { 
            cmd = new SqlCommand("select * from Kisiler Where Id = @Id", con); //Bu SQL sorgusu çalıştırılırken, @Id parametresi, DataAccessLayer metoduna iletilen
                                                                               //(ve dolayısıyla combobox'tan köken alan) id değeri ile eşlenir.
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KisilerListe()
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("Select * from Kisiler", con);
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

    }
}

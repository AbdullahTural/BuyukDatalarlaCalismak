using BuyukDatalarIleCalismak.Entities;
using BuyukDatalarIleCalismak.Operasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyukDatalarIleCalismak
{
    public partial class Form1 : Form
    {  
        Image Img;
        BusinessLogicLayer Bll;
        public Form1()
        {
            InitializeComponent();
            Bll = new BusinessLogicLayer();
            List<Entities.Kisi> kisiler =  Bll.KisilerListe();
            cmb_kisi_listesi.DataSource = kisiler;
        }

        private void btn_resim_ekle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog(); // OpenfileDialog Gösterilecek
            Img = Image.FromFile(OFD.FileName);
            pic_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_resim.Image = Img;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(); //MemoryStream, btn_Kaydet_Click olayında kullanıcının seçtiği resim dosyasını, veritabanında VarBinary tipinde saklanabilecek bir bayt dizisi formatına dönüştürmek için bir aracı olarak kullanılır.
            Img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            int returnvalue = Bll.KisiEkle(txt_isim.Text, txt_soyisim.Text, txt_Eposta.Text, txt_telefon.Text, mem.ToArray());
            if (returnvalue > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void cmb_kisi_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi K =  (Kisi)((ComboBox)sender).SelectedItem;
            Bll.KisiDetayGetir(K.ID); // Bu olay işleyicisinde, K.ID ifadesiyle, seçilen öğenin (yani Kisi nesnesinin) ID özelliği alınır.
                                      // Bu ID, kullanıcının combobox'ta seçtiği kişinin benzersiz kimlik numarasıdır.
                                      //Elde edilen bu K.ID değeri, Bll.KisiDetayGetir(K.ID) çağrısı ile BusinessLogicLayer
                                      //katmanındaki KisiDetayGetir metoduna bir parametre olarak iletilir.
            txt_dg_isim.Text = K.Isim;
            txt_dg_soyisim.Text = K.Soyisim;
            txt_dg_telefon.Text = K.Tel;
            txt_dg_Eposta.Text = K.EmailAdres;

            MemoryStream mem = new MemoryStream(K.Resim);
            Image Img = Image.FromStream(mem);
            pic_dg_resim.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_dg_resim.Image = Img;
        }
    }
}

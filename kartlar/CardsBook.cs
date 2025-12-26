using DataBaseLibrary.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using DataBaseLibrary.VeriErisim;
using LİBRARYPROJECT.deising;
namespace LİBRARYPROJECT.uye_menu_pages
{
    public partial class CardsBook : UserControl
    {

        private Kitap _mevcutKitap;
        public CardsBook()
        {
            Tool tasarlayıcı = new Tool();
            InitializeComponent();
            this.BackColor = Renkler.Koyu1;
            label1.ForeColor = Renkler.Yazi;
            label2.ForeColor = Renkler.YaziSoluk;
            label3.ForeColor = Renkler.YaziSoluk;
            label4.ForeColor = Renkler.YaziSoluk;
            tasarlayıcı.ButonAyarla(button1);
            button1.BackColor = Renkler.Koyu2;
        }
        public async void VerileriDoldur(Kitap gelenKitap)
        {
            _mevcutKitap = gelenKitap;

            label1.Text = gelenKitap.KitapAdi;
            label2.Text = gelenKitap.Yazar;
            label3.Text = gelenKitap.Tur;

            if (gelenKitap.Stok > 0)
            {
                label4.Text = "Stok: " + gelenKitap.Stok;
                label4.ForeColor = Color.Green;
                button1.Enabled = true; 
            }
            else
            {
                label4.Text = "TÜKENDİ";
                label4.ForeColor = Color.Red;
                button1.Enabled = false; 
            }

            
            pictureBox1.Image = null;

            // Link dolu mu ve http ile başlıyor mu?
            if (!string.IsNullOrEmpty(gelenKitap.KapakResmi) && gelenKitap.KapakResmi.StartsWith("http"))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                        var resimVerisi = await client.GetByteArrayAsync(gelenKitap.KapakResmi);

                        using (var stream = new MemoryStream(resimVerisi))
                        {
                            pictureBox1.Image = new Bitmap(stream);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch
                {
                    pictureBox1.BackColor = Color.LightGray;
                }
            }
            else
            {
                pictureBox1.BackColor = Color.LightGray;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string alanKisi = UyeDb.Oturum.AktifUye.KullaniciAdi;
            string alinanKitap = _mevcutKitap.KitapAdi;
            OduncDb oduncDb = new OduncDb();

            bool StokKontrol = oduncDb.DahaOnceAlmisMi(alanKisi, alinanKitap);

            if (StokKontrol)
            {
                MessageBox.Show($"'{alinanKitap}' kitabını zaten daha önce almışsınız. Aynı kitabı tekrar alamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mevcutKitap.Stok <= 0)
            {
                MessageBox.Show("Üzgünüz, bu kitap az önce tükendi.");
                button1.Enabled = false;
                label4.Text = "TÜKENDİ";
                label4.ForeColor = Color.Red;
                return;
            }

            _mevcutKitap.Stok--;

            KitapDb kitapDb = new KitapDb();
            kitapDb.Guncelle(_mevcutKitap);

            oduncDb.BasitKayit(alinanKitap, alanKisi);

            MessageBox.Show($"'{alinanKitap}' kitabı, Sayın {alanKisi} üzerine başarıyla kaydedildi.");


            label4.Text = "Stok: " + _mevcutKitap.Stok;

            if (_mevcutKitap.Stok <= 0)
            {
                label4.Text = "TÜKENDİ";
                label4.ForeColor = Color.Red;
                button1.Enabled = false;
                button1.Text = "TÜKENDİ";
            }
        }
        

    }
}

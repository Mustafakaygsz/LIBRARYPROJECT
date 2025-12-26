using DataBaseLibrary.Modeller;
using DataBaseLibrary.VeriErisim;
using LİBRARYPROJECT.deising;


namespace LİBRARYPROJECT.uye_menu_pages
{
    public partial class Iade_islem : UserControl
    {
        public Iade_islem()
        {

            InitializeComponent();

            Tool iade = new Tool();
            this.BackColor = Renkler.Koyu3;
            iade.KutuAyarla(textBox1);
            iade.ButonAyarla(button1);
            iade.ButonAyarla(button2);
            button2.BackColor = Renkler.Koyu2;
            button1.BackColor = Renkler.Koyu2;
            iade.ListboxAyarla(listBox1);
            listBox1.Items.Clear();
            iade.KutuAyarla(textBox1);
            textBox1.BackColor = Renkler.Koyu2  ;


        }
        private void button2_Click(object sender, EventArgs e)
        {


            string oturum = UyeDb.Oturum.AktifUye.KullaniciAdi;
            OduncDb yonetici1 = new OduncDb();

            var kitaplar = yonetici1.KullaniciyaGoreGetir(oturum);

            listBox1.Items.Add("Ödünç Aldığınız kitaplar\n");
            foreach (var kayit in kitaplar)
            {

                listBox1.Items.Add(kayit.KitapAdi);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string girilenKitapAdi = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(girilenKitapAdi))
            {
                MessageBox.Show("Lütfen iade edilecek kitap adını giriniz.");
                return;
            }

            OduncDb oduncYonetici = new OduncDb();


            bool iadeBasarili = oduncYonetici.KitapIadeEt(girilenKitapAdi);

            if (iadeBasarili)
            {


                KitapDb kitapYonetici = new KitapDb();


                Kitap iadeEdilenKitap = kitapYonetici.IsmeGoreGetir(girilenKitapAdi);

                if (iadeEdilenKitap != null)
                {
                    iadeEdilenKitap.Stok++;
                    kitapYonetici.Guncelle(iadeEdilenKitap);
                }

                MessageBox.Show($"'{girilenKitapAdi}' kitabı başarıyla iade alındı ve stok güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                listBox1.Items.Clear();

            }
            else
            {
                MessageBox.Show("Bu kitap ödünç listenizde bulunamadı! İsmi doğru yazdığınızdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        
    }
}

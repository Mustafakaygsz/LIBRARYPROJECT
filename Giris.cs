using DataBaseLibrary.Modeller;
using DataBaseLibrary.VeriErisim;
using DataBaseLibrary.Servisler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using LİBRARYPROJECT.deising;

namespace LİBRARYPROJECT
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }



      

        private void button1_Click(object sender, EventArgs e)
        {

            string kadi = textBox1.Text;
            string sifre = textBox2.Text;




            GirisYoneticisi yonetici = new GirisYoneticisi();
            Uye girisYapanUye = yonetici.GirisKontroluYap(kadi, sifre);


            if (girisYapanUye != null)
            {

                UyeDb.Oturum.AktifUye = girisYapanUye;

                MessageBox.Show($"Giriş Başarılı! Hoşgeldin: {girisYapanUye.KullaniciAdi}");


                if (girisYapanUye.YoneticiMi == true)
                {

                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else
                {

                    UyeAnaEkranı uyeForm = new UyeAnaEkranı();
                    uyeForm.Show();


                }


                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeKayit uye_kaydetme = new UyeKayit();
            uye_kaydetme.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Tool giris = new Tool();
            this.BackColor = Renkler.Koyu5;
            panel1.BackColor = Renkler.Koyu4;
            giris.Labelayarla(label1);
            giris.Labelayarla(label2);
            giris.Labelayarla(label3);
            giris.Labelayarla(label4);
            giris.Labelayarla(label5);
            giris.KutuAyarla(textBox1);
            giris.KutuAyarla(textBox2);
            textBox1.BackColor = Renkler.Koyu5;
            textBox2.BackColor = Renkler.Koyu5;
            giris.ButonAyarla(button1);
            button1.BackColor = Color.DodgerBlue;
            giris.ButonAyarla(button2);
            button2.BackColor = Renkler.Koyu5;
        }





        private void button1_Click_1(object sender, EventArgs e)
        {

            string kadi = textBox1.Text;
            string sifre = textBox2.Text;




            GirisYoneticisi yonetici = new GirisYoneticisi();
            Uye girisYapanUye = yonetici.GirisKontroluYap(kadi, sifre);


            if (girisYapanUye != null)
            {

                UyeDb.Oturum.AktifUye = girisYapanUye;

                MessageBox.Show($"Giriş Başarılı! Hoşgeldin: {girisYapanUye.KullaniciAdi}");

                if (girisYapanUye.YoneticiMi == true)
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    UyeAnaEkranı uyeForm = new UyeAnaEkranı();
                    uyeForm.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SİfreYenile yenileme = new SİfreYenile();
            yenileme.Show();
            this.Hide();
        }
    }
}

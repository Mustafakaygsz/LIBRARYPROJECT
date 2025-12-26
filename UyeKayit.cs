using DataBaseLibrary.Modeller;
using DataBaseLibrary.Servisler;
using DataBaseLibrary.VeriErisim;
using LİBRARYPROJECT.deising;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LİBRARYPROJECT
{

    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris girise_git = new Giris();
            girise_git.Show();
            this.Hide();
        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {
            Tool giris = new Tool();
            this.BackColor = Renkler.Koyu5;
            panel1.BackColor = Renkler.Koyu4;
            giris.Labelayarla(label1);
            giris.Labelayarla(label2);
            giris.Labelayarla(label3);
            giris.Labelayarla(label4);
            giris.Labelayarla(label5);
            giris.Labelayarla(label6);
            giris.Labelayarla(label7);
            giris.KutuAyarla(textBox1);
            giris.KutuAyarla(textBox2);
            giris.KutuAyarla(textBox3);
            giris.KutuAyarla(textBox4);
            textBox1.BackColor = Renkler.Koyu5;
            textBox2.BackColor = Renkler.Koyu5;
            textBox3.BackColor = Renkler.Koyu5;
            textBox4.BackColor = Renkler.Koyu5;
            giris.ButonAyarla(button1);
            button1.BackColor = Color.DodgerBlue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UyeDb veritabani = new UyeDb();
            DataBaseLibrary.Modeller.Uye yeniUye = new DataBaseLibrary.Modeller.Uye();
            try
            {
                yeniUye.KullaniciAdi = textBox1.Text;
                yeniUye.Email = textBox2.Text;
                yeniUye.TelNo = textBox4.Text;
                yeniUye.Sifre = textBox3.Text;

                MessageBox.Show("üye başarıyla kaydedildi: ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                veritabani.Ekle(yeniUye);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

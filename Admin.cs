using DataBaseLibrary.VeriErisim;
using LİBRARYPROJECT.admin_menu_pages.menu_pages;
using LİBRARYPROJECT.deising;
using LİBRARYPROJECT.uye_menu_pages;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            string girenKisi = UyeDb.Oturum.AktifUye.KullaniciAdi;
            label2.Text = girenKisi;
            Tool tasarlayıcı = new Tool();

            panel2.BackColor = Renkler.Koyu4;
            panel1.BackColor = Renkler.Koyu5;
            panel3.BackColor = Renkler.Koyu3;

            label1.ForeColor = Renkler.Yazi;
            label2.ForeColor = Renkler.YaziSoluk;
            label3.ForeColor = Renkler.YaziSoluk;

            tasarlayıcı.ButonAyarla(button2);
            tasarlayıcı.ButonAyarla(button4);
            tasarlayıcı.ButonAyarla(button1);
            tasarlayıcı.ButonAyarla(button3);

            button1.BackColor = Renkler.Koyu5;
            button2.BackColor = Renkler.Koyu5;
            button3.BackColor= Renkler.Koyu5;
            button4.BackColor = Renkler.Koyu5;
        }
        private void YeniSayfaYukle(UserControl userControl)
        {

            this.panel3.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(userControl);

            userControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_takip calismasalon = new admin_takip();
            YeniSayfaYukle(calismasalon);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris girise_don = new Giris();
            girise_don.Show();
            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Kitap_islem kitap = new Kitap_islem();
            YeniSayfaYukle(kitap);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitap_ekleme Kitap_ekle = new Kitap_ekleme();
            YeniSayfaYukle(Kitap_ekle);
        }
    }
}

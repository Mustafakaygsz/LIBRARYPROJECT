using DataBaseLibrary.Modeller;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LİBRARYPROJECT
{
    public partial class UyeAnaEkranı : Form
    {
        public UyeAnaEkranı()
        {
            InitializeComponent();
        }

        private void UyeAnaEkranı_Load(object sender, EventArgs e)
        {
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
            button3.BackColor = Renkler.Koyu5;
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
            Page_tablo TabloSayfası = new Page_tablo();
            YeniSayfaYukle(TabloSayfası);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calisma_salonu calismasalon = new calisma_salonu();
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
            Iade_islem iadeEkrani = new Iade_islem();
            YeniSayfaYukle(iadeEkrani);
        }
    }

}

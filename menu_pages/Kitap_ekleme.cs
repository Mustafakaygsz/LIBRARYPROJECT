using DataBaseLibrary.Modeller;
using DataBaseLibrary.VeriErisim;
using DataBaseLibrary.Servisler;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LİBRARYPROJECT.deising;

namespace LİBRARYPROJECT.admin_menu_pages.menu_pages
{
    public partial class Kitap_ekleme : UserControl
    {
        public Kitap_ekleme()
        {
            InitializeComponent();
            panel1.BackColor = Renkler.Koyu2;
            Tool ekle = new Tool();

            ekle.Labelayarla(label1);
            ekle.Labelayarla(label2);
            ekle.Labelayarla(label3);
            ekle.Labelayarla(label4);
            ekle.Labelayarla(label5);
            ekle.Labelayarla(label6);
            ekle.Labelayarla(label7);

            ekle.KutuAyarla(textBox1);
            ekle.KutuAyarla(textBox2);
            ekle.KutuAyarla(textBox3);
            ekle.KutuAyarla(textBox4);
            ekle.KutuAyarla(textBox5);

            textBox1.BackColor = Renkler.Koyu3;
            textBox2.BackColor = Renkler.Koyu3;
            textBox3.BackColor = Renkler.Koyu3;
            textBox4.BackColor = Renkler.Koyu3;
            textBox5.BackColor = Renkler.Koyu3;
            ekle.ButonAyarla(button2);
            button2.BackColor = Color.DodgerBlue;

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            KitapDb veritabani = new KitapDb();

            Kitap yeniKitap = new Kitap()
            {
                KitapAdi = textBox1.Text,
                Yazar = textBox2.Text,
                Tur = textBox3.Text,
                KapakResmi = textBox4.Text,
                Stok = int.Parse(textBox5.Text),

            };

            veritabani.Ekle(yeniKitap);

            MessageBox.Show("Yeni Kitap başarıyla eklendi!");

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }
        

        
    }
}

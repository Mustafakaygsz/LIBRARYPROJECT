using DataBaseLibrary.Modeller;
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
using static LİBRARYPROJECT.deising.Tool;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LİBRARYPROJECT.uye_menu_pages
{
    public partial class Page_tablo : UserControl
    {
        public Page_tablo()
        {
            InitializeComponent();
            Tool tasarlayıcı = new Tool();
            panel2.BackColor = Renkler.Koyu3;
            flowLayoutPanel1.BackColor = Renkler.Koyu2;
            tasarlayıcı.ButonAyarla(button11);
          
            button11.BackColor = Renkler.Koyu4;
            
            tasarlayıcı.KutuAyarla(textBox1);
            textBox1.BackColor=Renkler.Koyu4;
            Araclar arac = new Araclar();
            arac.PanelScrollbarKarart(flowLayoutPanel1);
        }
        private void button11_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();

            string aranan = textBox1.Text.Trim();
            KitapDb db = new KitapDb();
            List<Kitap> sonucListesi;

            if (string.IsNullOrEmpty(aranan))
            {
                sonucListesi = db.TumunuGetir();
            }
            else
            {
                sonucListesi = db.AramaYap(aranan);
            }

            if (sonucListesi.Count == 0)
            {
                MessageBox.Show("Aradığınız kriterlere uygun kitap bulunamadı.");
                return;
            }

            foreach (Kitap k in sonucListesi)
            {
                CardsBook book = new CardsBook();

                book.Margin = new Padding(8);

                book.VerileriDoldur(k);
                flowLayoutPanel1.Controls.Add(book);
            }
        }
    }
}

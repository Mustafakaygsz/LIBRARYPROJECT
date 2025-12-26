
using DataBaseLibrary.Servisler;
using LİBRARYPROJECT.deising;
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

namespace LİBRARYPROJECT.admin_menu_pages.menu_pages
{
    public partial class Kitap_islem : UserControl
    {

        public Kitap_islem()
        {
            InitializeComponent();
            Tool duzenle = new Tool();
            duzenle.ListboxAyarla(listBox1);
            duzenle.Labelayarla(label2);
            duzenle.ButonAyarla(button2);
            button2.BackColor = Color.DodgerBlue;
            Araclar arac = new Araclar();
            arac.PanelScrollbarKarart(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilendb = string.Empty;
            if (radioButton1.Checked)
            {

                Yazdirma yazdirici = new Yazdirma();

                List<string> veriListesi = yazdirici.ListeHazirla("db1");

                listBox1.Items.Clear();

                foreach (string satir in veriListesi)
                {
                    listBox1.Items.Add(satir);
                }

            }
            if (radioButton2.Checked)
            {
                Yazdirma yazdirici = new Yazdirma();

                List<string> veriListesi = yazdirici.ListeHazirla("db2");

                listBox1.Items.Clear();

                foreach (string satir in veriListesi)
                {
                    listBox1.Items.Add(satir);
                }
            }
            if (radioButton3.Checked)
            {
                Yazdirma yazdirici = new Yazdirma();
                List<string> veriListesi = yazdirici.ListeHazirla("db3");
                listBox1.Items.Clear();
                foreach (string satir in veriListesi)
                {
                    listBox1.Items.Add(satir);
                }
            }


        }
      


    }
}

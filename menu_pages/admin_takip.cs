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

namespace LİBRARYPROJECT.uye_menu_pages
{
    public partial class admin_takip : UserControl
    {
        MasaYoneticisi yonetici = new MasaYoneticisi();
        public admin_takip()
        {
            InitializeComponent();
            ResimleriGuncelle();
            foreach (Control arac1 in panel1.Controls)
            {
                if (arac1 is RadioButton rb)
                {
                    rb.CheckedChanged += (sender, e) =>
                    {

                        if (rb.Checked)
                        {
                            int masaNo = int.Parse(rb.Name.Replace("radioButton", ""));
                            var secilenMasa = yonetici.MasalarListesi.FirstOrDefault(m => m.No == masaNo);

                            if (secilenMasa != null)
                            {
                                if (secilenMasa.DoluMu)
                                {
                                    label2.Text = "DOLU";
                                    label2.ForeColor = Color.Red;
                                }
                                else
                                {
                                    label2.Text = "BOŞ";
                                    label2.ForeColor = Color.Green;
                                }
                            }
                        }
                    };
                }
            }
            Tool buton_ayar = new Tool();
            buton_ayar.ButonAyarla(button1);
            buton_ayar.Labelayarla(label1);
            button1.BackColor = Renkler.Koyu3;

            this.BackColor = Renkler.Koyu2;
            panel1.BackColor = Renkler.Koyu1;

            Araclar arac = new Araclar();

            arac.PanelScrollbarKarart(panel1);

            yonetici.SecimEtiketiniBagla(panel1, label3);
            this.BackColor = Renkler.Koyu2;
            this.panel1.BackColor = Renkler.Koyu1;
        }
        private void ResimleriGuncelle()
        {
            foreach (var masa in yonetici.MasalarListesi)
            {
                string arananIsim = "pictureBox" + masa.No;

                Control[] bulunanlar = this.Controls.Find(arananIsim, true);

                if (bulunanlar.Length > 0 && bulunanlar[0] is PictureBox kutu)
                {
                    kutu.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (masa.DoluMu)
                    {
                        kutu.Image = Properties.Resources.red;
                    }
                    else
                    {
                        kutu.Image = Properties.Resources.green;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control arac in panel1.Controls)
            {
                if (arac is RadioButton rb && rb.Checked)
                {
                    int masaNo = int.Parse(rb.Name.Replace("radioButton", ""));

                    string sonuc = yonetici.MasaIptalEt(masaNo);

                    if (sonuc == "OK")
                    {
                        ResimleriGuncelle();
                        MessageBox.Show("Masa " + masaNo + " rezervasyonu iptal edildi (Boşaltıldı).");
                    }
                    else
                    {
                        MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
            }
            MessageBox.Show("Lütfen iptal edilecek masayı seçiniz!");
        }
       
    }
}


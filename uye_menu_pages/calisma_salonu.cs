using LİBRARYPROJECT.deising;
using static LİBRARYPROJECT.deising.Tool;



namespace LİBRARYPROJECT.admin_menu_pages.menu_pages
{
    public partial class calisma_salonu : UserControl
    {
        MasaYoneticisi yonetici = new MasaYoneticisi();

        public calisma_salonu()
        {
            InitializeComponent();

            
            Tool buton_ayar = new Tool();
            buton_ayar.ButonAyarla(button1);
            button1.BackColor = Renkler.Koyu3;
            this.BackColor = Renkler.Koyu2;
            panel1.BackColor = Renkler.Koyu1;

            Araclar arac = new Araclar();
            arac.PanelScrollbarKarart(panel1);

            yonetici.SecimEtiketiniBagla(panel1, label3);

            
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
            ResimleriGuncelle();
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
                        kutu.Image = Properties.Resources.red;
                    else
                        kutu.Image = Properties.Resources.green;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control arac in panel1.Controls)
            {
                if (arac is RadioButton rb && rb.Checked)
                {
                    int masaNo = int.Parse(rb.Name.Replace("radioButton", ""));

                    string sonuc = yonetici.MasaRezerveEt(masaNo);

                    if (sonuc == "OK")
                    {
                        ResimleriGuncelle();
                        label2.Text = "DOLU";
                        label2.ForeColor = Color.Red;

                        MessageBox.Show("Masa " + masaNo + " başarıyla rezerve edildi.");
                    }
                    else
                    {
                        MessageBox.Show(sonuc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
            MessageBox.Show("Lütfen bir masa seçiniz!");
        }


        
    }
}


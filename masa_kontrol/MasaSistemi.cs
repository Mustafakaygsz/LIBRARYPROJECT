using kütüphaneClass.Masa_yönetim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class MasaYoneticisi
{
    public List<Masa> MasalarListesi { get; set; } = new List<Masa>();
    private Random rnd = new Random();

    public MasaYoneticisi()
    {
        
        for (int i = 1; i <= 20; i++)
        {
            bool rastgeleDurum = rnd.Next(0, 2) == 1;
            MasalarListesi.Add(new Masa(i, rastgeleDurum));
        }
    }

    
    public void SecimEtiketiniBagla(Panel panel, Label hedefLabel)
    {
        foreach (Control arac in panel.Controls)
        {
            if (arac is RadioButton rb)
            {
                rb.CheckedChanged += (sender, e) =>
                {
                    RadioButton secilen = (RadioButton)sender;
                    if (secilen.Checked)
                    {
                        string no = secilen.Name.Replace("radioButton", "");

                        if (int.TryParse(no, out int masaNo))
                        {
                            hedefLabel.Text = "Masa " + masaNo.ToString("00");
                        }
                    }
                };
            }
        }
    }

    public string MasaRezerveEt(int masaNo)
    {
        var masa = MasalarListesi.FirstOrDefault(m => m.No == masaNo);
        if (masa == null) return "Hata: Masa yok!";
        if (masa.DoluMu) return "Hata: Bu masa zaten dolu!";
        masa.DoluMu = true;
        return "OK";
    }
    public string MasaIptalEt(int masaNo)
    {
        var masa = MasalarListesi.FirstOrDefault(m => m.No == masaNo);

        if (masa == null) return "Hata: Masa bulunamadı!";


        if (!masa.DoluMu) return "Hata: Bu masa zaten boş!";


        masa.DoluMu = false;

        return "OK";
    }

}
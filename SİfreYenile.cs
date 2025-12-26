using DataBaseLibrary.Modeller;
using DataBaseLibrary.VeriErisim;
using LİBRARYPROJECT.deising;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LİBRARYPROJECT
{
    public partial class SİfreYenile : Form
    {
        public SİfreYenile()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UyeDb db = new UyeDb();

                Uye bulunanUye = db.SifreYenilemeKontrol(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());

                if (bulunanUye != null)
                {

                    bulunanUye.Sifre = textBox4.Text.Trim();

                    db.Guncelle(bulunanUye);

                    MessageBox.Show("Şifreniz başarıyla güncellendi. Yeni şifrenizle giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                   
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler sistemdeki hiçbir kayıtla eşleşmiyor. Lütfen bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SİfreYenile_Load(object sender, EventArgs e)
        {
            Tool giris = new Tool();
            this.BackColor = Renkler.Koyu5;
            panel1.BackColor = Renkler.Koyu4;
            giris.Labelayarla(label7);
            giris.Labelayarla(label2);
            giris.Labelayarla(label3);
            giris.Labelayarla(label4);
            giris.Labelayarla(label5);
            giris.Labelayarla(label6);
            giris.KutuAyarla(textBox1);
            giris.KutuAyarla(textBox2);
            giris.KutuAyarla(textBox3);
            giris.KutuAyarla(textBox4);
            textBox1.BackColor = Renkler.Koyu5;
            textBox2.BackColor = Renkler.Koyu5;
            textBox3.BackColor = Renkler.Koyu5;
            textBox4.BackColor = Renkler.Koyu5;

            giris.ButonAyarla(button2);
            button2.BackColor = Color.DodgerBlue;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris geriDon = new Giris();
            geriDon.Show();
            this.Hide();
        }
    }
}

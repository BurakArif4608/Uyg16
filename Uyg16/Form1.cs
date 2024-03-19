using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg16
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            deger = txtAdSoyad.Text;
            ogrenciler.Add(anahtar, deger);
            Listele();
        }

        private void Listele()
        {
            ListeOgrenciler.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                ListeOgrenciler.Items.Add(ogrenci.Key +"-"+ogrenci.Value);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            deger = txtAdSoyad.Text;
            ogrenciler[anahtar] = deger;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(txtOkulNo.Text);
            ogrenciler.Remove(anahtar);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (txtOkulNo.Text !="")
            {
                anahtar = int.Parse(txtOkulNo.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = txtAdSoyad.Text;
                durum = ogrenciler.ContainsValue(deger);
            }
            if (durum == true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Öğrenci Kayıtlı Değildir.");
            }
        }
    }
}

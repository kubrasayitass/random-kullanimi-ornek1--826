using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_kullanimi_ornek1__826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrtalamanNotUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNotlar.Items.Clear();
            for(int i = 0; i <15; i++)
            {
                int puan = rnd.Next(0,100);
                lbNotlar.Items.Add(puan);

            }
            
            
        }

        private void btnGecmekalmadurumu_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, takdir = 0;

            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]);// i.sıradaki notu alır.
                if (puan < 50)
                {
                    kaldi++;
                }
                else if (puan >= 50 && puan < 80)
                {
                    duz++;
                }
                else if (puan >= 80 && puan < 90)
                {
                    tesekkur++;
                }
                else
                {
                    takdir++;
                }
            }
            lblKalanOgrenciSayisi.Text = "kalan öğrenci sayısı:" + Convert.ToString(kaldi);
            lblDuzGecenOgrenciSayisi.Text = "düz geçen öğrenci sayısı:" + Convert.ToString(duz);
            lblTaktirAlanOgrenciSayisi.Text = "taktir alan öğrenci sayısı:" + Convert.ToString(takdir);
            lblTesekkurAlanOgrenciSayisi.Text = "teşekkür alan öğrenci sayısı:" + Convert.ToString(tesekkur);

        }

        private void lbOgrenciNotlar_Click(object sender, EventArgs e)
        {

        }
    }
}

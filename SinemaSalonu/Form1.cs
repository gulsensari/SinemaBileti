using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonu
{
    public partial class Form1 : Form
    {
        Salon s = new Salon();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.salonNO =textBox1.Text;
            s.toplamKoltukSayisi =Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add($"Salon oluşturuldu.Salon No:{s.salonNO}  Koltuk Sayısı:{s.toplamKoltukSayisi}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                s.indirimliBiletSat();
                listBox1.Items.Add("Bilet satıldı.Kalan koltuk sayısı:" + s.BosKoltuk);
            }
            else 
            {
                s.normalBiletSat();
                listBox1.Items.Add("Bilet satıldı.Kalan koltuk sayısı:" + s.BosKoltuk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (s.indirimliBilet!=0)
                {
                    s.indirimliBiletIptal();
                    listBox1.Items.Add($"Bilet iptal edildi.Kalan koltuk sayısı:{s.BosKoltuk}" );
                }
                else
                {
                    MessageBox.Show("iptal edilecek indirimli bilet yok");
                }
            }
            else 
            {
                if (s.normalBilet != 0)
                {
                    s.normalBiletIptal();
                    listBox1.Items.Add($"Bilet iptal edildi.Kalan koltuk sayısı:{s.BosKoltuk}"  );
                }
                else
                {
                    MessageBox.Show("iptal edilecek bilet yok");
                }

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kalan Bakiye:" + s.Bakiye());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Kalan Boş Koltuk:{s.BosKoltuk}" );
        }
    }
}

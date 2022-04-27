using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSalonu
{
    class Salon
    {
        
        private int satilanBilet;
        public int indirimliBilet { get; set; }
        public int normalBilet { get; set; }
        public int toplamKoltukSayisi{ get; set; }
       public int bosKoltukSayisi { get; set; }
        public string salonNO{ get; set; }
        public int bakiye{ get; set; }

        public int SatilanBilet
        {
            get { return satilanBilet; }
            set
            {
                if (value>=toplamKoltukSayisi)
                {
                    satilanBilet = toplamKoltukSayisi;
                }
                else
                {
                    satilanBilet = value;
                }

            }
        }
        public void indirimliBiletSat()
        {

            if (toplamKoltukSayisi-satilanBilet!=0)
            {
                indirimliBilet += 1;
                satilanBilet+=1;
                bakiye = bakiye + 15;
                BosKoltuk = toplamKoltukSayisi - satilanBilet;

            }
            
        }
        public void normalBiletSat()
        {

            if (toplamKoltukSayisi - satilanBilet != 0)
            {
                normalBilet += 1;
                satilanBilet += 1;
                bakiye = bakiye + 20;
                BosKoltuk = toplamKoltukSayisi - satilanBilet;

            }
        }

            public void indirimliBiletIptal()
            {
            if (toplamKoltukSayisi != BosKoltuk)
            {
                indirimliBilet -= 1;
                satilanBilet -= 1;
                bakiye -= 15;
                BosKoltuk = toplamKoltukSayisi - satilanBilet;
            }

            }

        public void normalBiletIptal()
        {

            if (toplamKoltukSayisi != BosKoltuk)
            {
                normalBilet -= 1;
                satilanBilet -= 1;
                bakiye -= 20;
                BosKoltuk = toplamKoltukSayisi - satilanBilet;
            }

        }
        private int bosKoltuk;

        public int BosKoltuk
        {
            get { return bosKoltuk; }
            set {
                if (value<0)
                {
                    bosKoltuk = 0;
                }
                else if (value>toplamKoltukSayisi)
                {
                    bosKoltuk = toplamKoltukSayisi; 
                }
                else
                {
                    bosKoltuk = value;
                }
                }
        }


        public int Bakiye()
        {
            return bakiye;
        }
    }
}

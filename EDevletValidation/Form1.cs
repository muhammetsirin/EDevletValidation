using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDevletValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            long tckimlik = long.Parse(tc.Text);
            int dogumyili = int.Parse(dogum.Text);

            bool? durum;

            try 
            {
                using (Dogrula.KPSPublicSoapClient servis=new Dogrula.KPSPublicSoapClient())
                {
                    durum = servis.TCKimlikNoDogrula(tckimlik, ad.Text, soyad.Text, dogumyili);
                }
            }
            catch (Exception)
            {

                durum = null;
            }
            if (durum == false)
            {
                MessageBox.Show("Eksik veya Hatalı Bilgi!","Sistem Mesajı");
            }
            else if(durum==true)
            {
                MessageBox.Show($"Hoşgeldin{ad.Text}",$"{ad.Text} {soyad.Text}");
            }
            else
            {
                MessageBox.Show("BOŞ HATA");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ad.CharacterCasing = CharacterCasing.Upper;
            //soyad.CharacterCasing = CharacterCasing.Upper;
        }
    }
}

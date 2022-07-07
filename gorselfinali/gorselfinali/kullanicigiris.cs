using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselfinali
{
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }
        
        private void btngiris_Click(object sender, EventArgs e)
        {
            
            string girisAd = txtka.Text;
            string sifre = txtsifre.Text;
            if (string.IsNullOrEmpty(girisAd) || string.IsNullOrEmpty(sifre))
            {
                //giriş adı veya şifre girilmemiş. Uyarı ver.
                MessageBox.Show("Giriş adı ve şifre boş olamaz!", "Giriş hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Giriş adı ve şifre boş değilse doludur. Kullanıcı var mı yok mu kontrol et
                gorselfinalEntities vt = new gorselfinalEntities();
               vKullanici girisKullanici = vt.vKullanici.SingleOrDefault(p => p.Personelka == girisAd && p.Personelsifre == sifre);
                if (girisKullanici == null)
                {   //eğer bu ad ve şifreye ait kullanıcı yoksa girisKullanici null döner
                    MessageBox.Show("Girilen ad ve şifreye ait kullanıcı bulunamadı!", "Giriş hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   //eğer vKullanici null değilse sisteme login et
                    kullanicipanel girisEkrani = new kullanicipanel();
                    girisEkrani.Show();
                    this.Hide();
                }
            }
            }

        private void kullanicigiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

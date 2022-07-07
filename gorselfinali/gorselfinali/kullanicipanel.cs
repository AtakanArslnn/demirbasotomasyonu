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
    public partial class kullanicipanel : Form
    {
        public kullanicipanel()
        {
            InitializeComponent();
        }
        kullanicigiris anaform = new kullanicigiris();
        gorselfinalEntities vt = new gorselfinalEntities();

        enum RolKodlari
        {
            Admin,
            Ayniyat,
            Personel

        }
        void tummenulerigizle()
        {
            menuSistemAdmin.Visible = false;
            PersonelMenu.Visible = false;
            menuGiseGorevlisi.Visible = false;

        }
        public kullanicipanel(vKullanici girisYapanKullanici)
        {
            InitializeComponent();
            tummenulerigizle();

            if (girisYapanKullanici.BirimKodu == RolKodlari.Admin.ToString())
            {
                menuSistemAdmin.Visible = true;
                PersonelMenu.Visible = true;
                menuGiseGorevlisi.Visible = true;
            }

            if (girisYapanKullanici.BirimKodu == RolKodlari.Personel.ToString())
            {
                menuGiseGorevlisi.Visible = true;
            }

            if (girisYapanKullanici.BirimKodu == RolKodlari.Ayniyat.ToString())
            {
                PersonelMenu.Visible = true;
            }
        }

        private void kullanicipanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personellistesi musteriListesi = new personellistesi();

            musteriListesi.Show();
        }

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelekleme musteriListe = new personelekleme();
            musteriListe.Show();
        }

        private void kullanicipanel_Load(object sender, EventArgs e)
        {


            
        }

        private void yeniMüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demirbasekleme musteriListe = new demirbasekleme();
            musteriListe.Show();
            
        }

        private void demirbaşAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demirbasatama musteriListe = new demirbasatama();
            musteriListe.Show();
           
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demirbaslistesi musteriListe = new demirbaslistesi();
            musteriListe.Show();
            
        }

        private void zimmetlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
          zimmetlerim musteriListe = new zimmetlerim();
            musteriListe.Show();
            
        }

        private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report musteriListe = new report();
            musteriListe.Show();
        }

        private void bankaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derslikekle musteriListe = new derslikekle();
            musteriListe.Show();
        }

        private void şubeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şubeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaEkle b = new BinaEkle();
            b.Show();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

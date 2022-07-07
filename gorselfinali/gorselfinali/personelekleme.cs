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
    public partial class personelekleme : Form
    {
        public personelekleme()
        {
            InitializeComponent();
        }
        void AlanlariTemizle()
        {

            txtTCNO.Text = "";
            txtAd.Clear();
            txtSoyad.Clear();
            txtka.Clear();
            txtsifre.Clear();
            txtgorev.Clear();
            txtbinaid.Clear();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (gorselfinalEntities vt = new gorselfinalEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        Personel yeniMusteri = new Personel();

                        yeniMusteri.PersonelTCNO = txtTCNO.Text;
                        yeniMusteri.PersonelAdi = txtAd.Text;
                        yeniMusteri.PersonelSoyadi = txtSoyad.Text;
                        yeniMusteri.Personelka = txtka.Text;
                        yeniMusteri.Personelsifre = txtsifre.Text;
                        if (comboBox1.SelectedIndex == 0)
                        {
                            yeniMusteri.PersonelRolID = 1;
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            yeniMusteri.PersonelRolID = 2;
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            yeniMusteri.PersonelRolID = 3;
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            yeniMusteri.PersonelRolID = 4;
                        }
                        yeniMusteri.Gorev = txtgorev.Text;
                        yeniMusteri.BinaID = Convert.ToInt32(txtbinaid.Text);
                        vt.Personel.Add(yeniMusteri);


                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            AlanlariTemizle();
                            MessageBox.Show("İşlem başarılı!");

                        }
                        else
                            MessageBox.Show("İşlem başarısız!");
                    }
                    catch (Exception hata)
                    {
                        //hata oluştu. Kaydetme işlemini iptal et. Tüm kayıtlar eski haline dönsün
                        transaction.Rollback(); //kaydetme iptal edilir. Kayıtlar eski haline döner
                    }
                    finally
                    {
                        //hiçbir hata olmadı. Tüm işlemler başarılı oldu. Bu sebeple kaydetme işlemini onayla
                        transaction.Commit(); // kaydetme işlemi onayla. Veriler tüm tablolara kayıt olur
                    }
                }
            }
            }

        private void txtbinaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtgorev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtka_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTCNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

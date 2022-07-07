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
    public partial class BinaEkle : Form
    {
        public BinaEkle()
        {
            InitializeComponent();
        }
        void AlanlariTemizle()
        {

            txtAd.Clear();
            txtSoyad.Clear();


        }
        gorselfinalEntities vt = new gorselfinalEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (gorselfinalEntities vt = new gorselfinalEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        Bina yeniMusteri = new Bina();

                        yeniMusteri.BinaAdi = txtAd.Text;
                        yeniMusteri.BinaAdresi = txtSoyad.Text;

                        vt.Bina.Add(yeniMusteri);


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

        private void BinaEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vt.Bina.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int silinecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Bina silinecekKisi = vt.Bina.FirstOrDefault(p => p.BinaID == silinecekKisiID);
                vt.Bina.Remove(silinecekKisi);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    dataGridView1.DataSource = vt.Bina.ToList();
                    MessageBox.Show("İşlem başarılı");
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlanlariTemizle();
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int guncellenecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Bina yeniMusteri = vt.Bina.FirstOrDefault(p => p.BinaID == guncellenecekKisiID);
                yeniMusteri.BinaAdi = txtAd.Text;
                yeniMusteri.BinaAdresi = txtSoyad.Text;
 int sonuc = vt.SaveChanges();
            dataGridView1.DataSource = vt.Bina.ToList();
            if (sonuc > 0)
            {
                AlanlariTemizle();

                MessageBox.Show("İşlem başarılı");
            }
            else
                MessageBox.Show("İşlem başarısız");
        }
            }
           
    }
    }


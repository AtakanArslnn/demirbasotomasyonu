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
    public partial class demirbasatama : Form
    {
        public demirbasatama()
        {
            InitializeComponent();
        }
        void AlanlariTemizle()
        {

            txtzimmet.Text = "";
            txtAd.Text = "";
            txtpersonelid.Text = "";
            txtbinaid.Text = "";
            txtgorev.Text = "";
            txtSoyad.Text = "";
            comboBox1.Text = "";
            txtTCNO.Text = "";

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        


          
        }
        void TumKayitlariListele()
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.vZimmetler.ToList();
            gorselfinalEntities vt2 = new gorselfinalEntities();
            dataGridView2.DataSource = vt2.vPersonel.ToList();
        }
        private void demirbasatama_Load(object sender, EventArgs e)
        {
            TumKayitlariListele();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlanlariTemizle();
            txtpersonelid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            lblKisiID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtTCNO.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            if (comboBox1.Text == "1")
            {
                comboBox1.Text = "Admin";
            }
            if (comboBox1.Text == "2")
            {
                comboBox1.Text = "Ayniyat";
            }
            if (comboBox1.Text == "3")
            {
                comboBox1.Text = "Personel";
            }
            if (comboBox1.Text == "4")
            {
                comboBox1.Text = "Depocu";
            }
            txtgorev.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtbinaid.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (gorselfinalEntities vt = new gorselfinalEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        Zimmet yeniMusteri = new Zimmet();
                        yeniMusteri.personelID = Convert.ToInt32(txtpersonelid.Text);
                        yeniMusteri.zimmetler = txtzimmet.Text;
                        yeniMusteri.personelTCNO = txtTCNO.Text;
                        yeniMusteri.eklenmeTarihi = DateTime.Now;
                        vt.Zimmet.Add(yeniMusteri);


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
    }

      
    }


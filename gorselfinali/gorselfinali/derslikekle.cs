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
    public partial class derslikekle : Form
    {
        public derslikekle()
        {
            InitializeComponent();
        }
        void AlanlariTemizle()
        {

            txtTCNO.Text = "";
            comboBox1.SelectedItem = "";

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
                        Derslik yeniMusteri = new Derslik();

                        yeniMusteri.DerslikAdi = txtTCNO.Text;
                        
                        
                        if (comboBox1.SelectedIndex == 0)
                        {
                            yeniMusteri.DerslikBinasi = "A Blok";
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            yeniMusteri.DerslikBinasi = "B Blok";
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            yeniMusteri.DerslikBinasi = "C Blok";
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            yeniMusteri.DerslikBinasi = "Rektörlük";
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            yeniMusteri.DerslikBinasi = "Dekanlık";
                        }
                        
                        vt.Derslik.Add(yeniMusteri);


                        int sonuc = vt.SaveChanges();
                        dataGridView1.DataSource = vt.Derslik.ToList();
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

        private void derslikekle_Load(object sender, EventArgs e)
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.Derslik.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int silinecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
               Derslik silinecekKisi = vt.Derslik.FirstOrDefault(p => p.DerslikID == silinecekKisiID);
                vt.Derslik.Remove(silinecekKisi);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {

                    TumKayitlariListele();
                    MessageBox.Show("İşlem başarılı");
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlanlariTemizle();
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTCNO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (comboBox1.Text == "A Blok")
            {
                comboBox1.Text = "A Blok";
            }
            if (comboBox1.Text == "B Blok")
            {
                comboBox1.Text = "B Blok";
            }
            if (comboBox1.Text == "C Blok")
            {
                comboBox1.Text = "C Blok";
            }
            if (comboBox1.Text == "Rektörlük")
            {
                comboBox1.Text = "Rektörlük";
            }
            if (comboBox1.Text == "Dekanlık")
            {
                comboBox1.Text = "Dekanlık";
            }

        }
        public void TumKayitlariListele()
        {
            dataGridView1.DataSource = vt.Derslik.ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int guncellenecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Derslik yeniMusteri = vt.Derslik.FirstOrDefault(p => p.DerslikID== guncellenecekKisiID);
                yeniMusteri.DerslikAdi = txtTCNO.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    yeniMusteri.DerslikBinasi = "A Blok";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    yeniMusteri.DerslikBinasi = "B Blok";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    yeniMusteri.DerslikBinasi = "C Blok";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    yeniMusteri.DerslikBinasi = "Rektörlük";
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    yeniMusteri.DerslikBinasi = "Dekanlık";
                }
               


                int sonuc = vt.SaveChanges();
TumKayitlariListele();
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

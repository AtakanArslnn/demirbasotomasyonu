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
    public partial class personellistesi : Form
    {
        public personellistesi()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int silinecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Personel silinecekKisi = vt.Personel.FirstOrDefault(p => p.PersonelID == silinecekKisiID);
                vt.Personel.Remove(silinecekKisi);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {

                    TumKayitlariListele();
                    MessageBox.Show("İşlem başarılı");
                }
            }
        }
        void TumKayitlariListele()
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.Personel.ToList();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int guncellenecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Personel yeniMusteri = vt.Personel.FirstOrDefault(p => p.PersonelID == guncellenecekKisiID);
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


                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    AlanlariTemizle();
                    TumKayitlariListele();
                    MessageBox.Show("İşlem başarılı");
                }
                else
                    MessageBox.Show("İşlem başarısız");
            }
            TumKayitlariListele();

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlanlariTemizle();
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTCNO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
            txtgorev.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtbinaid.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            txtTCNO.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label9.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            txtAd.Visible = true;
            txtSoyad.Visible = true;
            txtka.Visible = true;
            txtsifre.Visible = true;
            comboBox1.Visible = true;
            txtgorev.Visible = true;
            txtbinaid.Visible = true;
        }
        string secilenKisiID;
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //farenin sağ tuşuna tıklandıysa
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1) // bu indeksler -1 den büyükse tam hücre tıklanmıştır
                {
                    secilenKisiID = dataGridView1.Rows[e.RowIndex].Cells["PersonelID"].Value.ToString();
                }
            }
        }

        private void personellistesi_Load(object sender, EventArgs e)
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.Personel.ToList();
        }
    }
}

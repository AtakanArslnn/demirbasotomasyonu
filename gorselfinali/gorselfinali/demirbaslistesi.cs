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
    public partial class demirbaslistesi : Form
    {
        public demirbaslistesi()
        {
            InitializeComponent();
        }
        void TumKayitlariListele()
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.Demirbas.ToList();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int silinecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Demirbas silinecekKisi = vt.Demirbas.FirstOrDefault(p => p.DemirbasID == silinecekKisiID);
                silinecekKisi.SilinmeTarihi = dateTimePicker1.Value;
                silinecekKisi.DemirbasAktifmi = false;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {

                    TumKayitlariListele();
                    MessageBox.Show("İşlem başarılı");
                }
                else
                    MessageBox.Show("İşlem Başarısız");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblKisiID.Text))
            {
                int guncellenecekKisiID = Convert.ToInt32(lblKisiID.Text);
                gorselfinalEntities vt = new gorselfinalEntities();
                Demirbas yeniMusteri = vt.Demirbas.FirstOrDefault(p => p.DemirbasID == guncellenecekKisiID);
                yeniMusteri.DemirbasAdi = txtdemirbasadi.Text;
               if (cmbtur.SelectedIndex == 0)
                {
                    yeniMusteri.DemirbasTuru = "Elektronik";
                }
                if (cmbtur.SelectedIndex == 1)
                {
                    yeniMusteri.DemirbasTuru= "Mobilya";
                }
                if (cmbtur.SelectedIndex == 2)
                {
                    yeniMusteri.DemirbasTuru= "Kırtasiye";
                }
                yeniMusteri.DemirbasBilgisi = txtdemirbasbilgisi.Text;
                if (cmbaktiflik.SelectedIndex == 0)
                {
                    yeniMusteri.DemirbasAktifmi = true;
                    yeniMusteri.SilinmeTarihi = null;
                }
                if (cmbtur.SelectedIndex == 1)
                {
                    yeniMusteri.DemirbasAktifmi = false;
                }
                
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

            txtdemirbasadi.Text = "";
            txtdemirbasbilgisi.Text = "";
            cmbaktiflik.Text = "";
            cmbtur.Text = "";


        }
        private void demirbaslistesi_Load(object sender, EventArgs e)
        {
            gorselfinalEntities vt = new gorselfinalEntities();
            dataGridView1.DataSource = vt.Demirbas.ToList();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AlanlariTemizle();
            lblKisiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdemirbasadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbtur.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (cmbtur.SelectedIndex == 0)
            {
                cmbtur.Text = "Elektronik";
            }
            if (cmbtur.SelectedIndex == 1)
            {
                cmbtur.Text = "Mobilya";
            }
            if (cmbtur.SelectedIndex == 2)
            {
                cmbtur.Text = "Kırtasiye";
            }
           

            txtdemirbasbilgisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbaktiflik.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (cmbaktiflik.SelectedIndex == 0)
            {
                cmbaktiflik.Text = "True";
            }
            if (cmbaktiflik.SelectedIndex == 1)
            {
                cmbtur.Text = "False";
            }
           
            
        

            txtdemirbasadi.Visible = true;
            
           
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            txtdemirbasadi.Visible = true;
            txtdemirbasbilgisi.Visible = true;
            
            cmbaktiflik.Visible = true;
            cmbtur.Visible = true;
            
            
        }
    }
}

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
    public partial class demirbasekleme : Form
    {
        public demirbasekleme()
        {
            InitializeComponent();
        }
        void AlanlariTemizle()
        {

            txtdemirbasadi.Text = "";
            txtdemirbasbilgisi.Text = "";
            cmbaktiflik.Text = "";
            cmbtur.Text = "";


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (gorselfinalEntities vt = new gorselfinalEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        Demirbas yeniMusteri = new Demirbas();

                        yeniMusteri.DemirbasAdi = txtdemirbasadi.Text;
                        if (cmbtur.SelectedIndex==0)
                        {
                            yeniMusteri.DemirbasTuru = "Elektronik";
                                
                                }
                        if (cmbtur.SelectedIndex == 1)
                        {
                            yeniMusteri.DemirbasTuru = "Mobilya";

                        }
                        if (cmbtur.SelectedIndex == 2)
                        {
                            yeniMusteri.DemirbasTuru = "Kırtasiye";

                        }
                        yeniMusteri.DemirbasBilgisi = txtdemirbasbilgisi.Text;
                        if (cmbaktiflik.SelectedIndex == 0)
                        {
                            
                            yeniMusteri.DemirbasAktifmi =true;

                        }
                        if (cmbtur.SelectedIndex == 1)
                        {
                            yeniMusteri.DemirbasAktifmi = false;

                        }
                        yeniMusteri.EklenmeTarihi = dateTimePicker1.Value;


                        vt.Demirbas.Add(yeniMusteri);
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

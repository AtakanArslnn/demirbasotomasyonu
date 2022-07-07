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
    public partial class zimmetlerim : Form
    {
        public zimmetlerim()
        {
            InitializeComponent();
        }
gorselfinalEntities vt = new gorselfinalEntities();
        private void zimmetlerim_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource =vt.vZimmetler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<vZimmetler> sorguListesi = vt.vZimmetler.Where(p => p.PersonelTCNO == textBox1.Text).ToList();
            dataGridView2.DataSource = sorguListesi;


        }
    }
}

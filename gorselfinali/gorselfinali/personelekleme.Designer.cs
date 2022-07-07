
namespace gorselfinali
{
    partial class personelekleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbinaid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgorev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Ayniyat",
            "Personel",
            "Depocu"});
            this.comboBox1.Location = new System.Drawing.Point(550, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 24);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbinaid
            // 
            this.txtbinaid.Location = new System.Drawing.Point(550, 276);
            this.txtbinaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtbinaid.MaxLength = 50;
            this.txtbinaid.Name = "txtbinaid";
            this.txtbinaid.Size = new System.Drawing.Size(361, 22);
            this.txtbinaid.TabIndex = 69;
            this.txtbinaid.TextChanged += new System.EventHandler(this.txtbinaid_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Bina ID:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(550, 246);
            this.txtgorev.Margin = new System.Windows.Forms.Padding(4);
            this.txtgorev.MaxLength = 50;
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Size = new System.Drawing.Size(361, 22);
            this.txtgorev.TabIndex = 67;
            this.txtgorev.TextChanged += new System.EventHandler(this.txtgorev_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Görev:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Rol ID:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(550, 186);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.MaxLength = 50;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(361, 22);
            this.txtsifre.TabIndex = 64;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Şifre:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(550, 472);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 28);
            this.btnKaydet.TabIndex = 62;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtka
            // 
            this.txtka.Location = new System.Drawing.Point(550, 156);
            this.txtka.Margin = new System.Windows.Forms.Padding(4);
            this.txtka.MaxLength = 50;
            this.txtka.Name = "txtka";
            this.txtka.Size = new System.Drawing.Size(361, 22);
            this.txtka.TabIndex = 61;
            this.txtka.TextChanged += new System.EventHandler(this.txtka_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Kullanıcı Adı:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(550, 124);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(361, 22);
            this.txtSoyad.TabIndex = 59;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Soyad:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(550, 92);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(361, 22);
            this.txtAd.TabIndex = 57;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTCNO
            // 
            this.txtTCNO.Location = new System.Drawing.Point(550, 60);
            this.txtTCNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCNO.MaxLength = 11;
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(361, 22);
            this.txtTCNO.TabIndex = 55;
            this.txtTCNO.TextChanged += new System.EventHandler(this.txtTCNO_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "TC No:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // personelekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 560);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtbinaid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgorev);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTCNO);
            this.Controls.Add(this.label3);
            this.Name = "personelekleme";
            this.Text = "personelekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbinaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgorev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.Label label3;
    }
}
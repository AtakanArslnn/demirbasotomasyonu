
namespace gorselfinali
{
    partial class demirbasekleme
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.txtdemirbasbilgisi = new System.Windows.Forms.TextBox();
            this.txtdemirbasadi = new System.Windows.Forms.TextBox();
            this.cmbaktiflik = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(315, 359);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 28);
            this.btnKaydet.TabIndex = 63;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 131;
            this.label14.Text = "Demirbaş Bilgisi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(135, 132);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 17);
            this.label15.TabIndex = 130;
            this.label15.Text = "Demirbaş Türü:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 129;
            this.label16.Text = "Demirbaş Adı:";
            // 
            // cmbtur
            // 
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "Elektronik",
            "Mobilya",
            "Kırtasiye"});
            this.cmbtur.Location = new System.Drawing.Point(313, 125);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(361, 24);
            this.cmbtur.TabIndex = 128;
            // 
            // txtdemirbasbilgisi
            // 
            this.txtdemirbasbilgisi.Location = new System.Drawing.Point(313, 159);
            this.txtdemirbasbilgisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdemirbasbilgisi.MaxLength = 50;
            this.txtdemirbasbilgisi.Name = "txtdemirbasbilgisi";
            this.txtdemirbasbilgisi.Size = new System.Drawing.Size(361, 22);
            this.txtdemirbasbilgisi.TabIndex = 127;
            // 
            // txtdemirbasadi
            // 
            this.txtdemirbasadi.Location = new System.Drawing.Point(313, 95);
            this.txtdemirbasadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdemirbasadi.MaxLength = 256;
            this.txtdemirbasadi.Name = "txtdemirbasadi";
            this.txtdemirbasadi.Size = new System.Drawing.Size(361, 22);
            this.txtdemirbasadi.TabIndex = 126;
            // 
            // cmbaktiflik
            // 
            this.cmbaktiflik.FormattingEnabled = true;
            this.cmbaktiflik.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbaktiflik.Location = new System.Drawing.Point(313, 189);
            this.cmbaktiflik.Name = "cmbaktiflik";
            this.cmbaktiflik.Size = new System.Drawing.Size(361, 24);
            this.cmbaktiflik.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 196);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 17);
            this.label13.TabIndex = 132;
            this.label13.Text = "Demirbaş Aktiflik Durumu:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 22);
            this.dateTimePicker1.TabIndex = 134;
            this.dateTimePicker1.Visible = false;
            // 
            // demirbasekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbaktiflik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.txtdemirbasbilgisi);
            this.Controls.Add(this.txtdemirbasadi);
            this.Controls.Add(this.btnKaydet);
            this.Name = "demirbasekleme";
            this.Text = "demirbasekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.TextBox txtdemirbasbilgisi;
        private System.Windows.Forms.TextBox txtdemirbasadi;
        private System.Windows.Forms.ComboBox cmbaktiflik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
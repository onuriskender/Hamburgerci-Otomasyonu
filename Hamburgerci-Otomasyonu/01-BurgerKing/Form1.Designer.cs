
namespace _01_BurgerKing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.flpMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rdoBuyuk);
            this.grpBoyutlar.Controls.Add(this.rdoOrta);
            this.grpBoyutlar.Controls.Add(this.rdoKucuk);
            this.grpBoyutlar.Location = new System.Drawing.Point(8, 211);
            this.grpBoyutlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoyutlar.Size = new System.Drawing.Size(214, 40);
            this.grpBoyutlar.TabIndex = 25;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "BOYUT SEÇİN";
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(145, 17);
            this.rdoBuyuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rdoBuyuk.TabIndex = 7;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(79, 17);
            this.rdoOrta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(45, 17);
            this.rdoOrta.TabIndex = 6;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(9, 17);
            this.rdoKucuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(56, 17);
            this.rdoKucuk.TabIndex = 5;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(386, 504);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(14, 13);
            this.lblToplamTutar.TabIndex = 32;
            this.lblToplamTutar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(286, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(581, 504);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(173, 43);
            this.btnSiparisiTamamla.TabIndex = 30;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(8, 504);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(173, 43);
            this.btnSiparisEkle.TabIndex = 21;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 478);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ADET";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(56, 477);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(60, 20);
            this.nmrAdet.TabIndex = 28;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpMalzemeler
            // 
            this.flpMalzemeler.Location = new System.Drawing.Point(8, 281);
            this.flpMalzemeler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpMalzemeler.Name = "flpMalzemeler";
            this.flpMalzemeler.Size = new System.Drawing.Size(266, 189);
            this.flpMalzemeler.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(306, 16);
            this.lbxSiparisler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(450, 472);
            this.lbxSiparisler.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(8, 181);
            this.cmbMenuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(216, 21);
            this.cmbMenuler.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 553);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMenuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rdoBuyuk;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoKucuk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
    }
}
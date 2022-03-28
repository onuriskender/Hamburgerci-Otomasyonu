
namespace _01_BurgerKing
{
    partial class Form3
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
            this.grpMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.nmrExtraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnExtraMalzemeEkle = new System.Windows.Forms.Button();
            this.txtExtraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeEkle
            // 
            this.grpMalzemeEkle.Controls.Add(this.nmrExtraMalzemeFiyati);
            this.grpMalzemeEkle.Controls.Add(this.btnExtraMalzemeEkle);
            this.grpMalzemeEkle.Controls.Add(this.txtExtraMalzemeAdi);
            this.grpMalzemeEkle.Controls.Add(this.label2);
            this.grpMalzemeEkle.Controls.Add(this.label1);
            this.grpMalzemeEkle.Location = new System.Drawing.Point(6, 6);
            this.grpMalzemeEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMalzemeEkle.Name = "grpMalzemeEkle";
            this.grpMalzemeEkle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMalzemeEkle.Size = new System.Drawing.Size(288, 150);
            this.grpMalzemeEkle.TabIndex = 2;
            this.grpMalzemeEkle.TabStop = false;
            this.grpMalzemeEkle.Text = "EXTRA MALZEME BİLGİLERİ";
            // 
            // nmrExtraMalzemeFiyati
            // 
            this.nmrExtraMalzemeFiyati.DecimalPlaces = 2;
            this.nmrExtraMalzemeFiyati.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nmrExtraMalzemeFiyati.Location = new System.Drawing.Point(113, 84);
            this.nmrExtraMalzemeFiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrExtraMalzemeFiyati.Name = "nmrExtraMalzemeFiyati";
            this.nmrExtraMalzemeFiyati.Size = new System.Drawing.Size(164, 20);
            this.nmrExtraMalzemeFiyati.TabIndex = 5;
            this.nmrExtraMalzemeFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExtraMalzemeEkle
            // 
            this.btnExtraMalzemeEkle.Location = new System.Drawing.Point(139, 112);
            this.btnExtraMalzemeEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExtraMalzemeEkle.Name = "btnExtraMalzemeEkle";
            this.btnExtraMalzemeEkle.Size = new System.Drawing.Size(138, 35);
            this.btnExtraMalzemeEkle.TabIndex = 4;
            this.btnExtraMalzemeEkle.Text = "EXTRA MALZEME EKLE";
            this.btnExtraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnExtraMalzemeEkle.Click += new System.EventHandler(this.btnExtraMalzemeEkle_Click);
            // 
            // txtExtraMalzemeAdi
            // 
            this.txtExtraMalzemeAdi.Location = new System.Drawing.Point(113, 40);
            this.txtExtraMalzemeAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtraMalzemeAdi.Name = "txtExtraMalzemeAdi";
            this.txtExtraMalzemeAdi.Size = new System.Drawing.Size(166, 20);
            this.txtExtraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra Malzeme Adı";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 162);
            this.Controls.Add(this.grpMalzemeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MalzemeBilgileri";
            this.grpMalzemeEkle.ResumeLayout(false);
            this.grpMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeEkle;
        private System.Windows.Forms.Button btnExtraMalzemeEkle;
        private System.Windows.Forms.TextBox txtExtraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrExtraMalzemeFiyati;
    }
}
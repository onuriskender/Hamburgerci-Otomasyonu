
namespace _01_BurgerKing
{
    partial class Form2
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
            this.grpMenuEkle = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuEkle
            // 
            this.grpMenuEkle.Controls.Add(this.btnMenuEkle);
            this.grpMenuEkle.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuEkle.Controls.Add(this.txtMenuAdi);
            this.grpMenuEkle.Controls.Add(this.label2);
            this.grpMenuEkle.Controls.Add(this.label1);
            this.grpMenuEkle.Location = new System.Drawing.Point(11, 6);
            this.grpMenuEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMenuEkle.Name = "grpMenuEkle";
            this.grpMenuEkle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMenuEkle.Size = new System.Drawing.Size(288, 150);
            this.grpMenuEkle.TabIndex = 1;
            this.grpMenuEkle.TabStop = false;
            this.grpMenuEkle.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Location = new System.Drawing.Point(139, 112);
            this.btnMenuEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(138, 35);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "MENÜ EKLE";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.DecimalPlaces = 2;
            this.nmrMenuFiyati.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmrMenuFiyati.Location = new System.Drawing.Point(113, 77);
            this.nmrMenuFiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(164, 20);
            this.nmrMenuFiyati.TabIndex = 3;
            this.nmrMenuFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(113, 40);
            this.txtMenuAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(166, 20);
            this.txtMenuAdi.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 162);
            this.Controls.Add(this.grpMenuEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMenuEkle.ResumeLayout(false);
            this.grpMenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMenuEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
    }
}
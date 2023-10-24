namespace random_kullanimi_ornek1__826
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
            this.btnOrtalamanNotUret = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnGecmekalmadurumu = new System.Windows.Forms.Button();
            this.lbOgrenciNotlar = new System.Windows.Forms.Label();
            this.lblKalanOgrenciSayisi = new System.Windows.Forms.Label();
            this.lblDuzGecenOgrenciSayisi = new System.Windows.Forms.Label();
            this.lblTaktirAlanOgrenciSayisi = new System.Windows.Forms.Label();
            this.lblTesekkurAlanOgrenciSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrtalamanNotUret
            // 
            this.btnOrtalamanNotUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalamanNotUret.Location = new System.Drawing.Point(23, 51);
            this.btnOrtalamanNotUret.Name = "btnOrtalamanNotUret";
            this.btnOrtalamanNotUret.Size = new System.Drawing.Size(127, 58);
            this.btnOrtalamanNotUret.TabIndex = 0;
            this.btnOrtalamanNotUret.Text = "ortalama not üret";
            this.btnOrtalamanNotUret.UseVisualStyleBackColor = true;
            this.btnOrtalamanNotUret.Click += new System.EventHandler(this.btnOrtalamanNotUret_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 16;
            this.lbNotlar.Location = new System.Drawing.Point(166, 70);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(205, 196);
            this.lbNotlar.TabIndex = 1;
            // 
            // btnGecmekalmadurumu
            // 
            this.btnGecmekalmadurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmekalmadurumu.Location = new System.Drawing.Point(23, 125);
            this.btnGecmekalmadurumu.Name = "btnGecmekalmadurumu";
            this.btnGecmekalmadurumu.Size = new System.Drawing.Size(127, 53);
            this.btnGecmekalmadurumu.TabIndex = 2;
            this.btnGecmekalmadurumu.Text = "geçme kalma durumu";
            this.btnGecmekalmadurumu.UseVisualStyleBackColor = true;
            this.btnGecmekalmadurumu.Click += new System.EventHandler(this.btnGecmekalmadurumu_Click);
            // 
            // lbOgrenciNotlar
            // 
            this.lbOgrenciNotlar.AutoSize = true;
            this.lbOgrenciNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbOgrenciNotlar.Location = new System.Drawing.Point(163, 51);
            this.lbOgrenciNotlar.Name = "lbOgrenciNotlar";
            this.lbOgrenciNotlar.Size = new System.Drawing.Size(106, 16);
            this.lbOgrenciNotlar.TabIndex = 3;
            this.lbOgrenciNotlar.Text = "öğrenci notlar:";
            this.lbOgrenciNotlar.Click += new System.EventHandler(this.lbOgrenciNotlar_Click);
            // 
            // lblKalanOgrenciSayisi
            // 
            this.lblKalanOgrenciSayisi.AutoSize = true;
            this.lblKalanOgrenciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanOgrenciSayisi.Location = new System.Drawing.Point(172, 279);
            this.lblKalanOgrenciSayisi.Name = "lblKalanOgrenciSayisi";
            this.lblKalanOgrenciSayisi.Size = new System.Drawing.Size(146, 16);
            this.lblKalanOgrenciSayisi.TabIndex = 4;
            this.lblKalanOgrenciSayisi.Text = "kalan öğrenci sayısı";
            // 
            // lblDuzGecenOgrenciSayisi
            // 
            this.lblDuzGecenOgrenciSayisi.AutoSize = true;
            this.lblDuzGecenOgrenciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzGecenOgrenciSayisi.Location = new System.Drawing.Point(172, 307);
            this.lblDuzGecenOgrenciSayisi.Name = "lblDuzGecenOgrenciSayisi";
            this.lblDuzGecenOgrenciSayisi.Size = new System.Drawing.Size(179, 16);
            this.lblDuzGecenOgrenciSayisi.TabIndex = 5;
            this.lblDuzGecenOgrenciSayisi.Text = "düz geçen öğrenci sayısı";
            // 
            // lblTaktirAlanOgrenciSayisi
            // 
            this.lblTaktirAlanOgrenciSayisi.AutoSize = true;
            this.lblTaktirAlanOgrenciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaktirAlanOgrenciSayisi.Location = new System.Drawing.Point(176, 333);
            this.lblTaktirAlanOgrenciSayisi.Name = "lblTaktirAlanOgrenciSayisi";
            this.lblTaktirAlanOgrenciSayisi.Size = new System.Drawing.Size(176, 16);
            this.lblTaktirAlanOgrenciSayisi.TabIndex = 6;
            this.lblTaktirAlanOgrenciSayisi.Text = "taktir alan öğrenci sayısı";
            // 
            // lblTesekkurAlanOgrenciSayisi
            // 
            this.lblTesekkurAlanOgrenciSayisi.AutoSize = true;
            this.lblTesekkurAlanOgrenciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesekkurAlanOgrenciSayisi.Location = new System.Drawing.Point(175, 359);
            this.lblTesekkurAlanOgrenciSayisi.Name = "lblTesekkurAlanOgrenciSayisi";
            this.lblTesekkurAlanOgrenciSayisi.Size = new System.Drawing.Size(149, 16);
            this.lblTesekkurAlanOgrenciSayisi.TabIndex = 7;
            this.lblTesekkurAlanOgrenciSayisi.Text = "teşekkür alma sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.lblTesekkurAlanOgrenciSayisi);
            this.Controls.Add(this.lblTaktirAlanOgrenciSayisi);
            this.Controls.Add(this.lblDuzGecenOgrenciSayisi);
            this.Controls.Add(this.lblKalanOgrenciSayisi);
            this.Controls.Add(this.lbOgrenciNotlar);
            this.Controls.Add(this.btnGecmekalmadurumu);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.btnOrtalamanNotUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrtalamanNotUret;
        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnGecmekalmadurumu;
        private System.Windows.Forms.Label lbOgrenciNotlar;
        private System.Windows.Forms.Label lblKalanOgrenciSayisi;
        private System.Windows.Forms.Label lblDuzGecenOgrenciSayisi;
        private System.Windows.Forms.Label lblTaktirAlanOgrenciSayisi;
        private System.Windows.Forms.Label lblTesekkurAlanOgrenciSayisi;
    }
}


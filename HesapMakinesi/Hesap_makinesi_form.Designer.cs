namespace HesapMakinesi
{
	partial class Hesap_makinesi_form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesap_makinesi_form));
			this.btn_artıeksi = new System.Windows.Forms.Button();
			this.txt_sayi_girisleri = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_sıfır = new System.Windows.Forms.Button();
			this.btn_virgul = new System.Windows.Forms.Button();
			this.btn_esittir = new System.Windows.Forms.Button();
			this.btn_topla = new System.Windows.Forms.Button();
			this.btn_uc = new System.Windows.Forms.Button();
			this.btn_iki = new System.Windows.Forms.Button();
			this.btn_bir = new System.Windows.Forms.Button();
			this.btn_cıkar = new System.Windows.Forms.Button();
			this.btn_altı = new System.Windows.Forms.Button();
			this.btn_bes = new System.Windows.Forms.Button();
			this.btn_dort = new System.Windows.Forms.Button();
			this.btn_carpi = new System.Windows.Forms.Button();
			this.btn_dokuz = new System.Windows.Forms.Button();
			this.btn_sekiz = new System.Windows.Forms.Button();
			this.btn_yedi = new System.Windows.Forms.Button();
			this.btn_bolu = new System.Windows.Forms.Button();
			this.btn_ikikokx = new System.Windows.Forms.Button();
			this.btn_xkare = new System.Windows.Forms.Button();
			this.btn_1boluX = new System.Windows.Forms.Button();
			this.btn_silme = new System.Windows.Forms.Button();
			this.btn_C = new System.Windows.Forms.Button();
			this.btn_CE = new System.Windows.Forms.Button();
			this.btn_yuzde = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_artıeksi
			// 
			this.btn_artıeksi.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_artıeksi.Location = new System.Drawing.Point(5, 554);
			this.btn_artıeksi.Name = "btn_artıeksi";
			this.btn_artıeksi.Size = new System.Drawing.Size(100, 70);
			this.btn_artıeksi.TabIndex = 0;
			this.btn_artıeksi.Text = "+/-";
			this.btn_artıeksi.UseVisualStyleBackColor = true;
			this.btn_artıeksi.Click += new System.EventHandler(this.btn_artıeksi_Click);
			// 
			// txt_sayi_girisleri
			// 
			this.txt_sayi_girisleri.BackColor = System.Drawing.Color.Goldenrod;
			this.txt_sayi_girisleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_sayi_girisleri.Location = new System.Drawing.Point(0, 104);
			this.txt_sayi_girisleri.MaxLength = 327675;
			this.txt_sayi_girisleri.Multiline = true;
			this.txt_sayi_girisleri.Name = "txt_sayi_girisleri";
			this.txt_sayi_girisleri.Size = new System.Drawing.Size(429, 64);
			this.txt_sayi_girisleri.TabIndex = 1;
			this.txt_sayi_girisleri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txt_sayi_girisleri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sayi_giris_KeyPress);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btn_sıfır
			// 
			this.btn_sıfır.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_sıfır.Location = new System.Drawing.Point(111, 554);
			this.btn_sıfır.Name = "btn_sıfır";
			this.btn_sıfır.Size = new System.Drawing.Size(100, 70);
			this.btn_sıfır.TabIndex = 2;
			this.btn_sıfır.Text = "0";
			this.btn_sıfır.UseVisualStyleBackColor = true;
			this.btn_sıfır.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_virgul
			// 
			this.btn_virgul.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_virgul.Location = new System.Drawing.Point(217, 554);
			this.btn_virgul.Name = "btn_virgul";
			this.btn_virgul.Size = new System.Drawing.Size(100, 70);
			this.btn_virgul.TabIndex = 3;
			this.btn_virgul.Text = ",";
			this.btn_virgul.UseVisualStyleBackColor = true;
			this.btn_virgul.Click += new System.EventHandler(this.btn_virgul_Click);
			// 
			// btn_esittir
			// 
			this.btn_esittir.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_esittir.Location = new System.Drawing.Point(323, 554);
			this.btn_esittir.Name = "btn_esittir";
			this.btn_esittir.Size = new System.Drawing.Size(100, 70);
			this.btn_esittir.TabIndex = 4;
			this.btn_esittir.Text = "=";
			this.btn_esittir.UseVisualStyleBackColor = true;
			this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
			// 
			// btn_topla
			// 
			this.btn_topla.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_topla.Location = new System.Drawing.Point(323, 478);
			this.btn_topla.Name = "btn_topla";
			this.btn_topla.Size = new System.Drawing.Size(100, 70);
			this.btn_topla.TabIndex = 8;
			this.btn_topla.Text = "+";
			this.btn_topla.UseVisualStyleBackColor = true;
			this.btn_topla.Click += new System.EventHandler(this.dort_islem);
			// 
			// btn_uc
			// 
			this.btn_uc.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_uc.Location = new System.Drawing.Point(217, 478);
			this.btn_uc.Name = "btn_uc";
			this.btn_uc.Size = new System.Drawing.Size(100, 70);
			this.btn_uc.TabIndex = 7;
			this.btn_uc.Text = "3";
			this.btn_uc.UseVisualStyleBackColor = true;
			this.btn_uc.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_iki
			// 
			this.btn_iki.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_iki.Location = new System.Drawing.Point(111, 478);
			this.btn_iki.Name = "btn_iki";
			this.btn_iki.Size = new System.Drawing.Size(100, 70);
			this.btn_iki.TabIndex = 6;
			this.btn_iki.Text = "2";
			this.btn_iki.UseVisualStyleBackColor = true;
			this.btn_iki.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_bir
			// 
			this.btn_bir.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bir.Location = new System.Drawing.Point(5, 478);
			this.btn_bir.Name = "btn_bir";
			this.btn_bir.Size = new System.Drawing.Size(100, 70);
			this.btn_bir.TabIndex = 5;
			this.btn_bir.Text = "1";
			this.btn_bir.UseVisualStyleBackColor = true;
			this.btn_bir.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_cıkar
			// 
			this.btn_cıkar.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_cıkar.Location = new System.Drawing.Point(323, 402);
			this.btn_cıkar.Name = "btn_cıkar";
			this.btn_cıkar.Size = new System.Drawing.Size(100, 70);
			this.btn_cıkar.TabIndex = 12;
			this.btn_cıkar.Text = "-";
			this.btn_cıkar.UseVisualStyleBackColor = true;
			this.btn_cıkar.Click += new System.EventHandler(this.dort_islem);
			// 
			// btn_altı
			// 
			this.btn_altı.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_altı.Location = new System.Drawing.Point(217, 402);
			this.btn_altı.Name = "btn_altı";
			this.btn_altı.Size = new System.Drawing.Size(100, 70);
			this.btn_altı.TabIndex = 11;
			this.btn_altı.Text = "6";
			this.btn_altı.UseVisualStyleBackColor = true;
			this.btn_altı.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_bes
			// 
			this.btn_bes.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bes.Location = new System.Drawing.Point(111, 402);
			this.btn_bes.Name = "btn_bes";
			this.btn_bes.Size = new System.Drawing.Size(100, 70);
			this.btn_bes.TabIndex = 10;
			this.btn_bes.Text = "5";
			this.btn_bes.UseVisualStyleBackColor = true;
			this.btn_bes.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_dort
			// 
			this.btn_dort.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_dort.Location = new System.Drawing.Point(5, 402);
			this.btn_dort.Name = "btn_dort";
			this.btn_dort.Size = new System.Drawing.Size(100, 70);
			this.btn_dort.TabIndex = 9;
			this.btn_dort.Text = "4";
			this.btn_dort.UseVisualStyleBackColor = true;
			this.btn_dort.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_carpi
			// 
			this.btn_carpi.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_carpi.Location = new System.Drawing.Point(323, 326);
			this.btn_carpi.Name = "btn_carpi";
			this.btn_carpi.Size = new System.Drawing.Size(100, 70);
			this.btn_carpi.TabIndex = 16;
			this.btn_carpi.Text = "*";
			this.btn_carpi.UseVisualStyleBackColor = true;
			this.btn_carpi.Click += new System.EventHandler(this.dort_islem);
			// 
			// btn_dokuz
			// 
			this.btn_dokuz.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_dokuz.Location = new System.Drawing.Point(217, 326);
			this.btn_dokuz.Name = "btn_dokuz";
			this.btn_dokuz.Size = new System.Drawing.Size(100, 70);
			this.btn_dokuz.TabIndex = 15;
			this.btn_dokuz.Text = "9";
			this.btn_dokuz.UseVisualStyleBackColor = true;
			this.btn_dokuz.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_sekiz
			// 
			this.btn_sekiz.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_sekiz.Location = new System.Drawing.Point(111, 326);
			this.btn_sekiz.Name = "btn_sekiz";
			this.btn_sekiz.Size = new System.Drawing.Size(100, 70);
			this.btn_sekiz.TabIndex = 14;
			this.btn_sekiz.Text = "8";
			this.btn_sekiz.UseVisualStyleBackColor = true;
			this.btn_sekiz.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_yedi
			// 
			this.btn_yedi.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_yedi.Location = new System.Drawing.Point(5, 326);
			this.btn_yedi.Name = "btn_yedi";
			this.btn_yedi.Size = new System.Drawing.Size(100, 70);
			this.btn_yedi.TabIndex = 13;
			this.btn_yedi.Text = "7";
			this.btn_yedi.UseVisualStyleBackColor = true;
			this.btn_yedi.Click += new System.EventHandler(this.rakam_girisleri);
			// 
			// btn_bolu
			// 
			this.btn_bolu.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_bolu.Location = new System.Drawing.Point(323, 250);
			this.btn_bolu.Name = "btn_bolu";
			this.btn_bolu.Size = new System.Drawing.Size(100, 70);
			this.btn_bolu.TabIndex = 20;
			this.btn_bolu.Text = "/";
			this.btn_bolu.UseVisualStyleBackColor = true;
			this.btn_bolu.Click += new System.EventHandler(this.dort_islem);
			// 
			// btn_ikikokx
			// 
			this.btn_ikikokx.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_ikikokx.Location = new System.Drawing.Point(217, 250);
			this.btn_ikikokx.Name = "btn_ikikokx";
			this.btn_ikikokx.Size = new System.Drawing.Size(100, 70);
			this.btn_ikikokx.TabIndex = 19;
			this.btn_ikikokx.Text = "2 √ x";
			this.btn_ikikokx.UseVisualStyleBackColor = true;
			this.btn_ikikokx.Click += new System.EventHandler(this.btn_ikikokx_Click);
			// 
			// btn_xkare
			// 
			this.btn_xkare.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_xkare.Location = new System.Drawing.Point(111, 250);
			this.btn_xkare.Name = "btn_xkare";
			this.btn_xkare.Size = new System.Drawing.Size(100, 70);
			this.btn_xkare.TabIndex = 18;
			this.btn_xkare.Text = "x^2";
			this.btn_xkare.UseVisualStyleBackColor = true;
			this.btn_xkare.Click += new System.EventHandler(this.btn_xkare_Click);
			// 
			// btn_1boluX
			// 
			this.btn_1boluX.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_1boluX.Location = new System.Drawing.Point(5, 250);
			this.btn_1boluX.Name = "btn_1boluX";
			this.btn_1boluX.Size = new System.Drawing.Size(100, 70);
			this.btn_1boluX.TabIndex = 17;
			this.btn_1boluX.Text = "1/x";
			this.btn_1boluX.UseVisualStyleBackColor = true;
			this.btn_1boluX.Click += new System.EventHandler(this.btn_1boluX_Click_1);
			// 
			// btn_silme
			// 
			this.btn_silme.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_silme.Location = new System.Drawing.Point(323, 174);
			this.btn_silme.Name = "btn_silme";
			this.btn_silme.Size = new System.Drawing.Size(100, 70);
			this.btn_silme.TabIndex = 24;
			this.btn_silme.Text = "<----";
			this.btn_silme.UseVisualStyleBackColor = true;
			this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
			// 
			// btn_C
			// 
			this.btn_C.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_C.Location = new System.Drawing.Point(217, 174);
			this.btn_C.Name = "btn_C";
			this.btn_C.Size = new System.Drawing.Size(100, 70);
			this.btn_C.TabIndex = 23;
			this.btn_C.Text = "C";
			this.btn_C.UseVisualStyleBackColor = true;
			this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
			// 
			// btn_CE
			// 
			this.btn_CE.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_CE.Location = new System.Drawing.Point(111, 174);
			this.btn_CE.Name = "btn_CE";
			this.btn_CE.Size = new System.Drawing.Size(100, 70);
			this.btn_CE.TabIndex = 22;
			this.btn_CE.Text = "CE";
			this.btn_CE.UseVisualStyleBackColor = true;
			this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
			// 
			// btn_yuzde
			// 
			this.btn_yuzde.Font = new System.Drawing.Font("SamsungOneUILatin 700", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_yuzde.Location = new System.Drawing.Point(5, 174);
			this.btn_yuzde.Name = "btn_yuzde";
			this.btn_yuzde.Size = new System.Drawing.Size(100, 70);
			this.btn_yuzde.TabIndex = 21;
			this.btn_yuzde.Text = "%";
			this.btn_yuzde.UseVisualStyleBackColor = true;
			this.btn_yuzde.Click += new System.EventHandler(this.btn_yuzde_Click);
			// 
			// Hesap_makinesi_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Goldenrod;
			this.ClientSize = new System.Drawing.Size(429, 629);
			this.Controls.Add(this.btn_silme);
			this.Controls.Add(this.btn_C);
			this.Controls.Add(this.btn_CE);
			this.Controls.Add(this.btn_yuzde);
			this.Controls.Add(this.btn_bolu);
			this.Controls.Add(this.btn_ikikokx);
			this.Controls.Add(this.btn_xkare);
			this.Controls.Add(this.btn_1boluX);
			this.Controls.Add(this.btn_carpi);
			this.Controls.Add(this.btn_dokuz);
			this.Controls.Add(this.btn_sekiz);
			this.Controls.Add(this.btn_yedi);
			this.Controls.Add(this.btn_cıkar);
			this.Controls.Add(this.btn_altı);
			this.Controls.Add(this.btn_bes);
			this.Controls.Add(this.btn_dort);
			this.Controls.Add(this.btn_topla);
			this.Controls.Add(this.btn_uc);
			this.Controls.Add(this.btn_iki);
			this.Controls.Add(this.btn_bir);
			this.Controls.Add(this.btn_esittir);
			this.Controls.Add(this.btn_virgul);
			this.Controls.Add(this.btn_sıfır);
			this.Controls.Add(this.txt_sayi_girisleri);
			this.Controls.Add(this.btn_artıeksi);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Hesap_makinesi_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "HesapMakinesi";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_artıeksi;
		private System.Windows.Forms.TextBox txt_sayi_girisleri;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btn_sıfır;
		private System.Windows.Forms.Button btn_virgul;
		private System.Windows.Forms.Button btn_esittir;
		private System.Windows.Forms.Button btn_topla;
		private System.Windows.Forms.Button btn_uc;
		private System.Windows.Forms.Button btn_iki;
		private System.Windows.Forms.Button btn_bir;
		private System.Windows.Forms.Button btn_cıkar;
		private System.Windows.Forms.Button btn_altı;
		private System.Windows.Forms.Button btn_bes;
		private System.Windows.Forms.Button btn_dort;
		private System.Windows.Forms.Button btn_carpi;
		private System.Windows.Forms.Button btn_dokuz;
		private System.Windows.Forms.Button btn_sekiz;
		private System.Windows.Forms.Button btn_yedi;
		private System.Windows.Forms.Button btn_bolu;
		private System.Windows.Forms.Button btn_ikikokx;
		private System.Windows.Forms.Button btn_xkare;
		private System.Windows.Forms.Button btn_1boluX;
		private System.Windows.Forms.Button btn_silme;
		private System.Windows.Forms.Button btn_C;
		private System.Windows.Forms.Button btn_CE;
		private System.Windows.Forms.Button btn_yuzde;
	}
}


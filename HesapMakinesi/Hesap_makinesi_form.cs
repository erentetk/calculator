using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
	public partial class Hesap_makinesi_form : Form
	{
		public Hesap_makinesi_form()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		decimal sayi1, sayi2;
		double sayi3;
		Boolean sonuclandı;
		string islem;

		private void btn_artıeksi_Click(object sender, EventArgs e)
		{
			if (txt_sayi_girisleri.Text.Length > 0)
			{
				if (txt_sayi_girisleri.Text.Substring(0, 1) == "-")
				{
					txt_sayi_girisleri.Text = txt_sayi_girisleri.Text.Substring(1);
				}
				else
				{
					//sayı pozitiftir negatif yapacaz
					txt_sayi_girisleri.Text = "-" + txt_sayi_girisleri.Text;
				}
			}
		}

		private void btn_virgul_Click(object sender, EventArgs e)
		{
			if (txt_sayi_girisleri.Text.IndexOf(",") <= 0)
			{
				if (txt_sayi_girisleri.Text.Length == 0)
				{
					txt_sayi_girisleri.Text = "0";
				}
				else
				{
					txt_sayi_girisleri.Text = txt_sayi_girisleri.Text + ",";
				}
			}
		}

		private void btn_xkare_Click(object sender, EventArgs e)
		{

			sayi3 = Convert.ToInt32(txt_sayi_girisleri.Text);
			txt_sayi_girisleri.Text = Math.Pow(sayi3, 2).ToString();
			//txt_sayi_girisleri.Text=sayı.ToString();
			//txt_sayi_girisleri = (txt_sayi_girisleri.Text) * (txt_sayi_girisleri.Text);
			//txt_sayi_girisleri = Convert.ToInt32(txt_sayi_girisleri.Text);
			//txt_sayi_girisleri =Math.Sqrt(Convert.ToInt32(txt_sayi_girisleri.Text));
		}

		private void btn_ikikokx_Click(object sender, EventArgs e)
		{

			sayi3 = Convert.ToInt32(txt_sayi_girisleri.Text);
			txt_sayi_girisleri.Text = Math.Sqrt(sayi3).ToString();
		}

		private void txt_sayi_giris_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) == false) // klavyeden girilen  degerin rakam olup olmadıgını kontorol ediyoruz
			{
				e.Handled = true;
			}
		}

		private void dort_islem(object sender, EventArgs e)
		{
			islem = (sender as Button).Name;
			if (txt_sayi_girisleri.Text.Length == 0)
			{
				txt_sayi_girisleri.Text = ("");
			}


			sayi1 = Convert.ToDecimal(txt_sayi_girisleri.Text);
			txt_sayi_girisleri.Text = "";

		}
		private void btn_esittir_Click(object sender, EventArgs e)
		{
			sayi2 = Convert.ToDecimal(txt_sayi_girisleri.Text);
			if (islem == "btn_bolu")
			{
				txt_sayi_girisleri.Text = (sayi1 / sayi2).ToString();
			}
			if (islem == "btn_carpi")
			{
				txt_sayi_girisleri.Text = (sayi1 * sayi2).ToString();
			}
			if (islem == "btn_cıkar")
			{
				txt_sayi_girisleri.Text = (sayi1 - sayi2).ToString();
			}
			if (islem == "btn_topla")
			{
				txt_sayi_girisleri.Text = (sayi1 + sayi2).ToString();
			}
		}
		private void rakam_girisleri(object sender, EventArgs e)
		{
			if (sonuclandı)
			{
				txt_sayi_girisleri.Text = (sender as Button).Text;
				sonuclandı = false;
			}
			else
			{
				txt_sayi_girisleri.Text = txt_sayi_girisleri.Text + (sender as Button).Text;
			}
		}

		private void btn_CE_Click(object sender, EventArgs e)
		{
			txt_sayi_girisleri.Text = "";
		}

		private void btn_C_Click(object sender, EventArgs e)
		{
			txt_sayi_girisleri.Text = "";
		}

		private void btn_silme_Click(object sender, EventArgs e)
		{
			txt_sayi_girisleri.Text=txt_sayi_girisleri.Text.Substring(0,txt_sayi_girisleri.TextLength-1);
		}

		private void btn_yuzde_Click(object sender, EventArgs e)
		{
			decimal say = Convert.ToDecimal(txt_sayi_girisleri.Text);
			say = say/ 100;
			txt_sayi_girisleri.Text=say.ToString();
		}

		private void btn_1boluX_Click_1(object sender, EventArgs e)
		{
			decimal say = Convert.ToDecimal(txt_sayi_girisleri.Text);
			say = 1/say;
			txt_sayi_girisleri.Text = say.ToString();
		}

	}
}


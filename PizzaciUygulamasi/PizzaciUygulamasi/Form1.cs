using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciUygulamasi
{
    public partial class Form1 : Form
    {
        public string ad, telefon, adres,icecek,pizzaBoy,ekstraAdi;
        public int pizzaSayisi = 0, icecekSayisi = 0, ekstraSayisi = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            adSoyadTxt.Text = "";
            TelefonTxt.Text = "";
            PizzaBoyCmbx.Text = "";
            icecekCmbx.Text = "";
            icecekSayi.Value=0;
            pizzaSayi.Value = 0;
            ekstraAdi = string.Empty;
            adresTxt.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adSoyadListBox.Items.Clear();
            telefonListBOx.Items.Clear();
            adresListBox.Items.Clear();
            PizzaBoyAdetListbox.Items.Clear();
            ekstraListBox.Items.Clear();
            icecekAdetListBox.Items.Clear();
            ucretListBox.Items.Clear();
        }

        public int toplamFiyat = 0;

        private void ekstraSec(object sender, EventArgs e)
        {
            CheckBox ekstra = (CheckBox) sender;
            ekstraAdi += ekstra.Text+" ";
            toplamFiyat += (ekstraSayisi++);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void siparisiAlButton_Click(object sender, EventArgs e)
        {
            ad = adSoyadTxt.Text;
            telefon = TelefonTxt.Text;
            adres = adresTxt.Text;
            icecek = icecekCmbx.Text;
            pizzaBoy = PizzaBoyCmbx.Text;
            pizzaSayisi = int.Parse(pizzaSayi.Text);
            icecekSayisi = int.Parse(icecekSayi.Text);
            pizza();
            iceceks();
            yazdir();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            ekstraAdi = string.Empty;
            

        }

        private void pizza()
        {
            if (pizzaBoy == "Büyük")
            {
                toplamFiyat += 15 * pizzaSayisi;
            }
            else if (pizzaBoy == "Orta")
            {
                toplamFiyat += 10 * pizzaSayisi;
            }
            else if (pizzaBoy == "Küçük")
            {
                toplamFiyat += 8 * pizzaSayisi;
            }
        }

        private void iceceks()
        {
            if (icecek == "Kola")
            {
                toplamFiyat += 4 * icecekSayisi;
            }
            else if (icecek == "Su")
            {
                toplamFiyat += 2 * icecekSayisi;
            }
            else if (icecek == "Fanta")
            {
                toplamFiyat += 4 * icecekSayisi;
            }
            else if (icecek == "Sprite")
            {
                toplamFiyat += 5 * icecekSayisi;
            }
        }

        private void yazdir()
        {
            adSoyadListBox.Items.Add(ad);
            telefonListBOx.Items.Add(telefon);
            adresListBox.Items.Add(adres);
            PizzaBoyAdetListbox.Items.Add(pizzaBoy +" Adet:"+ pizzaSayisi.ToString());
            ekstraListBox.Items.Add(ekstraAdi);
            icecekAdetListBox.Items.Add(icecek + " Adet:" + icecekSayisi.ToString());
            ucretListBox.Items.Add(toplamFiyat.ToString()+" "+"TL");
        }
    }
}

using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class yonetici : Form
    {
        
        metod2 mtt = new metod2();
        public yonetici()
        {
            InitializeComponent();
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            string prsnltakip= "Server=localhost;DATABASE=prsnltakip;UID=root;PWD=''";
            using (var baglan = new MySqlConnection(prsnltakip))
            {
                using (var komut =new MySqlCommand("SELECT * FROM yonetici ",baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        while(dr.Read())
                        {
                            comboBox1.Items.Add(dr["kullaniciadi"].ToString());
                           

                        }
                        comboBox1.SelectedIndex= 0;
                    }
                    catch(Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int hak = 3;
           if (hak !=1)
            {
                if (mtt.KullaniciKontrol(comboBox1.SelectedItem.ToString(), textBox1.Text) == 1)
                {
                    anafrmyonetici anf= new anafrmyonetici();
                    anf.lblkullanici.Text = this.comboBox1.SelectedItem.ToString();
                    anf.Text = "Merhaba," + this.comboBox1.SelectedItem.ToString();
                    this.Hide();
                    anf.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı","hata" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (durum == false)
                hak--;
            {
                label4.Text = Convert.ToString(hak);
                if(hak == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Giriş Hakkınız Kalmadı!", "Personel Takip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        
        bool durum = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}

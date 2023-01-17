using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace deneme
{
    public partial class login : Form
    {
        metod mtt= new metod(); 
        public login()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            string prsnltakip = "Server=localhost;DATABASE=prsnltakip;UID=root;PWD=''";
            using (var baglan = new MySqlConnection(prsnltakip))
            {  /*comboBox kullaniciadlarini çektik*/
                using (var komut = new MySqlCommand("SELECT * FROM kullanici ", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr= komut.ExecuteReader();
                        while(dr.Read())
                        {
                            comboBox1.Items.Add(dr["kullaniciadi"].ToString());
                        }
                        comboBox1.SelectedIndex= 0;
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (hak != 0)
            {
                if (mtt.KullaniciKontrol(comboBox1.SelectedItem.ToString(), textBox2.Text) == 1)
                {
                    // MessageBox.Show("giriş başarılı","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    anaform af = new anaform();
                    af.lblkullanici.Text = this.comboBox1.SelectedItem.ToString();
                    af.Text = "Merhaba," + this.comboBox1.SelectedItem.ToString();
                    this.Hide();
                    af.Show();
                    

                }
                else
                {
                    MessageBox.Show("giriş yapılamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (durum == false)
                hak--;
            {
                label5.Text = Convert.ToString(hak);
                if (hak == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Giriş Hakkınız Kalmadı!","Personel Takip", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                }
            }
               
            
        }
        int hak = 3;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool durum = false;
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            yonetici yntc = new yonetici();
            yntc.Show();
            this.Hide();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

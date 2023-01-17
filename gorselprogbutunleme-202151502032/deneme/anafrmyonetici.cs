using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace deneme
{
    public partial class anafrmyonetici : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=prsnltakip;Uid=root;Pwd=''");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        string cinsiyet;

        public anafrmyonetici()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM kullanici", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void anafrmyonetici_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Ayarları Paneli";
            VeriGetir();
            radioButton1.Checked = true;
            textBox7.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                MySqlCommand gnclm = new MySqlCommand("update kullanici set tcno='" + textBox2.Text + "',adi='" + textBox3.Text + "',soyadi='" + textBox4.Text + "',kullaniciadi='" + textBox5.Text + "',cinsiyet='" + cinsiyet + "',bolum='" + comboBox1.Text + "',sifre='" + textBox6.Text + "' where kullanici_id='" + textBox7.Text+"'",conn );
                conn.Open();
                if (gnclm.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Kullanıcı Bilgileri Güncellendi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileri Güncellenemedi");
                }
                conn.Close();
                VeriGetir();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "K";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "E";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string cins = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (cins== "E")
                {
                    radioButton1.Checked=true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked= false;
                    radioButton2.Checked= true;
            
                }
                comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                this.dataGridView1.Columns["sifre"].Visible = false;


            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand ekle = new MySqlCommand("Insert into kullanici(tcno,adi,soyadi,kullaniciadi,cinsiyet,bolum,sifre) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+cinsiyet+"','"+comboBox1.Text+"','" + textBox6.Text + "')", conn);
            conn.Open();
            if (ekle.ExecuteNonQuery() == 1) 
            
                MessageBox.Show("Kullanıcı Eklendi");
            
            else
                MessageBox.Show("Kullanıcı Eklenemedi");
            conn.Close();
            VeriGetir();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(" delete from kullanici where kullanici_id=@kimlik", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@kimlik", textBox7.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            conn.Close();
            VeriGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = dt.DefaultView;
            dv.RowFilter = "adi LIKE '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yonetici yntc = new yonetici();
            yntc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maas ms = new maas();
            ms.Show();
            this.Hide();
        }
    }

}   

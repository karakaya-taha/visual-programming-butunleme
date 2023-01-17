using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace deneme
{
    public partial class maas : Form
    {
        
        public maas()
        {
            InitializeComponent();
        }
       
        


        

     
        private void maas_Load(object sender, EventArgs e)
        {
           
       


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == "Emirhan Yalçın")
            {
                listBox1.Items.Add("8.000₺");
                
            }
            if (comboBox1.Text == "Serdar Saka")
            {
                listBox1.Items.Add("20.000₺");

            }
            if (comboBox1.Text == "Mehmet Bülbül")
            {
                listBox1.Items.Add("20.000₺");

            }
            if (comboBox1.Text == "Zafer Dağ")
            {
                listBox1.Items.Add("15.000₺");

            }
            if (comboBox1.Text == "Ahmet Ertan")
            {
                listBox1.Items.Add("10.000₺");

            }
            if (comboBox1.Text == "Ömer Faruk Kakıcı")
            {
                listBox1.Items.Add("16.000₺");

            }
            if (comboBox1.Text == "Akif Döne")
            {
                listBox1.Items.Add("13.000₺");

            }
            if (comboBox1.Text == "Berkay Mutlu")
            {
                listBox1.Items.Add("7.000₺");

            }
            if (comboBox1.Text == "Furkan Atalay")
            {
                listBox1.Items.Add("12.000₺");

            }
            if (comboBox1.Text == "ibrahim Atalay")
            {
                listBox1.Items.Add("3.000₺");

            }
            if (comboBox1.Text == "Yücel Fil")
            {
                listBox1.Items.Add("9.000₺");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anafrmyonetici afy = new anafrmyonetici();
            afy.Show();
            this.Hide();
        }
    }
}

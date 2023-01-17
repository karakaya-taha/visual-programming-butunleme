using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class yemekmenu : Form
    {
        public yemekmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == "Pazartesi") 
            {
                listBox1.Items.Add("Mercimek Çorbası");
                listBox1.Items.Add("Tas Kebabı");
                listBox1.Items.Add("Pirinç Pilavı");
                listBox1.Items.Add("Cacık");
            }
            if (comboBox1.Text == "Salı")
            {
                listBox1.Items.Add("Tarhana Çorbası");
                listBox1.Items.Add("Tavuk Sote");
                listBox1.Items.Add("Makarna");
                listBox1.Items.Add("Yoğurt");
            }
            if (comboBox1.Text == "Çarşamba")
            {
                listBox1.Items.Add("Ezogelin Çorbası");
                listBox1.Items.Add("Kuru Fasulye");
                listBox1.Items.Add("Pirinç Pilavı");
                listBox1.Items.Add("Yoğurt");
            }
            if (comboBox1.Text == "Perşembe")
            {
                listBox1.Items.Add("Yoğurt Çorbası");
                listBox1.Items.Add("Karnıyarık");
                listBox1.Items.Add("Bulgur Pilavı");
                listBox1.Items.Add("salata");
            }
            if (comboBox1.Text == "Cuma")
            {
                listBox1.Items.Add("Şehriye Çorbası");
                listBox1.Items.Add("Taze Fasulye");
                listBox1.Items.Add("Yoğurtlu Makarna");
                listBox1.Items.Add("Cacık");
            }
            if (comboBox1.Text == "Cumartesi")
            {
                listBox1.Items.Add("Düğün Çorbası");
                listBox1.Items.Add("Et Sote");
                listBox1.Items.Add("Pirinç Pilavı");
                listBox1.Items.Add("Cacık");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaform af = new anaform();
            af.Show();
            this.Hide();
        }
    }
}

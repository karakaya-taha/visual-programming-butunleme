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
    public partial class anaform : Form
    {
        public class Kur
        {
            public string metal { get; set; }
            public decimal buy { get; set; }
            public decimal sell { get; set; }
            public decimal change { get; set; }
            public DateTime time { get; set; }
        }

        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kurlar kur = new kurlar();
            kur.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calismasaatleri cs = new calismasaatleri();
            cs.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            yemekmenu ym= new yemekmenu();
            ym.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}

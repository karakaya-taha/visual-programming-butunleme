using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; 

namespace deneme
{
    public partial class kurlar : Form
    {
        public kurlar()
        {
            InitializeComponent();
        }

        private void kurlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml"; 
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod= 'USD']/BanknoteSelling").InnerXml;
            label1.Text = string.Format("Tarih {0} USD; {1}" , tarih.ToShortDateString(), USD);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod= 'EUR']/BanknoteSelling").InnerXml;
            label2.Text = string.Format("Tarih {0} EURO; {1}", tarih.ToShortDateString(),EURO);

            string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod= 'GBP']/BanknoteSelling").InnerXml;
            label3.Text = string.Format("Tarih {0} POUND; {1}", tarih.ToShortDateString(), POUND);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaform anf = new anaform();
            anf.Show();
            this.Hide();
        }
    }
    
}

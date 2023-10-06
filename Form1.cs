using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcKimlikDogrulamaWC.TCKNService;

namespace TcKimlikDogrulamaWC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient proxy = new KPSPublicSoapClient();
            bool vertify = proxy.TCKimlikNoDogrula(Convert.ToInt64(txbTc.Text), txbAd.Text.ToUpper(), txbSoyad.Text.ToUpper(), Convert.ToInt32(txbDogumYili.Text));
            MessageBox.Show(vertify.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbTc.PasswordChar = '*';
            txbDogumYili.PasswordChar = '*';
        }
    }
}

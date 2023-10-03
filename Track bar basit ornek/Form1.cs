using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_bar_basit_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblBar.Text = tbSeviye.Value.ToString();

            if (tbSeviye.Value <=20)
            {
                lblSes.Text = "Ses seviyesi:  Çok Kısık" + tbSeviye.Value.ToString();
                this.BackColor = Color.Green;
            }
            if (tbSeviye.Value > 20 && tbSeviye.Value <= 40)
            {
                lblSes.Text = "Ses seviyesi: Kısık" + tbSeviye.Value.ToString();
                this.BackColor = Color.Green;
            }
            if (tbSeviye.Value > 40 && tbSeviye.Value <= 50)
            {
                lblSes.Text = "Ses seviyesi: Orta" + tbSeviye.Value.ToString();
                this.BackColor = Color.Yellow;
            }
            if (tbSeviye.Value > 50 && tbSeviye.Value <= 75)
            {
                lblSes.Text = "Ses seviyesi: Yüksek" + tbSeviye.Value.ToString();
                this.BackColor = Color.Red;
            }
            if (tbSeviye.Value >75 && tbSeviye.Value <=100)
            {
                lblSes.Text = "Ses seviyesi: Çok Yüksek" + tbSeviye.Value.ToString();
                this.BackColor = Color.Red;
            }

        }
    }
}

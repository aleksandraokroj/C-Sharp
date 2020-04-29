using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong m = ulong.Parse(textBox1.Text);
            ulong n = ulong.Parse(textBox2.Text);
            ulong roznica;
            do
            {
                roznica = m > n ? m - n : n - m;
                if (n > m)
                    n = roznica;
                else
                    m = roznica;

            }
            while (roznica != 0);
            label3.Text = "Największy wspólny dzielnik podanych liczb to " + n;
        }
    }
}

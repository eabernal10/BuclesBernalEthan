using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuclesBernalEthan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BaseN = Convert.ToInt32(txtBase.Text);
            int ExpoNum = Convert.ToInt32(this.txtExponente.Text);
            int resultado = 1;
            int k = 0;

            do
            {
                resultado *= BaseN;
                k++;
            } while (k < ExpoNum);

            this.txtResultado.Text = resultado.ToString();

        }
    }
}

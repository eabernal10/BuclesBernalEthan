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
    public partial class frmDecimal_a_binario : Form
    {
        public frmDecimal_a_binario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(this.txtDecimal.Text);
            int[] vector = new int[16];
            int k = 0;
            if (numero >= 0 && numero <= 65535)
            {
                while (numero > 0)
                {
                    int resto = numero % 2;
                    vector[k] = resto;


                    numero /= 2;
                    k++;

                    lstBinario.Items.Add(resto);
                }
            }
            else
            {
                MessageBox.Show("No esta en el rango");
            }
        }
    }
}

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
    public partial class frmDecimal_a_Binario_chkbox : Form
    {
        public frmDecimal_a_Binario_chkbox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

                    this.chk1.Checked = (vector[0] == 1) ? true : false;
                    this.chk2.Checked = (vector[1] == 1) ? true : false;
                    this.chk3.Checked = (vector[2] == 1) ? true : false;
                    this.chk4.Checked = (vector[3] == 1) ? true : false;
                    this.chk5.Checked = (vector[4] == 1) ? true : false;
                    this.chk6.Checked = (vector[5] == 1) ? true : false;
                    this.chk7.Checked = (vector[6] == 1) ? true : false;
                    this.chk8.Checked = (vector[7] == 1) ? true : false;
                    this.chk9.Checked = (vector[8] == 1) ? true : false;
                    this.chk10.Checked = (vector[9] == 1) ? true : false;
                    this.chk11.Checked = (vector[10] == 1) ? true : false;
                    this.chk12.Checked = (vector[11] == 1) ? true : false;
                    this.chk13.Checked = (vector[12] == 1) ? true : false;
                    this.chk14.Checked = (vector[13] == 1) ? true : false;
                    this.chk15.Checked = (vector[14] == 1) ? true : false;
                    this.chk16.Checked = (vector[15] == 1) ? true : false;
                }
                }
                else
                {
                    MessageBox.Show("No esta en el rango");
                }
            }
        }
    }


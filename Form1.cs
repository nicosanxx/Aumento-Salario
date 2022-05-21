using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aumento_salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //DECLARANDO E DANDO VALORES

            decimal salario = Convert.ToDecimal(txt_salario.Text);
            decimal aumento = Convert.ToDecimal(txt_salario.Text);

            if (aumento >= 5000)
            {

                aumento = salario * 10 / 100;
                txt_aumento.Text = aumento.ToString();
                
            }

            else if(aumento < 5000 && aumento>= 2000)
            {

                aumento = salario * 20 / 100;
                txt_aumento.Text = aumento.ToString();

            }

            else
            {

                aumento = salario * 30 / 100;
                txt_aumento.Text = aumento.ToString();
 
            }



        }
    }
}

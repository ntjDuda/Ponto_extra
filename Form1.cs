using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_pg15_16_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txt_valor.Text);
            int quantidade = int.Parse(txt_quantidade.Text);
            float total = valor * quantidade;
            float total_desconto;

            if (quantidade <= 5)
            {
                total_desconto = total - (total * 2 / 100);
                MessageBox.Show(" O valor total com o desconto vai ser de : " + total_desconto);
            }
            else if ((quantidade <= 6) && (quantidade >= 10))
            {
                total_desconto = total - ( total * 3/ 100);
                MessageBox.Show(" O valor total com a taxa aplicada será de: " + total_desconto);
            }
            
            else
            {
                total_desconto = total - ( total * 5/100);
                MessageBox.Show(" O valor total com a taxa aplicada será de: " + total_desconto);
            }
             

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

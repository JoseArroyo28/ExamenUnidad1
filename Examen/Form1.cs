using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index <= 25)
            {
                ListBox ltv = new ListBox();
                ltv.Items.Add(" " + index);
                listBox1.Items.Add(index);
                index++;
            }
            else
            {
                MessageBox.Show("Limite de Numeros");
            }
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                ListBox ltv = new ListBox();
                ltv.Items.Add(" " + index);
                listBox1.Items.RemoveAt(index-1);
                index--;
            }
            else
            {
                MessageBox.Show("No hay Numeros");
            }
        }
    }
}

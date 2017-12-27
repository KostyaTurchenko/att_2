using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SymbolCode instance = new SymbolCode(textBox1.Text);

            label1.Text = instance.GetSymbol1();

            label2.Text = instance.GetSymbol2();
        }
    }
}

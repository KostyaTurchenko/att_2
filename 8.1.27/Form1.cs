using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _8._1._27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            int n = (int)numericUpDown1.Value;
            ChangeList instance = new ChangeList(n);           
            list1 = instance.List1generation(n);
            list2 = instance.List2generation(n);
            var list3 = instance.CreateNewList(list1, list2);
            label1.Text = string.Join(", ", list1);
            label2.Text = string.Join(", ", list2);
            label3.Text = string.Join(", ", list3);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

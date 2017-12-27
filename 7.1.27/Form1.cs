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

namespace _7._1._27
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void generation_Click(object sender, EventArgs e)
        {
            WorkWithCoords instance = new WorkWithCoords();
            BL.Point[] arrcoords = WorkWithCoords.RandomGeneration((int)numericUpDown1.Value);
            label1.Text = string.Format("{0}; {1}", instance.FirstQminSto00(arrcoords).X, instance.FirstQminSto00(arrcoords).Y);
            label2.Text = string.Format("{0}; {1}", instance.SecQminSto00(arrcoords).X, instance.SecQminSto00(arrcoords).Y);
            label3.Text = string.Format("{0}; {1}", instance.ThirdQminto00(arrcoords).X, instance.ThirdQminto00(arrcoords).Y);
            label4.Text = string.Format("{0}; {1}", instance.FourthQminSto00(arrcoords).X, instance.FourthQminSto00(arrcoords).Y);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

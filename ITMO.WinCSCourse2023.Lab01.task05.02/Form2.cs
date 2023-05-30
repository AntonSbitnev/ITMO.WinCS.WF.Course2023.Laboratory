using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO_Course_WinCS_Lab1_05_02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rhombus newRomb = new Rhombus();
            newRomb.Show();
        }
    }
}

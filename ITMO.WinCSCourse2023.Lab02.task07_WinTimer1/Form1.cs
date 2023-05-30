using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.Lab02.task07_WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, UserControlTimer userControlTimer)
        {
            if (userControlTimer1.TimeEnabled) 
            {
            userControlTimer1.TimeEnabled = false;
                button1.Text = "START";
            }
            else
            {
                userControlTimer1.TimeEnabled = true;
                button1.Text = "STOP";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled) 
            {
             userControlTimer1.TimeEnabled=false;
                button1.Text = "START";
            }
            else 
            { userControlTimer1.TimeEnabled=true;
                button1.Text = "STOP";
            }
        }
    }
}

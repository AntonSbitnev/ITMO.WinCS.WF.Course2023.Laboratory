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
    public partial class Rhombus : Form
    {
        public Rhombus()
        {
            InitializeComponent();
        }
        //static Bitmap b = new Bitmap(400, 200);
        //static Graphics g = Graphics.FromImage(b);
        //Romb E = new Romb(10, 20, 100, 70);
        //Point[] p;

        private void Romb_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(400, 20), new Point(650, 270), new Point(400, 520), new Point(150, 270) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

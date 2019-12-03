using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game1.func;

namespace game1
{
    public partial class Form1 : Form
    {
        ArrayList stars;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rendorter.isRun = !Rendorter.isRun;
            button1.Text = Rendorter.isRun.ToString();
        }


        private void NewMethod(PaintEventArgs e)
        {
            SolidBrush sb;
            Rectangle r;
            foreach (CStar s in stars)
            {
                sb = new SolidBrush(s.GetColor);
                r = new Rectangle(s.GetPoint, s.GetSize);
                e.Graphics.FillEllipse(sb, r);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitStars();

            g = this.CreateGraphics();
        }

        private void InitStars()
        {
            stars = new ArrayList();
            CStar s = new CStar(100, 200, 50, 50, 0, Color.FromArgb(100, Color.Red));
            stars.Add(s);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            func.Rendorter.Rendort(g, stars);
        }
    }
}

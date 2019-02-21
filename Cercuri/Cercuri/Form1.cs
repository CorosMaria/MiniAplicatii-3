using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cercuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0, j = 0;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_rosu;
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
            Desen.Clear(this.BackColor);
            do
            {
                i = 0;
                do
                {
                    Desen.DrawEllipse(Creion_rosu, i, j, 25, 25);
                    i += 30;
                } while (i <= this.Width - 30);
                j += 30;
            } while (j <= this.Height - 50);
        }
    }
}

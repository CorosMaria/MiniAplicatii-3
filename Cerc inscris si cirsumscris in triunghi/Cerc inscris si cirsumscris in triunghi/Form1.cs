using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cerc_inscris_si_cirsumscris_in_triunghi
{
    public partial class Form1 : Form
    {
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_albastru;

        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point [] Triunghi = new Point []
            {
                new Point {X = 190, Y = 65}, new Point {X = 105, Y = 290},
                new Point {X = 290, Y = 290}, new Point {X= 190, Y=65}
            };
            Desen.DrawPolygon(Creion_albastru, Triunghi);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(this.radioButton1.Checked)
                Desen.DrawEllipse(Creion_albastru, 65, 65, 260, 260);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton2.Checked)
                Desen.DrawEllipse(Creion_albastru, )
        }
    }
}

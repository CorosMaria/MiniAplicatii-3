using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ceas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_rosu;
        System.Drawing.Pen Creion_albastru;
        System.Drawing.SolidBrush Radiera;
        int i, x0, y0, w, alfa, xc, yc, x, y, alfa_i;
        double alfar, alfa_m;

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1, y1, u;
            int secunde, ora;
            ora = System.DateTime.Now.Minute;
            secunde = System.DateTime.Now.Second;
            this.label1.Text = Convert.ToString(ora)+ ":" + Convert.ToString(secunde);
            Desen.FillEllipse(Radiera, x0 + 1, y0 + 1, w - 2, w - 2);

            for (u = 1; u <= 60; u++)
            {

                x = xc + System.Convert.ToInt16((w -8)/ 2  * (Math.Cos(u )));
                y = yc - System.Convert.ToInt16((w - 8) / 2  * (Math.Sin(u )));

                x1 = xc + System.Convert.ToInt16((w + 8) / 2  * (Math.Cos(u )));
                y1 = yc - System.Convert.ToInt16((w + 8) / 2  * (Math.Sin(u )));
                Desen.DrawLine(Creion_rosu, x, y, x1, y1);
            }





                alfar = System.Math.PI / 2 - System.Math.PI / 30 * secunde;
                x = xc + System.Convert.ToInt16(w / 2 * (Math.Cos(alfar)));
                y = yc - System.Convert.ToInt16(w / 2 * (Math.Sin(alfar)));
                Desen.DrawLine(Creion_rosu, xc, yc, x, y);

                alfa_m = System.Math.PI / 4 - System.Math.PI / 60 * ora;
                x = xc + System.Convert.ToInt16(w / 2 * (Math.Cos(alfa_m)));
                y = yc - System.Convert.ToInt16(w / 2 * (Math.Sin(alfa_m)));
                Desen.DrawLine(Creion_rosu, xc, yc, x, y);
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

            
            Desen = this.CreateGraphics();
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.BlueViolet);
            Radiera = new System.Drawing.SolidBrush(this.BackColor);
            x0 = 100;//coordonata x a cercului
            y0 = 100;//coordonata y a cercului
            w = 200;//Diametrul cercului
            xc = x0 + w / 2;//Deplasarea 
            yc = y0 + w / 2;
            Desen.DrawEllipse(Creion_rosu, x0, y0, w, w);

            
        }
    }
}
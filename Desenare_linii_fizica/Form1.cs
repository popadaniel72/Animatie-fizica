using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare_linii_fizica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int baza, lung, stg = 10;
        Pen rosu = new Pen(Color.Red, 1);
        Pen verde = new Pen(Color.Green, 1);
        Pen albastru = new Pen(Color.Blue, 1);
        Pen galben = new Pen(Color.Yellow, 1);
        double accX, accY, vitX, vitY, miu, masa, ag=9.81;
        int forta, unghi, lu = 50, la = 30, x, y, dv=10;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            x = 2 * stg;
            y = baza - 1;
            accX = accY = vitX = vitY = 0;
            masa = ValMasa.Value;
            unghi = ValUnghi.Value;
            forta = ValForta.Value;
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (accX > 0)
            {
                vitX += accX * (1.0 / timer1.Interval)*dv;
                x += (int)(vitX * (1.0 / timer1.Interval));
            }
            if (accY > 0)
            {
                vitY += accY * (1.0 / timer1.Interval)*dv;
                y -= (int)(vitY * (1.0 / timer1.Interval));
            }
            this.Invalidate();
            if (x > this.Width || y<20) timer1.Enabled = false;
                   }

        private void button1_Click(object sender, EventArgs e)
        {
            accX = (forta * Math.Cos(unghi * Math.PI / 180) - masa * miu * ag)/masa;
            accY = (forta * Math.Sin(unghi * Math.PI / 180) - masa * ag) / masa;
            vitX = vitY = 0;
            if (accX <= 0 && accY <= 0) MessageBox.Show("Nu se mișcă ");
            else timer1.Enabled = true;
        }

        private void ValMasa_Scroll(object sender, ScrollEventArgs e)
        {
            AfMasa.Text = (ValMasa.Value / 10.0).ToString() + " Kg";
            masa = ValMasa.Value / 10.0;
            this.Invalidate();
        }

        private void ValMiu_Scroll(object sender, ScrollEventArgs e)
        {
            AfMiu.Text = (ValMiu.Value / 100.0).ToString();
            miu = ValMiu.Value / 100.0;
            this.Invalidate();
        }

        private void ValForta_Scroll(object sender, ScrollEventArgs e)
        {
            AfForta.Text = ValForta.Value.ToString()+" N";
            forta = ValForta.Value;
            this.Invalidate();
        }

        
        private void ValUnghi_Scroll(object sender, ScrollEventArgs e)
        {
            AfUnghi.Text = ValUnghi.Value.ToString();
            unghi = ValUnghi.Value;
            this.Invalidate();
        }

        
        // x,y= punct de aplicare, u-unghi, l-lungime vector, cul-culoare, e- suport desen
        void dVector(int x, int y, int u, int l, Pen cul, PaintEventArgs e)
        {
            int a = 30, vv = 10; //a = unghiul varfului, vv= lungimea varf
            double dx, dy;
            int xv, yv;
            // desen linie principala
            dx = l * Math.Cos(u * Math.PI / 180);
            dy = l * Math.Sin(u * Math.PI / 180);
            xv = x + (int)dx; // xv, yv - coordonatele varfului
            yv = y - (int)dy;
            e.Graphics.DrawLine(cul, x, y, xv , yv );
            // desen varf
            dx = vv * Math.Cos((u + 180 - a) * Math.PI / 180);
            dy = vv * Math.Sin((u + 180 - a) * Math.PI / 180);
            e.Graphics.DrawLine(cul, xv, yv, xv + (int)dx, yv - (int)dy);
            dx = vv * Math.Cos((u + 180 + a) * Math.PI / 180);
            dy = vv * Math.Sin((u + 180 + a) * Math.PI / 180);
            e.Graphics.DrawLine(cul, xv, yv, xv + (int)dx, yv - (int)dy);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            baza = this.Height - 50;
            lung = this.Width - 3 * stg;
            this.Invalidate();
            x = 2 * stg;
            y = baza-1;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            baza = this.Height - 50;
            lung = this.Width - 3 * stg;
            x = 2 * stg;
            y = baza -1;
            accX = accY = vitX = vitY = 0;
            masa = 0.1;
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // desenez baza
            e.Graphics.DrawLine(albastru, stg, baza, lung, baza);
            // desenez corpul
            e.Graphics.DrawRectangle(verde, x, y-la, lu,  la);
            // desenez vectorul forta
            dVector(x + lu / 2, y - la / 2, unghi, forta, rosu, e);
            //desenez vectorul forta de frecare
            dVector(x + lu / 2, y - la / 2, 180, (int)(miu*ag*masa), galben, e);
        }
    }
}

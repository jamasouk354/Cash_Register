using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register 
{
    public partial class Form1 : Form
    {
        const double PLATES_COST = 2.49;
        const double DESSERTS_COST = 1.89;
        const double DRINKS_COST = 0.99;
        const double HST = 0.13;

        double plates, desserts, drinks;
        double orderCost, taxAmount, totalCost, tendered, change;



        public Form1()
        {
            InitializeComponent();
        }

        private void printReciptButton_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 2);
            SolidBrush drawBrush = new SolidBrush(Color.GhostWhite);
            Font drawFont = new Font("Consolas", 11, FontStyle.Bold);

            g.FillRectangle(drawBrush, 200, 30, 215, 20);
            Thread.Sleep(250);
            g.FillRectangle(drawBrush, 200, 50, 215, 20);
            drawBrush = new SolidBrush(Color.Black);
            g.DrawString("Dinning Place", drawFont, drawBrush, 250, 50);
            Thread.Sleep(250);
            drawBrush = new SolidBrush(Color.GhostWhite);
            g.FillRectangle(drawBrush, 200, 70, 215, 20);
            Thread.Sleep(250);
            g.FillRectangle(drawBrush, 200, 90, 215, 20);
            Thread.Sleep(250);
            g.FillRectangle(drawBrush, 200, 110, 215, 20);
            drawFont = new Font("Consolas", 10);
            drawBrush = new SolidBrush(Color.Black);
            g.DrawString("Dinning Place", drawFont, drawBrush, 205, 110);
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {

        }

        private void totalCostOutput_Click(object sender, EventArgs e)
        {
            totalCostOutput.Text = "Sub Total";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expenditure_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        public void plot_random_chart()
        {
            Random r = new Random();

            Bunifu.DataViz.Data data = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint income = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);
   Bunifu.DataViz.DataPoint expenditure= new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.spline);
         
            for (int i = 0; i < 10; i++)
            {
                int v = r.Next(0, 100);
                expenditure.addLabely(i.ToString(), v.ToString());
                income.addLabely(i.ToString(), (v+r.Next(0,50)).ToString());
            }

            data.addData(income);
            data.addData(expenditure);

            bunifuCharts1.Render(data);

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            plot_random_chart();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            plot_random_chart();
        }
    }
}

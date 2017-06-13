using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYS_Outgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {

            //Soft launch
            double slCompletes = 0;
            double.TryParse(this.slCompletes.Text, out slCompletes);
            var slIR = double.Parse(this.slIR.Text);
            var slDOR = double.Parse(this.slDOR.Text);
            var slRR = double.Parse(this.slRR.Text);

            var slSum = 1;
            if (slCompletes == 0)
            {
                slSum = 0;
                slSample.Text = slSum.ToString();
            }
            else
            {
                slSum = (int)(slCompletes / (slIR / 100 * slRR / 100 * (1 - slDOR / 100)));
                slSample.Text = slSum.ToString();
            }


            //full launch

            double flCompletes = 0;
            double.TryParse(this.flCompletes.Text, out flCompletes);
            var flIR = double.Parse(this.flIR.Text);
            var flDOR = double.Parse(this.flDOR.Text);
            var flRR = double.Parse(this.flRR.Text);
            var flSum = 1;
            if (flCompletes == 0)
            {
                flSum = 0;
                flSample.Text = flSum.ToString();
            }
            else
            {
                 flSum = (int)(flCompletes / (flIR / 100 * flRR / 100 * (1 - flDOR / 100)));
                flSample.Text = flSum.ToString();
            }



            //total

            var totalCompletes = slCompletes + flCompletes;
            var totalSum = (int)(slSum + flSum); 
            totalSample.Text = totalSum.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slCompletes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

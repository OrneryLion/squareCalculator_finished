using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squareCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int lowerLimit = 0;
            int upperLimit = 10;
            listBox1.Items.Clear();
            try { 
                lowerLimit = int.Parse(txt_startNum.Text);
                upperLimit = int.Parse(txt_stopNum.Text);

                // For loop

                for (int x = lowerLimit; x <= upperLimit; x++)
                {
                    listBox1.Items.Add("x = " + x + " squared = " + x * x);
                }
            }
            catch {
                MessageBox.Show("Please Enter only numbers");
            }

        }
    }
}

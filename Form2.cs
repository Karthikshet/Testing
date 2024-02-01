using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           userControl21.Visible = true;
           userControl11.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl11.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl11.Visible = true;
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wel w = new Wel();
            this.Hide();
            w.Show();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl11.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            this.Hide(); f.Show();
        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }
    }
}

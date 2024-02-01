using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wel w = new Wel();
            this.Hide();
            w.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Show();
            }
            else
            {
                label3.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            label3.Hide();
            checkBox1.Checked = false;
                //panel3.Visible = false;

        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void TButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (TButton1.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
               
    }
}

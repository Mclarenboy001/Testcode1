using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("this is a pop up!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked button 2 right?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show("Sender Name : " + sender.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Sameeksha" && textBox2.Text=="Trainee")
            {
                Form2 gg = new Form2();
                gg.StartPosition = FormStartPosition.CenterScreen;
                gg.Show();

                MessageBox.Show("Hello");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cm;
        SqlDataReader read;
        SqlDataAdapter ADP;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT220\\SQLEXPRESS; database=library;integrated security=true");
            con.Open();
            
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "LibAdmin" && textBox2.Text == "CTS123")
            {
                AdminForm gg = new AdminForm();
                gg.StartPosition = FormStartPosition.CenterScreen;
                gg.Show();
                               
            }
            else
            {
                MessageBox.Show("The Username and Password does not match");
            }

        }
    }
}

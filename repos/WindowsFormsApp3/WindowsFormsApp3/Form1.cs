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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection con;
        SqlCommand cm;
        SqlDataReader read;
        SqlDataAdapter ADP;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT220\\SQLEXPRESS; database=register;integrated security=true");
            con.Open();
            MessageBox.Show("Connection Established");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            cm = new SqlCommand("Insert into Student values('" + Id.Text + "','" + name.Text + "','" + Course.Text + "','" + CourseFee.Text + "')", con);

            cm.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully ");

            Id.Clear();
            name.Clear();
            Course.Clear();
            CourseFee.Clear();
            // con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Id.Clear();
            name.Clear();
            Course.Clear();
            CourseFee.Clear();

            /* SqlCommand cmd;
             string query;
             query = "Select * from StudentI; ";
             cmd = new SqlCommand(query, con);*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("select * from Student where StudNo = " + Id.Text + " ", con);
            try
            {
                read = cm.ExecuteReader();
                if (read.Read())
                {
                    name.Text = read[1].ToString();
                    Course.Text = read[2].ToString();
                    CourseFee.Text = read[3].ToString();
                }
                else
                {
                    MessageBox.Show(" No Record");
                }
                read.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" No Record");
            }
            /*finally
            {
                con.Close();
            }*/
        }


        private void button10_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("Delete  from Student where StudNo=" + Id.Text + " ", con);
            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                Id.Clear();
                name.Clear();
                Course.Clear();
                CourseFee.Clear();

            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            /*finally
            {
                con.Close();
            }*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("update Student set StudName= '" + name.Text + "', Course= '" + Course.Text + "' , CourseFee=' " + CourseFee.Text + "' where StudNo =     '" + Id.Text + "' ", con);
            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Updated..");
            }
            catch (Exception)
            {
                MessageBox.Show(" Not Updated");
            }
           /* finally
            {
                con.Close();
            }*/
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form GridView = new Form();
            DataGridView View = new DataGridView();


            ADP = new SqlDataAdapter("Select * from Student ",con);
            DataSet GrdSet = new DataSet();
            ADP.Fill(GrdSet, "Student");

            View.DataSource = GrdSet;
            View.DataMember = "Student";

            View.Location = new Point(100, 100);
            GridView.Controls.Add(View);

            GridView.StartPosition = FormStartPosition.CenterScreen;
            GridView.Height = 700;
            GridView.Width = 400;
            GridView.Show();
        }
    }
}




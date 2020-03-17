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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        SqlConnection con;
        SqlCommand cmd;
        string Query;
        SqlDataAdapter ADP;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server = BLT220\\SQLEXPRESS; Database = student; Integrated Security = true");
            con.Open();
        }

     

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
            ADP = new SqlDataAdapter("select * from st_age", con);
            DataSet ds = new DataSet();
            ADP.Fill(ds, "st_age");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "st_age";
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
            Query = "Insert into st_age values('" + textBox1.Text + "','" + textBox2.Text + "','" + dt + "')";
            cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";


            MessageBox.Show("Row Inserted Successfully...", "Insert");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    


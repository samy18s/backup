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


namespace WindowsFormsApp4
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            if(str=="ALL")
            {
                ADP = new SqlDataAdapter("Select * from StudentInfo ", con);
                DataSet GrdSet = new DataSet();
                ADP.Fill(GrdSet, "StudentInfo");

                View.DataSource = GrdSet;
                View.DataMember = "StudentInfo";
            }

            else if(str=="DATE")
            {
                Label mylab = new Label();
                mylab.Text = "Enter the date (YYYY-MM-DD)";
                mylab.Location = new Point(222, 90);
                mylab.AutoSize = true;            
                mylab.Visible = true;
                mylab.Show();
                

                TextBox txt = new TextBox();
                mylab.Location = new Point(250, 90);
                mylab.AutoSize = true;
                mylab.Visible = true;
                txt.Show() ;



               /* ADP = new SqlDataAdapter("Select * from StudentInfo where jdate = '" + txt.Text + "' ", con);
                DataSet GrdSet = new DataSet();
                ADP.Fill(GrdSet, "StudentInfo");

                View.DataSource = GrdSet;
                View.DataMember = "StudentInfo";*/
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT220\\SQLEXPRESS; database=CourseInfo;integrated security=true");
            con.Open();
            MessageBox.Show("Connection Established");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("Insert into StudentInfo values('" + No.Text + "','" + sName.Text + "','" + Course.Text + "','" + Date.Text + "')", con);

            cm.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully ");

            No.Clear();
            sName.Clear();
            Course.Clear();
            Date.Clear();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("select * from StudentInfo where no = '" + No.Text + "' ", con);
            try
            {
                read = cm.ExecuteReader();
                if (read.Read())
                {
                    sName.Text = read[1].ToString();
                    Course.Text = read[2].ToString();
                    Date.Text = read[3].ToString();
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

        private void Update_Click(object sender, EventArgs e)
        {
            
                cm = new SqlCommand("update StudentInfo set sname= '" + sName.Text + "', course= '" + Course.Text + "' , jdate=' " + Date.Text + "' where no =     '" + No.Text + "' ", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            No.Clear();
            sName.Clear();
            Course.Clear();
            Date.Clear();
          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            cm = new SqlCommand("Delete  from StudentInfo where StudNo=" + No.Text + " ", con);
            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                No.Clear();
                sName.Clear();
                Course.Clear();
                Date.Clear();
                

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            ADP = new SqlDataAdapter("Select * from StudentInfo where jdate = '"+Pick.Text+"' ", con);
            DataSet GrdSet = new DataSet();
            ADP.Fill(GrdSet, "StudentInfo");

            View.DataSource = GrdSet;
            View.DataMember = "StudentInfo";
        }

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


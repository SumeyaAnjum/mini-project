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

namespace WindowsFormsApplication1
{
    public partial class Grouping : Form
    {
        public Grouping()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        private void btncopy_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    //dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();


                }


            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");




            SqlDataAdapter sqa = new SqlDataAdapter("Select * from Student"/*.RegistrationNo, [Group].Created_On"*//* [GroupStudent].Status, [GroupStudent].AssignmentDate"*/, conn);
            //SqlDataAdapter sqb = new SqlDataAdapter("Select * from [Group]",conn);
            SqlDataAdapter sqc = new SqlDataAdapter("Select * from [GroupStudent]",conn);




            DataTable dt = new DataTable();
            sqa.Fill(dt);
            //sqb.Fill(dt);
            sqc.Fill(dt);
            

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["RegistrationNo"].ToString();
                //dataGridView1.Rows[n].Cells[2].Value = item["Created_On"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Status"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["AssignmentDate"].ToString();


            }
        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {





            conn.Open();
            try
            {
                string query = "insert into [Group](Created_On) values ('" + (dateTimePickercreatedon.Value.ToString("MM/dd/yyyy")) + "') ";
                SqlDataAdapter dt = new SqlDataAdapter(query, conn);
                dt.SelectCommand.ExecuteNonQuery();

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {

                    SqlCommand cmd = new SqlCommand("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) Values((select Id from [Group] where Created_On='" + (dateTimePickercreatedon.Value.ToString("MM/dd/yyyy")) + "', (select Id from Student where RegistrationNo='" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "'), (Select Id from Lookup where Value='" + combostatus.Text + "'),'" +(dateTimePickerassignmentdate.Value.ToString("MM/dd/yyyy")) + "')", conn);


                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("added successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry");
            }
            conn.Close();
            dataGridView2.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();

        }
        //if (txtreg.Text != "" && combostatus.Text != "")
        //{
        //    conn.Open();
        //    string query = "insert into [Group](Created_On) values ( '" + (dateTimePickercreatedon.Value.ToString("MM/dd/yyyy")) + "')";
        //    SqlDataAdapter cmd = new SqlDataAdapter(query, conn);

        //    cmd.SelectCommand.ExecuteNonQuery();







        //    string query2 = "insert into GroupStudent(Status,AssignmentDate,GroupId,StudentId) values('" + combostatus.Text + "','" + (dateTimePickerassignmentdate.Value.ToString("MM/dd/yyyy")) + "', (Select GroupId from [Group] where Email='" + txtemail.Text + "', (Select StudentId from Student where Email = '" + txtemail + "'))";
        //    SqlDataAdapter cdn2 = new SqlDataAdapter(query2, conn);
        //    cdn2.SelectCommand.ExecuteNonQuery();


        //    string query1 = "insert into Student(RegistrationNo, Id) values('" + txtreg.Text + "', (Select Id from Person where Email='" + txtemail.Text + "' ))";
        //    SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
        //    cdn1.SelectCommand.ExecuteNonQuery();










        //    conn.Close();
        //    MessageBox.Show("Data Added Successfully");
        //    //DataTable dt = new DataTable();
        //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Student", conn);
        //adapter.Fill(dt);
        //dataGridView1.DataSource = dt;
        //DataTable dt = new DataTable();
        //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
        //adapter.Fill(dt);
        //DataGridViewevaluations.DataSource = dt;
        //    txtreg.Text = "";
        //    combostatus.Text = "";
        //    txtemail.Text = "";


        //    //dataGridViewprojects.DataSource = dt;
        //    //txtprojectname.Text = "";
        //    //txtdescription.Text = "";
        //    //id = 0;
        //}
        //else
        //{
        //    MessageBox.Show("Please Provide complete information");
        //}
    }

        //private void Grouping_Load(object sender, EventArgs e)
        //{

        //}
    }

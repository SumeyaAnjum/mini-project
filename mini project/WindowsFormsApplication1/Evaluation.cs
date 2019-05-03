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
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        int id = 0;

        private void Evaluation_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
            adapter.Fill(dt);
            DataGridViewevaluations.DataSource = dt;
        }

        private void btnaddadvsr_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text != "")
            {
                conn.Open();
                string query = "insert into Evaluation(Name,TotalMarks,TotalWeightage) values ('" + txtname.Text + "','" + Convert.ToInt32(txttotalmarks.Text) + "','" + Convert.ToInt32(txttotalweightage.Text) + "')";
                SqlDataAdapter cmd = new SqlDataAdapter(query, conn);

                cmd.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                adapter.Fill(dt);
                DataGridViewevaluations.DataSource = dt;
                //DataTable dt = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                //adapter.Fill(dt);
                //DataGridViewevaluations.DataSource = dt;
                txtname.Text = "";
                txttotalmarks.Text = "";
                txttotalweightage.Text = "";
               

                //dataGridViewprojects.DataSource = dt;
                //txtprojectname.Text = "";
                //txtdescription.Text = "";
                //id = 0;
            }
            else
            {
                MessageBox.Show("Please Provide complete information");
            }
        }

        private void DataGridViewevauations_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtname.Text = DataGridViewevaluations.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtname.Text = DataGridViewevaluations.Rows[e.RowIndex].Cells[1].Value.ToString();
            txttotalmarks.Text = DataGridViewevaluations.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttotalweightage.Text = DataGridViewevaluations.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnupdateevaluation_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txttotalmarks.Text != "" && txttotalweightage.Text != "")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Evaluation Set [Name]='" + (txtname.Text) + "', [TotalMarks] ='" + Convert.ToInt32(txttotalmarks.Text) + "',[TotalWeightage] = '" + Convert.ToInt32(txttotalweightage.Text) + "' where Id='"+id+"'", conn);
                command.ExecuteNonQuery();




                MessageBox.Show("Record Updated Successfully");
                conn.Close();


                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                adapter.Fill(dt);
                DataGridViewevaluations.DataSource = dt;
                //DataTable dt = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Evaluation on Person.Id = Evaluation.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                //adapter.Fill(dt);
                //DataGridViewevaluations.DataSource = dt;
                txtname.Text = "";
                txttotalmarks.Text = "";
                txttotalweightage.Text = "";

              //  id = 0;
            }
            else
            {
                MessageBox.Show("Please provide all Information!!!");
            }
        }

        private void btndeleteevaluation_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                int id1 = id;
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Evaluation where id='" + id + "'", conn);


                cmd1.ExecuteNonQuery();

                //SqlCommand cmd = new SqlCommand("Delete from Person where Id='" + id1 + "'", conn);
                //cmd.ExecuteNonQuery();

                conn.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                adapter.Fill(dt);
                DataGridViewevaluations.DataSource = dt;
                txtname.Text = "";
                txttotalmarks.Text = "";
                txttotalweightage.Text = "";
               
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }



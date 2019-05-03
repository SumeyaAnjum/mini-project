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
    public partial class Project_Advisor : Form
    {
        public Project_Advisor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comborole.Text != "")
            {
                conn.Open();
                string query = "insert into ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate) values ((select Id from Advisor),(select Id from Project),(select Id from Lookup where Value ='" + comborole.Text + "','" + (dateTimePickerasgnmnt.Value.ToString("MM/dd/yyyy")) +"')"; 
                SqlDataAdapter cmd = new SqlDataAdapter(query, conn);

                cmd.SelectCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data Added Successfully");

                comborole.Text = "";
                
                //dateTimePicker1.Value= "MM / dd / yyyy";
               
                //conn.Close();
                //MessageBox.Show("Data Added Successfully");
                //DataTable dt = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter("Select * from ProjectAdvisor", conn);
                //adapter.Fill(dt);
                //dateTimePickerasgnmnt.DataSource = dt;
                ////DataTable dt = new DataTable();
                ////SqlDataAdapter adapter = new SqlDataAdapter("Select * from Evaluation", conn);
                ////adapter.Fill(dt);
                ////DataGridViewevaluations.DataSource = dt;
                //comborole.Text = "";



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

        private void Project_Advisor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from ProjectAdvisor", conn);
            adapter.Fill(dt);
            dataGridViewprojectadvisor.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

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
    public partial class Group_Project : Form
    {
        public Group_Project()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        int id = 0;
        private void Group_Project_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from GroupProject", conn);
            adapter.Fill(dt);
            dataGridViewgroupproject.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
                conn.Open();



                string query = "insert into GroupProject(ProjectId,GroupId,AssignmentDate) values ((Select Id from Project where Title = '" + txtprojectname + "'),(select Id from [Group] where Created_On='" + (dateTimePickercreatedon.Value.ToString("MM/dd/yyyy")) + "'),'" + (dateTimePickerassignmentdate.Value.ToString("MM / dd / yyyy")) + "')";
                SqlDataAdapter c = new SqlDataAdapter(query, conn);

                c.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from GroupProject", conn);
                adapter.Fill(dt);
                dataGridViewgroupproject.DataSource = dt;
                txtprojectname.Text = "";

                id = 0;





                //this.Hide();
                //Form1 f1 = new Form1();
                //f1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}


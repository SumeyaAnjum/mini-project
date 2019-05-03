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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        int id = 0;

        private void Project_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
            adapter.Fill(dt);
            dataGridViewprojects.DataSource = dt;
        }

        private void dataGridViewprojects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewprojects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtprojectname.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtprojectname.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdescription.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                string query = "insert into Project(Title,Description) values ('" + txtprojectname.Text + "','" + txtdescription.Text + "')";
                SqlDataAdapter c = new SqlDataAdapter(query, conn);

                c.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                adapter.Fill(dt);
                dataGridViewprojects.DataSource = dt;
                txtprojectname.Text = "";
                txtdescription.Text = "";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtprojectname.Text != "" && txtdescription.Text != "")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Project set Title='" + txtprojectname.Text + "',Description='" + txtdescription.Text + "' where id='" + id + "';", conn);

                command.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                adapter.Fill(dt);
                dataGridViewprojects.DataSource = dt;
                txtprojectname.Text = "";
                txtdescription.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please provide all Information!!!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                SqlCommand cmd = new SqlCommand("Delete Project where id='" + id + "';", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Delete successfully!!");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Project", conn);
                adapter.Fill(dt);
                dataGridViewprojects.DataSource = dt;
                txtprojectname.Text = "";
                txtdescription.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }

        private void dataGridViewprojects_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = Convert.ToInt32(txtprojectname.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtprojectname.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdescription.Text = dataGridViewprojects.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

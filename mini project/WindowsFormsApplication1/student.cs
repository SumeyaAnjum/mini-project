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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");

        int id = 0;
        private void student_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
            adapter.Fill(dt);
            dataGridStudentdetail.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                string query = "insert into Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtcontact.Text + "', '" + txtemail.Text + "', '" + (dateTimePicker1.Value.ToString("MM/dd/yyyy"))+ "', (select id from Lookup where Value = '" + combogender.Text + "'))";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                
                string query1 = "insert into Student(RegistrationNo, Id) values('" + txtregno.Text + "', (Select Id from Person where Contact='" + txtcontact.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                cdn1.SelectCommand.ExecuteNonQuery();
                //string q = "insert into Student(RegistrationNo,Id) values('" + txtregno.Text + "',(select Id from Person where ))";
                //SqlCommand c = new SqlCommand(q, conn);
                //c.ExecuteNonQuery();



                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;

                txtfirstname.Text = "";
                txtlastname.Text = "";
                txtemail.Text = "";
                //dateTimePicker1.Value= "MM / dd / yyyy";
                txtregno.Text = "";
                txtcontact.Text = "";

            


                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combogender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridStudentdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridStudentdetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontact.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
           // txtdob.Text = Convert.ToDateTime(dataGridStudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtregno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontact.Text != "")
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Person Set [FirstName]='" + txtfirstname.Text + "', [LastName] ='" + txtlastname.Text + "',Contact = '" + txtcontact.Text + "',Email='" + txtemail.Text + "', DateOfBirth='" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "',Gender=(select Id from Lookup where Value='" + combogender.Text + "') where id='" + id + "'", conn);

                command.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand("Update Student set [RegistrationNo]='" + txtregno.Text + "' where Id=(select Id from Person where [FirstName]='" + txtfirstname.Text + "' and [LastName] ='" + txtlastname.Text + "' and Contact = '" + txtcontact.Text + "' and Email='" + txtemail.Text + "' and DateOfBirth='" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "' and Gender=(select Id from Lookup where Value='" + combogender.Text + "'))", conn);

                command1.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtemail.Text = "";
                combogender.Text = "";
                txtcontact.Text = "";
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
                int id1 = id;
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Student where id='" + id + "'", conn);


                cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Delete from Person where Id='" + id1 + "'", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data Delete successfully!!");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id,Person.FirstName,Person.LastName,person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person inner join Student on Person.Id=Student.Id", conn);
                adapter.Fill(dt);
                dataGridStudentdetail.DataSource = dt;
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtemail.Text = "";
                combogender.Text = "";
                txtcontact.Text = "";
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }

           

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            this.Show();


        }

        private void dataGridStudentdetail_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontact.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            // txtdob.Text = Convert.ToDateTime(dataGridStudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtregno.Text = dataGridStudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}


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
    public partial class advisor : Form
    {
        public advisor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                string query = "insert into Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtcontact.Text + "', '" + txtemail.Text + "', '" + Convert.ToDateTime(dateTimePicker1.Value).ToString() + "', (select id from Lookup where Value = '" + combogender.Text + "'))";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                string q = "insert into Advisor(Designation,Salary) values('" + combodesignation.Text + "','" + txtsalary.Text + "')";
                SqlCommand cm = new SqlCommand(q, conn);
                conn.Close();
                MessageBox.Show("Data Added Successfully");


                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void advisor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
            adapter.Fill(dt);
            dataGridViewadvisor.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != ""  && txtcontact.Text != "" && txtsalary.Text != "" && combodesignation.Text != "" && combogender.Text != "")
            {
                conn.Open();
                string query = "insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "',(select Id from Lookup where Value='" + combogender.Text + "'))";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Advisor(Designation,Salary,Id) values((select Id from Lookup where Value='" + combodesignation.Text + "'),'" + txtsalary.Text + "', (Select Id from Person where Contact='" + txtcontact.Text + "' and LastName='" + txtlastname.Text + "' and Email='" + txtemail.Text + "' and FirstName='" + txtfirstname.Text + "'))";
                SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
                cdn1.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation , Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
                adapter.Fill(dt);
                dataGridViewadvisor.DataSource = dt;
                txtfirstname.Text = "";
                txtlastname.Text = "";
                txtemail.Text = "";
                //(dateTimePicker1.Value) =  "MM / dd / yyyy";
                txtsalary.Text = "";
                txtcontact.Text = "";
                combodesignation.Text = "";
                combogender.Text = "";

                id = 0;
            }
            else
            {
                MessageBox.Show("Please Provide complete information");
            }
        }

        private void dataGridViewadvisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //{
            //    query = "select Value from Lookup where Id='" + dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString() + "'";
            //}
        }
        private void dataGridViewadvisor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontact.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[4].Value.ToString();
           // dateTimedob.Text = Convert.ToDateTime(dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            combogender.Text = Convert.ToInt32(dataGridViewadvisor.Rows[e.RowIndex].Cells[6].Value.ToString()).ToString();

            combodesignation.Text = query;
            txtsalary.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        String query;

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewadvisor_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcontact.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[4].Value.ToString();
            // dateTimedob.Text = Convert.ToDateTime(dataGridViewadvisor.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            //combogender.Text = Convert.ToInt32(dataGridViewadvisor.Rows[e.RowIndex].Cells[6].Value.ToString()).ToString();

            combodesignation.Text = query;
            txtsalary.Text = dataGridViewadvisor.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
       

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void btnupdateadvsr_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontact.Text != "")
            {
                conn.Open();
                 string query1 ="Update Person Set [FirstName]='" + txtfirstname.Text + "', [LastName] ='" + txtlastname.Text + "',Contact = '" + txtcontact.Text + "',Email='" + txtemail.Text + "', DateOfBirth='" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "',Gender=(select Id from Lookup where Value='" + combogender.Text + "') where id='" + id + "'";
                SqlDataAdapter cdn = new SqlDataAdapter(query1, conn);
                cdn.SelectCommand.ExecuteNonQuery();
                
                string query2  ="Update Advisor set Designation=(Select Id from Lookup where value = '" +combodesignation.Text+ "'), [Salary]='" + Convert.ToDecimal( txtsalary.Text)+"' where id = '" + id + "'";
                SqlDataAdapter cdn1 = new SqlDataAdapter(query2,conn);
                cdn1.SelectCommand.ExecuteNonQuery();
                conn.Close();

           
                MessageBox.Show("Record Updated Successfully");
                
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth,Person.Gender,Advisor.Designation, Advisor.Salary from Person join Advisor on Person.Id = Advisor.Id", conn); 
                adapter.Fill(dt);
                dataGridViewadvisor.DataSource = dt;
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






































            //if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtcontact.Text != "")
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand("Update Person Set [FirstName]='" + txtfirstname.Text + "', [LastName] ='" + txtlastname.Text + "',Contact = '" + txtcontact.Text + "',Email='" + txtemail.Text + "', DateOfBirth='" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "',Gender=(select Id from Lookup where Value='" + combogender.Text + "') where id='" + id + "'", conn);

            //    command.ExecuteNonQuery();

            //    SqlCommand command1 = new SqlCommand("Update Advisor(Designation,Salary) values((select Id from Lookup where Value = '" + combodesignation.Text + "','" +txtsalary+"'),/*+ Convert.ToInt32(combodesignation.Text) + *//*, [Salary]='" +Convert.ToDecimal(txtsalary.Text)+"'*/ where Id=(select Id from Person where [FirstName]='" + txtfirstname.Text + "' and [LastName] ='" + txtlastname.Text + "' and Contact = '" + txtcontact.Text + "' and Email='" + txtemail.Text + "' and DateOfBirth='" + (dateTimePicker1.Value.ToString("MM/dd/yyyy")) + "' and Gender=(select Id from Lookup where Value='" + combogender.Text + "'))", conn);

            //    command1.ExecuteNonQuery();
            //    MessageBox.Show("Record Updated Successfully");
            //    conn.Close();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id, Person.FirstName, Person.LastName, person.Contact, Person.Email, Person.DateOfBirth, Student.RegistrationNo, Lookup.Value from Person join Student on Person.Id = Student.Id join Lookup on Lookup.Id=Person.Gender ", conn);
            //    adapter.Fill(dt);
            //    dataGridViewadvisor.DataSource = dt;
            //    txtlastname.Text = "";
            //    txtfirstname.Text = "";
            //    txtemail.Text = "";
            //    combogender.Text = "";
            //    txtcontact.Text = "";
            //    combodesignation.Text = "";
            //    txtsalary.Text = "";
            //    id = 0;
            //}
            //else
            //{
            //    MessageBox.Show("Please provide all Information!!!");
            //}

        }

        private void btndeleteadvsr_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                int id1 = id;
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Delete from Advisor where id='" + id + "'", conn);


                cmd1.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Delete from Person where Id='" + id1 + "'", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Data Delete successfully!!");
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Person.Id,Person.FirstName,Person.LastName,person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo from Person inner join Student on Person.Id=Student.Id", conn);
                adapter.Fill(dt);
                dataGridViewadvisor.DataSource = dt;
                txtlastname.Text = "";
                txtfirstname.Text = "";
                txtemail.Text = "";
                combogender.Text = "";
                txtcontact.Text = "";
                txtsalary.Text = "";
                combodesignation.Text = "";
            
                id = 0;
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


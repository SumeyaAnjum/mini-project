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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
        int id = 0;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student f3 = new student();
            f3.Show();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            advisor f3 = new advisor();
            f3.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project f2 = new Project();
            f2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluation f1 = new Evaluation();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grouping f2 = new Grouping();
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Making_group f4 = new Making_group();
            //f4.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group_Project f2 = new Group_Project();
            f2.Show();
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project_Advisor f6 = new Project_Advisor();
            f6.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            @new f0 = new @new();
                
            f0.Show();
        }
    }
}

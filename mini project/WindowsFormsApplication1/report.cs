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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("EntireReport", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dsAProject = new DataSet();
            sqlDa.Fill(dsAProject);
            sqlCon.Close();
            CrystalReport.crptprojects crptEntireReport = new CrystalReport.crptprojects();
            crptEntireReport.Database.Tables["Person"].SetDataSource(dsAProject.Tables[0]);
            crviewer2.ReportSource = null;
            crviewer2.ReportSource = crptEntireReport;




        }
    }
}

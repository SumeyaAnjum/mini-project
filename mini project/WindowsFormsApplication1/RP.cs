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
    public partial class @new : Form
    {
        public @new()
        {
            InitializeComponent();
        }

        private void crvViewer_Load(object sender, EventArgs e)
        {

        }

        private void new_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=.;Initial Catalog=ProjectA;Integrated Security=True");
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ProjectReport", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dsProject = new DataSet();
            sqlDa.Fill(dsProject);
            sqlCon.Close();


            CrystalReport.crptprojects crptProject = new CrystalReport.crptprojects();
            crptProject.Database.Tables["Project"].SetDataSource(dsProject.Tables[0]);
            crptProject.Database.Tables["Advisor"].SetDataSource(dsProject.Tables[1]);
            crptProject.Database.Tables["Students"].SetDataSource(dsProject.Tables[2]);
            crvViewer.ReportSource = null;
            crvViewer.ReportSource = crptProject; 






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Project
{
    public partial class ipoandsmedetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showdata();
            showdata1();
        }
        private void showdata()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\brijeshasp\Project\Project\App_Data\ipodetails.mdf;Integrated Security=True");
            cn.Open();
            string sql = "select * from ipo";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }
        private void showdata1()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\brijeshasp\Project\Project\App_Data\ipodetails.mdf;Integrated Security=True");
            cn.Open();
            string sql = "select * from sme";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            cn.Close();
        }
    }
}
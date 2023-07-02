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
    public partial class insertfirstpagedata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\brijeshasp\Project\Project\App_Data\ipodetails.mdf;Integrated Security=True");
            cn.Open();
            string sql = "insert into ipo values('"+TextBox1.Text+"','"+ TextBox2.Text + "','"+ TextBox3.Text + "','"+ TextBox4.Text + "','" + TextBox5.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Response.Write("Inserted");
            cn.Close();
            Response.Redirect("default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\brijeshasp\Project\Project\App_Data\ipodetails.mdf;Integrated Security=True");
            cn.Open();
            string sql = "insert into sme values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Response.Write("Inserted");
            cn.Close();
            Response.Redirect("default.aspx");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class adminhelp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="admin" && TextBox2.Text == "admin")
            {
                Response.Redirect("insertfirstpagedata.aspx");
            }
            else
            {
                Response.Write("You Are Not Admin");
            }
        }
    }
}
using PROGPOEPART3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOEPART3.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        internal Liabrary Liabrary
        {
            get => default;
            set
            {
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string uName = txtUserName.Text.ToString();
            string pass = txtPassword.Text.ToString();
            User us = new User();
            us.getUser(uName);


            if (uName.Equals((uName)))
            {
                lblshow.Text = "LOGIN SUCCESSFUL!!!";
                Response.Redirect("Home.aspx");

            }
            else
            {
                Response.Write("Incorrect Details, Please proceed to register if details do not exist");

            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
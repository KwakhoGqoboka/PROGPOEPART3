using PROGPOEPART3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOEPART3.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text.ToString();
            string UserPassword = txtPassword.Text.ToString();
            User us = new User(UserName, UserPassword);
            us.hashPassword(UserPassword);
            us.Register();
            Response.Write($"User {UserName} has been added");
            
            Response.Redirect("Login.aspx");
            
        }
    }
}
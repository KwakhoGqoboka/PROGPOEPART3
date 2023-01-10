 using PROGPOEPART3.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOEPART3.Views.Home
{
    public partial class ManageModules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string code = txtSearch.Text;
            //Liabrary l = new Liabrary();

            //lstDisplay.Items.Add(l[code].ToString());

            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM tblModules WHERE ModuleCode= '{txtSearch.Text}'", conn);
            sqlCom.Parameters.AddWithValue("ModuleCode", txtSearch.Text);
            SqlDataReader readerData1;
            readerData1 = sqlCom.ExecuteReader();
            try
            {
                if (readerData1.Read())
                {
                    lstDisplay.Items.Add("-----------------------------------------------------------");
                    lstDisplay.Items.Add("Student: \t" + readerData1["UserName"].ToString());
                    lstDisplay.Items.Add("Module Code: \t" + readerData1["ModuleCode"].ToString());
                    lstDisplay.Items.Add("Module Name: \t" + readerData1["ModuleName"].ToString());
                    lstDisplay.Items.Add("Module Credits: \t" + readerData1["ModuleCredits"].ToString());
                    lstDisplay.Items.Add("Module Hours: \t" + readerData1["ModuleHours"].ToString());
                    lstDisplay.Items.Add("Module Start Date: \t" + readerData1["ModuleStartDate"].ToString());
                    lstDisplay.Items.Add("Module Weeks: \t" + readerData1["ModuleWeeks"].ToString());
                    lstDisplay.Items.Add("Self Study Hours: \t" + readerData1["SelfStudy"].ToString());
                    lstDisplay.Items.Add("Remaining Hours: \t" + readerData1["Remainder"].ToString());
                    lstDisplay.Items.Add("-----------------------------------------------------------");
                }
            }
            catch (Exception error)
            {
                Response.Write(error.Message);
            }
        }
    }
}
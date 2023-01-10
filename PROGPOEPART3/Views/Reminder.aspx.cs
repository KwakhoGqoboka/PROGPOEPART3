using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOEPART3.Views
{
    public partial class Reminder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RemiderStore(string cString, string Modulecode, DateTime DateCal)
        {

            string query = "INSERT INTO dbo.Reminder(Modulecode,DateReminder)" +
                "Values (@Modulecode,@DateReminder)";

            using (SqlConnection cn = new SqlConnection(cString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@Modulecode", System.Data.SqlDbType.VarChar).Value = Modulecode;

                cmd.Parameters.Add("@DateReminder", System.Data.SqlDbType.DateTime).Value = DateCal;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

            protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ModuleCode = txReminder.Text;
            DateTime cal = DateCal.SelectedDate;


            string cString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\PROGPOEPART3\PROGPOEPART3\App_Data\App.mdf;Integrated Security=True";
            RemiderStore(cString, ModuleCode, cal);
            Response.Write("SUCCESSFULLY SET A REMINDER FOR YOU");
        }
    }
}
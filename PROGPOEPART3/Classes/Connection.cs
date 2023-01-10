using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace PROGPOEPART3.Classes
{
    public class Connection
    {
        internal static Liabrary Liabrary
        {
            get => default;
            set
            {
            }
        }

        public static SqlConnection GetConnection()
        {
            string fileName = "App.mdf";
            string filePath = Path.GetFullPath(fileName).Replace(@"\bin\Debug", @"\Data");
            string strCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\PROGPOEPART3\PROGPOEPART3\App_Data\App.mdf;Integrated Security=True";
            return new SqlConnection(strCon);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROGPOEPART3.Classes
{
    class Liabrary
    {
        SqlConnection conn = Connection.GetConnection();
        //Create a list
        public static List<Liabrary> ProgramList = new List<Liabrary>();

        public string _moduleCode { get; set; }
        public string ModuleCode
        {
            get { return _moduleCode; }
            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new Exception($"Module Name ({value}) should at least be 3 characters long");
                }
                _moduleCode = value;
            }
        }
        private string ModuleName { get; set; }
        public int ModuleCredits { get; set; }
        public int ModuleHours { get; set; }
        public string ModuleStartDate { get; set; }
        public int ModuleWeeks { get; set; }
        public int Remainder { get; set; }
        public int SelfStudy { get; set; }



        //Default constructor
        public Liabrary()
        {

        }
        public Liabrary(string mCode, string mName, int mCredits, int mHours, string mStartDate, int mWeeks)
        {
            ModuleCode = mCode;
            ModuleName = mName;
            ModuleCredits = mCredits;
            ModuleHours = mHours;
            ModuleStartDate = mStartDate;
            ModuleWeeks = mWeeks;


        }
        public void SelfStudyCalculation()
        {
            SelfStudy = ((ModuleCredits * 10) / ModuleWeeks) - ModuleHours;
        }

        public void RemainderCalculation()
        {
            Remainder = ModuleHours - SelfStudy;
        }
        public override string ToString()
        {

            //Code: PROG6212 NAME: Programming 2B Credits: 15 Hours: 5
            return $"Module Code: {ModuleCode} Module Name: {ModuleName} Module Credits: {ModuleCredits} Module Hours: {ModuleHours} Module Start Date: {ModuleStartDate} Module Weeks: {ModuleWeeks} Self Study Hours: {SelfStudy} Self Study Remainder: {Remainder}";

        }

        //Implementing indexer that will return a specific code
        public Liabrary this[string code]
        {
            get
            {
                return ProgramList.Find(x => x.ModuleCode.Equals(code));
            }

        }
        public Liabrary SelfStudyHours()
        {
            string strSelect = $"SELECT * FROM tblModules WHERE SelfStudy ";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModuleCode = (string)reader[0];
                            ModuleName = (string)reader[1];
                            ModuleCredits = Convert.ToInt32(reader[2]);
                            ModuleHours = Convert.ToInt32(reader[3]);
                            ModuleStartDate = (string)reader[4];
                            ModuleWeeks = Convert.ToInt32(reader[5]);
                            SelfStudy = Convert.ToInt32(reader[6]);
                            Remainder = Convert.ToInt32(reader[7]);
                        }
                    }
                }
            }
            return new Liabrary(ModuleCode, ModuleName, ModuleCredits, ModuleHours, ModuleStartDate, ModuleWeeks);
        }
        public Liabrary RemainderHours()
        {
            string strSelect = $"SELECT * FROM tblModules";
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(strSelect, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ModuleCode = (string)reader[0];
                            ModuleName = (string)reader[1];
                            ModuleCredits = Convert.ToInt32(reader[2]);
                            ModuleHours = Convert.ToInt32(reader[3]);
                            ModuleStartDate = (string)reader[4];
                            ModuleWeeks = Convert.ToInt32(reader[5]);
                            SelfStudy = Convert.ToInt32(reader[6]);
                            Remainder = Convert.ToInt32(reader[7]);
                        }
                    }
                }
            }
            return new Liabrary(ModuleCode, ModuleName, ModuleCredits, ModuleHours, ModuleStartDate, ModuleWeeks);
        }
        //Create Table
        public void CreateTableModules()
        {
            string strModules = "CREATE TABLE tblModules(ModuleCode varchar(10) not null Primary Key, ModuleName varchar(50) not null, ModuleCredits int not null, ModuleHours int not null, ModuleStartDate date not null, ModuleWeeks int not null, SelfStudy int not null, Remainder int not null, UserName varchar(50) not null Foreign Key ";


            SqlCommand cmdInsert = new SqlCommand(strModules, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public void CreateTableUser()
        {
            string strUser = "CREATE TABLE tblUser(UserName varchar(50) not null Primary Key, UserName int not null";

            SqlCommand cmdInsert = new SqlCommand(strUser, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        //Add Fields
        public void AddModules()
        {
            string strInsert = $"INSERT INTO tblModules VALUES('{ModuleCode}','{ModuleName}','{ModuleCredits}','{ModuleHours}','{ModuleStartDate}','{ModuleWeeks}','{SelfStudy}','{Remainder}', '{User.UserName}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public List<Liabrary> AllModules()
        {

            string strSelect = $"SELECT * FROM tblModules";
            SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
            DataTable myTable = new DataTable();
            DataRow myRow;
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            List<Liabrary> _list = new List<Liabrary>();

            conn.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];
                    ModuleCode = (string)myRow[0];
                    ModuleName = (string)myRow[1];
                    ModuleCredits = Convert.ToInt32(myRow[2]);
                    ModuleHours = Convert.ToInt32(myRow[3]);
                    ModuleStartDate = (string)myRow[4];
                    ModuleWeeks = Convert.ToInt32(myRow[5]);


                    _list.Add(new Liabrary(ModuleCode, ModuleName, ModuleCredits, ModuleHours, ModuleStartDate, ModuleWeeks));
                }
            }

            conn.Close();
            return _list;
        }

    }
}

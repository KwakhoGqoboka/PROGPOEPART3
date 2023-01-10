using PROGPOEPART3.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PROGPOEPART3.Classes
{
    public class User
    {
        SqlConnection conn = Connection.GetConnection();
        public static string UserName { get; set; }
        public static string UserPassword { get; set; }

        public Register Register1
        {
            get => default;
            set
            {
            }
        }

        public User()
        {

        }
        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }
        public void getUser(string uName)
        {
            string sqlSelect = $"SELECT * FROM tblUser WHERE UserName = '{uName}'";
            using (conn)
            {
                SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);

                conn.Open();
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserName = (string)reader[0];
                        UserPassword = (string)(reader[1]);
                    }
                }
               
            }
        }
        public void Register()
        {
            string strInsert = $"INSERT INTO tblUser VALUES('{UserName}','{UserPassword}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);
            
            conn.Open();
            cmdInsert.ExecuteNonQuery();
           
        }
        // 
        public string hashPassword(string UserPassword)
        {
            SHA1CryptoServiceProvider hash = new SHA1CryptoServiceProvider();

            //get the byte representing of the password
            byte[] passwordBytes = Encoding.ASCII.GetBytes(UserPassword);

            //returning the hash encrypted password
            byte[] encryptedBytes = hash.ComputeHash(passwordBytes);

            //returning thhe string
            return Convert.ToBase64String(encryptedBytes);

        }
    }
}
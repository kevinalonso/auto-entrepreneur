using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AutoEntrepreneur.Core.Constant;

namespace AutoEntrepreneur.Core.ConnectionBdd
{
     public class DataBaseConnection
    {
        #region Fields
        private MySqlConnection _Connection;
        #endregion

        #region Construtor
        public DataBaseConnection()
        {
            Initialize();
            OpenConnection();
        }
        #endregion

        #region InitializeValues
        private void Initialize()
        {
            string connectionString;
            connectionString = "server=" + Config.SERVER + ";" + "uid=" + Config.UID + ";" + "password=" + Config.PASSWORD + "; Ssl Mode=none";

            _Connection = new MySqlConnection(connectionString); 
        }

        #endregion

        #region OpenAndClose
        /// <summary>
        ///Open connection to database
        /// </summary>
        /// <returns></returns>
        private bool OpenConnection()
        {
            try
            {
                _Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Close connection
        /// </summary>
        /// <returns></returns>
        public bool CloseConnection()
        {
            try
            {
                _Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region Method
        public MySqlConnection Conn()
        {
            return _Connection;
        }
        #endregion
    }
}

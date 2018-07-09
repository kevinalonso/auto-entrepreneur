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

        }
        #endregion

        #region InitializeValues
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + Config.SERVER + ";" + "DATABASE=" +
            Config.DB + ";" + "UID=" + Config.UID + ";" + "PASSWORD=" + Config.PASSWORD + ";";

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
        private bool CloseConnection()
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
    }
}

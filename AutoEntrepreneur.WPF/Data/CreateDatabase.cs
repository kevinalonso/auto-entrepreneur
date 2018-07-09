using AutoEntrepreneur.Core.ConnectionBdd;
using AutoEntrepreneur.WPF.Constant;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEntrepreneur.WPF.Data
{
    public class CreateDatabase
    {

        #region Fields
        private MySqlCommand _Command;
        private DataBaseConnection _Conn;
        #endregion

        #region CreateDatabase
        public void CreateDb()
        {
            try
            {
                _Conn = new DataBaseConnection();

                _Command = new MySqlCommand(Config.CREATE_DATABASE, _Conn.Conn());
                int result = _Command.ExecuteNonQuery();

                if(result == 1)
                {
                    CreateTable();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if(_Conn != null)
                {
                    _Conn.CloseConnection();
                }
            }
        }
        #endregion

        #region CreateTables
        public void CreateTable()
        {
                
        }
        #endregion
    }
}

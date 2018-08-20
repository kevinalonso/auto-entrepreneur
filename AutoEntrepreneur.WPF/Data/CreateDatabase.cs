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
        private string _CreateTable;
        #endregion

        #region CreateDatabase
        public void CreateDb()
        {
            try
            {
                _Conn = new DataBaseConnection();

                _Command = new MySqlCommand(Config.CREATE_DATABASE, _Conn.Conn());
                int result = _Command.ExecuteNonQuery();
                _Conn.CloseConnection();

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
            #region Table Person
            _CreateTable = Config.CREATE_TABLE_PERSON;
            ExecuteCommandToCreateTable(_CreateTable);
            #endregion

            #region Table Type Money
            _CreateTable = Config.CREATE_TABLE_TYPE_MONEY;
            ExecuteCommandToCreateTable(_CreateTable);
            #endregion

            #region Type Customer
            _CreateTable = Config.CREATE_TABLE_TYPE_CUSTOMER;
            ExecuteCommandToCreateTable(_CreateTable);
            #endregion

            #region Customer
            _CreateTable = Config.CREATE_TABLE_CUSTOMER;
            ExecuteCommandToCreateTable(_CreateTable);
            #endregion

            #region Article
            _CreateTable = Config.CREATE_TABLE_ARTICLE;
            ExecuteCommandToCreateTable(_CreateTable);
            #endregion
        }
        #endregion

        #region Methods
        private void ExecuteCommandToCreateTable(string script)
        {
            _Command = new MySqlCommand(script, _Conn.ConnAfterCreateDb());
            _Command.ExecuteNonQuery();
        }
        #endregion
    }
}

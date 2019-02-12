﻿/*Maftoul Omar 2019*/

using System.Data;
using System.Data.SQLite;


namespace WorldCup
{
        public class TeamsDataBase
        {
            private readonly string _dataSource = @"teams.db";
            private string _sqlConnectionString = "";
            private SQLiteConnection _sqlConnection;

            public TeamsDataBase()
            {
                OpenConnection();
            }
            private void OpenConnection()
            {
                _sqlConnectionString = $"Data Source = {_dataSource}; Version =3;";
                _sqlConnection = new SQLiteConnection(_sqlConnectionString);
                _sqlConnection.Open();
             }

            private void CloseConnection()
            {
                _sqlConnection.Close();
            }

            public string ReadDatabase()
            {
            
            }

        }

}
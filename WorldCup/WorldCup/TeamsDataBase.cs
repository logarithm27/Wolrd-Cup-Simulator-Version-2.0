/*Maftoul Omar 2019*/

using System;
using System.Data.SQLite;
using System.IO;
using System.Windows;


namespace WorldCup
{
        public class TeamsDataBase
        {

            private readonly string _path = Path.Combine(Environment.CurrentDirectory, @"Data\","teams.db");
            private readonly string _dataSource = @"teams.db";
            private SQLiteConnection _sqlConnection;

            public TeamsDataBase()
            {
                OpenConnection();
            }
            private void OpenConnection()
            {
                var  sqlConnectionString = $"Data Source = {_dataSource}"+";";
                _sqlConnection = new SQLiteConnection(sqlConnectionString);
                if( !File.Exists(_path) )

                    //SQLiteConnection.CreateFile(_path);
                //_sqlConnection.Open();
            }

            private void CloseConnection()
            {
                _sqlConnection.Close();
            }

        public string ReadDatabase()
        {
            return String.Empty;
            /* TO DO*/
        }

    }
}
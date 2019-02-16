/*Maftoul Omar 2019*/

using System;
using System.Data.SQLite;
using System.IO;


namespace WorldCup
{
        public class TeamsDataBase
        {

            private readonly string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug",""), @"Data\","teams.db");
            private SQLiteConnection _sqlConnection;

            public TeamsDataBase()
            {
                OpenConnection();
            }
            private void OpenConnection()
            {
                var  sqlConnectionString = $"Data Source = {_path}"+";";
                _sqlConnection = new SQLiteConnection(sqlConnectionString);
                if (!File.Exists(_path))
                    SQLiteConnection.CreateFile(_path);
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
/*Maftoul Omar 2019*/

using System.Data;
using System.Data.SQLite;


namespace WorldCup
{
        public class TeamsDataBase
        {
            private readonly string _dataSource = @"teams.db";
            private SQLiteConnection _sqlConnection;

            public TeamsDataBase()
            {
                OpenConnection();
            }
            private void OpenConnection()
            {
                var  sqlConnectionStrin = $"Data Source = {_dataSource}";
                _sqlConnection = new SQLiteConnection(sqlConnectionString);
                _sqlConnection.Open();
             }

            private void CloseConnection()
            {
                _sqlConnection.Close();
            }

        public string ReadDatabase()
        {
            /*TO DO */
        }

    }

}
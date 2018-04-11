using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCollection.Utility
{
    public class SqliteDatabase : IDisposable
    {
        private readonly string name;
        private SQLiteConnection database;

        public SqliteDatabase(string databaseName)
        {
            name = databaseName;
            InitializeDatabase();            
        }
        public void Dispose()
        {
            database.Close();
            database.Dispose();
        }

        public void CreateTable(string tableName, string primaryColumn)
        {
            string query = string.Format("CREATE TABLE IF NOT EXISTS {0} ({1} TEXT NOT NULL PRIMARY KEY); ", tableName, primaryColumn);
            ExecuteWriteQuery(query);
        }
        public void CreateColumn(string tableName, string columnName)
        {
            if (ColumnExists(tableName, columnName))
                return;

            string query = string.Format("ALTER TABLE {0} ADD COLUMN {1} TEXT;", tableName, columnName);
            ExecuteWriteQuery(query);
        }
        public void AddRow(string tableName, Dictionary<string, object> entry)
        {
            string keys = string.Join(", ", entry.Keys);
            string values = string.Format("'{0}'", string.Join("', '", entry.Values));

            string query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, keys, values);
            ExecuteWriteQuery(query);
        }
        public List<Dictionary<string, object>> GetRows(string tableName)
        {
            DataTable table = GetTable(tableName);

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            foreach (DataRow row in table.Rows)
            {
                Dictionary<string, object> current = new Dictionary<string, object>();
                foreach (DataColumn column in table.Columns)
                    current.Add(column.ColumnName, row[column]);

                result.Add(current);
            }

            return result;
        }
        public void ClearTable(string tableName)
        {
            string query = string.Format("DELETE FROM {0};", tableName);
            ExecuteWriteQuery(query);
        }

        public void PrintTable(string tableName)
        {
            DataTable table = GetTable(tableName);
            Console.Write(ConvertDataTableToString(table));
        }
        public void PrintTablenames()
        {
            DataTable table = GetTableNames();
            Console.Write(ConvertDataTableToString(table));
        }

        private void InitializeDatabase()
        {
            OpenDatabase();
        }
        private void OpenDatabase()
        {
            database = new SQLiteConnection(string.Format("Data Source={0};Version=3;", name));
            database.Open();
        }

        private bool ColumnExists(string tableName, string columnName)
        {
            DataTable table = GetTable(tableName);
            return table.Columns.Contains(columnName);
        }

        private DataTable GetTable(string tableName)
        {
            return ExecuteReadQuery(string.Format("SELECT * from {0}", tableName));
        }
        private DataTable GetTableNames()
        {
            return ExecuteReadQuery(string.Format("SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1"));
        }
        private DataTable ExecuteReadQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, database);
            SQLiteDataReader reader = command.ExecuteReader();

            DataTable result = new DataTable();
            result.Load(reader);

            reader.Close();
            reader.Dispose();
            command.Dispose();

            return result;
        }
        private void ExecuteWriteQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, database);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    
        private string ConvertDataTableToString(DataTable dataTable)
        {
            var output = new StringBuilder();

            var columnsWidths = new int[dataTable.Columns.Count];

            // Get column widths
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    var length = row[i].ToString().Length;
                    if (columnsWidths[i] < length)
                        columnsWidths[i] = length;
                }
            }

            // Get Column Titles
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var length = dataTable.Columns[i].ColumnName.Length;
                if (columnsWidths[i] < length)
                    columnsWidths[i] = length;
            }

            // Write Column titles
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var text = dataTable.Columns[i].ColumnName;
                output.Append("|" + PadCenter(text, columnsWidths[i] + 2));
            }
            output.Append("|\n" + new string('=', output.Length) + "\n");

            // Write Rows
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    var text = row[i].ToString();
                    output.Append("|" + PadCenter(text, columnsWidths[i] + 2));
                }
                output.Append("|\n");
            }
            return output.ToString();
        }
        private string PadCenter(string text, int maxLength)
        {
            int diff = maxLength - text.Length;
            return new string(' ', diff / 2) + text + new string(' ', (int)(diff / 2.0 + 0.5));

        }
    }
}

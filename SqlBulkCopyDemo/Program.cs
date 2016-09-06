using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBulkCopyDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            var entities = new Entities();

            var tempTable = new DataTable("#tempTable");
            var nameColumn = new DataColumn("Name", typeof(string));
            var isMaleColumn = new DataColumn("IsMale", typeof(bool));

            tempTable.Columns.Add(nameColumn);
            tempTable.Columns.Add(isMaleColumn);

            var row = tempTable.NewRow();
            row[0] = "new added";
            row[1] = false;

            tempTable.Rows.Add(row);
            tempTable.AcceptChanges();

            using (var bulkCopy = new SqlBulkCopy(ConfigurationManager.ConnectionStrings["Entities"].ConnectionString))
            {
                bulkCopy.DestinationTableName = "dbo.Angas";
                bulkCopy.WriteToServer(tempTable);
            }

            var sql = @"select name from dbo.Angas";
            var result = entities.Database.SqlQuery<string>(sql);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

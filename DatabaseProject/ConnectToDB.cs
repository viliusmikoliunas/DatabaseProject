using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    class ConnectToDB
    {
        public DataTable GetTableFromDB(string tableName)
        {
            string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FridgeBussiness;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from " + tableName, connection);
            DataTable table;
            using (DataSet set = new DataSet("TempSet"))
            {
                adapter.FillSchema(set, SchemaType.Source, tableName);
                adapter.Fill(set, tableName);
                table = set.Tables[tableName];
            }
            connection.Close();
            connection.Dispose();
            return table;
        }
    }

    class DateOperations
    {
        public DateTime DateParsing(string yy, string mm, string dd)
        {
            int year = Int32.Parse(yy);
            int month = Int32.Parse(mm);
            int day = Int32.Parse(dd);
            return new DateTime(year, month, day);
        }
    }

    class DriverTable
    {
        public DataTable GenerateDataTableForDriver()
        {
            DataTable newTable = new DataTable();
            newTable.Columns.AddRange(new []
            {
                new DataColumn("FridgeId",typeof(int)),
                new DataColumn("Client",typeof(string)), 
                new DataColumn("Address",typeof(string)),
                new DataColumn("DeliverUntil",typeof(DateTime)),
                new DataColumn("IsDelivered",typeof(bool))
            });
            for (int i = 0; i < newTable.Columns.Count - 1; i++) newTable.Columns[i].ReadOnly = true;
            using (var conn = new FridgeBussinessEntities2())
            {
                DataRow newnew = newTable.NewRow();
                var driver =
                    from dd in conn.Driver
                    join ff in conn.Fridge on dd.PersonalCode equals ff.DeliveringDriverPersonalCode
                    select new {drv = dd.FirstName+" "+dd.LastName, FridgeId = ff.FridgeID,
                        cust = ff.Customer, until = ff.DeliverUntil, delivered = (ff.DeliveredAt!=null)}
                    ;
                foreach (var car in driver)
                {
                    if (car.drv.Equals("Vasia Jonavicius")&&!car.delivered)
                    {
                        DataRow newRow = newTable.NewRow();
                        newRow[0] = car.FridgeId;
                        newRow[1] = car.cust;
                        newRow[2] = conn.Customer.FirstOrDefault(c => c.CustomerName == car.cust).Address;
                        newRow[3] = car.until;
                        newTable.Rows.Add(newRow);
                    }
                }
            }
            return newTable;
        }

        public DataTable FillDataTable(DataTable table)
        {

            return table;
        }
    }
}

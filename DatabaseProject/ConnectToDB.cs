using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    /*
     * fix warehouse table for warehouse purposes only
       kiek laiko vairuotojas uztrunka nuvezti viena saldytuva
     * 
     */
    class ConnectToDB
    {
        public DataTable GetTableFromDB(string selection, string location, string condition = "")
        {
            string connectionStr = 
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FridgeBussiness;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string command = "Select " + selection + " from " + location;
            command = string.IsNullOrEmpty(condition) ? command : command + " " + condition;
            DataTable table;

            using (var connection = new SqlConnection(connectionStr))
            using (var adapter = new SqlDataAdapter(command, connection))
            using (var set = new DataSet("TempSet"))
            {
                adapter.FillSchema(set, SchemaType.Source, location);
                adapter.Fill(set, location);
                table = set.Tables[location];
            }
            return table;
        }
    }

    class DateOperations
    {
        public DateTime DateParsing(string yy, string mm, string dd)
        {
            int year = int.Parse(yy);
            int month = int.Parse(mm);
            int day = int.Parse(dd);
            return new DateTime(year, month, day);
        }
    }

    class DriverTable
    {
        public DataTable GetDriverTable(string driverFullName)
        {
            DataTable newTable = GenerateEmptyDriverTable();
            using (var connection = new FridgeBussinessEntities2())
            {
                var driverTable =
                    from dd in connection.Driver
                    join ff in connection.Fridge on dd.PersonalCode equals ff.DeliveringDriverPersonalCode
                    select new
                    {
                        driver = dd.FirstName + " " + dd.LastName,
                        FridgeId = ff.FridgeID,
                        cust = ff.Customer,
                        until = ff.DeliverUntil,
                        delivered = ff.DeliveredAt
                    };
                foreach (var car in driverTable)
                {
                    if (car.driver.Equals(driverFullName) && car.delivered==null)
                    {
                        DataRow newRow = newTable.NewRow();
                        newRow["FridgeId"] = car.FridgeId;
                        newRow["Client"] = car.cust;
                        newRow["Address"] = connection.Customer.Single(c => c.CustomerName == car.cust).Address;
                        newRow["DeliverUntil"] = car.until;
                        newRow["Delivered"] = null;
                        newTable.Rows.Add(newRow);
                    }
                }
            }
            return newTable;
        }

        private DataTable GenerateEmptyDriverTable()
        {
            DataTable newTable = new DataTable();
            newTable.Columns.AddRange(new[]
            {
                new DataColumn("FridgeId",typeof(int)),
                new DataColumn("Client",typeof(string)),
                new DataColumn("Address",typeof(string)),
                new DataColumn("DeliverUntil",typeof(DateTime)),
                new DataColumn("Delivered",typeof(string))
            });
            return newTable;
        }
    }
}

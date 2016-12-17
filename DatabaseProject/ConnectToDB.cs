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
            SqlConnection connection = new SqlConnection(connectionStr);
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable table;
            using (DataSet set = new DataSet("TempSet"))
            {
                adapter.FillSchema(set, SchemaType.Source, location);
                adapter.Fill(set, location);
                table = set.Tables[location];
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
        public DataTable GenerateDataTableForDriver(string driverFullName)
        {
            DataTable newTable = new DataTable();
            newTable.Columns.AddRange(new []
            {
                new DataColumn("FridgeId",typeof(int)),
                new DataColumn("Client",typeof(string)), 
                new DataColumn("Address",typeof(string)),
                new DataColumn("DeliverUntil",typeof(DateTime)),
                new DataColumn("Delivered",typeof(string))
            });
            using (var conn = new FridgeBussinessEntities2())
            {
                var driver =
                    from dd in conn.Driver
                    join ff in conn.Fridge on dd.PersonalCode equals ff.DeliveringDriverPersonalCode
                    select new {drv = dd.FirstName+" "+dd.LastName, FridgeId = ff.FridgeID,
                        cust = ff.Customer, until = ff.DeliverUntil, delivered = ff.DeliveredAt}
                    ;
                foreach (var car in driver)
                {
                    if (car.drv.Equals(driverFullName) &&car.delivered==null)
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
    }
}

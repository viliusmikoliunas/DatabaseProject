using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class ReviewOrderedForm : Form
    {
        private const int week = 7;
        private string currentClient;
        public ReviewOrderedForm(string currentClient)
        {
            InitializeComponent();
            this.currentClient = currentClient;
            label1.Text += AverageOrderToDeliveryTime();
        }

        private void ReviewOrderedForm_Load(object sender, EventArgs e)
        {
            label.Text = currentClient;
            ConnectToDB connect = new ConnectToDB();
            DataTable orderTable = connect.GetTableFromDB("Mass,Volume,ManufacturedOn,DeliverUntil","Fridge", string.Format("where Customer = '{0}' and DeliveredAt is null", currentClient));
            orderTable.Columns.Add(new DataColumn("ExpectedDelivery", typeof(DateTime)));
            fillExpectedDeliveryColumn(orderTable, AverageOrderToDeliveryTime());
            orderedGrid.DataSource = orderTable;
        }

        private TimeSpan AverageOrderToDeliveryTime()
        {
            TimeSpan total = new TimeSpan(0);
            int counter;
            using (var connection = new FridgeBussinessEntities2())
            {
                Fridge[] fridges = connection.Fridge.ToArray();
                foreach (var fr in fridges.Where(f=>f.DeliveredAt!=null))
                {
                    TimeSpan span = fr.DeliverUntil.Value - fr.DeliveredAt.Value;
                    total += span + new TimeSpan(ClientForm.OrderToDeliverDayCount);
                }
                counter = connection.Fridge.Count(c => c.DeliveredAt!=null);
            }
            return new TimeSpan(total.Ticks / counter);
        }

        private void fillExpectedDeliveryColumn(DataTable table, TimeSpan span)
        {
            foreach (DataRow row in table.Rows)
            {
                DateTime newTime = (DateTime) row["DeliverUntil"] - span;
                if (newTime.Hour > 17) newTime = newTime.AddHours(14);
                else if (newTime.Hour < 7)  newTime = newTime.AddHours(8);
                newTime = newTime.AddTicks(-(newTime.Ticks % TimeSpan.TicksPerHour));//trunc minutes and seconds
                if (newTime.DayOfWeek == DayOfWeek.Saturday || newTime.DayOfWeek == DayOfWeek.Sunday)
                    newTime = newTime.AddDays(2);
                row["ExpectedDelivery"] = newTime;
            }            
        }


        #region experiments
        private int AverageDeliveriesPerDay()
        {
            int days;
            int fridges;
            using (var connection = new FridgeBussinessEntities2())
            {
                days = connection.Fridge.Select(f => f.DeliveredAt).Distinct().Count();
                fridges = connection.Fridge.Count();
            }
            return fridges / days;
        }
        private void tesstt(DataTable table)
        {
            using (var sms = new FridgeBussinessEntities2())
            {
                var fridges = sms.Fridge.AsQueryable().Where(c => c.Customer == currentClient);
                fridges = fridges.OrderBy(f => f.DeliveringDriverPersonalCode).ThenBy(f => f.DeliverUntil);
                
                
                foreach (var fr in fridges)
                {
                    




                    label1.Text += "\n" +
                                   sms.Driver.First(d => d.PersonalCode == fr.DeliveringDriverPersonalCode).FirstName +
                                   " " + fr.DeliverUntil;
                }
                //var collection = sms.Fridge.AsQueryable().Where(c => c.Customer == currentClient).GroupBy(c=>c.DeliveringDriverPersonalCode);

            }

        }
        //struct FirstAndLast
        //{
        //    public DateTime? first;
        //    public DateTime? last;
        //    public int amplitude => (last.Value - first.Value).Days;
        //}
        private DataTable testinMethod(DataTable orderTable)
        {
            //using (var connection = new FridgeBussinessEntities2())
            //{
            //    var smth = connection.Fridge.GroupBy(f => f.DeliveringDriverPersonalCode);
            //    List<FirstAndLast> list = new List<FirstAndLast>();
            //    foreach (var op in smth)
            //    {
            //        DateTime? temp1 = op.AsQueryable().Where(d => d.Customer == currentClient).Select(f => f.DeliverUntil).Min();
            //        DateTime? temp2 = op.AsQueryable().Where(d => d.Customer == currentClient).Select(f => f.DeliverUntil).Max();
            //        list.Add(new FirstAndLast
            //        {
            //            first = temp1,
            //            last = temp2
            //        });
            //    }
            //    foreach (var ll in list)
            //    {
            //        label1.Text += "\n" + ll.first + " " + ll.last + " amp =" + ll.amplitude;
            //    }
            //}

            return orderTable;
        }
        #endregion
    }
}

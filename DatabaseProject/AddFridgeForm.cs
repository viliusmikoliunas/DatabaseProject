﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class AddFridgeForm : Form
    {
        private int fridgeID;
        FridgeForm _owner;
        public AddFridgeForm(FridgeForm owner, int index = -1)
        {
            _owner = owner;
            InitializeComponent();
            fridgeID = index;
        }

        private void AddFridgeForm_Load(object sender, EventArgs e)
        {
            ManufactureDateYYBox.DataSource = Enumerable.Range(2006, DateTime.Now.Year - 2005).Reverse().ToList();
            ManufactureDateMMBox.DataSource = Enumerable.Range(1, 12).ToList();
            ManufactureDateDDBox.DataSource = Enumerable.Range(1, 31).ToList();

            DeliverYYBox.DataSource = Enumerable.Range(DateTime.Now.Year, 4).ToList();
            DeliverMMBox.DataSource = Enumerable.Range(1, 12).ToList();
            DeliverDDBox.DataSource = Enumerable.Range(1, 31).ToList();

            using (var temp = new FridgeBussinessEntities2())
            {
                CustomerBox.DataSource = temp.Customer.Select(c => c.CustomerName).ToList();
                DriverBox.DataSource = temp.Driver.Select(d => d.FirstName + " " + d.LastName).ToList();
            }

            if(fridgeID==-1)
            {
                CustomerBox.SelectedIndex = -1;
                DriverBox.SelectedIndex = -1;

                DeliverYYBox.SelectedIndex = -1;
                DeliverMMBox.SelectedIndex = -1;
                DeliverDDBox.SelectedIndex = -1;
            }
            else
            {
                Text = "Edit Fridge";
                button1.Text = "Save edit";
                using(var conn = new FridgeBussinessEntities2())
                {
                    Fridge current = conn.Fridge.FirstOrDefault(c => c.FridgeID == fridgeID);
                    MassBox.Text = current.Mass.ToString();
                    VolumeBox.Text = current.Volume.ToString();
                    ManufactureDateYYBox.SelectedItem = current.ManufacturedOn.Year;
                    ManufactureDateMMBox.SelectedItem = current.ManufacturedOn.Month;
                    ManufactureDateDDBox.SelectedItem = current.ManufacturedOn.Day;
                    CustomerBox.SelectedItem = current.Customer;
                    DriverBox.SelectedItem = (current.Driver != null) ? current.Driver.FirstName + " " + current.Driver.LastName : null;
                    DeliverYYBox.SelectedItem = current.DeliverUntil.Value.Year;
                    DeliverMMBox.SelectedItem = current.DeliverUntil.Value.Month;
                    DeliverDDBox.SelectedItem = current.DeliverUntil.Value.Day;
                }
            }
        }

        private void ManufacturedDateMMBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int currYear = short.Parse(ManufactureDateYYBox.Text);
            int currMonth = short.Parse(ManufactureDateMMBox.Text);
            ManufactureDateDDBox.DataSource = Enumerable.Range(1, DateTime.DaysInMonth(currYear, currMonth)).ToList();
        }

        private void DeliverMMBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int currYear = short.Parse(DeliverYYBox.Text);
            int currMonth = short.Parse(DeliverMMBox.Text);
            DeliverDDBox.DataSource = Enumerable.Range(1, DateTime.DaysInMonth(currYear, currMonth)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fridge newFridge = new Fridge();
            decimal volume;
            int mass;
            bool isValid = validateVolumeAndMass(out volume, out mass);
            if (isValid)
            {
                newFridge = CreateFridge(volume, mass);
                SaveFridge(newFridge);
                Close();
            }
        }

        private void AddFridgeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.Form1_Load(null, null);
        }

        //----------

        private bool validateVolumeAndMass(out decimal volume, out int mass)
        {
            ValidationClass valid = new ValidationClass();
            CorrectValue correct = new CorrectValue();
            volume = 0;
            mass = 0;
            if (valid.ValidateVolume(VolumeBox.Text)) volume = decimal.Parse(correct.CorrectVolume(VolumeBox.Text));
            else
            {
                MessageBox.Show("Incorrect volume format");
                return false;
            }
            if (valid.ValidateMass(MassBox.Text)) mass = int.Parse(MassBox.Text);
            else
            {
                MessageBox.Show("Incorrect mass format");
                return false;
            }
            return true;
        }
        private Fridge CreateFridge(decimal volume, int mass)
        {
            using (var conn = new FridgeBussinessEntities2())
            {
                DateOperations dop = new DateOperations();
                return new Fridge
                {
                    FridgeID = fridgeID != -1 ? fridgeID : -1,
                    Mass = mass,
                    Volume = volume,
                    ManufacturedOn =
                        dop.DateParsing(ManufactureDateYYBox.Text, ManufactureDateMMBox.Text, ManufactureDateDDBox.Text),
                    Customer = conn.Customer.FirstOrDefault(c => c.CustomerName == CustomerBox.Text).CustomerName,
                    DeliverUntil =
                        dop.DateParsing(DeliverYYBox.Text, DeliverMMBox.Text, DeliverDDBox.Text),
                    DeliveringDriverPersonalCode =
                        conn.Driver.First(d => d.FirstName + " " + d.LastName == DriverBox.Text).PersonalCode,
                    Driver = conn.Driver.First(d => d.FirstName + " " + d.LastName == DriverBox.Text)
                };
            }
        }

        private void SaveFridge(Fridge newFridge)
        {
            using (var conn = new FridgeBussinessEntities2())
            {
                if (fridgeID == -1)
                {
                    conn.Fridge.Add(newFridge);
                    conn.SaveChanges();
                }
                else
                {
                    Fridge temp = conn.Fridge.FirstOrDefault(f => f.FridgeID == newFridge.FridgeID);
                    conn.Fridge.Remove(temp);
                    conn.Fridge.Add(newFridge);
                    conn.SaveChanges();
                }
            }
        }
    }
}

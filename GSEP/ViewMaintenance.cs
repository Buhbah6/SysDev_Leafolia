using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSEP
{
    public partial class ViewMaintenance : Form
    {
        public ViewMaintenance()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }

        private void ViewMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceDataSet.Maintenance' table. You can move, or remove it, as needed.
            this.maintenanceTableAdapter.Fill(this.maintenanceDataSet.Maintenance);

        }

        private void searchSkuButton_Click(object sender, EventArgs e)
        {
            var dbProducts = new ProjectDBEntities();
            List<Maintenance> maintenanceList = dbProducts.Maintenances.ToList();
            List<Product> productList = dbProducts.Products.ToList();
            bool flag = true;

            foreach (Product product in productList)
            {
                if (product.ProductSKU.Equals(skuTextBox.Text))
                    flag = false;
            }

            foreach (Maintenance maintenance in maintenanceList)
            {
                if (maintenance.ProductSKU.Equals(skuTextBox.Text))
                {
                    strategyTextBox.Text = maintenance.Strategy;
                    initialDateTimePicker.Value = maintenance.InitialDate;
                    intervalNumericUpDown.Value = maintenance.Interval;
                    return;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || flag)
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku to search.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("No maintenance strategy found. \nPlease create one for this product.",
                    "No Set Strategy", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addScheduleButton_Click(object sender, EventArgs e)
        {
            var scheduleManagement = new ProjectDBEntities();
            List<Maintenance> maintenanceList = scheduleManagement.Maintenances.ToList();
            bool validProduct = true;

            List<Product> productList = scheduleManagement.Products.ToList();
            bool flag = false;

            foreach (Product product in productList)
            {
                if (product.ProductSKU.Equals(skuTextBox.Text))
                    flag = true;
            }

            foreach (Maintenance m in maintenanceList)
            {
                if (m.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = false;
                    MessageBox.Show("Already assigned Strategy.\nThis product already has a maintenance strategy assigned.",
                    "Already assigned Strategy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || String.IsNullOrEmpty(strategyTextBox.Text))
                validProduct = false;

            if (flag)
            {
                if (validProduct)
                {
                    String tempID;
                    if (maintenanceList.Count == 0)
                        tempID = "00001";
                    else
                    {
                        tempID = (Convert.ToInt32(maintenanceList[maintenanceList.Count - 1].MaintenanceID) + 1) + "";
                        for (int i = tempID.Length; i < 5; i++)
                            tempID = "0" + tempID;
                    }


                    String command = "INSERT INTO Maintenance VALUES ('" + tempID + "','" + skuTextBox.Text +
                        "','" + strategyTextBox.Text + "','" + initialDateTimePicker.Value + "','" + intervalNumericUpDown.Value + "');";
                    scheduleManagement.Database.ExecuteSqlCommand(command);
                }
                else
                {
                    MessageBox.Show("Missing Field.\nPlease enter data for all fields to add Maintenance Strategy successfully.",
                        "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku to search.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.maintenanceTableAdapter.Fill(this.maintenanceDataSet.Maintenance);
        }

        private void modifyScheduleButton_Click(object sender, EventArgs e)
        {
            bool validProduct = false;
            var dbProducts = new ProjectDBEntities();
            Maintenance currentMaintenance = new Maintenance();
            List<Maintenance> mainList = dbProducts.Maintenances.ToList();
            foreach (Maintenance maintenance in mainList)
            {
                if (maintenance.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = true;
                    currentMaintenance = maintenance;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku to modify a Maintenance Strategy.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(strategyTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Invalid Strategy.\nPlease enter a valid Sku and Strategy to modify a Maintenance Strategyt.",
                    "Invalid Strategy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(initialDateTimePicker.Value.ToString()) || validProduct == false)
            {
                MessageBox.Show("Invalid Initial Date.\nPlease enter a valid Sku and Initial Date to modify a Maintenance Strategy.",
                    "Invalid Initial Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (intervalNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Invalid Interval.\nPlease enter a valid Sku and daily interval between maintenance to modify a Maintenance Strategy.",
                    "Invalid Interval", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = "UPDATE Maintenance SET Strategy = '" + strategyTextBox.Text + "' WHERE ProductSku = '" +
                    skuTextBox.Text + "';";
                dbProducts.Database.ExecuteSqlCommand(command);

                command = "UPDATE Maintenance SET InitialDate = '" + initialDateTimePicker.Value + "' WHERE ProductSku = '" +
                    skuTextBox.Text + "';";
                dbProducts.Database.ExecuteSqlCommand(command);

                command = "UPDATE Maintenance SET Interval = '" + intervalNumericUpDown.Text + "' WHERE ProductSku = '" +
                    skuTextBox.Text + "';";
                dbProducts.Database.ExecuteSqlCommand(command);
            }
            this.maintenanceTableAdapter.Fill(this.maintenanceDataSet.Maintenance);
        }

        private void deleteScheduleButton_Click(object sender, EventArgs e)
        {
            var deleteMaintenance = new ProjectDBEntities();
            List<Maintenance> mainList = deleteMaintenance.Maintenances.ToList();
            Maintenance currentMaintenance = new Maintenance();
            string command = "";
            bool validProduct = false;

            foreach (Maintenance maintenance in mainList)
            {
                if (maintenance.ProductSKU.Equals(skuTextBox.Text))
                {
                    validProduct = true;
                    currentMaintenance = maintenance;
                }
            }
            if (String.IsNullOrEmpty(skuTextBox.Text) || validProduct == false)
            {
                MessageBox.Show("Sku not found.\nPlease enter a valid Sku to delete a Maintenance Strategy.",
                    "Sku unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dg = MessageBox.Show("Are you sure you want to delete the strategy for product: " + skuTextBox.Text + "?\n This action cannot be undone.", "Delete Maintenance Strategy?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    command = "DELETE FROM Maintenance WHERE ProductSKU = '" + skuTextBox.Text + "';";
                    deleteMaintenance.Database.ExecuteSqlCommand(command);
                    MessageBox.Show("Maintenance Strategy Deleted Successfully.", "Maintenance Strategy Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Maintenance Strategy Deletion Cancelled.", "Maintenance Strategy NOT Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.maintenanceTableAdapter.Fill(this.maintenanceDataSet.Maintenance);
        }
    }
}

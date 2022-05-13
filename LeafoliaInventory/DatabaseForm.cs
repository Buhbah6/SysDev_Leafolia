using LeafoliaInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeafoliaInventory
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
            // TODO: This line of code loads data into the 'maintenanceDataSet.Maintenance' table. You can move, or remove it, as needed.
            this.maintenanceTableAdapter.Fill(this.maintenanceDataSet.Maintenance);
            // TODO: This line of code loads data into the 'employeesDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDataSet.Employees);

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            this.Hide();
            mmf.ShowDialog();
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int yAxis = 60;
            Font font = new Font("Arial", 12, FontStyle.Regular);

            var databaseModel = new ProjectDBEntities();
            List<Employee> employees = databaseModel.Employees.ToList();
            List<Maintenance> maintenances = databaseModel.Maintenances.ToList();
            List<Product> products = databaseModel.Products.ToList();

            e.Graphics.DrawString("Database Contents", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Employees:", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 40));

            foreach (Employee employee in employees)
            {
                e.Graphics.DrawString(employee.ToString(), font, Brushes.Black, new Point(10, yAxis));
                yAxis += 20;
            }

            yAxis += 20;
            e.Graphics.DrawString("Maintenance Strategies:", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yAxis));
            yAxis += 20;
            foreach (Maintenance maintenance in maintenances)
            {
                e.Graphics.DrawString(maintenance.ToString(), font, Brushes.Black, new Point(10, yAxis));
                yAxis += 100;
            }

            e.Graphics.DrawString("Products:", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yAxis));
            yAxis += 20;
            foreach (Product product in products)
            {
                e.Graphics.DrawString(product.ToString(), font, Brushes.Black, new Point(10, yAxis));
                yAxis += 60;
            }

        }
    }
}

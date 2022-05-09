using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeafoliaInventory
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            createUsersButton.Enabled = true;
            manageUsersButton.Enabled = true;
            manageMaintenanceButton.Enabled = true;
            dbButton.Enabled = true;

            var permEntities = new ProjectDBEntities();
            List<Employee> employeeList = permEntities.Employees.ToList();
            String perms = "";
            foreach (Employee emp in employeeList)
            {
                if (emp.EmployeeID.Equals(LoginForm.currentEmployeeId))
                    perms = emp.Permissions;
            }

            if (perms.Contains('0'))
                dbButton.Enabled = false;
            if (perms.ElementAt(1) == '0')
                manageMaintenanceButton.Enabled = false;
            if (perms.ElementAt(2) == '0')
                createUsersButton.Enabled = false;
            if (perms.ElementAt(4) == '0')
                manageUsersButton.Enabled = false;
        }

        private void createUsersButton_Click(object sender, EventArgs e)
        {
            CreateUserForm cuf = new CreateUserForm();
            this.Hide();
            cuf.ShowDialog();
            this.Close();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm muf = new ManageUsersForm();
            this.Hide();
            muf.ShowDialog();
            this.Close();
        }

        private void manageProductsButton_Click(object sender, EventArgs e)
        {
            ViewProductsForm vpf = new ViewProductsForm();
            this.Hide();
            vpf.ShowDialog();
            this.Close();
        }

        private void manageMaintenanceButton_Click(object sender, EventArgs e)
        {
            ViewMaintenance vm = new ViewMaintenance();
            this.Hide();
            vm.ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
            this.Close();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cf = new ChangePasswordForm();
            this.Hide();
            cf.ShowDialog();
            this.Close();
        }

        private void dbButton_Click(object sender, EventArgs e)
        {
            DatabaseForm dbf = new DatabaseForm();
            this.Hide();
            dbf.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYEManagement
{
    public partial class ctlEmployee : UserControl
    {
        private EmployeeController employeeController;
        public ctlEmployee()
        {
            InitializeComponent();
            pnlAdd.Hide();
            employeeController = new EmployeeController();
            employeeController.loadEmployees();
            lstEm.DataSource = employeeController.getEmployeeList();
        }
   
        /// <summary>
        /// show selected employee detail in text box
        /// </summary>
        private void showSelectItem(object sender, EventArgs e)
        {
            if (lstEm.SelectedIndex < 0)
            {
                clearEditText();
            }
            else
            {
                txtID.Text = employeeController.getID(lstEm.SelectedIndex);
                txtNick.Text = employeeController.getNickName(lstEm.SelectedIndex);
                txtLast.Text = employeeController.getLastName(lstEm.SelectedIndex);
                txtFirst.Text = employeeController.getFirstName(lstEm.SelectedIndex);
                txtIRD.Text = employeeController.getIRDNumber(lstEm.SelectedIndex);
                txtCode.Text = employeeController.getTaxCode(lstEm.SelectedIndex);
                txtPhone.Text = employeeController.getPhoneNumber(lstEm.SelectedIndex);
            }
        }
        /// <summary>
        /// clear text box
        /// </summary>
        private void clearEditText()
        {
            txtID.Text = "";
            txtNick.Text = "";
            txtLast.Text = "";
            txtFirst.Text = "";
            txtIRD.Text = "";
            txtCode.Text = "";
            txtPhone.Text = "";
        }
        /// <summary>
        /// Delete Employee
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(employeeController.deleteEmployee(lstEm.SelectedIndex))
            {
                clearEditText();
                if (employeeController.getEmployeeList().Count > 0)
                {
                    lstEm.SelectedIndex = 0;
                }
            }
           
        }
        /// <summary>
        /// Update Employee
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(employeeController.updateEmployee(lstEm.SelectedIndex, txtNick.Text, txtFirst.Text, txtLast.Text,
                txtIRD.Text, txtPhone.Text, txtCode.Text))
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[employeeController.getEmployeeList()];
                cm.Refresh();
            }
        }
        /// <summary>
        /// Add new Employee
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();
            btnAdd.Visible = false;
        }
        /// <summary>
        /// Save new Employee
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (employeeController.addNewEmployee(txtAddID.Text.Trim(), txtAddNick.Text, txtAddFirst.Text,
                txtAddLast.Text, txtAddIRD.Text, txtAddNum.Text, txtAddCode.Text))
            {
                lstEm.SelectedIndex = lstEm.Items.Count - 1;
                pnlAdd.Hide();
            }
        }
        /// <summary>
        /// Cancel add Employee
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Hide();
            btnAdd.Visible = true;

        }
        /// <summary>
        /// Exit system
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}

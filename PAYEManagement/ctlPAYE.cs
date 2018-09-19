using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace PAYEManagement
{
    public partial class ctlPAYE : UserControl
    {
        private List<Employee> employeeList = new List<Employee>();
        private EmployeeController employeeController;
        private PAYEController payeController;

        public ctlPAYE()
        {
            InitializeComponent();
            pnlAddRecord.Hide();
            payeController = new PAYEController();
            payeController.LoadPAYEList();
            employeeController = new EmployeeController();
            employeeController.loadEmployees();
            dgvPAYE.DataSource = payeController.getEmployeePAYEList();
        }
        /// <summary>
        /// Create new PAYE records
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnlAddRecord.Show();
            lstEm.DataSource = employeeController.getEmployeeList();
        }
        /// <summary>
        /// Get employee list
        /// </summary>
        private void lstEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeController.checkSelectRange(lstEm.SelectedIndex))
            {
                txtID.Text = employeeController.getID(lstEm.SelectedIndex);
                txtLast.Text = employeeController.getLastName(lstEm.SelectedIndex);
                txtFirst.Text = employeeController.getFirstName(lstEm.SelectedIndex);
                txtIRD.Text = employeeController.getIRDNumber(lstEm.SelectedIndex);
                txtCode.Text = employeeController.getTaxCode(lstEm.SelectedIndex);
            }
        }
        /// <summary>
        ///cancel add record
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddRecord.Hide();
        }
        /// <summary>
        /// save records
        /// </summary>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            payeController.addNewRecord(txtID.Text.Trim(), txtLast.Text, txtFirst.Text,
               txtIRD.Text, txtCode.Text, txtHours.Text, txtPAYE.Text, txtSL.Text, txtKW.Text, txtNet.Text);
            pnlAddRecord.Hide();
        }
        /// <summary>
        /// delete PAYE records
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] selectedIndexes = new int[dgvPAYE.SelectedRows.Count];
            int index = 0;
            foreach (DataGridViewRow row in dgvPAYE.SelectedRows)
            {
                selectedIndexes[index++] = row.Index;
            }
            payeController.deleteItems(selectedIndexes);
        }
        /// <summary>
        /// Exit the form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        /// <summary>
        /// Print invoice
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPAYE.Rows.Count == 0)
            {
                MessageBox.Show("There is no record in the sheet, please add first");
            }
            else
            {
                prtPreview.ShowDialog();
            }
        }
        /// <summary>
        /// show invoice in print view dialog
        /// </summary>
        private void printInvoice(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font textFont = new Font("Arial", 20, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 15, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 15, FontStyle.Bold);
            Font headingFont = new Font("Arial", 24, FontStyle.Bold);
            //set the row in the vacancy table

            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 200;
            int rightMargin = e.MarginBounds.Right;

            g.DrawString("Invoice", headingFont, brush, leftMargin + headingLeftMargin, topMargin + textFont.Height);

            g.DrawString("\r\n"+"Date : " + DateTime.Now.ToShortDateString(), textFont, brush, leftMargin + headingLeftMargin * 2, topMargin + textFont.Height);

            g.DrawString(payeController.getInvoice(), textFont, brush, leftMargin, topMargin + textFont.Height);

            
        }

    }
}

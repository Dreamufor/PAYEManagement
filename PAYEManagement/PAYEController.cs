using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYEManagement
{
    class PAYEController
    {
        private const string FILE_PATH = @"c:\temp\EmployeePAYE.txt";
        private BindingList<EmployeePAYE> employeePAYEList = new BindingList<EmployeePAYE>();
        private Regex numberChecker = new Regex(@"^\d(\.\d{0,2})?");
        /// <summary>
        /// Load current PAYE records from txt file.
        /// </summary>
        public void LoadPAYEList()
        {
            foreach (string line in File.ReadLines(FILE_PATH))
            {

                String[] parts = line.Split('$');
                if (parts.Length != 10)
                {
                    continue;
                }
                EmployeePAYE employeePAYE = new EmployeePAYE();
                employeePAYE.ID = parts[0].Trim();
                employeePAYE.LastName = parts[1].Trim();
                employeePAYE.FirstName = parts[2].Trim();
                employeePAYE.IRDNumber = parts[3].Trim();
                employeePAYE.TaxCode = parts[4].Trim();
                employeePAYE.Hours = parts[5].Trim();
                employeePAYE.PAYE = parts[6].Trim();
                employeePAYE.StudentLoan = parts[7].Trim();
                employeePAYE.Kiwisaver = parts[8].Trim();
                employeePAYE.NetPay = parts[9].Trim();
                employeePAYEList.Add(employeePAYE);
            }
        }
        /// <summary>
        /// Write data to file
        /// </summary>
        public void writeToFile()
        {
            System.IO.File.WriteAllLines(FILE_PATH, employeePAYEList.Select(e =>
            {
                return e.toOneLine();
            }).ToArray());
        }
        /// <summary>
        /// Binding records
        /// </summary>
        public BindingList<EmployeePAYE> getEmployeePAYEList()
        {
            return employeePAYEList;
        }
        /// <summary>
        /// Add new PAYE records
        /// </summary>
        public void addNewRecord(String ID, String lastName, String firstName, String IRDNumber, String TaxCode, String hours, 
            String PAYE, String studentLoan, String kiwisaver, String netPay)
        {

            if (hours.Length == 0 || PAYE.Length == 0 || studentLoan.Length == 0 ||
               kiwisaver.Length == 0 || netPay.Length == 0)
            {
                MessageBox.Show("You must fill all the fields");
                return;
            }
            else if (!numberChecker.IsMatch(hours) || !numberChecker.IsMatch(PAYE) || !numberChecker.IsMatch(studentLoan) ||
               !numberChecker.IsMatch(kiwisaver) || !numberChecker.IsMatch(netPay))
            {
                MessageBox.Show("Please input valid data");//check if input is valid data
                return;
            } 
            else
            {
                EmployeePAYE employeePAYE = new EmployeePAYE();
                employeePAYE.ID = ID;
                employeePAYE.LastName = lastName;
                employeePAYE.FirstName = firstName;
                employeePAYE.IRDNumber = IRDNumber;
                employeePAYE.TaxCode = TaxCode;
                employeePAYE.Hours = hours;
                employeePAYE.PAYE = PAYE;
                employeePAYE.StudentLoan = studentLoan;
                employeePAYE.Kiwisaver = kiwisaver;
                employeePAYE.NetPay = netPay;
                employeePAYEList.Add(employeePAYE);
                writeToFile();

                MessageBox.Show("The PAYE record have created successfully!");
            }
        }
        /// <summary>
        /// Delete PAYE records
        /// </summary>
        public void deleteItems(int[] selectedIndexes)
        {
            if (MessageBox.Show("Do you want to delete this records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Array.Sort(selectedIndexes);

                for (int i = selectedIndexes.Length - 1; i >= 0; i--)
                {
                    if (checkRange(selectedIndexes[i]))
                    {
                        employeePAYEList.RemoveAt(selectedIndexes[i]);
                    }
                }

                writeToFile();
            }
        }
        /// <summary>
        /// check range
        /// </summary>
        public bool checkRange(int index)
        {
            return index >= 0 && index < employeePAYEList.Count;
        }
        /// <summary>
        /// Get total amount for invoice
        /// </summary>
        public String getInvoice()
        {
            double totalPAYE = 0;
            double totalStudentLoan = 0;
            double totalKiwiSaver = 0;
            double totalPay = 0;
            for (int i = 0; i < employeePAYEList.Count; i++)
            {
                totalPAYE += Convert.ToDouble(employeePAYEList[i].PAYE);
                totalStudentLoan += Convert.ToDouble(employeePAYEList[i].StudentLoan);
                totalKiwiSaver += Convert.ToDouble(employeePAYEList[i].Kiwisaver);
            }

            totalPay = totalPAYE + totalStudentLoan + totalKiwiSaver;

            return "\r\n" + "\r\n"+ "\r\n"+ "Total PAYE / tax on Schedular payments :    " + "\r\n" + "\r\n" + "                                                                    $NZ" + totalPAYE + "\r\n" + "\r\n" +
                "Total Student Loan deductions :   " + "\r\n" + "\r\n" + "                                                                    $NZ " + totalStudentLoan + "\r\n" + "\r\n" +
                "Total KiwiSaver deductions :   " + "\r\n" + "\r\n" + "                                                                    $NZ " + totalKiwiSaver + "\r\n" + "\r\n" + "\r\n" +
                "Total amount payable :  $NZ " + "\r\n" + "\r\n" + "                                                                    $NZ " + totalPay;
        }
        /// <summary>
        /// check if an employee has related PAYE records。
        /// </summary>
        public bool isInvoveEmployee(String ID)
        {
            foreach (EmployeePAYE paye in employeePAYEList)
            {
                if (paye.ID.Equals(ID))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace PAYEManagement
{
    class EmployeeController
    {
        private const String FILE_PATH = @"c:\temp\Employee.txt";
        private BindingList<Employee> employeeList = new BindingList<Employee>();
        private PAYEController payeController;
        /// <summary>
        /// Load Employee data from txt file
        /// </summary>
        public void loadEmployees()
        {
            foreach (string line in File.ReadLines(FILE_PATH))
            {
                String[] parts = line.Split('$');
                if (parts.Length != 7)
                {
                    continue;
                }
                Employee employee = new Employee();
                employee.ID = parts[0].Trim();
                employee.NickName = parts[1].Trim();
                employee.LastName = parts[2].Trim();
                employee.FirstName = parts[3].Trim();
                employee.IRDNumber = parts[4].Trim();
                employee.TaxCode = parts[5].Trim();
                employee.PhoneNumber = parts[6].Trim();

                employeeList.Add(employee);
            }
        }
        /// <summary>
        /// Write data to database
        /// </summary>
        public void writeToFile()
        {
            System.IO.File.WriteAllLines(FILE_PATH, employeeList.Select(e =>
            {
                return e.toOneLine();
            }).ToArray());
        }
        /// <summary>
        /// getEmployeeList
        /// </summary>
        public BindingList<Employee> getEmployeeList()
        {
            return employeeList;
        }
        /// <summary>
        /// getID
        /// </summary>
        public String getID(int index)
        {
            return employeeList[index].ID;
        }
        /// <summary>
        /// getNickName
        /// </summary>
        public String getNickName(int index)
        {
            return employeeList[index].NickName;
        }
        /// <summary>
        /// getLastName
        /// </summary>
        public String getLastName(int index)
        {
            return employeeList[index].LastName;
        }
        /// <summary>
        /// getFirstName
        /// </summary>
        public String getFirstName(int index)
        {
            return employeeList[index].FirstName;
        }
        /// <summary>
        /// getIRD
        /// </summary>
        public String getIRDNumber(int index)
        {
            return employeeList[index].IRDNumber;
        }
        /// <summary>
        /// getTaxCode
        /// </summary>
        public String getTaxCode(int index)
        {
            return employeeList[index].TaxCode;
        }
        /// <summary>
        /// getPhoneNumber
        /// </summary>
        public String getPhoneNumber(int index)
        {
            return employeeList[index].PhoneNumber;
        }
        /// <summary>
        /// check select list
        /// </summary>
        public bool checkSelectRange(int index)
        {
            return index >= 0 && index < employeeList.Count;
        }
        /// <summary>
        /// delete employee
        /// </summary>
        public bool deleteEmployee(int index)
        {
            if (!checkSelectRange(index))//No employee selected
            {
                MessageBox.Show("Please select an employee");
                return false;
            }

            if (payeController == null)//get PAYE records
            {
                payeController = new PAYEController();
                payeController.LoadPAYEList();
            }

            if (payeController.isInvoveEmployee(employeeList[index].ID))//check if there are related records
            {
                MessageBox.Show("You cannot delete an employee with PAYE records, please delete record first.");
                return false;
            }

            if (MessageBox.Show("Do you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                employeeList.RemoveAt(index);
                writeToFile();
                MessageBox.Show("The employee has been deleted successfully");
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
        /// Update employee
        /// </summary>
        public bool updateEmployee(int index, String nickName, String firstName, String lastName, String IRDNumber, String PhoneNumber, String TaxCode)
        {
            if (!checkSelectRange(index))
            {
                MessageBox.Show("Please select an employee");
                return false;
            } else
            {
                Employee employee = employeeList[index];

                if (!isNeedUpdate(employee, nickName, PhoneNumber, TaxCode))
                {
                    MessageBox.Show("You haven't made any changes");
                    return false;
                } else if (MessageBox.Show("Do you want to save the changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    employee.NickName = nickName;
                    employee.LastName = lastName;
                    employee.FirstName = firstName;
                    employee.IRDNumber = IRDNumber;
                    employee.PhoneNumber = PhoneNumber;
                    employee.TaxCode = TaxCode;
                    MessageBox.Show("Your changes have been saved");
                    writeToFile();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool isNeedUpdate(Employee employee, String nickName, String phoneNumber, String taxCode)
        {
            return !(employee.NickName.Equals(nickName) && employee.PhoneNumber.Equals(phoneNumber) && employee.TaxCode.Equals(taxCode));
        }

        /// <summary>
        /// Add new employee
        /// </summary>
        public bool addNewEmployee(String ID, String nickName, String firstName, String lastName, String IRDNumber, String PhoneNumber, String TaxCode)
        {
            if (ID.Length == 0 || nickName.Length == 0 || firstName.Length == 0 ||
              lastName.Length == 0 || IRDNumber.Length == 0 || PhoneNumber.Length == 0 || TaxCode.Length == 0)
            {
                MessageBox.Show("You must fill all the fields");
                return false;
            }

            foreach (Employee item in employeeList)
            {
                if (item.ID.Equals(ID))
                {
                    MessageBox.Show("The Employee ID is already exsited.");
                    return false;
                }
            }

            Employee employee = new Employee();
            employee.NickName = nickName;
            employee.LastName = lastName;
            employee.FirstName = firstName;
            employee.IRDNumber = IRDNumber;
            employee.PhoneNumber = PhoneNumber;
            employee.TaxCode = TaxCode;
            employee.ID = ID;

            employeeList.Add(employee);// Add the new employee to the list
            writeToFile();

            return true;
        }
    }
}

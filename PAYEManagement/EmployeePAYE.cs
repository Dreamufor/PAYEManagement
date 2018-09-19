using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYEManagement
{
    class EmployeePAYE
    {
        public String ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String IRDNumber { get; set; }
        public String TaxCode { get; set; }
        public String Hours { get; set; }
        public String PAYE { get; set; }
        public String StudentLoan { get; set; }
        public String Kiwisaver { get; set; }
        public String NetPay { get; set; }
        /// <summary>
        /// save data to file in single line
        /// </summary>
        public String toOneLine()
        {
            return ID + "$" + LastName + "$" + FirstName + "$" + IRDNumber + "$" + TaxCode + "$" + Hours + "$" + PAYE
                + "$" + StudentLoan + "$" + Kiwisaver + "$" + NetPay;
        }
    }
}

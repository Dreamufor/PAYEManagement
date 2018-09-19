using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYEManagement
{
    class Employee
    {
        public String ID { get; set; }
        public String NickName { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String IRDNumber { get; set; }
        public String TaxCode { get; set; }
        public String PhoneNumber { get; set; }

        public override String ToString()
        {
            return NickName;
        }
        /// <summary>
        /// save data to file in single line
        /// </summary>
        public String toOneLine()
        {
            return ID + "$" + NickName + "$" + LastName + "$" + FirstName + "$" + IRDNumber + "$" + TaxCode + "$" + PhoneNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    class Employee
    {
        public string FullName { get; set; }

        public Employee(string name)
        {
            FullName = name;
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}

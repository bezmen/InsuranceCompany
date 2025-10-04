using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    [Serializable]
    public class Employee
    {
        public string FullName { get; }
        public string Address { get; }
        public string Telephone { get; }

        public Employee(string name, string address, string telephone)
        {
            FullName = name;
            Address = address;
            Telephone = telephone;
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}

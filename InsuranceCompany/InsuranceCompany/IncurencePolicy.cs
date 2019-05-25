using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    enum MyEnum
    {
    }
    class IncurencePolicy
    {
        public int Number { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
        public IClientable Client { get; set; }
        public DateTime DateOfConclusion { get; set; }
        public DateTime TermOfImprisonment { get; set; }
        public decimal Sum { get; set; }
        public decimal Cost { get; set; }
        public int PaymentTerm { get; set; }
        
        public IncurencePolicy(int number, Employee employee, Category category, IClientable client, DateTime dateOfConclusion, DateTime termOfImprisonment, decimal sum, decimal cost, int paymentTerm)
        {
            Number = number;
            Employee = employee;
            Category = category;
            Client = client;
        }
    }
}

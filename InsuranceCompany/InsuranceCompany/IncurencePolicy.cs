using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class IncurencePolicy
    {
        public int Number { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
        public DateTime DateOfConclusion { get; set; }
        public DateTime TermOfImprisonment { get; set; }
        public decimal Sum { get; set; }
        public decimal Cost { get; set; }
        public decimal Payout { get; set; }
        public int PaymentTerm { get; set; }


        public IncurencePolicy(int number, Employee employee, Category category, DateTime dateOfConclusion, DateTime termOfImprisonment, decimal sum, decimal cost, int paymentTerm)
        {
            Number = number;
            Employee = employee;
            Category = category;
            DateOfConclusion = dateOfConclusion;
            TermOfImprisonment = termOfImprisonment;
            PaymentTerm = paymentTerm;
            Sum = sum;
            Cost = cost;
        }
    }
}

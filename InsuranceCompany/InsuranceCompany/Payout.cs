using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class Payout
    {
        public Client Client { get; }
        public Category Category { get; }
        public Subcategory Subcategory { get; }
        public DateTime DateOfAppeal { get; set; }
        public DateTime DateOfPayout { get; }
        public decimal SumPayout { get; set; }

        public Payout(Client client, Category category, Subcategory subcategory, DateTime dateOfAppeal, DateTime dateOfPayout, decimal sumPayout)
        {
            Client = client;
            Category = category;
            Subcategory = subcategory;
            DateOfAppeal = dateOfAppeal;
            DateOfPayout = dateOfPayout;
            SumPayout = sumPayout;
        }
    }
}

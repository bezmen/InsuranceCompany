using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    
    public class Appeal
    {
        public enum StateAppeal
        {
            Accepted,
            Denied,
            Waiting
        }
        public Client Client { get; }
        public Category Category { get; }
        public Subcategory Subcategory { get; }
        public DateTime DateOfAppeal { get; }
        public bool IsOppened { get; set; } // if State = true -> Appeal is opened
        public StateAppeal State { get; set; }

        public Appeal(DateTime dateOfAppeal, Client client, Category category, Subcategory subcategory)
        {
            Client = client;
            Category = category;
            Subcategory =  subcategory;
            DateOfAppeal = dateOfAppeal;
            State = StateAppeal.Waiting;
            IsOppened = false;
        }

        public override string ToString()
        {
            return string.Format("{0}({1}) {2}", Category.Name, Subcategory.Name, DateOfAppeal.ToShortDateString());
        }
    }
}

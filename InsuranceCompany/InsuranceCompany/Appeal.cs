using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class Appeal
    {
        public Client Client { get; }
        public Category Category { get; }
        public Subcategory Subcategory { get; }
        public bool State { get; set; } // if State = true -> Appeal is opened

        public Appeal(Client client, Category category, Subcategory subcategory)
        {
            Client = client;
            Category = category;
            Subcategory =  subcategory;
            State = true;
        }
    }
}

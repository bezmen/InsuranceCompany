using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    [Serializable]
    public class Client
    {
        public List<IncurencePolicy> Policies { get; set; }
        public List<Appeal> Appeals { get; set; }
        public List<Payout> Payouts { get; set; }
        public decimal SumPayouts { get; set; }
        public string UTN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public Client(string UTN, string name, string address, string telephone)
        {
            Policies = new List<IncurencePolicy>();
            Appeals = new List<Appeal>();
            Payouts = new List<Payout>();
            SumPayouts = 0;
            this.UTN = UTN;
            this.Name = name;
            this.Address = address;
            this.Telephone = telephone;
        }
    }
}

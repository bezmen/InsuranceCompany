using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class Client
    {
        public List<IncurencePolicy> Policies { get; set; }
        public List<Appeal> Appeals { get; set; }
        public List<Payout> Payouts { get; set; }
        public decimal SumPayouts { get; set; }
        public string UTN { get; set; }

        public Client(string UTN)
        {
            Policies = new List<IncurencePolicy>();
            Appeals = new List<Appeal>();
            Payouts = new List<Payout>();
            SumPayouts = 0;
            this.UTN = UTN;
        }
    }
}

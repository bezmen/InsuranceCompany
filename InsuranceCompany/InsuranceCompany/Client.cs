using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class Client
    {
        public List<IncurencePolicy> Policies { get; set; }
        public List<Appeal> Appeals { get; set; }

        public Client()
        {
            Policies = new List<IncurencePolicy>();
            Appeals = new List<Appeal>();
        }
    }
}

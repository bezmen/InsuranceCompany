using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    class IndividualClient : Client
    {
        public string Name { get; set; }
        public DateTime Birthday { get; }
        public bool Sex { get; }
        public int StoolDryving { get; }
        public string Address { get; set; }
        public string NumberOfTelephone { get; set; }

        public IndividualClient()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

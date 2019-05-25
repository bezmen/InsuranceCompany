using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    enum TypeClient
    {
        Individual, // физ лицо
        Entity // юр лицо
    }

    class IndividualClient : IClientable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Otchestvo { get; set; }
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
        public int StoolDryving { get; set; }
        public string Address { get; set; }
        public string NumberOfTelephone { get; set; }

        public IndividualClient()
        {

        }
    }
}

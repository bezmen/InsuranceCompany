using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    class EntityClient : IClientable
    {
        public string NameCompany { get; }
        public int UTN { get; } // УНП
        public string FIO_Director { get; }
        public string FIO_ChiefAccountant { get; }
        public string Address { get; set; }
        public string Number { get; set; }

        public EntityClient()
        {

        }
    }
}

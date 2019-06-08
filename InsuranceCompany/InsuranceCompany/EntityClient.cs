using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class EntityClient : Client
    {
        public string NameCompany { get; }
        public string UTN { get; } // УНН
        public string FIO_Director { get; }
        public string FIO_ChiefAccountant { get; }
        public string Address { get; }
        public string NumberOfTelephone { get; set; }

        public EntityClient(string nameCompany, string UTN, string FIO_dir, string FIO_account, string address, string telephone)
        {
            NameCompany = nameCompany;
            this.UTN = UTN;
            FIO_Director = FIO_dir;
            FIO_ChiefAccountant = FIO_account;
            Address = address;
            NumberOfTelephone = telephone;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class EntityClient : Client
    {
        public string FIO_Director { get; }
        public string FIO_ChiefAccountant { get; }
        public string NumberOfTelephone { get; set; }

        public EntityClient(string nameCompany, string UTN, string FIO_dir, string FIO_account, string address, string telephone) : base(UTN, nameCompany, address)
        {
            Name = nameCompany;
            FIO_Director = FIO_dir;
            FIO_ChiefAccountant = FIO_account;
            NumberOfTelephone = telephone;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

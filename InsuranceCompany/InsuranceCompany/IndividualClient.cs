using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class IndividualClient : Client
    {
        public string Name { get; }
        public DateTime Birthday { get; }
        public bool Sex { get; }
        public int StoolDryving { get; }
        public string Address { get; }
        public string NumberOfTelephone { get; }

        public IndividualClient(string name, DateTime birth, bool sex, string UTN, int stoolDriv, string address, string number) : base(UTN)
        {
            Name = name;
            Birthday = birth;
            Sex = sex;
            StoolDryving = stoolDriv;
            Address = address;
            NumberOfTelephone = number;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

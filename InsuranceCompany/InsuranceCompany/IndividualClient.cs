using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class IndividualClient : Client
    {
        public DateTime Birthday { get; }
        public bool Sex { get; }
        public int StoolDryving { get; }
        public string NumberOfTelephone { get; }

        public IndividualClient(string name, string UTN, DateTime birth, bool sex, int stoolDriv, string address, string number) : base(UTN, name, address)
        {
            Birthday = birth;
            Sex = sex;
            StoolDryving = stoolDriv;
            NumberOfTelephone = number;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

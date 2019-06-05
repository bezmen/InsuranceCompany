﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class IndividualClient : Client
    {
        public string Name { get; set; }
        public DateTime Birthday { get; }
        public bool Sex { get; }
        public int StoolDryving { get; }
        public string Address { get; set; }
        public string NumberOfTelephone { get; set; }

        public IndividualClient(string name, DateTime birth, bool sex, int stoolDriv, string address, string number)
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

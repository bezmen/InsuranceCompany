﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    public class Subcategory
    {
        public string Name { get; set; }

        public Subcategory(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
   
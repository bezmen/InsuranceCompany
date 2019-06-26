using System;

namespace InsuranceCompany
{
    [Serializable]
    public class Subcategory
    {
        public string Name { get; set; }
        public double Percent { get; set; }

        public Subcategory(string name, double percent)
        {
            Name = name;
            Percent = percent;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
   
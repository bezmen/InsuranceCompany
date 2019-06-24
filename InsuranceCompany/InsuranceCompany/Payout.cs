using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    [Serializable]
    public class Payout
    {
        public IncurencePolicy Policy { get; }
        public Subcategory Subcategory { get; }
        public DateTime DateOfAppeal { get; set; }
        public DateTime DateOfPayout { get; }
        public decimal _Payout { get; set; }

        public Payout(IncurencePolicy policy, Subcategory subcategory, DateTime dateOfAppeal, DateTime dateOfPayout, decimal payout)
        {
            Policy = policy;
            Subcategory = subcategory;
            DateOfAppeal = dateOfAppeal;
            DateOfPayout = dateOfPayout;
            _Payout = payout;
        }
    }
}

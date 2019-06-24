using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany
{
    [Serializable]
    class Session
    {
        public List<Employee> employees;
        public List<Client> clients;
        public Dictionary<Category, List<Subcategory>> dicCategory;
        public int countPolycies;
        public Session(List<Employee> employees, List<Client> clients, Dictionary<Category, List<Subcategory>> dicCategory, int countPolycies)
        {
            this.employees = employees;
            this.clients = clients;
            this.dicCategory = dicCategory;
            this.countPolycies = countPolycies;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Company
{
    internal class Departement
    {
        public required int DepId { get; set; }
        public string? Name { get; set; }

        private List<Employee> Employees = new List<Employee>();

        public List<Employee> employees
        {
            get { return Employees; }
        }


    }
}

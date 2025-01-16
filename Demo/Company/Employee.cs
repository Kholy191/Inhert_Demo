using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Company
{
    internal class Employee
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }

        public required Departement departement { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} ,  Name is {Name} , Age = {Age},  Departement Id = {departement.DepId}";
        }

    }
}

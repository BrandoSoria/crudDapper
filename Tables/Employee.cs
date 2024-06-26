using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudDapper.Tables
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
}

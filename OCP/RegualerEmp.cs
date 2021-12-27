using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCR
{
    internal class RegualerEmp : IEmployee
    {

        public string Id { get; set; }
        public string? Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal CalacSalary(decimal hours)
        {
            return((BasicSalary / 30) / 8);
        }

        //public override decimal CalcSalary(decimal hours)
        //{
        //    return ((BasicSalary / 30)/8); 
        //}

        public override string ToString()
        {
            return $"Employee Id : {Id}  , Employee Name : {Name}";
        }
    }
}

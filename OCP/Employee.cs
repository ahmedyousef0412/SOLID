using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCR
{
    internal  abstract class Employee  
    {

        public string Id { get; set; }
        public string? Name { get; set; }

        public decimal BasicSalary { get; set; }


        public abstract decimal CalcSalary(decimal hours);
        

        public override string ToString()
        {
            return $"Employee Id : {Id}  , Employee Name : {Name}";
        }
    }
}

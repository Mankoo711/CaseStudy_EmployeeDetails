using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_EmployeeDetails
{
    public class Employees
    {
        public List<EmployeeDetails> data { get; set; }
    }
    public class EmployeeData
    {
        public EmployeeDetails data { get; set; }
    }
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string name { get; set; }    
        public string gender { get; set; }    
        
        public string email { get; set; }
        public string status { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractDesignPattern.Manger
{
    public class EmployeeManagerFactory
    {

        public IEmployee GetEmployee(string type)
        {
            IEmployee emp = null;

            if(type=="Permanent")
            {
                emp = new PermanentEmployee();
            }

            else if(type== "Contract")
            {
                emp = new ContractEmployee();
            }

            return emp;
        }
    }
}
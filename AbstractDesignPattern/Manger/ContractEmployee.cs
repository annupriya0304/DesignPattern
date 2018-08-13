using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractDesignPattern.Manger
{
    public class ContractEmployee : IEmployee
    {
        public double Bonus()
        {
            return 8;
        }

        public double Salary()
        {
            return 100;
        }
    }
}
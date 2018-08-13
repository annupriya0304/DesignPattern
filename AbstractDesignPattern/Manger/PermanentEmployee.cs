using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractDesignPattern.Manger
{
    public class PermanentEmployee : IEmployee
    {
        public double Bonus()
        {
            return 10;
        }

        public double Salary()
        {
            return 150;
        }
    }
}
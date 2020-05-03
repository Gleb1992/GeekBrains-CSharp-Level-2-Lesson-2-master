using System;

namespace Worker
{
    class FixedPayment : Salary
    {

        public FixedPayment(string fio, double salary) : base(fio, salary)
        {
            
        }

        override public double CalcSalary()
        {
            return salary;
        }
    }
}

using System;

namespace Worker
{
    class HourlyPayment : Salary
    {
        public HourlyPayment(string fio, double salary) : base(fio, salary)
        {
            
        }

        override public double CalcSalary()
        {

            return 20.8 * 8 * salary;
        }
    }
}

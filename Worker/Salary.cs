using System;

namespace Worker
{
    abstract class Salary
    {
        protected string fio;
        protected double salary; //хранится зарплата за месяц или за час

        public Salary(string fio, double salary)
        {
            this.fio = fio;
            this.salary = salary;
        }

        abstract public double CalcSalary();

        override public string ToString()
        {

            return this.fio + "  зп = " + this.CalcSalary();
        } 
    }
}

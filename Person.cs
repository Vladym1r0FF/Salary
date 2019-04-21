using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
        }

        private string lastName;

        private int age;
        public int Age
        {
            get { return this.age; }
        }
        private double salary;
        public double Salary
        {
            get { return this.salary; }
        }
        public void IncreaseSalary(double bonus)
        {
            double multiplyer = 1.0 + (bonus / 100);
            this.salary *= multiplyer;
        }
        public Person(string name, string family, int age, double salary)
        {
            this.firstName = name;
            this.lastName = family;
            this.age = age;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{firstName} {this.lastName} get {this.salary:f2} leva";
        }

    }
}

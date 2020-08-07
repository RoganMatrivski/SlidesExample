using System;

namespace Inheritance
{
    //* Ga pake Getter Setter ama semua variabel dibikin public biar simpel
    class Person
    {
        public string Name;
    }

    class Employee : Person
    {
        public string Department;

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public string GetInfo()
        {
            return string.Format("The employee name is {0} which is in {1} department", Name, Department);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee someone = new Employee("Rogan", "Programmer");

            Console.WriteLine(someone.GetInfo());
        }
    }
}

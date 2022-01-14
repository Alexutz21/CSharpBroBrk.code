using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    class ClassGavinLon_Long
    {
        /*
         * C - Create
         * R - Read
         * U - Update
         * D - Delete
         */
    }

    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public decimal annualSalary;
        public char Gender;
        public bool isManager;

        public static void EmployeeExample()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Jack";
            employee.LastName = "Sparrow";
            employee.annualSalary = 100057;
            employee.Gender = 'M';
            employee.isManager = true;

            Console.WriteLine($"Annual salary before update is: {employee.annualSalary}");
            //UpdateAnnualSallary(employee);
            Console.WriteLine($"Annual salary after update is: {employee.annualSalary}");
            Console.WriteLine();
        }




    }

}

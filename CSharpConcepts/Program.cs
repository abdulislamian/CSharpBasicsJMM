using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void myFunctionDelegate(string Message);

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //myFunctionDelegate del = new myFunctionDelegate(myMethod);
            //del("This is message from Delegaate");
            List<Employee> employeeslist = new List<Employee>();
            employeeslist.Add(new Employee { ID = 1, Name = "Abdullah", Salary = 6000, Experiance = 5 });
            employeeslist.Add(new Employee { ID = 2, Name = "Rehan", Salary = 9000, Experiance = 6 });
            employeeslist.Add(new Employee { ID = 3, Name = "Rizwan", Salary = 6500, Experiance = 4 });


            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(employeeslist,emp=>emp.Experiance>=5);
        }

        //Check if employee is elgible for promotion or not
        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experiance >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}




        //public static void myMethod(string strMessage)
        //{
        //    //Console.WriteLine(strMessage);
        //    //Console.ReadLine();
        //    Console.ReadLine();
        //}
       
    }
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experiance { get; set; }
        public static void PromoteEmployee(List<Employee> employeesList, IsPromotable isEligible)
        {
            foreach (Employee employee in employeesList)
            {
                //if(employee.Experiance >= 5)
                //{
                //    Console.WriteLine(employee.Name + " has Promoted");
                //}
                if (isEligible(employee))
                {
                    Console.WriteLine(employee.Name + " has Promoted");
                }
            }
            Console.ReadLine();
        }
    }

}

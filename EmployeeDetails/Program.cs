using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeDetails
{
    class Employee
    {
        internal string EmpName, EmpCode;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Employee emp1 = new Employee();


            list.Add(emp1);
            list.Add(new Employee() { EmpName = "Swapnil", EmpCode = "E001" });
            list.Add(new Employee() { EmpName = "Vikas", EmpCode = "E002" });
            list.Add(new Employee() { EmpName = "Vaishnavi", EmpCode = "E003" });
            list.Add(new Employee() { EmpName = "Abhishek", EmpCode = "E004" });

            emp1.EmpCode = "E005";
            emp1.EmpName = "Jitendra";
            Console.WriteLine("Code \t Name");

            foreach (Employee o in list)
            {
                Console.Write("{0} \t {1}", o.EmpCode, o.EmpName);
                Console.WriteLine();
               
            }
            Console.ReadKey();

        }
    }
}

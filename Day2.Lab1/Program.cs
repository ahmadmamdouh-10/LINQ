using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lab2.1 ");

            int x = 123456789;

            int num = x.Reverse();

            Console.WriteLine($" Number after Reverse : {num} ");



            Console.WriteLine(" =============================================================== ");

            Console.WriteLine(" Lab2.2 ");

            List<Employee> myList = new List<Employee>
            {
               new Employee {ID = 1, Name = "Ali" },
               new Employee{ ID = 2, Name = "Hosam"},

            };

            List<Employee> newList = myList.EagerFilter();

            foreach(var item in newList)
            {
                Console.WriteLine($" AT Eager :::: Employee Id {item.ID}, Employee Name {item.Name} ");
            }


            IEnumerable<Employee> newList2 = myList.DeferredFilter();

            foreach(var item in newList2)
            {
                Console.WriteLine($"AT Deferred Execution ::::Employee Id {item.ID}, Employee Name {item.Name} ");

            }


            Console.WriteLine(" =============================================================== ");

            Console.WriteLine(" After Changing the source of Employee List : ");

            myList[0].ID = 5;

            foreach (var item in newList)
            {
                Console.WriteLine($" AT Eager :::: Employee Id {item.ID}, Employee Name {item.Name} ");
            }

            foreach (var item in newList2)
            {
                Console.WriteLine($"AT Deferred Execution ::::Employee Id {item.ID}, Employee Name {item.Name} ");

            }





        }
    }
}

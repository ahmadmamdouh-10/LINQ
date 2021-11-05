using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    static class Extensions
    {
        public static int Reverse(this int x)
        {
            string str = x.ToString();

            char[] arrayOfChar = str.ToCharArray();

            string afterReverse = string.Empty;

            for(int i = 0; i < arrayOfChar.Length; i++)
            {
                afterReverse += arrayOfChar[arrayOfChar.Length - 1 - i];
            }

            return int.Parse(afterReverse);
        }

        public static List<Employee> EagerFilter(this List<Employee> employees)
        {
            List<Employee> myList = new List<Employee>();

            foreach(Employee emp in employees)
            {
                if (emp.ID > 1)
                {
                    Employee e = new Employee();
                    e.ID = emp.ID;
                    e.Name = emp.Name;

                    myList.Add(e);
                }
            }
            return myList;
        }

        public static IEnumerable<Employee> DeferredFilter(this List<Employee> employees)
        {
            foreach(Employee emp in employees)
            {
                if (emp.ID > 1)
                {
                    yield return emp;
                }
            }
        }
    }
}

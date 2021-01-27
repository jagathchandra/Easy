using System;
using System.Collections.Generic;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employees = new List<string>();
            Console.WriteLine("Please enter the Employee namesin the order of their eligibility for promotion(Please enter blank to stop)");
            for (; ; )
            {
                String s = Console.ReadLine();
                if (s == "")
                    break;
                else
                    Employees.Add(s);
            }
            
            

            Console.WriteLine("Please enter the name of the employee to check promotion position");
            string name = Console.ReadLine();
            int index = Employees.IndexOf(name) + 1;
            Console.WriteLine(name+" is the position "+(index)+ " for promotion");



            Console.WriteLine("The current size of the collection is " +Employees.Capacity);
            Employees.TrimExcess();
            Console.WriteLine("The size after removing the extra space is " +Employees.Capacity);

         



            Console.WriteLine("Promoted employee list:");
            Employees.Sort();
            Employees.ForEach(Console.WriteLine);


            

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollege
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Ramrao Institute Of Technology!");
            Console.WriteLine(" ");
            Person studentInstance = new Student(111, "Kharghar", "27-02-2003", "Computer Science & Business Systems");
            Person professorInstance = new Professor(121, "Mumbai", "22-05-1971", 60000.00);

            Console.WriteLine($"Person Type: {studentInstance.GetType().Name} ");
            studentInstance.DisplayDetailsOfPerson();
            Console.WriteLine(" ");
            Console.WriteLine($"Person Type: {professorInstance.GetType().Name} ");
            professorInstance.DisplayDetailsOfPerson();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollege
{
    public class Student : Person
    {
        public string BranchOfStudent { get; set; }

        public Student(int personId, string personAddress, string dateOfBirth, string branchOfStudent) : base(personId, personAddress, dateOfBirth)
        {
            this.BranchOfStudent = branchOfStudent;
        }

        public override void DisplayDetailsOfPerson()
        {
            base.DisplayDetailsOfPerson();
            Console.WriteLine($"Branch Of Student: {BranchOfStudent}");
        }
    }
}

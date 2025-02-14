using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollege
{
    public class Person
    {
        public int PersonId {  get; set; }
        public string PersonAddress {  get; set; }
        public string DateOfBirth { get; set; }

        public Person(int personId, string personAddress, string dateOfBirth)
        {
            this.PersonId = personId;
            this.PersonAddress = personAddress;
            this.DateOfBirth = dateOfBirth;
        }   

        public virtual void DisplayDetailsOfPerson()
        {
            Console.WriteLine($"Person ID: {PersonId} \nPerson Address: {PersonAddress} \nDate Of Birth: {DateOfBirth}");
        }
    }
}

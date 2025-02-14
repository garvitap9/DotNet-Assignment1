using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollege
{
    public class Professor : Person
    {
        public double BasePayOfProfessor {  get; set; }
        double HouseRentAllowances = 30; //in percentage %
        double DearnessAllowances = 20; //in percentage %
        double TravellingAllowances = 20; //in percentage %
        public Professor(int personId, string personAddress, string dateOfBirth, double basePayOfProfessor) : base(personId, personAddress, dateOfBirth)
        {
            this.BasePayOfProfessor = basePayOfProfessor;
        }

        public double ProfessorSalaryCalculation()
        {
            HouseRentAllowances = 30.0 / 100.0 * BasePayOfProfessor;
            DearnessAllowances = 20.0 / 100.0 * BasePayOfProfessor;
            TravellingAllowances = 20.0 / 100.0 * BasePayOfProfessor;

            return BasePayOfProfessor + HouseRentAllowances + DearnessAllowances + TravellingAllowances ;
        }
        public override void DisplayDetailsOfPerson()
        {
            base.DisplayDetailsOfPerson();
            Console.WriteLine(" ");
            Console.WriteLine($"House Rent Allowances: {HouseRentAllowances}% " +
                $"\nDearness Allowances: {DearnessAllowances}% " +
                $"\nTravelling Allowances {TravellingAllowances}%");
            Console.WriteLine(" ");
            Console.WriteLine($"Salary of the Professor: {ProfessorSalaryCalculation()}");
        }
    }
}

using System;

namespace comp5202_9925082_Payroll_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Welcome to the Payroll system calculator");
            Console.WriteLine("----------------------------------------");


            //Used to gather information about the employee and save them to variables used by the Employee Object.

            Console.Write("Please enter the Employee's Full Name: ");

            string fname = Console.ReadLine();

            Console.Write($"Please enter {fname}'s Tax Rate: ");

            double tax = double.Parse(Console.ReadLine());

            Console.Write($"Please enter {fname}'s Annual Gross Salary: ");

            double gross = double.Parse(Console.ReadLine());



            //Creates Employee object that is populated by variables of the employees info useing the constructor.

            Employee p1 = new Employee(fname, tax, gross);

            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------Employees Details-------");
            Console.WriteLine("--------------------------------");

            //This Console.writeline displays the Full name,Tax Rate and Annual Gross Salary, back to the user. 

            Console.WriteLine($"Full Name: {p1.Fname}\nTax Rate: {p1.Tax}%\nAnnual Gross Salary: {p1.Gross}\nNet Salary: {p1.Net()}");

        }

    }
    class Employee

    {

        //3 auto implemented properties, typeing prop then pressing tab 2x allows you to auto create these GET/SET.

        public string Fname { get; set; }


        public double Tax { get; set; }

        public double Gross { get; set; }

        //Constructor.

        public Employee(string _fname, double _tax, double _gross)

        {

            Fname = _fname;

            Tax = _tax;

            Gross = _gross;

        }

        //Methord used to calculate Tax Net Salary earned by the employee.

        public double Net()

        {

            return Gross * (1 - Tax / 100);

        }

    }

}
        

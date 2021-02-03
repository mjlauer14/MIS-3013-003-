using System;

namespace In_Class_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;
            double gpa;

            Console.WriteLine("Please enter your first name>>");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastname = Console.ReadLine();

            Console.WriteLine("Please enter your gpa >>");
            string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; // This is a comment

            string output = "Hello" + firstname " " + lastname "! " + " We boosted your gpa " + gpa.ToString("n3");

            Console.WriteLine(output);
        }
    }
}

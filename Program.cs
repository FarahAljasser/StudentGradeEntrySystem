using System;

namespace StudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string countinue = "Yes";

            while (countinue == "Yes") {
                Student students = new Student { };

                Console.WriteLine("Please Enter The Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Please Enter Your Grade: ");
                string grade = Console.ReadLine();

                Console.WriteLine(students + " is " + students.passedOrNot);

                Console.WriteLine("Do You Add More? ");
                countinue = Console.ReadLine().ToUpper();
            }
        }
    }

    class Student {
        public string name { get; set; }
        public int grade { get; set; }
        public string passedOrNot { get { string reasult = (grade <= 60) ? "Failed " : "Passed "; return reasult; } }
    }

    
}

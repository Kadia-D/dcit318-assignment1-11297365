using System;

class Ticket
{
    static void Main(string[] args)
    {
        Console.Write("Enter numerical grade (0 - 100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            string letterGrade;

            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}

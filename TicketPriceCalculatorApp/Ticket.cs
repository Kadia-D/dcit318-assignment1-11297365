using System;

class Grade
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7 (Discounted)");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}

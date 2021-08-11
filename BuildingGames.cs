using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWithBob
{
    class BuildingGames
    {
        public void Games()
        {
            Console.WriteLine("Pick a number to know if you won a car?");
            Console.WriteLine("Enter only one out the number listed to know if you are a luky winner: 1, 2, 3");
            string car = Console.ReadLine();

            if (car == "1")
            {
                Console.WriteLine("Sorry try again someother time");
            }
            else if (car == "2")
            {
                Console.WriteLine("You just won a car from chikki");
            }
            else if (car == "3")
            {
                Console.WriteLine(" You won a phone");
            }
            else
            {
                Console.WriteLine("Just go Home");
            }
        }
        public void MoreGames()
        {
            Console.WriteLine("Pick a number to know if you won a car?");
            Console.WriteLine("Enter only one out the number listed to know if you are a luky winner: 1, 2, 3");
            string car = Console.ReadLine();
            string message = "";
            if (car == "1")
            {
                message = "Sorry try again someother time";
            }
            else if (car == "2")
            {
                message = "You just won a car from chikki";
            }
            else if (car == "3")
            {
                message = " You won a phone";
            }
            else
            {
                message = "Just go Home. You lost!";
            }
            Console.WriteLine(message);
            Console.Read();
        }
        public void LocalGames()
        {
            Console.WriteLine("Pick a number to know if you won a car?");
            Console.WriteLine("Enter only one out the number listed to know if you are a luky winner: 1, 2, 3");
            string car = Console.ReadLine();

            string message = (car == "1") ? "You won a car" : "Go home you lost!!!";
            Console.WriteLine(message);
        }

        public void LondonGames()
        {
            Console.WriteLine("Pick a number to know if you won a car?");
            Console.WriteLine("Enter only one out the number listed to know if you are a luky winner: 1, 2, 3");
            string car = Console.ReadLine();

            string message = (car == "1") ? "You won a car" : "Go home you lost.!!!";
            Console.WriteLine("you entered: {0}, therefore  {1}.", car, message);
            for (int myValue = 0; myValue < 10; myValue++)
            {

            }

        }
        public static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers App!!");
            Console.WriteLine("Enter any positive number of your choice other than zero?");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result)
            {
                Console.Write(counter);
                Console.Write("*");
                counter++;
            }
            Console.Read();

        }
        public static void GuessingGames()
        {
            Console.WriteLine(" Guess a random number to win!!");
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int guesses = 0;
            // int guessCount = 3;
            bool iscorrect = true;

            while (iscorrect)
            {
                Console.WriteLine("Guess a number between 1 and 20");
                string guess = (Console.ReadLine());
                guesses++;
                if (guess != randomNumber.ToString())
                {
                    Console.WriteLine("You guessed the wrong number!");
                    // iscorrect = true;

                }
                else
                {
                    Console.WriteLine($" Correct, it took you {guesses} guesses");

                }

            }
            Console.Read();
        }
        public static void ParseFromStringWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse");
            if (bool.TryParse("false", out bool a))
            {
                Console.WriteLine($"Value of a: {a}");
            }
            string value = "123";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine($" Value of d: {value}");
            }
            else
            {
                Console.WriteLine($"Failed to convert the input {value} to a double");

            }
            Console.WriteLine();
        }

    }

    class Student
    {
        // The name information to describe a student
        public string studentName;
        public string studentAge;
        //Creating a method
        public void StudentInfo(string studentname, string studentage)
        {
            studentName = studentname;
            studentAge = studentage;

            Console.WriteLine($"my name is {studentname} and i am {studentage} years old!!");

        }
        

    }
}

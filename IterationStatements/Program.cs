using System.Collections.Concurrent;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NegPosThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeByThree()
        {
            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualityCheck(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int evenOrOddNum)
        {
            if (evenOrOddNum % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int posOrNegNum)
        {
            if (posOrNegNum > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (posOrNegNum < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero or Error");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void AgeToVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough.");
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void WithinNegPos10(int withinTensNum)
        {
            if (withinTensNum > 10)
            {
                Console.WriteLine("Too Big");
            }
            else if (withinTensNum < -10)
            {
                Console.WriteLine("Too Small");
            }
            else
            {
                Console.WriteLine("It is within -10 to 10");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int toBeTabled)
        {
            Console.WriteLine($"Multiplication Table for {toBeTabled}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(toBeTabled * i);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Method1
            NegPosThousand();
            Console.WriteLine("");


            //Method2
            ThreeByThree();
            Console.WriteLine("");


            //Method3
            Console.WriteLine("Time to check if two numbers are equal. What is your first number?");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            int secondNum = int.Parse(Console.ReadLine());
            EqualityCheck(firstNum, secondNum);
            Console.WriteLine("");


            //Method4
            Console.WriteLine("Now let's check if a number is even or odd. What number?");
            int evenCheckNum = int.Parse(Console.ReadLine());
            EvenOrOdd(evenCheckNum);
            Console.WriteLine("");


            //Method5
            Console.WriteLine("Now for checking if a number is positive or negative. What number?");
            int positiveCheckNum = int.Parse(Console.ReadLine());
            PosOrNeg(positiveCheckNum);
            Console.WriteLine("");


            //Method6
            Console.WriteLine("Let's see if you are old enough to vote. How old are you?");
            int ageToVote = int.Parse(Console.ReadLine());
            AgeToVote(ageToVote);
            Console.WriteLine("");

            //Heatin Up1
            Console.WriteLine("This time we will check if a number is within -10 and 10. What number?");
            int numWithinNegPos10 = int.Parse(Console.ReadLine());
            WithinNegPos10(numWithinNegPos10);
            Console.WriteLine("");

            //Heatin Up2
            Console.WriteLine("Lastly, we will do the multiplication table (1 through 12) for a number. What number?");
            int numToBeTabled = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            MultiplicationTable(numToBeTabled);
            Console.WriteLine("");

            //Exit
            Console.WriteLine("Thanks for getting to the end! Press any key to exit");
            Console.ReadKey();
        }
    }
}

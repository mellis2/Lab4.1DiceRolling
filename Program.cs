using System;

namespace Lab4._1_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            string rollAgain = "y";

            while (rollAgain == "y")
            {
                Console.Write("How many sides should each die have?: ");
                RandomNumber(int.Parse(Console.ReadLine()));

                Console.Write("Roll Again? (y/n): ");
                rollAgain = Console.ReadLine();

                if (rollAgain == "n") 
                {
                    Console.WriteLine("Thanks for playing!!");
                }

            }


            //Console.WriteLine(RandomNumber(int.Parse(Console.ReadLine())));

        }

        // Generate a random number between two numbers  
        static int RandomNumber(int max)
        {
            Random random = new Random();
            int roll1 = random.Next(1, max + 1);
            int roll2 = random.Next(1, max + 1);
            int total = roll1 + roll2;
            Console.WriteLine($"You rolled a {roll1} and a {roll2} ({total} total)");
            //Console.WriteLine(Output(roll1, roll2, total));
            if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine("Snake Eyes");
            }
            else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
            {
                Console.WriteLine("Ace Deuce");
            }
            else if (roll1 == 6 && roll2 == 6)
            {
                Console.WriteLine("Box Cars");
            }
            else if (total == 7 || total == 11)
            {
                Console.WriteLine("Win");
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine("Craps");
            }
            return max;

        }

        //static string Output(int roll1, int roll2, int total);
        //{


                //if (roll1 == 1 && roll2 == 1)
                //{
                //    Console.WriteLine("Snake Eyes");
                //}
                //else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
                //{
                //    Console.WriteLine("Ace Deuce");
                //}
                //else if (roll1 == 6 && roll2 == 6)
                //{
                //    Console.WriteLine("Box Cars");
                //}
                //else if (total == 7 || total == 11)
                //{
                //    Console.WriteLine("Win");
                //}
                //else if (total == 2 || total == 3 || total == 12)
                //{
                //    Console.WriteLine("Craps");
                //}
        //        return -1;
        //}

    }
}

using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////// GUESSING GAME ////////////////");            
            bool valid;
            char sign;
            while (true)
            {
                do
                {
                    Console.Write("\nPlease select one number beetwen (1-3): ");
                    sign = Console.ReadKey().KeyChar;
                    valid = Checking(sign);
                }
                while (valid);
                Random random = new Random();
                int computer = random.Next(1, 4);

                GAME(computer, sign);
                Console.Write("Do You want to play again? (Y/N):");
                char choice =Console.ReadKey().KeyChar;
                if(choice =='N' || choice =='n')
                {
                    Console.Write("Thanks for playing!");
                    break;
                }

            }   

        }
        public static bool Checking(char sign)
        {    
                if (sign == '1' || sign == '2' || sign == '3')
                {
                    
                    return false;
                }
                else
                {
                Console.WriteLine("You entered wrong number invalid try again");
                return true;
                }            
        }
        public static void GAME(int computer, char sign)
        {
    
            string computeSt = computer.ToString();
            string player = sign.ToString();
            Console.WriteLine($"\nComputer:{computeSt}");
            Console.WriteLine($"Player:{player}");
            if (computeSt == player)
            {
                Console.WriteLine("\nYou Won");
            }
            else
            {
                Console.WriteLine("\nYou loose");
            }
        }
    }
}

   



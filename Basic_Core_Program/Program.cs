using System;

namespace Basic_Core_Program
{
    class basicCoreProgram
    {
        public void flipCoin()
        {
            int head = 0;
            int tail = 0;
            Console.WriteLine("Enter the number of times you want to flip the coin:");
            int Num_Of_Flip = Convert.ToInt32(Console.ReadLine());

            while (Num_Of_Flip <= 0)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please enter again:");
                Num_Of_Flip = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Num_Of_Flip; i++)
            {
                Random Coin = new Random();
                int CoinCheck = Coin.Next(0, 2);
                if (CoinCheck < 0.5)
                {
                    Console.WriteLine("Heads");
                    head++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
            }
            float Head_Persent = (float)(head * 100 / Num_Of_Flip);
            float Tail_Persent = (float)(tail * 100 / Num_Of_Flip);

            Console.WriteLine("Persentage of hear vs tail:" + Head_Persent);
            Console.WriteLine("Persentage of tail vs head:" + Tail_Persent);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for your choice:");
            Console.WriteLine("1 for flip coin presentage");
            int Problem = Convert.ToInt32(Console.ReadLine());
            basicCoreProgram basicCoreProgram = new basicCoreProgram();
            switch (Problem)
            {
                case 1:
                    basicCoreProgram.flipCoin();
                    break;
                default:
                    Console.WriteLine("You enter invalid number");
                    break;
            }

        }
    }
}
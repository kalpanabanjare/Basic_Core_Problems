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

        public void LeapYear()
        {
            Console.WriteLine("Enter Year :");
            int Year = int.Parse(Console.ReadLine());
            {
                if (Year >= 1000 && Year <= 9999)
                {
                    Console.WriteLine("Valid input");
                    if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) // to check the comdition
                    {
                        Console.WriteLine("{0} is a leap Year", Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap Year", Year);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }            
        }

        public void PowerOfTwo()
        {            
                Console.Write("Enter Number :");
                int number = int.Parse(Console.ReadLine());
                for (int num = 0; num <= number; num++)
                {
                    int PowerOfTwo = (int)Math.Pow(2, num);
                    Console.Write("2 to the Power of:" + num);
                    Console.WriteLine("=" + PowerOfTwo);
                }            
        }

        public void HarmonicNumber()
        {
            int num;
            double Harmonic = 0.0;
            Console.WriteLine("Calculate the harmonic series and their sum:");
            Console.Write("Input the number of terms: ");
            int Terms = int.Parse(Console.ReadLine());
            for (num = 1; num <= Terms - 1; num++)
            {
                Console.Write("1/{0} + ", num);
                Harmonic += 1 / (float)num;
            }
            if (num == Terms)
            {
                Console.Write("1/{0} ", num);
                Harmonic += 1 / (float)num;
            }
            Console.WriteLine("\nthe Nth Harmonic Value. {0} terms : {1} ", num, Harmonic);
        }

        public void Factor()
        {            
            Console.Write("Please enter your integer: ");
            int num = int.Parse(Console.ReadLine());
            for (int factor = 1; factor <= num; factor++)
            {
                if (num % factor == 0)
                {
                    Console.WriteLine(factor + " is a factor of " + num);
                }
            }
        }

        public void QuotientAndRemainder()
        {
            Console.WriteLine("Enter Divident:");
            int Divident = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Divisor:");
            int Divisor = int.Parse(Console.ReadLine());
            int Quotient = Divident / Divisor;
            int Remainder = Divident % Divisor;
            Console.WriteLine("Quotient = " + Quotient);
            Console.WriteLine("Remainder = " + Remainder);
            Console.ReadLine();
        }

        public void SwapTeoNum()
        {
            Console.WriteLine("Enter Frist number:");
            int FristNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int SecontNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap Frist number = " + FristNum + " Second number= " + SecontNum);
            FristNum = FristNum + SecontNum;
            SecontNum = FristNum - SecontNum;
            FristNum = FristNum - SecontNum;
            Console.WriteLine("After swap Frist number= " + FristNum + " Second number= " + SecontNum);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for your choice:");
            Console.WriteLine("1 for flip coin presentage");
            Console.WriteLine("2 for leap year");
            Console.WriteLine("3 for power of tow");
            Console.WriteLine("4 for Harmonic number");
            Console.WriteLine("5 for Factor");
            Console.WriteLine("6 for Quotient And Remainder");
            Console.WriteLine("7 for Swap two Number");
            int Problem = Convert.ToInt32(Console.ReadLine());
            basicCoreProgram basicCoreProgram = new basicCoreProgram();
            switch (Problem)
            {
                case 1:
                    basicCoreProgram.flipCoin();
                    break;
                case 2:
                    basicCoreProgram.LeapYear();
                    break;
                case 3:
                    basicCoreProgram.PowerOfTwo();
                    break;
                case 4:
                    basicCoreProgram.HarmonicNumber();
                    break;
                case 5:
                    basicCoreProgram.Factor();
                    break;
                case 6:
                    basicCoreProgram.QuotientAndRemainder();
                    break;
                case 7:
                    basicCoreProgram.SwapTeoNum();
                    break;
                default:
                    Console.WriteLine("You enter invalid number");
                    break;
            }
        }
    }
}
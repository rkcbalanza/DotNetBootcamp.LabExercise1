using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            char toContinue;
            do
            {
                Console.WriteLine("Welcome to the Area and Perimeter Calculator");

                Console.Write("Enter length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                decimal area = width * length;
                decimal perimeter = (2 * width) + (2 * length);

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.Write("Do you want to continue? (y/n): ");
                toContinue = Convert.ToChar(Console.ReadLine());
            } while (toContinue == 'y' || toContinue == 'Y' );


        }

        static void Number2()
        {
            char toContinue;
            do
            {
                Console.WriteLine("Welcome to the Letter Grade Calculator");

                Console.Write("Enter numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                char letterGrade;

                if (grade <= 100 && grade >= 88)
                {
                    letterGrade = 'A';
                } 
                else if (grade <= 87 && grade >= 80)
                {
                    letterGrade = 'B';
                }
                else if (grade <= 79 && grade >= 67)
                {
                    letterGrade = 'C';
                }
                else if (grade <= 66 && grade >= 60)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }

                Console.WriteLine("Letter grade: {0}", letterGrade);

                Console.Write("Do you want to continue? (y/n): ");
                toContinue = Convert.ToChar(Console.ReadLine());
            } while (toContinue == 'y' || toContinue == 'Y');

        }

        static void Number3()
        {
            char toContinue;
            do
            {
                Console.WriteLine("Welcome to the Download Time Estimator");
                Console.WriteLine("This program calculates how long will it take to download a file with a 56k analog modem.");

                Console.Write("Enter a file size (MB): ");
                int fileSize = Convert.ToInt32(Console.ReadLine());

                int kbSize = fileSize * 1024;
                double totalSeconds = kbSize / 5.2;
                int hour = (int)totalSeconds / 3600;
                int minute = (int)(totalSeconds % 3600) / 60;
                int second = (int)(totalSeconds - (hour * 3600) - (minute * 60));

                Console.WriteLine("A 56k modem will take {0} hours {1} minutes {2} seconds", hour, minute, second);


                Console.Write("Do you want to continue? (y/n): ");
                toContinue = Convert.ToChar(Console.ReadLine());
            } while (toContinue == 'y' || toContinue == 'Y');

        }

        static void Number4()
        {
            Console.Write("Enter square size: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());

            for(int row = 0; row < squareSize; row++)
            {
                for(int column = 0; column < squareSize; column++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            Number1();
            //Number2();
            //Number3();
            //Number4();

            

        }
    }
}

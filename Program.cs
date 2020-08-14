using Microsoft.VisualBasic;
using System;
using System.IO;

namespace W2L7
{

    class Program
    {
        public enum Descriptions
        {
            Celujacy,
            BardzoDobry,
            Dobry,
            Dostateczny,
            Dopuszczajacy,
            Niedostateczny
        }
        public enum NamesOfDays
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            Task13();

        }

        private static void Task13()
        {
            double result = 0;
            Console.Write("Enter a first number (only integer): ");
            var number1 = enterTheNumber();
            Console.Write("Enter a second number (only integer): ");
            var number2 = enterTheNumber();
            Console.WriteLine("What math do you want to do? Enter 1-4");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice = enterTheNumber();
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    while(number2 == 0)
                    {
                        Console.Write("Enter correct number(no 0): ");
                        number2 = enterTheNumber();
                    }
                    if (number2 != 0) result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
                    break;
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }
            Console.WriteLine($"Result: {Math.Round(result,2)} ");

        }

        private static void Task12()
        {
            int number = 4;

            var dayOfTheWeek = number switch
            {
                1 => NamesOfDays.Poniedzialek,
                2 => NamesOfDays.Wtorek,
                3 => NamesOfDays.Sroda,
                4 => NamesOfDays.Czwartek,
                5 => NamesOfDays.Piatek,
                6 => NamesOfDays.Sobota,
                7 => NamesOfDays.Niedziela
            };
            Console.WriteLine(dayOfTheWeek.ToString());
        }

        private static void Task11()
        {
            int grade = 3;

            var stringGrade = grade switch
            {
                1 => Descriptions.Niedostateczny,
                2 => Descriptions.Dopuszczajacy,
                3 => Descriptions.Dostateczny,
                4 => Descriptions.Dobry,
                5 => Descriptions.BardzoDobry,
                6 => Descriptions.Celujacy
            };
            Console.WriteLine(stringGrade.ToString());
        }

        private static void Task10()
        {
            int a, b, c;
            a = 3;
            b = 4;
            c = 5;
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) Console.WriteLine("You can create triangle");
            else  Console.WriteLine("Unfortunetly you can't create triangle");
        }

        private static void Task9()
        {
            int temp = 22;
            if (temp < 0) Console.WriteLine("Cholernie piździ");
            else if (temp > 0 && temp < 10) Console.WriteLine("Zimno");
            else if (temp > 10 && temp < 20) Console.WriteLine("Chłodno");
            else if (temp > 20 && temp < 30) Console.WriteLine("W sam raz");
            else if (temp > 30 && temp < 40) Console.WriteLine("Zaczyna być słabo, bo gorąco");
            else Console.WriteLine("A weź wyprowadzam sie na Alaskę");
        }

        private static void Task8()
        {
            int math = 80;
            int physics = 70;
            int chemistry = 0;
            int allSchoolSubjects = math + physics + chemistry;
            if ((math > 70 && physics > 55 && chemistry > 45 && allSchoolSubjects > 180) || (math + physics) > 150 || (math + chemistry) > 150)
            {
                Console.WriteLine("Congratulations!");
            }
            else Console.WriteLine("Unfortunately not");
        }
        
        private static void Task7()
        {
            Console.Write("Enter number 1: ");
            int number1 = enterTheNumber();
            Console.Write("Enter number 2: ");
            int number2 = enterTheNumber();
            Console.Write("Enter number 3: ");
            int number3 = enterTheNumber();
            Console.WriteLine("The biggest one is " + Math.Max(Math.Max(number1, number2), number3));
        }

        private static void Task6()
        {
            
            Console.Write("Enter your height in cm: ");
            int height = enterTheNumber(); 
            if (height <= 160) Console.WriteLine("You are a dwarf");
            else if (height >= 160 && height <= 180) Console.WriteLine("You are a big boy");
            else if (height >= 180 && height < 200) Console.WriteLine("You are a true man");
            else Console.WriteLine("You are a really true man");
        }       

        private static void Task5()
        {
            Console.Write("Enter your age: ");
            int age = enterTheNumber();
            if (age >= 21 && age < 30) Console.WriteLine("Możesz zostać posłem. No i premierem, jak Cie wybiorą.");
            else if (age >= 30 && age < 35) Console.WriteLine("Możesz zostać posłem oraz senatorem. No i premierem, jak Cie wybiorą."); 
            else if (age >= 35) Console.WriteLine("Możesz zostać posłem, senatorem oraz prezydentem. No i premierem, jak Cie wybiorą.");
            else Console.WriteLine("No niestety");
        }

        private static void Task4()
        {
            int year = 0;
            bool correctYear = false;
            while (correctYear != true) {
                Console.Write("Enter the year(1000+): ");
                year = enterTheNumber();
                if (year.ToString().Length != 4) Console.WriteLine("The year has only 4 number or must be a positive value!");
                else correctYear = true;
            }
            if(year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) Console.WriteLine($"The year {year} is a leap year (it has 366 days).");
                    else Console.WriteLine($"The year {year} is not a leap year (it has 365 days).");
                }
                else Console.WriteLine($"The year {year} is a leap year (it has 366 days).");
            }
            else Console.WriteLine($"The year {year} is not a leap year (it has 365 days).");
        }

        private static void Task3()
        {
            
            Console.Write("Enter number: ");
            int number = enterTheNumber();

            if (number > 0) Console.WriteLine($"{number} is positive");
            else if(number == 0) Console.WriteLine($"{number} is zero");
            else Console.WriteLine($"{number} is negative");
        }

        private static void Task2()
        {
            Console.Write("Enter number: ");
            int number = enterTheNumber();

            if (number % 2 == 0) Console.WriteLine($"{number} is even");
            else Console.WriteLine($"{number} is odd");

        }

        public static void Task1()
        {
            int a = 5;
            int b = 10;
            /*if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else Console.WriteLine($"{a} i {b} nie są równe");*/
            string  result = a == b ? $"{a} i {b} są równe" : $"{a} i {b} nie są równe";
            Console.WriteLine(result);
        }

        private static int enterTheNumber()
        {
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("This is not valid input. Please enter an integer value: ");
            }
            return number;
        }
    }
}

using System.Diagnostics;

namespace ПРАКТИЧЕСКАЯ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            strelki();
        }
        static void pomoh()
        {
            Console.Clear();
            Console.WriteLine(" Выбрана дата 15.10.2022");
            Console.WriteLine("  1. Пойти гулять");
            Console.WriteLine("  2. Пойти в колледж");
        }
        static void vtoroy()
        {
            Console.Clear();
            Console.WriteLine(" Выбрана дата 16.10.2022");
            Console.WriteLine("  1. Пойти в колледж");
        }
        static void tretiy()
        {
            Console.Clear();
            Console.WriteLine(" Выбрана дата 17.10.2022");
            Console.WriteLine("  1. Пойти к врачу");

        }
        static void chetiri()
        {
            Console.Clear();
            Console.WriteLine(" Выбрана дата 18.10.2022");
            Console.WriteLine("  1. Пойти на тренировку");

        }
        static void patiy()
        {
            Console.Clear();
            Console.WriteLine(" Выбрана дата 19.10.2022");
            Console.WriteLine("  1. Убраться дома");

        }
        static string strelki()
        {
            int position = 1;
            pomoh();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                pomoh();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        date();
                    }
                    else if (position == 2)
                    {
                        date_1();
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    shiza();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    shiza_4();
                }
            }
        }
        static void date()
        {
            Console.Clear();
            Console.WriteLine(" Пойти гулять");
            Console.WriteLine("________________________ \n Описание: С моим лучшим другом, подойти к Макдональдсу у дома! \n Дата: 15.10.2022");
        }
        static void date_1()
        {
            Console.Clear();
            Console.WriteLine(" Пойти в колледж");
            Console.WriteLine("________________________ \n Описание: Приезжать к 2 паре по 5, взять с собой ноутбук и приготовиться к боли. \n Дата: 15.10.2022");
        }
        static void date_2()
        {
            Console.Clear();
            Console.WriteLine(" Пойти в колледж");
            Console.WriteLine("________________________ \n Описание: Приезжать к 2 паре по 5, взять с собой ноутбук и приготовиться к анальной боли. \n Дата: 16.10.2022");
        }
        static void date_3()
        {
            Console.Clear();
            Console.WriteLine(" Пойти к врачу");
            Console.WriteLine("________________________ \n Описание: Приехать к стоматологу к 12:45. \n Дата: 17.10.2022");
        }
        static void date_4()
        {
            Console.Clear();
            Console.WriteLine(" Пойти на тренировку");
            Console.WriteLine("________________________ \n Описание: Подойти к фитнес клубу в 18:30, взять с собой форму. \n Дата: 18.10.2022");
        }
        static void date_5()
        {
            Console.Clear();
            Console.WriteLine(" Убраться дома");
            Console.WriteLine("________________________ \n Описание: Убраться к маминому приходу, а то мне сделают фистинг. \n Дата: 19.10.2022");
        }
        static void shiza()
        {
            int position = 1;
            vtoroy();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                vtoroy();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        date_2();
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    shiza_2();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    strelki();
                }
            }
        }
        static void shiza_2()
        {
            int position = 1;
            tretiy();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                tretiy();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        date_3();
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    shiza_3();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    shiza();
                }
            }
        }
        static void shiza_3()
        {
            int position = 1;
            chetiri();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                chetiri();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        date_4();
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    shiza_4();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    shiza_2();
                }
            }
        }
        static void shiza_4()
        {
            int position = 1;
            patiy();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                patiy();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        date_5();
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    strelki();
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    shiza_3();
                }
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
namespace Lab8_1
{
    class Flight
    {
        public string From;
        public string Incity;
        public string Airport;
        public int Price;
        public int Number;

        public Flight() { }
        public Flight(string from, string incity, string airport, int price, int number)
        {
            From = from;
            Incity = incity;
            Airport = airport;
            Price = price;
            Number = number;
        }

        public override string ToString()
        {
            return this.From + " " + this.Incity + " " + this.Airport + " " + this.Price + " " + this.Number;
        }

    }
    class Program
    {
        static public void FileInformationRewrite(string path, List<Flight> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Flight informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            List<Flight> A = new List<Flight>();
            using (StreamReader s = new StreamReader("flight.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split(" ");
                        A.Add(new Flight(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }
            Console.WriteLine("Додати записи: A");
            Console.WriteLine("Редагувати записи: E");
            Console.WriteLine("Знищити записи: R");
            Console.WriteLine("Показати записи: Enter");
            Console.WriteLine("Сортування за мiсцем вильоту: N");
            Console.WriteLine("Сортування за назвою аеропорта: D");
            Console.WriteLine("Сортування за номером рейсу: S");
            Console.WriteLine("Сортування за мiсцем прильоту: U");
            Console.WriteLine("Сортування за цiною: G");
            Console.WriteLine("Вихiд: Esc");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                foreach (Flight p in A)
                {
                    Console.WriteLine(p.ToString());

                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Звiдки:");
                string from = Console.ReadLine();
                Console.WriteLine("Куди:");
                string incity = Console.ReadLine();
                Console.WriteLine("Аеропорт:");
                string airport = Console.ReadLine();
                Console.WriteLine("Цiна:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Номер:");
                int number = int.Parse(Console.ReadLine());


                if (from != null && incity != null && airport != null && price != null && number != null)
                {
                    A.Add(new Flight() { From = from, Incity = incity, Airport = airport, Price = price, Number = number });
                    FileInformationRewrite("flight.txt", A);
                }
                else
                    Console.WriteLine("Ви не добавили нову iнформацiю:!");
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                Console.WriteLine("Напишiть номер файлу, який ви хочете видалити");
                int n = int.Parse(Console.ReadLine());
                A.RemoveAt(n - 1);
                Console.WriteLine(n + " is deleted");
                FileInformationRewrite("flight1.txt", A);
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");

            }

            if (Console.ReadKey().Key == ConsoleKey.E)
            {
                Console.Clear();
                Flight A1 = new Flight();
                Console.WriteLine("Який файл ви хочете редагувати");
                int k = int.Parse(Console.ReadLine());

                Console.WriteLine("Звiдки:");
                string from = Console.ReadLine();
                A1.From = from;
                Console.WriteLine("Куди:");
                string incity = Console.ReadLine();
                A1.Incity = incity;
                Console.WriteLine("Аеропорт:");
                string airport = Console.ReadLine();
                A1.Airport = airport;
                Console.WriteLine("Цiна:");
                int price = int.Parse(Console.ReadLine());
                A1.Price = price;
                Console.WriteLine("Номер:");
                int number = int.Parse(Console.ReadLine());
                A1.Number = number;

                A.RemoveAt(k - 1);
                A.Insert(k - 1, A1);
                FileInformationRewrite("flight.txt", A);
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }


            if (Console.ReadKey().Key == ConsoleKey.N)

            {

                var result = from u in A
                             orderby u.From
                             select u;
                foreach (Flight a in result)
                {
                    Console.WriteLine("\n" + a.ToString());
                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.D)

            {

                var result = from u in A
                             orderby u.Airport
                             select u;
                foreach (Flight a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.U)
            {

                var result = from u in A
                             orderby u.Incity
                             select u;
                foreach (Flight a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.G)

            {

                var result = from u in A
                             orderby u.Price
                             select u;
                foreach (Flight a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }

            if (Console.ReadKey().Key == ConsoleKey.S)

            {
                var result = from u in A
                             orderby u.Number
                             select u;
                foreach (Flight a in result)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Додати записи: A");
                Console.WriteLine("Редагувати записи: E");
                Console.WriteLine("Знищити записи: R");
                Console.WriteLine("Показати записи: Enter");
                Console.WriteLine("Сортування за мiсцем вильоту: N");
                Console.WriteLine("Сортування за назвою аеропорта: D");
                Console.WriteLine("Сортування за номером рейсу: S");
                Console.WriteLine("Сортування за мiсцем прильоту: U");
                Console.WriteLine("Сортування за цiною: G");
                Console.WriteLine("Вихiд: Esc");
            }
            Console.ReadKey();
        }
    }
}


﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Man> people = new List<Man>();
            Console.WriteLine("Введите файл с студентами:");
            string adress = Console.ReadLine();
            using (StreamReader fileIn = new StreamReader(adress + ".txt", Encoding.Default))
            {
                while (true)
                {
                    string[] tempstring;
                    try
                    {
                        tempstring = fileIn.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    }
                    catch (System.NullReferenceException e)
                    {
                        break;
                    }
                    if (tempstring.Length == 4)
                    {
                        Int32.TryParse(tempstring[1], out int a);
                        Int32.TryParse(tempstring[2], out int b);
                        Int32.TryParse(tempstring[3], out int c);

                        people.Add(new Man(tempstring[0], a, b, c));
                    }
                    else if (tempstring.Length == 7)
                    {
                        Int32.TryParse(tempstring[1], out int a);
                        Int32.TryParse(tempstring[2], out int b);
                        Int32.TryParse(tempstring[3], out int c);
                        Int32.TryParse(tempstring[4], out int d);
                        Int32.TryParse(tempstring[6], out int e);

                        people.Add(new Student(tempstring[0], a, b, c, d, tempstring[5], e));
                    }
                    else if (tempstring.Length == 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Внимание! Неверное значение");
                    }
                }
            }

            foreach (Man person in people)
            {
                Console.WriteLine(person);
            }


            Console.WriteLine();

            Author author = new Author("Джейн", "Остин", 1775);
            Console.WriteLine(author);

            Book book = new Book("Книга", 402, "Гордость и предубеждение", new DateTime(1813, 9, 1), new DateTime(1813, 1, 1), author);
            Console.WriteLine(book);

            Console.WriteLine();
            Console.WriteLine(author);

            Console.ReadLine();

        }
    }
}

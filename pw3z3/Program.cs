using System;

public class pw3z3
{
        static void Main(string[] args)
        {
            SQLCommand command = new SQLCommand();
            Console.WriteLine("Введите SQL-запрос:");
            command.CommandText = Console.ReadLine();
            Console.WriteLine($"Введенный SQL-запрос (в верхнем регистре): {command.CommandText}");
        }
    }
using System;
using System.Collections.Generic;

class Program
{
    static List<int> numbers = new List<int>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Добавить число");
            Console.WriteLine("2. Удалить число");
            Console.WriteLine("3. Показать список");
            Console.WriteLine("4. Сумма чисел");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите действие: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0": return;
                //кейсы
                default: Console.WriteLine("Неверный ввод"); break;
            }
        }
        
        //функции
        
    }
}
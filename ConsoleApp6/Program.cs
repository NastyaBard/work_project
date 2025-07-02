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
                case "1": AddNumber(); break;
                case "2": RemoveNumber(); break;
                case "3": DisplayList(); break;
                default: Console.WriteLine("Неверный ввод"); break;
            }
        }
        
        //функции
        static void AddNumber()
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
                Console.WriteLine("Число добавлено.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        
        static void RemoveNumber()
        {
            Console.Write("Введите число для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (numbers.Remove(num))
                    Console.WriteLine("Число удалено.");
                else
                    Console.WriteLine("Число не найдено.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
        
        static void DisplayList()
        {
            Console.WriteLine("Список чисел:");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
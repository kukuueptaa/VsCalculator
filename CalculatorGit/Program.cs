using System;

class Program
{
    static double A = 0, B = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("0. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InputA();
                    break;
                case "2":
                    InputB();
                    break;
                case "3":
                    Console.WriteLine($"Результат: {Add(A, B)}");
                    break;
                case "4":
                    Console.WriteLine($"Результат: {Subtract(A, B)}");
                    break;
                case "5":
                    Console.WriteLine($"Результат: {Multiply(A, B)}");
                    break;
                case "6":
                    Console.WriteLine($"Результат: {Divide(A, B)}");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }
        }
    }
    static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Деление на ноль запрещено!");

}
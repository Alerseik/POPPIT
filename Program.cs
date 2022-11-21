using System;
using MyLib;
namespace pop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person tom = new Person("Tom");
            tom.Print();
            SayHello();
            Pop();

           

            }
        static void SayHello()
        {
            Console.WriteLine("Привет! вот мой некоторые данные");
            string name = "Алексей";
            int age = 18;
            double height = 187;
            Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
            Console.WriteLine("Щас будет преставлен калькулятор, введите первое число и ннажмите ");

        }

        static double Plus(double a, double b)
        {
            return a + b;
        }

        static double Minus(double a, double b)
        {
            return a - b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Pop()
        {
            double a;
            double b;
           
            char h;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите +,-,*,/");
            h = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (h == '+')
            {
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + Plus(a,b) + ".");
            }

            else if (h == '-')
            {
                Console.WriteLine("Разность " + a + " и " + b + " равна " + Minus(a,b) + ".");
            }

            else if (h == '*')
            {
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + Multiply(a,b) + ".");
            }

            else if (h == '/')
            {
                Console.WriteLine("Деление " + a + " на " + b + " равно " + Division(a,b) + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");

            }
            Pop();
        }

    }
}

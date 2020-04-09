using System;
using System.Collections.Generic;
using System.Text;
using System.IO;//для роботи з файлами
namespace LaboratotyWork6
{
    class File
    {
        private int n;
        private double a;
        private double b;
        private double result;
        private string expression;
        private string path;
        public File()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Виберіть дію:\n" +
                "1) +\n"+
                "2) -\n"+
                "3) *\n"+
                "4) /\n"+
                "5) Возвести в степінь\n" +
                "6) Взяти квадратний корінь");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Mult();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Pow();
                    break;
                case 6:
                    Sqrt();
                    break;
                default:
                    Console.WriteLine("Такої дії не має!");
                    break;

            }
        }       

        public void CreateFile(bool add)
        {
            path = @"C:\Users\misha\Desktop\Lab5.txt";//<- змінити шлях створення файлу перед запуском програми
            FileStream file = new FileStream(path, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(file);
            if (add)
            {
                streamWriter.WriteLine("Вираз: " + expression);
                streamWriter.WriteLine("Результат: " + result);
                streamWriter.WriteLine();
                streamWriter.Close();
                file.Close();
            }
            else
            {
                Console.WriteLine("В файл нічого не записано!");
            }
        }
        private void Add()
        {
            Console.WriteLine("Перше число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a + b;
            expression = a+" + "+b;
        }
        private void Subtract()
        {
            Console.WriteLine("Перше число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a - b;
            expression = a + " - " + b;
        }
        private void Mult()
        {
            Console.WriteLine("Перше число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a * b;
            expression = a + " * " + b;
        }
        private void Division()
        {
            Console.WriteLine("Перше число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a / b;
            expression = a + " / " + b;
        }
        private void Pow()
        {
            Console.WriteLine("Перше число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Друге число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = Math.Pow(a, b);
            expression = a + " ^^ " + b;
        }
        private void Sqrt()
        {
            Console.WriteLine("Введіть число: ");
            a = Convert.ToDouble(Console.ReadLine());
            result = Math.Sqrt(a);
            expression = "√" + a;
        }
    }
}

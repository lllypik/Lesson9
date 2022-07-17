using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        // Проверку правильности введенных данных реализовал в отдельном методе c выдачей сигнала о неправильных данных
        static void DataEnterValidation (in bool rightDataIn, out double num, out bool rightDataOut)
        {
            num = 0;
            rightDataOut = rightDataIn;
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rightDataOut  = false;
            }
        }
                static void Main(string[] args)
        {
            // блок ввода и проверки данных
            string operationName = "";
            bool flag = true;
            double num1 = 0, num2 = 0, total = 0, operationType = 0;
            Console.Write("Введите первое число ");
            DataEnterValidation(in flag, out num1, out flag);
            Console.Write("Введите второе число ");
            DataEnterValidation(in flag, out num2, out flag);
            Console.Write("Введите код операции над числами (1 - сложение, 2 - вычитание, 3 - деление, 4 - умножение) ");
            DataEnterValidation(in flag, out operationType, out flag);
                                
            //блок вычислений и вывода результата
            if (operationType == 1 && flag == true)
            {
                total = num1 + num2;
                operationName = "+";
                Console.WriteLine("{0} {1} {2} = {3}", num1, operationName, num2, total);
            }
            else if (operationType == 2 && flag == true)
            {   total = num1 - num2;
                operationName = "-";
                Console.WriteLine("{0} {1} {2} = {3}", num1, operationName, num2, total);
            }
            else if (operationType == 3 && flag == true)
            {
                try
                {
                    total = num1 / num2;
                    operationName = "/";
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operationName, num2, total);
                }
                catch (DivideByZeroException) // Не смог реализовать данное исключение, т.к в типе double допускается деление на ноль.
                {
                    Console.WriteLine ("Деление на ноль!");
                    flag = false;
                }
            }
            else if (operationType == 4 && flag == true)
            {
                total = num1 * num2;
                operationName = "*";
                Console.WriteLine("{0} {1} {2} = {3}", num1, operationName, num2, total);
            }
            else Console.WriteLine("Некорректно введенный тип данных или некорректный тип операции");
            Console.ReadKey();
        }
    }
}

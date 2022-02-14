using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab_18_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> MyStack = new Stack<char>();


            //Получение исходной строки
            Console.WriteLine("Введите строку, содержащую только открытые и закрытые фигурные скобки. Результом обработки будет проверка совпадения открытых и закрытых скобок:");
            string InitialString = Console.ReadLine();

            for (int i = 0; i < InitialString.Length; i++)
            {
                if (InitialString[i] == '{'  )
                {
                    MyStack.Push('}');
                }
                else if (InitialString[i] == '[')
                {
                    MyStack.Push(']');
                }
                else if (InitialString[i] == '(')
                {
                    MyStack.Push(')');
                }

                else if (InitialString[i] == '}' || InitialString[i] == ']' || InitialString[i] == ')')
                {
                    if (InitialString[i] == MyStack.Peek())
                    {
                        MyStack.Pop();
                    }
                    else
                    {
                        MyStack.Push(InitialString[i]);
                    }
                }

            }

            if ( MyStack.Count == 0)
            {
                Console.WriteLine("Открытые и закрытые скобки совпадают");
            }
            else
            {
                Console.WriteLine("Открытые и закрытые скобки  _НЕ_  совпадают");
            }

            Console.ReadKey();

        }
    }
}

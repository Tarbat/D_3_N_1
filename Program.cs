using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


class HelloWorld
{
    public class iStack
    {
        int[] imitStack;
        int currentPoint = 0;
    
    public iStack()
        {
            int SizeStack = 100;
            imitStack = new int[SizeStack];
        }

        public void push(int n)
        {
            imitStack[currentPoint] = n;
            Console.WriteLine("ok");
            currentPoint++;
        }
        public int pop()
        {
            currentPoint--;
            int returnValue = imitStack[currentPoint];
            imitStack[currentPoint] = 0;
            return returnValue;
        }
        public int back()
        {
            int cP = currentPoint - 1;
            int bVal = imitStack[cP];
            return bVal;
        }
        public int size()
        {
            int curPoint = currentPoint--;
            currentPoint++;
            return curPoint;
        }
        public void clear()
        {
            currentPoint = 0;
            Console.WriteLine("ok");
        }
        public void exit()
        {
            Console.WriteLine("bye");
        }

    }

    static void Main()
    {

        iStack imitStack = new iStack();

        for (; ; )
        {
            String code;

            Console.WriteLine("push - внести элемент в стек (После внесения 'push' нажать enter и только затем внести число)");
            Console.WriteLine("pop - удалить верхний элемент массива");
            Console.WriteLine("back - вывод последнего элемента");
            Console.WriteLine("size - размер стека");
            Console.WriteLine("clear - очистить стек");
            Console.WriteLine("exit - выход");

            Console.Write("Code - ");
            code = Console.ReadLine();
            int dataOutput;

            switch (code)
            {
                case "push":
                    int sinAct;
                    sinAct = Convert.ToInt32(Console.ReadLine());
                    imitStack.push(sinAct);
                    break;

                case "pop":
                    dataOutput = imitStack.pop();
                    Console.WriteLine(dataOutput);
                    break;

                case "back":
                    dataOutput = imitStack.back();
                    Console.WriteLine(dataOutput);
                    break;

                case "size":
                    dataOutput = imitStack.size();
                    Console.WriteLine(dataOutput);
                    break;

                case "clear":
                imitStack.clear();
                    break;

                case "exit":
                    imitStack.exit();
                    return;

                default:
                    Console.WriteLine("Error, Incorrect command entered");
                    break;
            }
        }
    }
}
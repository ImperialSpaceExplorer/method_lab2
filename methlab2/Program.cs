using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Реализуйте структуру данных "очередь".Напишите программу, содержащую описание очереди и моделирующую работу очереди, реализовав все указанные здесь методы.Программа считывает последовательность команд и в зависимости от команды выполняет ту или иную операцию. После выполнения каждой команды программа должна вывести одну строчку.Возможные команды для программы:

            //push n
            //Добавить в очередь число n(значение n задается после команды).Программа должна вывести ok.
            //pop
            //Удалить из очереди первый элемент. Программа должна вывести его значение.
            //front
            //Программа должна вывести значение первого элемента, не удаляя его из очереди.
            //size
            //Программа должна вывести количество элементов в очереди.
            //clear
            //Программа должна очистить очередь и вывести ok.
            //exit
            //Программа должна вывести bye и завершить работу.



            int[] queue = new int[0];
            bool run = true, aoelem = false;

            string buf; int buf2 = 0;

            while (run == true)
            {
                buf = Console.ReadLine();

                if (buf.StartsWith("push")) { buf2 = Convert.ToInt32(buf.Substring(5)); buf = "push"; }

                switch (buf)
                {
                    case "push":

                        
                            push(buf2, ref queue);

                            aoelem = true;
                            Console.WriteLine("OK ");
                       

                        break;
                    case "pop"://Удалить из стека первый элемент. Программа должна вывести его значение.

                        if (aoelem == true)
                        {
                            int last = pop(ref queue);

                            Console.WriteLine(last);

                            if (size(queue) == 0) aoelem = false;
                        }
                        else Console.WriteLine("error ");


                        break;
                    case "front"://Программа должна вывести значение первого элемента, не удаляя его из стека.

                        if (aoelem == true)
                        {
                            Console.WriteLine(front(queue));
                        }
                        else Console.WriteLine("error ");

                        break;
                    case "size":

                        if (aoelem == true)
                        {
                            Console.WriteLine(size(queue));
                        }

                        break;
                    case "clear":

                        if (aoelem == true)
                        {
                            clear(ref queue);

                            Console.WriteLine("OK ");

                            aoelem = false;
                        }

                        break;
                    case "exit":
                        Console.WriteLine("Bye");
                        run = false;
                        break;

                }
            }
        }

        public static void push(int num, ref int[] queue)
        {

            Array.Resize(ref queue, queue.Length + 1);
            queue[queue.Length - 1] = num;

            return;

        }

        public static int pop(ref int[] queue)
        {
            int first = queue[0];
            Array.ConstrainedCopy(queue,1, queue,0,queue.Length-1);
            Array.Resize(ref queue, queue.Length - 1);

            return first;

        }

        public static int front(int[] queue)
        {
            int first = queue[0];

            return first;
        }

        public static int size(int[] stack)
        {
            return stack.Length;

        }

        public static void clear(ref int[] stack)
        {
            Array.Resize(ref stack, 0);
        }

    }
}

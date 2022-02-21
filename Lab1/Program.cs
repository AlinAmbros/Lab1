using System;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
            var list = new LinkedList<int>();

            // Добавляем элементы.
            list.Prepand(1);
            list.Prepand(5);
            list.Prepand(17);
            list.Prepand(42);
            list.Prepand(-69);

            /*// Выводим все элементы на консоль.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Delete(17);*/

            // Выводим все элементы на консоль.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            //Console.WriteLine(list.Find(42));

            //Console.WriteLine(list.DeleteHead()); 

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
	}
}

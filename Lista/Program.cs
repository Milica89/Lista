using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        public static void Main(string[] args)
        {
            IMyList<int> list = new MyList<int>(10);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Add element " + i);
                list.AddLast(i);
                Console.WriteLine("New length is: " + list.GetLength());

            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("View last element " + list.ViewLast());
                Console.WriteLine("Remove last element " + list.RemoveLast());
                Console.WriteLine("New length is " + list.GetLength());

            }

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("View first element " + list.ViewFirst());
                Console.WriteLine("Remove first element " + list.RemoveFirst());
                Console.WriteLine("New length is " + list.GetLength());

            }

    
            list.ClearList();
            Console.WriteLine("MyList: " + list.GetLength());
            var item = list.ShowAllElements();
            foreach (var i in item)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("MyList: " + list.ShowAllElements());

            list.AddLast(12);
            Console.WriteLine(list.GetLength());
            Console.WriteLine(list.ViewLast());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Add last element " + i);
                list.AddLast(i);
                Console.WriteLine("New length is: " + list.GetLength());

            }

              for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Add first element " + i);
                list.AddFirst(i);
                Console.WriteLine("New length is: " + list.GetLength());

            }


            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();






        }
    }
}

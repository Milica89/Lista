using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class MyList<T> : IMyList<T>
    {
        public int Capacity { get; set; }

        private int index = -1;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private int length;
        public int Length
        {
            get { return length = Index + 1; }
        }

        public T[] Elements { get; set; }

        private void IncreaseList()
        {
            Capacity++;
            T[] newList = new T[Capacity];
            Array.Copy(Elements, newList, Elements.Length);
            Elements = newList;
        }

        public MyList()
        {
            Elements = new T[Capacity];
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            Elements = new T[Capacity];
        }


        public void AddFirst(T element)
        {
            if (this.Length == Capacity)
            {
                IncreaseList();
            }
            Index++;
            for (int i = 0; i < Index; i++)
            {
                Elements[Index - i] = Elements[Index - i - 1]; 
            }
                Elements[0] = element;
        }

        public void AddLast(T element)
        {
            if (this.Length == Capacity)
            {                
                IncreaseList();
            }
            Index++;
            Elements[Index] = element;
        }

        public T ViewFirst()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("List is empty!");
            }
            return Elements[0];
        }

        public T ViewLast()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("List is empty!");
            }
            return Elements[Index];
        }

        public T RemoveFirst()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("List is empty!");
            }           

            for (int i = 0; i < Index; i++)
            {
                Elements[i] = Elements[i + 1];
            }
            Index--;
            return Elements[0];
        }

        public T RemoveLast()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("List is empty!");
            }
            Elements[Index] = default(T);
            Index--;
            return Elements[Index];
        }

        public List<T> ShowAllElements()
        {
            List<T> ListOfElements = new List<T>();
            for (int i = 0; i < Length; i++)
            {
                ListOfElements.Add(Elements[i]);
            }
            return ListOfElements;
        }

        public int GetLength()
        {
            return Length;
        }

        public void ClearList()
        {
            Array.Clear(Elements, 0, Elements.Length);
            Index = -1;
        }
    }
}

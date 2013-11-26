using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    interface IMyList<T>
    {
        void AddFirst(T element);
        void AddLast(T element);
        T ViewFirst();
        T ViewLast();
        T RemoveFirst();
        T RemoveLast();
        List<T> ShowAllElements();
        int GetLength();
        void ClearList();
    }
    
}

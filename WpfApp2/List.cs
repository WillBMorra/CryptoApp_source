using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Collections.IEnumerator;

namespace WpfApp2
{
    class SetList<T> : IList<T>
    {
        int index;
        int counter => index;
        T[] mas;
        public SetList(int size = 100)
        {
            index = 0;
            mas = new T[size];
        }
        
        public T this[int index]
        {
            get { return this[index]; }
            set { }
        }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        public void Add(T data) 
        {
            mas[index] = data;
            index++;
        }


        public IEnumerator<T> GetEnumerator() { return GetEnumerator(); }

        public int IndexOf(T data) { return 0; }

        public void Insert(int index, T data) { }   
        
        public bool Remove(T data) { return false; }

        public bool Contains(T data) { return false; }

        public int Count { get { return 0; } }

        public bool IsReadOnly { get { return false; } }

        

        public void CopyTo(T[] array, int arrayIndex) { }

        public void Clear() 
        { 
            
        }

       public void RemoveAt(int index) { }

        public void SortbyNumb(int content) 
        {
            
        }


    }
}

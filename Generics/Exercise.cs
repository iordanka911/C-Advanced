using System;
using System.Collections.Generic;
using System.IO;

namespace GenericDemo
{
    class Pair<T>
        
    {
        public T First { get; set; }
        public T Second { get; set; }
    }

    class Box<T>
    {
        private List<T> internalList = new List<T>();
       public void Add(T a)
        {
            internalList.Add(a);
        }

        public int Count
        {
            get
            {
               return  internalList.Count;
            }

        }

        public T Remove()
        {
            T element = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);
            return element;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            box.Add("Niki");
            box.Add("Stoyan");
            box.Remove();
            var pair = new Pair<string>();
            //var pair1 = new Pair<BufferedStream>();
           // pair.First-> type string
            var list = new List<string>();
            var list1 = CreateListWith100Items<int>(4);

            var array = CreateArray<int>(10, 1);
            var arrayString = CreateArray<string>(10, "Niki");
            var arrayLists = CreateArray(10, new List<string>());
        }

        static List<T> CreateListWith100Items<T>(T value)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(value);
            }
            return list;

        }
        static T[]CreateArray<T>(int count, T element)
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = element;
            }
            return result;
        }
    }
}

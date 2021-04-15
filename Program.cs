using System;

namespace Lab_2_1
{
    class MyList<T>
    {
        private T[] myList = null;
        public T this[int index]
        {
            get { return myList[index]; }
            set { myList[index] = value; }
        }
        public MyList()
        {
            this.myList = new T[1];
        }
        public MyList(int count)
        {
            this.myList = new T[count];
        }
        public void Add(T item)
        {
            T[] extendedList = new T[myList.Length + 1];
            extendedList[extendedList.Length - 1] = item;
            myList = extendedList;
        }
        public int Capacity
        {
            get { return myList.Length; } // Повертає число елементiв, якi фактично мiтяться в колекцii MyList<T>.
        }
        public int Count
        {
            get
            {
                int count = 0;
                for (int i = 0; i < myList.Length; i++)
                {
                    if (myList[i].ToString() != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(5);
            myList[0] = 1;
            Console.WriteLine("Вмiст списку: {0} елемент(-ов)", myList.Capacity);
            Console.WriteLine("Список фактично мiстить {0} елемент(-ов)", myList.Count);
            myList.Add(15);
            Console.WriteLine("Вмiст списку: {0} елемент(-ов)", myList.Capacity);

            Console.ReadLine();
        }
    }
}

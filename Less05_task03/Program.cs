using System;

namespace Less05_task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance[2]);
            //выход за пределы массива
            Console.WriteLine(instance[10]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        string[] array = new string[3] { "one", "two", "three" };
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                return "index out of range";
            }
            set
            {
                if (index >= 0 || index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
    }
}

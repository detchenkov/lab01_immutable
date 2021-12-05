using System;

namespace lab01_immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyImmutable temp = new MyImmutable("Some name");
            MyImmutable temp2 = temp;
            temp = new MyImmutable("another name");

            System.Console.WriteLine(temp.GetName);
            System.Console.WriteLine(temp2.GetName);
        }
    }

    class MyImmutable
    {
        private readonly string name;
        
        public MyImmutable(string str)
        {
            name = str;
        }
        public string GetName
        {
            get { return name; }
        }

    }
}

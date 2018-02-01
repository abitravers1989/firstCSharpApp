using System;

namespace YagoSession1Practice
{
    class Program
    {
      public static void Main (string [] args)
        {
            Animal first = new Animal("cat", "poopie");
            var second = new Animal("dog");

            first.DescribeMe();
            second.DescribeMe();
            Console.ReadLine();
        }
    }
}

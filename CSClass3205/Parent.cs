using System;

namespace CSClass3205
{
    public class Parent
    {
        public static int counter = 0;
        public int variable = 23;

        public void Method()
        {
            Console.WriteLine("부모 메서드");
        }

        public void CountParent()
        {
            Parent.counter++;
        }

        public Parent()
        {
            Console.WriteLine("Parent()");
        }

        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string param)
        {
            Console.WriteLine("Parent(string param)");
        }

    }
}
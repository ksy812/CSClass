using System;

namespace CSClass3205
{
    class Dog : Animal
    {
        public String Color { get; set; }
        public void Eat()
        {
            Console.WriteLine("쩝쩝 먹겠습니다.");
        }

        public void Bark()
        {
            base.Eat();
            Console.WriteLine("왈왈 짓습니다.");
        }
    }
}
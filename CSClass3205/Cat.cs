using System;

namespace CSClass3205
{
    class Cat : Animal
    {
        public Cat()
        {
            this.Age = 0;
        }

        internal void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}
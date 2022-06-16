using System;

namespace CSClass3205
{
    class Cat : Animal
    {
        public Cat()
        {
            this.Age = 0;
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }

        public override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다.");
        }
    }
}
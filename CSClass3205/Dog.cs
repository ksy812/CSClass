using System;

namespace CSClass3205
{
    class Dog : Animal
    {
        public string Color { get; set; }

        public void Bark()
        {
            //base.Eat();
            Console.WriteLine("왈왈 짓습니다.");
        }
        
        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다.");
        }
    }
}
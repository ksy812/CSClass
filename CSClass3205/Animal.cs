﻿using System;

namespace CSClass3205
{
    internal class Animal
    {
        public int Age { get; set; }
        public Animal()
        {
            this.Age = 0;
        }
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}
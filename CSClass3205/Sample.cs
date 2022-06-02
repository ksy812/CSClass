using System;

namespace CSClass3205
{
    class Sample
    {
        public static int value = 41;

        static Sample()
        {
            value = 100;
            Console.WriteLine("Sample() 정적 생성자 호출");
        }

        ~Sample()
        {
            Console.WriteLine("Sample 객체 소멸자 호출");
        }
    }
}
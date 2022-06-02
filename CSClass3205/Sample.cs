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

        public Sample()
        {
            Console.WriteLine("Sample() 생성자 호출");
        }
    }
}
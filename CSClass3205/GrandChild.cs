using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass3205
{
    public class GrandChild : Child
    {
        public override void Method2()
        {
            Console.WriteLine("자식의 자식 메서드");
        }
    }
}

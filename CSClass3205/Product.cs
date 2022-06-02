using System;

namespace CSClass3205
{
    class Product
    {
        public static int counter = 0;
        public int id;

        public static string MADEIN = "Korea";

        public Product(string name, int price)
        {
            Product.counter++;
            this.id = counter;
            this.name = name;
            this.price = price;
            Console.WriteLine(this);
        }
        override public String ToString()
        {
            return this.id + ": " + this.name + ", " + this.price;
        }


        /// <summary>
        /// 상품 이름
        /// </summary>
        public string name = "무명";
        
        /// <summary>
        /// 상품 가격(단위: 원)
        /// </summary>
        public int price = 1000;

        public Product()
        {
        }
    }
}
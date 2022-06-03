using System;

namespace CSClass3205
{
    class Box2
    {
        private int width;
        private int height;

        public Box2(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;

        }

        //java 스타일 getter&setter
        public void SetWidth(int width)
        {
            if(width > 0)
                this.width = width;
            else
                Console.WriteLine("양수를 입력해주세요.");
        }
        public void SetHeight(int height)
        {
            if (height > 0)
                this.height = height;
            else
                Console.WriteLine("양수를 입력해주세요.");
        }

        public int GetWidth() { return this.width; }
        public int GetHeight() { return this.height; }
    }
}
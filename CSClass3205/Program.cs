using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass3205
{
    internal class Program
    {
        static int number;
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            //random.Next();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble() * 10);


            /*List<int> list = new List<int>();
            list.Add(1);
            list.Add(10);
            list.Add(100);
            list.Add(11);*/
            List<int> list = new List<int>() { 52, 273, 32, 24 };
            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Hamburger nyam = new Hamburger();


            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            //인스턴스 변수 생성과 동시에 초기화(C# 고유 문법)
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 5500, name = "당근케이크" };
            Product productD = new Product() { name = "보름달" };

            /*
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "김소연", grade = 1 });
            students.Add(new Student() { name = "이름", grade = 2 });
            students.Add(new Student() { name = "가나다", grade = 3 });
            students.Add(new Student() { name = "라마바", grade = 1 });
            students.Add(new Student() { name = "고양이", grade = 2 });
            students.Add(new Student() { name = "가오리", grade = 3 });
            students.Add(new Student() { name = "해파리", grade = 1 });
            students.Add(new Student() { name = "홍길동", grade = 2 });
            students.Add(new Student() { name = "하카파", grade = 3 });
            */
            List<Student> students = new List<Student>()
            {
                new Student() { name = "김소연", grade = 1 },
                new Student() { name = "이름", grade = 2 },
                new Student() { name = "가나다", grade = 3 },
                new Student() { name = "라마바", grade = 1 },
                new Student() { name = "고양이", grade = 2 },
                new Student() { name = "가오리", grade = 3 },
                new Student() { name = "해파리", grade = 1 },
                new Student() { name = "홍길동", grade = 2 },
                new Student() { name = "하카파", grade = 3 },
            };
            /*
            foreach (var item in students)
            {
                if(item.grade > 2)
                {
                    students.Remove(item);
                }
                Console.WriteLine(item);
            }
            */
            /*
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }*/
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {

                Console.WriteLine(item);
            }

            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 10));
            Console.WriteLine(Method.Abs(-100));
            Console.WriteLine(Method.Abs(100));
            //Console.WriteLine(method.Abs(100)); //java에서는 가능한 문법


            //Method Overloading
            //int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            //double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-52.273));

            //long
            Console.WriteLine(MyMath.Abs(2223456789L));
            Console.WriteLine(MyMath.Abs(-2223456789L));


            //static 변수
            Product product1 = new Product("감자", 3000);
            Product product2 = new Product("고구마", 5000);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            //static 생성자
            /*            
                        Console.WriteLine("첫번째 위치");
                        Console.WriteLine(Sample.value); //여기서 생성자 호출
                        Console.WriteLine("두번째 위치");
                        Sample sample = new Sample();
                        Console.WriteLine("세번째 위치");
            */
            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();  //여기서 생성자 호출
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치");


            //속성
            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 : " + box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.SetWidth(-10);
            Console.WriteLine("box2 면적은 : " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box 면적은 : " + box.Area);

            //재귀함수
            /*
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.Get(100));
            Console.WriteLine(Fibonacci.Get(1000));
            */

            //23-1. 상속과 다형성 소개
            //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog() , new Dog()};
            //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                //((Dog)item).Bark();

                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
                                
            }

            //23-6. 상속의 생성자
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parent = new Parent();
            Child child = new Child();
            Console.WriteLine("p counter: " + Parent.counter + " / c counter" + Child.counter);
            parent.CountParent();
            Console.WriteLine("p counter: " + Parent.counter + " / c counter" + Child.counter);
            child.CountParent();
            Console.WriteLine("p counter: " + Parent.counter + " / c counter" + Child.counter);


            //섀도잉
            int number = 20; //위에 Program - static int number 있음
            Console.WriteLine(number);

            //하이딩
            Child c = new Child();
            Console.WriteLine("child.variable: " + c.variable);
            Console.WriteLine("(Parent)child).variable: " + ((Parent)c).variable);
            c.Method();
            ((Parent)c).Method();
        }
    }
}
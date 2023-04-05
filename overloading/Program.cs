using System;

namespace overloading
    
{
    class program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("task1-----------------------------------------Start");
            Console.WriteLine("Cevrenin Radiusunu daxil et");
            int r = Convert.ToInt32(Console.ReadLine());
            over(r);
            Console.WriteLine("------------------------------");
            Console.WriteLine("duzbucaqlinin enini daxil et");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("duzbucaqlinin uzunlugunu daxil et");
            int b = Convert.ToInt32(Console.ReadLine());
            over(a, b);
            Console.WriteLine("------------------------------");

            Console.WriteLine("duzbucaqli parlapipedin  enini daxil et");
            int eni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("duzbucaqli parlapipedin uzunlugunu daxil et");
            int uzunluq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("duzbucaqli parlapipedin hundurluyunu daxil et daxil et");
            int hundurluk = Convert.ToInt32(Console.ReadLine());
            over(eni,uzunluq,hundurluk);
            Console.WriteLine("------------------------------");

            Console.WriteLine("ucbucagin perimetrini daxil edin");
            int perimetr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ucbucagin daxiline cekilmish cevrenin radiusunu daxil edin");
            int radius = Convert.ToInt32(Console.ReadLine());


            over(perimetr,radius);
            Console.WriteLine("------------------------------End");


            Console.WriteLine("Task 2 --------------------------");
            Console.WriteLine("1 reqem daxil elediyimiz halda");
            Console.WriteLine("REQEM DAXIL EDIN");
            int num=Convert.ToInt32(Console.ReadLine());
            newOverloading(num);
            Console.WriteLine("2 reqem daxil elediyimiz halda");
            Console.WriteLine("1 ci reqemi daxil edin");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci reqemi daxil edin");
            int num2 = Convert.ToInt32(Console.ReadLine());
            newOverloading(num1,num2);
        }

        #region  Task1
        static void over(int r)
        {
            int S = 3 * r * r;
            Console.WriteLine("cevrenin Sahesi" + " " + S);
        }
        static void over(int a, int b)
        {
            int S = a * b;
            Console.WriteLine("duzbucaqlinin sahesi" + " " + S);
        }
        static void over(int eni, int uzunluq, int hundurluk)
        {
            int S = 2 * (eni* uzunluq + eni * hundurluk + uzunluq * hundurluk);
            Console.WriteLine("duzbucaqli parlapipedin tamsethinin sahesi" + " " + S);
        }
        static void over(int perimetr, int radius, int A, int B, int C)
        {

            perimetr = (A + B + C) / 2;
            int S = perimetr * radius;
            Console.WriteLine("Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi" + " " + S);
        }

        #endregion





        #region Task2
        static void newOverloading(int num)
        {
            int multiplication = num * num;
            Console.WriteLine(multiplication);
        }
        static void newOverloading(int num1, int num2)
        {
            double power = Math.Pow(num1, num2);
            Console.WriteLine(power);
        }
        #endregion

    }
}
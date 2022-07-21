using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha21()
            {
                //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                Console.WriteLine("введите координаты точки 1");

                int xx=Convert.ToInt32(Console.ReadLine());
                int xy=Convert.ToInt32(Console.ReadLine());
                int xz=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("введите координаты точки 2");

                int yx=Convert.ToInt32(Console.ReadLine());
                int yy=Convert.ToInt32(Console.ReadLine());
                int yz=Convert.ToInt32(Console.ReadLine());
                
                double distance=Math.Sqrt(Math.Pow(xx-yx,2)+Math.Pow(xy-yy,2)+Math.Pow(xz-yz,2));
                
                Console.WriteLine(distance);
            }
            Zadacha21();
        }
        
     }
    
}
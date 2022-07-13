using System;

namespace UD3_Ejercicios
{
    class EJ3
    {
        public void Ejercicio3()
        {
            int X = 2;
            int Y = 3;
            double N = 4;
            double M = 5;
            int dobleX = X * 2;
            int dobleY = Y * 2;
            double dobleN = N * 2;
            double dobleM = M * 2;

            Console.WriteLine("Variable X =" + (X));
            Console.WriteLine("Variable Y =" + (Y));
            Console.WriteLine("Variable N =" + (N));
            Console.WriteLine("Variable M =" + (M));
            Console.WriteLine(X + Y);
            Console.WriteLine(X - Y);
            Console.WriteLine(X * Y);
            Console.WriteLine(X / Y);
            Console.WriteLine(X % Y);
            Console.WriteLine(N + M);
            Console.WriteLine(N * M);
            Console.WriteLine(N / M);
            Console.WriteLine(N % M);
            Console.WriteLine(X + N);
            Console.WriteLine(Y / M);
            Console.WriteLine(Y % M);
            Console.WriteLine("Doble Variable X =" + (dobleX));
            Console.WriteLine("Doble Variable Y =" + (dobleY));
            Console.WriteLine("Doble Variable N =" + (dobleN));
            Console.WriteLine("Doble Variable M =" + (dobleM));
            Console.WriteLine(X + Y + N + M);
            Console.WriteLine(X / Y / N / M);
        }
    }
}
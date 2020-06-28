using System;
using System.Globalization;


namespace matrizexe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas tem?");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas tem?");
            int M = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, M];

            for (int i =0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j=0; j < M; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Qual numero quer procurar?");
            int procurar = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matriz[i, j] == procurar) {
                        Console.WriteLine("Posição: " + i + ", "+j);
                        if(j>0) Console.WriteLine("left: " + matriz[i, j - 1]);
                        if (j<M-1 ) Console.WriteLine("right: " + matriz[i, j + 1]);
                        if (i < N-1) Console.WriteLine("down: " + matriz[i+1, j]);
                        if (i > 0) Console.WriteLine("up: " + matriz[i - 1, j]);

                    }
                }
            }

            Console.WriteLine(matriz .Length );
        }
    }
}

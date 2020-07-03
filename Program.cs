using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura;
            int altura;
            int i = 1;
            int j = 1;

            Console.WriteLine("Tamanho do retângulo:");
            Console.Write("Largura..: ");
            largura = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Altura...: ");
            altura = Convert.ToInt32(Console.ReadLine());

            while (i <= altura)
            {
                while(j <= largura)
                {
                    //Primeira Linha ou Última Linha ou Primeira Coluna ou Última coluna
                    if (i == 1 || i == altura || j == 1 || j == largura)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    j++;
                }
                j = 1;
                i++;
                Console.WriteLine();
            }

        }
    }
}

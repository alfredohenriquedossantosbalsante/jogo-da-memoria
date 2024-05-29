using System.Diagnostics;

namespace jogo_da_memoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tela = new int[4, 4];
            int[,] jogo = new int[4, 4];
            int acertos = 0;

            int linha, coluna;

            Random gerador = new Random();

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 0; j < 2; j++)
                {


                    do
                    {
                        linha = gerador.Next(0, 4);
                        coluna = gerador.Next(0, 4);
                    } while (jogo[linha, coluna] != 0);
                    jogo[linha, coluna] = i;
                }

            }
            do
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(tela[j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                int linha1, coluna1;
                Console.WriteLine("entre com a linha[1, 4]");
                linha1 = int.Parse(Console.ReadLine());
                Console.WriteLine("entre com a coluna[1, 4]");
                coluna1 = int.Parse(Console.ReadLine());

                linha1--;
                coluna1--;
                tela[linha1, coluna1] = jogo[linha1, coluna1];

                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(tela[j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int linha2, coluna2;
                Console.WriteLine("entre com a linha[1, 4]");
                linha2 = int.Parse(Console.ReadLine());
                Console.WriteLine("entre com a coluna[1, 4]");
                coluna2 = int.Parse(Console.ReadLine());

                linha2--;
                coluna2--;
                tela[linha2, coluna2] = jogo[linha2, coluna2];
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(tela[j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                if (tela[linha1, coluna1] == tela[linha2, coluna2])
                {
                    acertos++;
                }
                else
                {
                    tela[linha1, coluna1] = 0;
                    tela[linha2, coluna2] = 0;
                }
            } while (acertos < 8);  


        }
    }
}

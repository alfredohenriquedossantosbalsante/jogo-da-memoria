using System.Diagnostics;

namespace jogo_da_memoria
{
    internal class Program
    {
        static void PrintMatrix(int[,] tela)
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
        }
static void Main(string[] args)
        {
            int[,] tela = new int[4, 4];
            int[,] jogo = new int[4, 4];
            int acertos = 0;
            int jogadasp1 = 0, jogadasp2 = 0;

            Console.WriteLine("entre com o nome do player 1: ");
            string namep1 = Console.ReadLine();
            Console.WriteLine("entre com o nome do player 2: ");
            string namep2 = Console.ReadLine();

            player p1 = new player(namep1);
            player p2 = new player(namep2);

            Console.WriteLine("nome: "+ p1.Name);
            Console.WriteLine("pontuação: " + p1.Score);

            Console.WriteLine(p1._name);
            Console.WriteLine(p2._name);


            Environment.Exit(0);

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

            int jogador = gerador.Next(1, 3);

            
            if(jogador == 1)
            {
                Console.WriteLine(p1.Name+" é a sua vez.");
            }
            else
            {
                Console.WriteLine(p2.Name+" é a sua vez."); 
            }
            DateTime begin = DateTime.Now;
            do
            {


                Program.PrintMatrix(tela);
                    int linha1, coluna1;
                Console.WriteLine("entre com a linha[1, 4]");
                linha1 = int.Parse(Console.ReadLine());
                Console.WriteLine("entre com a coluna[1, 4]");
                coluna1 = int.Parse(Console.ReadLine());

                linha1--;
                coluna1--;
                tela[linha1, coluna1] = jogo[linha1, coluna1];

               Program.PrintMatrix(tela);
                int linha2, coluna2;
                Console.WriteLine("entre com a linha[1, 4]");
                linha2 = int.Parse(Console.ReadLine());
                Console.WriteLine("entre com a coluna[1, 4]");
                coluna2 = int.Parse(Console.ReadLine());

                linha2--;
                coluna2--;
                tela[linha2, coluna2] = jogo[linha2, coluna2];
               Program.PrintMatrix(tela);

                if (tela[linha1, coluna1] == tela[linha2, coluna2])
                {
                    if(jogador == 1)
                    {
                        p1.Score = 1;
                        jogadasp1++;
                    }
                    else
                    {
                        p2.Score = 1;
                        jogadasp2++;
                    }
                    acertos++;
                    
                }
                else
                {
                    TimeSpan timeSpan = DateTime.Now - begin;

                    if(jogador == 1)
                    {
                        p1.GameTime = timeSpan;
                        jogadasp1++;
                    }
                    else
                    {
                        p2.GameTime = timeSpan;
                        jogadasp2++;
                    }
                    
                    tela[linha1, coluna1] = 0;
                    tela[linha2, coluna2] = 0;
                }

                

                
            } while (acertos < 8);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine("o numero de jogadas do player 1 foi: " + jogadasp1); 
            Console.WriteLine("o numero de jogadas do player 2 foi: " + jogadasp2);



        }
    }
}

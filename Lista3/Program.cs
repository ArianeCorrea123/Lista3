using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3
{
    internal class Program
    {
        static int Menu()
        {
            Console.Clear();
            int resp;
            Console.WriteLine("Entre com o número de acordo com o exercício.\n");
            Console.WriteLine("Exercicio: 01");
            Console.WriteLine("Exercicio: 02");
            Console.WriteLine("Exercicio: 03");
            Console.WriteLine("Exercicio: 04");
            Console.WriteLine("Exercicio: 0 - Sair");
            resp = int.Parse(Console.ReadLine());
            return resp;
        }
        static void Ex1()
        {
                int Numero;
                float[] vet;

                Console.Write("Digite o tamanho do vetor: ");
                Numero = int.Parse(Console.ReadLine());

                vet = new float[Numero];

                for (int i = 0; i < Numero; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    vet[i] = float.Parse(Console.ReadLine());
                }

                float menor = vet[0];
                float maior = vet[0];
                float soma = vet[0];

                for (int i = 1; i < Numero; i++)
                {
                    if (vet[i] < menor)
                    {
                        menor = vet[i];
                    }
                    if (vet[i] > maior)
                    {
                        maior = vet[i];
                    }
                    soma += vet[i];
                }

                float media = soma / Numero;

                Console.WriteLine($"Menor número: {menor}");
                Console.WriteLine($"Maior número: {maior}");
                Console.WriteLine($"Média aritmética: {media}");
                Console.ReadKey();
        }
           
        static void Ex2()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero.");
                return;
            }

            int[] vetor = new int[numero];
            int soma = 0;

            for (int i = 0; i < numero; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            double media = (double)soma / numero;

            Console.WriteLine($"Média dos números digitados: {media}");

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < numero; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.ReadLine();
        }
        static void Ex3()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero.");
                return;
            }

            int[] vetor = new int[numero];
            int soma = 0;

            for (int i = 0; i < numero; i++)
            {
                Random random = new Random();
                vetor[i] = random.Next(1, 100); // serão selecionado os numeros
                soma += vetor[i];
            }

            double media = (double)soma / numero;

            Console.WriteLine($"Média dos números digitados: {media}");

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < numero; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.ReadLine();

        }
        static void Ex4()
        {
            // Instruções iniciais
            Console.WriteLine("JOGO DA VELHA\n" +
               "Instruções: Para começar, escolha um número no tabuleiro [Esse número representa a sua posição]. \n\n" +
                "1° Jogador - 'você será X' \n" +
                "2° Jogador - 'você será O' \n");


            // Variáveis e arrays
            int jogada1, jogada2;
            String[,] tabuleiro = new String[3, 3];
            bool ganhou = true;

            // Casas no tabuleiro
            tabuleiro[0, 0] = "1";
            tabuleiro[0, 1] = "2";
            tabuleiro[0, 2] = "3";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "7";
            tabuleiro[2, 1] = "8";
            tabuleiro[2, 2] = "9";

            do
            {
                // 1° estrutura do tabuleiro 
                Console.WriteLine(" -------------");

                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[0, t]);
                }
                Console.Write(" | \n");

                // 2° estrutura do tabuleiro 
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[1, t]);
                }
                Console.Write(" | \n");

                // 3° estrutura do tabuleiro 
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(" | " + tabuleiro[2, t]);
                }
                Console.Write(" | \n");

                Console.WriteLine(" -------------");

                // AQUI COMEÇA O 1° JOGADOR ;) 

                try
                {
                    Console.Write("Sua vez, 1° Jogador: ");
                    jogada1 = int.Parse(Console.ReadLine());


                    // Parte superior do tabuleiro 
                    if (jogada1 == 1)
                    {
                        tabuleiro[0, 0] = "X";
                    }
                    else if (jogada1 == 2)
                    {
                        tabuleiro[0, 1] = "X";
                    }
                    else if (jogada1 == 3)
                    {
                        tabuleiro[0, 2] = "X";
                    }

                    // Parte central do tabuleiro 
                    else if (jogada1 == 4)
                    {
                        tabuleiro[1, 0] = "X";
                    }
                    else if (jogada1 == 5)
                    {
                        tabuleiro[1, 1] = "X";
                    }
                    else if (jogada1 == 6)
                    {
                        tabuleiro[1, 2] = "X";
                    }

                    // Parte inferior do tabuleiro 
                    else if (jogada1 == 7)
                    {
                        tabuleiro[2, 0] = "X";
                    }
                    else if (jogada1 == 8)
                    {
                        tabuleiro[2, 1] = "X";
                    }
                    else if (jogada1 == 9)
                    {
                        tabuleiro[2, 2] = "X";
                    }

                    Console.Clear();

                    // 1° estrutura do tabuleiro - 2
                    Console.WriteLine(" -------------");

                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[0, t]);
                    }
                    Console.Write(" | \n");

                    // 2° estrutura do tabuleiro - 2 
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[1, t]);
                    }
                    Console.Write(" | \n");

                    // 3° estrutura do tabuleiro - 2
                    for (int t = 0; t < 3; t++)
                    {
                        Console.Write(" | " + tabuleiro[2, t]);
                    }
                    Console.Write(" | \n");

                    Console.WriteLine(" -------------");

                    // Caso tenha empate
                    if ((tabuleiro[0, 0] == "X" | tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "X" | tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "X" | tabuleiro[0, 2] == "O") &&
                        (tabuleiro[1, 0] == "X" | tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "X" | tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "X" | tabuleiro[1, 2] == "O") &&
                        (tabuleiro[2, 0] == "X" | tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "X" | tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "X" | tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Vocês empataram!");
                        break;
                    }


                    // Caso o "X" ganhe na horizontal 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[0, 1] == "X") && (tabuleiro[0, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[1, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "X") && (tabuleiro[2, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }

                    // Caso "X" ganhe na vertical 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 0] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 1] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 2] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }

                    // Caso "X" ganhe na diagonal 
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        ganhou = false;
                        Console.WriteLine("1° jogador ganhou!");
                        break;
                    }


                    // AQUI COMEÇA O 2° JOGADOR -------------------------- ;)

                    Console.Write("Sua vez, 2° Jogador: ");
                    jogada2 = int.Parse(Console.ReadLine());

                    // Parte superior do tabuleiro 
                    if (jogada2 == 1)
                    {
                        tabuleiro[0, 0] = "O";
                    }
                    else if (jogada2 == 2)
                    {
                        tabuleiro[0, 1] = "O";
                    }
                    else if (jogada2 == 3)
                    {
                        tabuleiro[0, 2] = "O";
                    }

                    // Parte central do tabuleiro
                    else if (jogada2 == 4)
                    {
                        tabuleiro[1, 0] = "O";
                    }
                    else if (jogada2 == 5)
                    {
                        tabuleiro[1, 1] = "O";
                    }
                    else if (jogada2 == 6)
                    {
                        tabuleiro[1, 2] = "O";
                    }

                    // Parte inferior do tabuleiro
                    else if (jogada2 == 7)
                    {
                        tabuleiro[2, 0] = "O";
                    }
                    else if (jogada2 == 8)
                    {
                        tabuleiro[2, 1] = "O";
                    }
                    else if (jogada2 == 9)
                    {
                        tabuleiro[2, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Atenção ao jogo...");
                    }

                    // Caso o "O" ganhe na horizontal 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }

                    // Caso o "O" ganhe na vertical 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 0] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 1] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 1] == "OX"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 2] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }

                    // Caso o "O" ganhe na diagonal 
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("2° jogador ganhou!");
                        break;
                    }
                    // Caso tenha empate - 2° possibilidade 
                    if ((tabuleiro[0, 0] == "X" | tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "X" | tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "X" | tabuleiro[0, 2] == "O") &&
                        (tabuleiro[1, 0] == "X" | tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "X" | tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "X" | tabuleiro[1, 2] == "O") &&
                        (tabuleiro[2, 0] == "X" | tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "X" | tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "X" | tabuleiro[2, 2] == "O"))
                    {
                        ganhou = false;
                        Console.WriteLine("Vocês empataram!");
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Atenção! Apenas os números que constam no tabuleiro.");
                }

            } while (ganhou);

            Console.WriteLine("\n\n Obrigada por jogar! Pressione qualquer tecla para sair :)");
            Console.ReadKey();


        }
        static void Main(string[] args)
        {
            int resp;
            do
            {
                resp = Menu();
                switch (resp)
                {
                    case 0:
                        Console.WriteLine("Até a próxima.\n");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        Ex1();
                        break;
                    case 2:
                        Console.Clear();
                        Ex2();
                        break;
                    case 3:
                        Console.Clear();
                        Ex3();
                        break;
                    case 4:
                        Console.Clear();
                        Ex4();
                        break;
                    
                }
            }
            while (resp != 0);
        }
    }
    
}

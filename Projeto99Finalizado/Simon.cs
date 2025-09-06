using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Simon
    {
        public static Jogador Jogar(Jogador jogador1)
        {
            int j = 0, cont1 = 0, cont2 = 0, cont3 = 0, dificul = 0;
            int[,] matriz = new int[2, 15];
            bool continua = true;
            if (jogador1.Dificuldade == '3')
            {
                dificul = 10;
            }
            else if (jogador1.Dificuldade == '2')
            {
                dificul = 8;
            }
            else
            {
                dificul = 6;
            }
            while (continua == true)
            {
                Console.Clear();
                Design.Escrita("Vozes do Além : Bem vindo ao Simon, um jogo feito para testar sua memória, caso não consiga concluir, perderá uma vida.\n\nVidas:");
                Console.Write(jogador1.Vidas);
                Design.Escrita("\n\nVozes do Além : Diga a sequencia usando o seguinte método ( 1 = verde ) ( 2 = vermelho ) ( 3 = amarelo ) ( 4 = azul ): \n\n ");
                Thread.Sleep(2000);
                Console.Clear();
                Stopwatch cronometroSimon = new Stopwatch();
                cronometroSimon.Reset();
                cronometroSimon.Start();
                for (int i = 1; i <= dificul; i++)
                {
                    Thread.Sleep(700);
                    Console.Clear();
                    Design.Padrao();
                    Thread.Sleep(200);
                    Random escolhaBot = new Random();
                    matriz[cont1, cont2] = escolhaBot.Next(1, 4);
                    Thread.Sleep(500);

                    for (cont2 = 0; cont2 < i; cont2++)
                    {
                        if (matriz[cont1, cont2] == 1)
                        {
                            Console.Clear();
                            Design.Verde();
                            Thread.Sleep(500);
                            Console.Clear();
                            Design.Padrao();

                        }
                        else if (matriz[cont1, cont2] == 2)
                        {
                            Console.Clear();
                            Design.Vermelho();
                            Thread.Sleep(500);
                            Console.Clear();
                            Design.Padrao();
                        }
                        else if (matriz[cont1, cont2] == 3)
                        {
                            Console.Clear();
                            Design.Amarelo();
                            Thread.Sleep(500);
                            Console.Clear();
                            Design.Padrao();
                        }
                        else if (matriz[cont1, cont2] == 4)
                        {
                            Console.Clear();
                            Design.Azul();
                            Thread.Sleep(500);
                            Console.Clear();
                            Design.Padrao();
                        }

                    }
                    Console.WriteLine("\n\nSequencia:");
                    cont3 = cont2;
                    
                    
                        for (int k = 0; k < i; k++)
                        {


                            int resp = Convert.ToInt32(Console.ReadLine());
                            matriz[cont1 + 1, cont2] = resp;
                            if (resp != matriz[cont1, cont2 - cont3])
                            {
                                if (jogador1.Escudo == true)
                                {
                                    Random VidaSafe = new Random();
                                    int sorteioVida = VidaSafe.Next(1, 4);
                                    if (sorteioVida == 1)
                                    {
                                        Design.Escrita("Vozes do Além : Aparentemente você possui um anjo da guarda que o salvou do amargor da derrota e poupou 1 de suas vidas, deseja recomeçar?( 1 =  reiniciar ) ( 2 = voltar para o seletor de jogos )");
                                        char escolha2 = Console.ReadKey().KeyChar;
                                        if (escolha2 == '1')
                                        {
                                            jogador1.ChosenGame = 2;
                                            return jogador1;

                                        }
                                        else if (escolha2 == '2')
                                        {
                                            jogador1.ChosenGame = 0;
                                            return jogador1;
                                        }
                                    }
                                    else
                                    {
                                        jogador1.Vidas--;

                                        if (jogador1.Vidas == 0)
                                        {

                                            Design.Escrita("Vozes do Além : GAME OVER!!");
                                            jogador1.ChosenGame = -1;
                                            return jogador1;

                                        }
                                        else
                                        {
                                            Design.Escrita("Vozes do Além : HAHAHAHA, menos uma vida, deseja recomeçar?( 1 =  reiniciar ) ( 2 = voltar para o seletor de jogos )");
                                            char escolha2 = Console.ReadKey().KeyChar;
                                            if (escolha2 == '1')
                                            {
                                                jogador1.ChosenGame = 2;
                                                return jogador1;

                                            }
                                            else if (escolha2 == '2')
                                            {
                                                jogador1.ChosenGame = 0;
                                                return jogador1;
                                            }

                                        }
                                    }
                                }
                                else
                                {

                                    jogador1.Vidas--;

                                    if (jogador1.Vidas == 0)
                                    {

                                        Design.Escrita("Vozes do Além : GAME OVER!!");
                                        jogador1.ChosenGame = -1;
                                        return jogador1;

                                    }
                                    else
                                    {
                                        Design.Escrita("Vozes do Além : HAHAHAHA, menos uma vida, deseja recomeçar?( 1 =  reiniciar ) ( 2 = voltar para o seletor de jogos )");
                                        char escolha2 = Console.ReadKey().KeyChar;
                                        if (escolha2 == '1')
                                        {
                                            jogador1.ChosenGame = 2;
                                            return jogador1;

                                        }
                                        else if (escolha2 == '2')
                                        {
                                            jogador1.ChosenGame = 0;
                                            return jogador1;
                                        }
                                    }
                                }
                            }


                            cont3--;
                        }
                    
                   
                }
                cronometroSimon.Stop();
                TimeSpan simonInt = cronometroSimon.Elapsed;
                int ResultTimeSimon = Convert.ToInt32(simonInt.TotalSeconds);
                Design.Escrita("Vozes do Além : Parabéns, você conseguiu concluir o game!!!");
                continua = false;
                if (jogador1.Ampulheta == true)
                {
                    ResultTimeSimon -= 30;
                    Design.Escrita($"\nTempo: {ResultTimeSimon} segundos");

                }
                else
                {
                    Design.Escrita($"\nTempo: {ResultTimeSimon} segundos");
                }
                int Bonus = 1;
                if (jogador1.Estrela == true)
                {
                    Bonus = 2;
                }
                if (ResultTimeSimon <= 90)
                {
                    jogador1.Moedas += (10 * Bonus);
                    Design.Escrita("\nEstrelas: 3");
                    Design.Escrita("\nMoedas Ganhas: " + (10 * Bonus));
                }
                else if (ResultTimeSimon <= 120)
                {
                    jogador1.Moedas += (5 * Bonus);
                    Design.Escrita("\nEstrelas: 2");
                    Design.Escrita("\nMoedas Ganhas: " + (5 * Bonus));
                }
                else
                {
                    jogador1.Moedas += (3 * Bonus);
                    Design.Escrita("\nEstrelas: 1");
                    Design.Escrita("\nMoedas Ganhas: " + (3 * Bonus));
                }
                Thread.Sleep(3000);
                Console.Clear();
                jogador1.Simon = true;
                jogador1.ChosenGame = 0;
                jogador1.JogosCompletos++;
                return jogador1;

            }
            return jogador1;

        }
    }
}

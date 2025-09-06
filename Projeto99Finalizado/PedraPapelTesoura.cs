using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class PPT
    {
        public static Jogador Jogar(Jogador jogador1)
        {
            string bot = null;
            int player = 0, npc = 0;
            char escolha = 'a';
            bool continua = true;
            while (continua == true)
            {
                player = 0;
                npc = 0;
                Stopwatch cronometroPPT = new Stopwatch();
                cronometroPPT.Reset();
                cronometroPPT.Start();
                Design.Escrita("Vozes do Além : Bem vindo ao Pedra, Papel e Tesoura, o jogo será melhor de 5, caso perca, perderá uma vida.\n\nVidas:");
                Console.Write(jogador1.Vidas);
                while (player < 3 && npc < 3)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Design.Escrita("\n\nVozes do Além : Faça sua escolha: ( 1 = Pedra ) ( 2 = Papel ) ( 3 = Tesoura )\n\n");
                        escolha = Console.ReadKey().KeyChar;
                        if (escolha != '1' && escolha != '2' && escolha != '3')
                        {
                            j = -1;
                            Design.Escrita("Vozes do Além : Número inválido, escolha denovo");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                    Random escolhaBot = new Random();
                    int x = escolhaBot.Next(1, 4);
                    if (x == 1)
                    {
                        bot = "Pedra";
                    }
                    else if (x == 2)
                    {
                        bot = "Papel";
                    }
                    else if (x == 3)
                    {
                        bot = "Tesoura";
                    }
                    Console.WriteLine($"\n\nEscolha do adversário:{bot}");
                    if (escolha == 'x')
                    {
                        Console.WriteLine("\n\n Empate");
                    }
                    else if (escolha == '1' && x == 2)
                    {
                        Console.WriteLine("\n\n Ponto para o bot!!");
                        npc++;
                    }
                    else if (escolha == '1' && x == 3)
                    {
                        Console.WriteLine("\n\n Ponto seu!!");
                        player++;
                    }
                    else if (escolha == '2' && x == 1)
                    {
                        Console.WriteLine("\n\n Ponto seu!!");
                        player++;
                    }
                    else if (escolha == '2' && x == 3)
                    {
                        Console.WriteLine("\n\n Ponto para o bot!!");
                        npc++;
                    }
                    else if (escolha == '3' && x == 1)
                    {
                        Console.WriteLine("\n\n Ponto para o bot!!");
                        npc++;
                    }
                    else if (escolha == '3' && x == 2)
                    {
                        Console.WriteLine("\n\n Ponto seu!!");
                        player++;
                    }

                    Console.WriteLine($"\n\nPlacar:{player}x{npc}");
                    Thread.Sleep(3000);
                    Console.Clear();

                }
                if (player == 3)
                {
                    cronometroPPT.Stop();
                    TimeSpan pptInt = cronometroPPT.Elapsed;
                    int ResultTimePPT = Convert.ToInt32(pptInt.TotalSeconds);
                    Design.Escrita("Vozes do Além : Parabéns, você conseguiu concluir o game!!!");
                    continua = false;
                    if (jogador1.Ampulheta == true)
                    {
                        ResultTimePPT -= 30;
                        Design.Escrita($"\nTempo: {ResultTimePPT} segundos");

                    }
                    else
                    {
                        Design.Escrita($"\nTempo: {ResultTimePPT} segundos");
                    }
                    int Bonus = 1;
                    if (jogador1.Estrela == true)
                    {
                        Bonus = 2;
                    }

                    if (ResultTimePPT <= 60)
                    {
                        jogador1.Moedas += (10 * Bonus);
                        Design.Escrita("\nEstrelas: 3");
                        Design.Escrita("\nMoedas Ganhas: " + (10*Bonus));
                    }
                    else if (ResultTimePPT <= 120)
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
                    jogador1.ChosenGame = 0;
                    jogador1.PPT = true;
                    jogador1.JogosCompletos++;
                    return jogador1;
                }
                else if (npc == 3)
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
                                jogador1.ChosenGame = 1;
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
                                Thread.Sleep(3000);
                                jogador1.ChosenGame = -1;
                                return jogador1;

                            }
                            else
                            {
                                Design.Escrita("Vozes do Além : HAHAHAHA, menos uma vida, deseja recomeçar?( 1 =  reiniciar ) ( 2 = voltar para o seletor de jogos )");
                                char escolha2 = Console.ReadKey().KeyChar;
                                if (escolha2 == '1')
                                {
                                    jogador1.ChosenGame = 1;
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
                                jogador1.ChosenGame = 1;
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

            }

            return jogador1;
        }
    }
}

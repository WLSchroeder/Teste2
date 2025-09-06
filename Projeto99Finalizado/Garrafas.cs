using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Garrafas
    {
        public static Jogador Jogar(Jogador jogador1)
        {
            int indiceSorteado = 0;
            List<int> sort1 = new List<int>();
            List<int> sort2 = new List<int>();
            int[,] matriz = new int[3, 15];
            int dificul = 0, chances = 0;
            int cont = 0, teste = 0;
            bool continua = true, continuarGame = true;
            int valor1, valor2, resp1, resp2;
            if (jogador1.Dificuldade == '3')
            {
                sort1.Add(0);
                sort1.Add(1);
                sort1.Add(2);
                sort1.Add(3);
                sort1.Add(4);
                sort1.Add(5);
                sort1.Add(6);
                teste = 6;
                sort2.Add(0);
                sort2.Add(1);
                sort2.Add(2);
                sort2.Add(3);
                sort2.Add(4);
                sort2.Add(5);
                sort2.Add(6);
                chances = 20;
            }
            else if (jogador1.Dificuldade == '2')
            {
                sort1.Add(0);
                sort1.Add(1);
                sort1.Add(2);
                sort1.Add(3);
                sort1.Add(4);
                sort1.Add(5);
                teste = 5;
                sort2.Add(0);
                sort2.Add(1);
                sort2.Add(2);
                sort2.Add(3);
                sort2.Add(4);
                sort2.Add(5);
                chances = 10;
            }
            else
            {
                sort1.Add(0);
                sort1.Add(1);
                sort1.Add(2);
                sort1.Add(3);
                teste = 3;
                sort2.Add(0);
                sort2.Add(1);
                sort2.Add(2);
                sort2.Add(3);
                chances = 6;
            }
            Console.Clear();
            Design.Escrita($"Vozes do Além : Seja bem vindo ao jogo Garrafas, um jogo feito para testar sua lógica, caso não descubra a ordem, perderá uma vida. \n\n Vidas:{jogador1.Vidas}");
            Design.Escrita("\n\nPara jogar, escolha 1 garrafa pelo o seu número, e em seguida escolha com qual garrafa deseja alterna-la. Boa Sorte! ");
            Thread.Sleep(5000);
            Random random = new Random();
            while (sort1.Count > 0) // sorteia a sequencia do jogo
            {
                indiceSorteado = random.Next(0, sort1.Count);

                matriz[1, cont] = sort1[indiceSorteado];
                sort1.RemoveAt(indiceSorteado);

                cont++;
            }
            bool continuar = true;
            cont = 0;

            while (sort2.Count > 0) // sorteia a resposta
            {


                continuar = true;

                while (continuar == true)
                {
                    indiceSorteado = random.Next(0, sort2.Count);
                    matriz[2, cont] = sort2[indiceSorteado];
                    if (matriz[2, cont] == matriz[1, cont])
                    {
                        continuar = true;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                matriz[2, cont] = sort2[indiceSorteado];

                sort2.RemoveAt(indiceSorteado);
                cont++;
            }
            while (continuarGame == true)
            {
                Stopwatch cronometroGarrafas = new Stopwatch();
                cronometroGarrafas.Reset();
                cronometroGarrafas.Start();
                int gambiarra = Design.GarrafasCores(teste, matriz, chances);
                chances--;
                if (gambiarra == 1)
                {
                    cronometroGarrafas.Stop();
                    TimeSpan GarrafasInt = cronometroGarrafas.Elapsed;
                    int ResultTimeGarrafas = Convert.ToInt32(GarrafasInt.TotalSeconds);
                    Design.Escrita("Vozes do Além : Parabéns, você conseguiu concluir o game!!!");
                    continua = false;
                    if (jogador1.Ampulheta == true)
                    {
                        ResultTimeGarrafas -= 30;
                        Design.Escrita($"\nTempo: {ResultTimeGarrafas} segundosAAAAAA");

                    }
                    else
                    {
                        Design.Escrita($"\nTempo: {ResultTimeGarrafas} segundos");
                    }
                    int Bonus = 1;
                    if (jogador1.Estrela == true)
                    {
                        Bonus = 2;
                    }
                    if (ResultTimeGarrafas <= 60)
                    {
                        jogador1.Moedas += (10 * Bonus);
                        Design.Escrita("\nEstrelas: 3");
                        Design.Escrita("\nMoedas Ganhas : " + (10 * Bonus));
                    }
                    else if (ResultTimeGarrafas <= 120)
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
                    jogador1.Garrafas = true;
                    jogador1.JogosCompletos++;
                    return jogador1;
                }
                else if (gambiarra == 0)
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
                                jogador1.ChosenGame = 3;
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
                                    jogador1.ChosenGame = 3;
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
                                jogador1.ChosenGame = 3;
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

                resp1 = Convert.ToInt32(Console.ReadLine());
                resp2 = Convert.ToInt32(Console.ReadLine());
                valor1 = matriz[1, resp1 - 1];
                valor2 = matriz[1, resp2 - 1];
                matriz[1, resp1 - 1] = valor2;
                matriz[1, resp2 - 1] = valor1;
            }
            return jogador1;
        }
    }
}

using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Seletor
    {
        public static Jogador Escolher(Jogador jogador1)
        {

            Console.Clear();
            List<string> jogos = new List<string>();
            List<bool> jogoCompleto = new List<bool>();
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            jogoCompleto.Add(false);
            if (jogador1.PPT == false)
            {
                jogos.Add("Pedra Papel e Tesoura");
            }
            else
            {
                jogos.Add("Pedra Papel e Tesoura");
                jogoCompleto.Insert(0, true);

            }
            if (jogador1.Simon == false)
            {
                jogos.Add("Simon");
            }
            else
            {
                jogos.Add("Simon");
                jogoCompleto.Insert(1, true);

            }
            if (jogador1.Garrafas == false)
            {
                jogos.Add("Garrafas");
            }
            else
            {
                jogos.Add("Garrafas");
                jogoCompleto.Insert(2, true);

            }
            if (jogador1.Sudoku == false)
            {

            }
            else
            {
                jogos.Add("");
                jogoCompleto.Insert(3, true);

            }
            jogos.Add("Feira do Rolo");
            if (jogador1.Ticket == true)
            {
                jogos.Add("Tigrinho");
            }

            int li = 0, co = 0, ppl = 3, ppc = 0, cont = 0, cont2 = -1, co2 = 0, y = 0;
            bool continuar = false;
            while (continuar == false)
            {
                for (cont = 0; cont < jogos.Count * 3; cont++)
                {



                    for (co = 0 + co2; co < 50; co++)
                    {
                        if (co == ppc && li == ppl)
                        {
                            Console.Write("██");
                            co += 2;
                        }
                        Console.Write(" ");
                    }

                    if (li % 3 == 0)
                    {
                        cont2++;
                        Console.Write(jogos[cont2]);
                        if (jogoCompleto[cont2] == true)
                        {
                            Console.Write("  ( Jogo Completo )");
                        }
                    }

                    Console.WriteLine("");
                    li++;
                    co = 0;

                }

                Console.WriteLine("\n\n\n");
                char resp = Console.ReadKey().KeyChar;
                if (resp == 'a' && ppc > 0)
                {
                    ppc -= 1;
                }
                else if (resp == 'w' && ppl > 0)
                {
                    ppl -= 1;
                }
                else if (resp == 's' && ppl < (jogos.Count - 1) * 3)
                {
                    ppl += 1;
                }
                else if (resp == 'd' && ppc < 47)
                {
                    ppc += 1;
                }

                if (ppl == 0 && ppc == 47)
                {
                    if (jogador1.PPT == true)
                    {
                        Console.Clear();
                        Design.Escrita("Vozes do Além: Jogo completo, impossível de ser acessado, escolha outro");
                        Thread.Sleep(2000);
                        jogador1.ChosenGame = 0;
                    }
                    else
                    {
                        jogador1.ChosenGame = 1;
                        return jogador1;
                    }

                }
                else if (ppl == 3 && ppc == 47)
                {
                    if (jogador1.Simon == true)
                    {
                        Console.Clear();
                        Design.Escrita("Vozes do Além: Jogo completo, impossível de ser acessado, escolha outro");
                        Thread.Sleep(2000);
                        jogador1.ChosenGame = 0;
                        return jogador1;
                    }
                    else
                    {
                        jogador1.ChosenGame = 2;
                        return jogador1;
                    }
                }
                else if (ppl == 6 && ppc == 47)
                {
                    if (jogador1.Garrafas == true)
                    {
                        Console.Clear();
                        Design.Escrita("Vozes do Além: Jogo completo, impossível de ser acessado, escolha outro");
                        Thread.Sleep(2000);
                        jogador1.ChosenGame = 0;
                        return jogador1;
                    }
                    else
                    {
                        jogador1.ChosenGame = 3;
                        return jogador1;
                    }
                }
                else if (ppl == 9 && ppc == 47)
                {
                    jogador1.ChosenGame = 4;
                    return jogador1;
                }
                else if (ppl == 12 && ppc == 47)
                {
                    jogador1.ChosenGame = 5;
                    return jogador1;
                }
                else if (ppl == 15 && ppc == 47)
                {
                    jogador1.ChosenGame = 6;
                    return jogador1;
                }
                Console.Clear();
                cont2 = -1;
                li = 0;
            }
            return jogador1;
        }

    }
}

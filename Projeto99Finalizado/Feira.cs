using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Feira
    {
        public static Jogador Visitar(Jogador jogador1)
        {
            bool continuar = true;
            int lado = 100;
            char compra = '1';
            char sópraencherlinguica = Console.ReadKey().KeyChar;
            sópraencherlinguica = Console.ReadKey().KeyChar;
            sópraencherlinguica = Console.ReadKey().KeyChar;
            while (continuar == true)
            {
                if (lado % 2 == 0)
                {
                    Console.Clear();

                    Design.Feirante1();
                    Design.Escrita("Flávio: Tranquilo meu amigo? O que deseja?");
                    Console.WriteLine("\nSuas Moedas:" + jogador1.Moedas);
                    Console.WriteLine("\n\nClique ( 1 = Maçã ) ( 2 = Ampulheta ) ( 3 = Ticket ? ) para ver a descrição do objeto ou comprar!! Também pode clicar ( D = Loja à Direita), ( A = Loja à Esquerda) ou ( P = Sair da feira )");
                    char resp = Console.ReadKey().KeyChar; // descrição de produto
                    if (resp == '1')
                    {

                        Console.WriteLine("\n\nMaçã: Uma fruta ultra nutritiva feita para melhorar sua saúde. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Maçã == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Maçã = true;
                            jogador1.Vidas += 1;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }

                    }
                    else if (resp == '2')
                    {
                        Console.WriteLine("\n\nAmpulheta : Uma vez Flávio ficou tanto tempo sem respirar em baixo d'agua, que foram obrigados a criar algo para medir o tempo. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Ampulheta == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Ampulheta = true;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == '3')
                    {

                        Console.WriteLine("\n\nTicket ??? : ?? ??? ? ???? ?? ? ??? ?? . ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Ticket == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Ticket = true;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == 'a' || resp == 'A')
                    {
                        lado--;
                    }
                    else if (resp == 'd' || resp == 'D')
                    {
                        lado++;
                    }
                    else if (resp == 'p' || resp == 'P')
                    {
                        Console.Clear();
                        continuar = false;
                    }
                }
                else if ((lado - 1) % 2 == 0)
                {
                    Console.Clear();
                    Design.Feirante2();
                    Design.Escrita("Bianca: Olá, tudo bem? Desejas algo?");
                    Console.WriteLine("\nSuas Moedas:" + jogador1.Moedas);
                    Console.WriteLine("\n\nClique ( 1 = Trevo ) ( 2 = Escudo ) ( 3 = Estrela ) para ver a descrição do objeto ou comprar!! Também pode clicar ( D = Loja à Direita), ( A = Loja à Esquerda) ou ( P = Sair da feira )");
                    char resp = Console.ReadKey().KeyChar;
                    if (resp == '1')
                    {

                        Console.WriteLine("\n\nTrevo: A sorte. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Trevo == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Trevo = true;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == '2')
                    {
                        Console.WriteLine("\n\nEscudo : O melhor ataque as vezes é a defesa. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Escudo == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Escudo = true;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == '3')
                    {

                        Console.WriteLine("\n\nEstrela : Algum dizens que estrelas realizam desejos, mas acho que só as cadentes. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (jogador1.Estrela == true)
                        {
                            Design.Escrita("Item indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (jogador1.Moedas >= 5 & compra == '1')
                        {
                            jogador1.Moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + jogador1.Moedas);
                            Thread.Sleep(3000);
                            jogador1.Estrela = true;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == 'a' || resp == 'A')
                    {
                        lado--;
                    }
                    else if (resp == 'd' || resp == 'D')
                    {
                        lado++;
                    }
                    else if (resp == 'p' || resp == 'P')
                    {
                        Console.Clear();
                        continuar = false;
                    }
                }
            }
            return jogador1;
        }
    }
}

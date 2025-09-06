using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Tigrinho
    {
        public static Jogador Jogar(Jogador jogador1)
        {
            int aposta = (jogador1.Moedas - 1);
            Design.Escrita("Litle Tiger : Seja bem vindo a SchroederBet, unica casa de aposta do planeta que você não perde sua dignidade, só seu patrimonio...Você pode multiplicar suas moedas até 5x. deseja apostar quantas das suas moedas?\n(Obs: caso não queira apostar nada, digite 0. Seu ticket não será reembolsado.)\n\nMoedas:" + jogador1.Moedas + "\n\n");
            while (aposta > jogador1.Moedas)
            {
                aposta = Convert.ToInt32(Console.ReadLine());
                if (aposta > jogador1.Moedas || aposta < 0)
                {
                    Console.WriteLine("Valor inválido");
                }
                else if (aposta == 0)
                {
                    return jogador1;

                }
            }
            Console.WriteLine("Aposta feita (" + aposta + ")");
            Design.Escrita("Vamos la");
            Thread.Sleep(1000);
            Console.Clear();
            int resposta = Design.TigrinhoRoleta();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            if (jogador1.Trevo == false)
            {
                jogador1.Moedas += resposta * aposta;
                Design.Escrita($"Litle Tiger : Parabéns,você multiplicou suas moedas por: {resposta} e agora elas se tornaram {aposta * resposta} moedas.\n\nEspero que tenha gostado ");
                return jogador1;
            }
            else if (jogador1.Trevo == true)
            {
                jogador1.Moedas += (resposta + 2) * aposta;
                Design.Escrita($"Litle Tiger : Parabéns,você multiplicou suas moedas por: {resposta + 2} e agora elas se tornaram {aposta * (resposta + 2)} moedas.\n\nEspero que tenha gostado ");
                return jogador1;
            }
            return jogador1;

        }
    }
}

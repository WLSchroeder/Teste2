using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pokemon
    {
        public string Nome;
        public string Tipo;
        public string Fraqueza;
        public string Resistencia;
        public bool EstaComEfeito;
        public bool TipoEfeito;
        public int ValorEfeito;
        public int TempoEfeito;
        public int Vida;
        public int Defesa;
        public int Ataque1;
        public int EneAtaque1;
        public int ValorEfeitoBonus;
        public bool ParalisaOuDanifica;
        public int Ataque2;
        public int EneAtaque2;
        public bool Evolui;
        public string Evolucao;
        public int Nivel;
        /*public pokemon(string nome,string tipo,string fraqueza, string resistencia, int vida, bool ataque1, int eneataque1,int valorataque1,int valorataquebonus,int ataque2,int eneataque2, int enetotal, bool evolui, string evolucao)
        {
            Nome = nome;
            Tipo = tipo;
            Fraqueza = fraqueza;
            Resistencia = resistencia;
            Vida = vida;
            Ataque1 = ataque1;
            EneAtaque1 = eneataque1;
            ValorAtaque1 = valorataque1;
            ValorAtaqueBonus = valorataquebonus;
            Ataque2 = ataque2;
            EneTotal = enetotal;
            Evolui = evolui;
            Evolucao = evolucao;
        }*/



    }
    class Treinador
    {
        public string Nome;
        public List<Pokemon> PokemonsCapturadosIni = new List<Pokemon>();
        public List<Pokemon> PokemonsCapturadosInt = new List<Pokemon>();
        public List<Pokemon> PokemonsCapturadosAva = new List<Pokemon>();
        public List<Pokemon> PokemonsDerrotados = new List<Pokemon>();
        public int Energias = 0;
        public Pokemon PokemonAtivo;
        public Treinador(string n)
        {
            Nome = n;
        }
        public void CapturarPokemonIni(Pokemon selecionado)
        {
            PokemonsCapturadosIni.Add(selecionado);
        }
        public void CapturarPokemonInt(Pokemon selecionado)
        {
            PokemonsCapturadosInt.Add(selecionado);
        }
        public void CapturarPokemonAva(Pokemon selecionado)
        {
            PokemonsCapturadosAva.Add(selecionado);
        }
        public void Desmaiou(Pokemon selecionado)
        {
            PokemonsDerrotados.Add(selecionado);
        }
        public void Escolhe(Pokemon selecionado)
        {
            PokemonAtivo = selecionado;
        }
        public void RemoveIni(int a)
        {
            PokemonsCapturadosIni.RemoveAt(a);
        }
        public void RemoveInt(int a)
        {
            PokemonsCapturadosInt.RemoveAt(a);
        }
        public void RemoveAva(int a)
        {
            PokemonsCapturadosAva.RemoveAt(a);
        }
    }

    class Batalha
    {
        public static void VerificarPokemons(Pokemon p)
        {
            Design.Escrita($"\nNome: {p.Nome}");
            Design.Escrita($"\nTipo: {p.Tipo}");
            Design.Escrita($"\nHP: {p.Vida}");
            Design.Escrita($"\nFraqueza: {p.Fraqueza}");
            Design.Escrita($"\nResistencia: {p.Resistencia}");
            Design.Escrita($"\nAtaque1: {p.Ataque1}");
            Design.Escrita($"\nAtaque2: {p.Ataque2}");
            Design.Escrita($"\nCusto Ataque1: {p.EneAtaque1}");
            Design.Escrita($"\nCusto Ataque2: {p.EneAtaque2}");
            Design.Escrita($"\nDefesa: {p.Defesa}");
            if(p.Evolui==true)
            {
                Design.Escrita($"\nEvolui para : {p.Evolucao}");
            }

        }
        public static int QuemComeça(string nomePlayer, string Lagoas)
        {
            Random sorteio = new Random();
            int quemComeça = sorteio.Next(1, 3);
            if (quemComeça == 1)
            {
                Design.Escrita($"\n\nVozes do Além: {nomePlayer} começa atacando!");
                return 2;
            }
            else
            {
                Design.Escrita($"\n\nVozes do Além: {Lagoas} começa atacando!");
                return 3;
            }

        }
        public static bool CalculaDano1(Pokemon atacante, Pokemon defensor)
        {
            int dano =0;

            if (atacante.Tipo == defensor.Fraqueza)
            {
                dano += 10;
                Design.Escrita("\n\nÉ super efetivo!");
                Thread.Sleep(1000);
            }
            else if (atacante.Tipo == defensor.Resistencia)
            {
                dano -= 10;
                Design.Escrita("\n\nNão é muito efetivo...");
            }
            if (atacante.ParalisaOuDanifica == true)
            {
                if (atacante.Tipo == "Elétrico" || atacante.Tipo == "Psíquico")
                {
                    Random random = new Random();
                    int chance = random.Next(1, 4);
                    if (chance == 1)
                    {
                        Design.Escrita($"\n\n{atacante.Nome} está doidão por {defensor.TempoEfeito} rodadas e não pode atacar!");
                        defensor.TempoEfeito = 1;
                        defensor.EstaComEfeito = true;
                        defensor.TipoEfeito = true;
                    }
                }
                else
                {
                    Random random = new Random();
                    int chance = random.Next(1, 4);
                    if (chance == 1)
                    {

                        atacante.TempoEfeito = 1;
                        defensor.ValorEfeito = atacante.ValorEfeitoBonus;
                        defensor.EstaComEfeito = true;
                        defensor.TipoEfeito = false;
                        if (atacante.Tipo == defensor.Resistencia)
                        {
                            defensor.ValorEfeito -= 10;
                        }
                        Design.Escrita($"\n\n{defensor.Nome} está amaldiçoado por {defensor.TempoEfeito} rodadas e receberá {defensor.ValorEfeito} de dano extra!");
                    }
                }
            }
            dano += atacante.Ataque1 - (defensor.Defesa / 3);
            if (dano < 0)
            {
                dano = atacante.ValorEfeitoBonus;
                Design.Escrita($"\n\nA defesa do {defensor} anulou 100% o dano real");
                Design.Escrita($"\n\nHp do {defensor}: {defensor.Vida}");
                
            }
            else
            {
                Design.Escrita($"\n\nO dano total causado foi de {dano}");
                defensor.Vida -= dano;
                Design.Escrita($"\n\nHp do {defensor.Nome}: {defensor.Vida}");
            }
            
            if (defensor.Vida <= 0)
            {
                return true;
            }

            return false;

        }
        public static bool CalculaDano2(Pokemon atacante, Pokemon defensor)
        {
            int dano = 0;

            if (atacante.Tipo == defensor.Fraqueza)
            {
                dano += 10;
                Design.Escrita("\n\nÉ super efetivo!");
                Thread.Sleep(1000);
            }
            else if (atacante.Tipo == defensor.Resistencia)
            {
                dano -= 10;
                Design.Escrita("\n\nNão é muito efetivo...");
            }
            dano += atacante.Ataque2 - (defensor.Defesa / 3);
            if (dano < 0)
            {
                dano = atacante.ValorEfeitoBonus;
                Design.Escrita($"\n\nA defesa do {defensor} anulou 100% o dano real\n");
            }
            else
            {
                Design.Escrita($"\n\nO dano total causado foi de {dano}\n");
                defensor.Vida -= dano;
                Design.Escrita($"\n\nHp do {defensor.Nome}: {defensor.Vida}\n");
            }
            
            if (defensor.Vida <= 0)
            {
                return true;
            }

            return false;

        }


    }
    class EscolhasDeBatalha
    { 

    }




}

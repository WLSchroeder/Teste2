using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Jogador
    {
        public string Nome;
        public char Dificuldade; // altera a dificuldade dos jogos como quantidade de desafios, recompensas e etc
        public double Tempo;    // cronometra o tempo para ranking de desempenho
        public int Vidas;
        public int ChosenGame;
        public int JogosCompletos; // conta os jogos completos para ranking de desempenho
        public int Conquistas; // conta conquistas completas para ranking de desempenho
        public int Moedas = 0;  // usada para comércio do jogo
        public bool PPT = false;
        public bool Simon = false;
        public bool Garrafas = false;
        public bool Sudoku = false;
        public bool Maçã = false;     // aumenta 1 de hp
        public bool Ampulheta = false;  // reduz 30 segundos no cronometro de cada jogo na hora do calculo da recompensa
        public bool Ticket = false;   // libera a casa de aposta ( Tigrinho )
        public bool Trevo = false;   // aumenta as odds do tigrinho
        public bool Escudo = false;  // libera a chance de 25% de não perder uma vida ao perder algum jogo
        public bool Estrela = false; // aumenta a % de recompensa de moedas
        /*public Stopwatch cronometroGeral = new Stopwatch();
        public Stopwatch cronometroPPT = new Stopwatch();
        public Stopwatch cronometroSimon = new Stopwatch();
        public Stopwatch cronometroGarrafas = new Stopwatch();
        public Stopwatch cronometroSudoku = new Stopwatch();*/


        public Jogador(string n, char d, int v)
        {
            Nome = n;
            Dificuldade = d;
            Vidas = v;

        }

    }
}

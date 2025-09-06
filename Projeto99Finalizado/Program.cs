using ConsoleApp5;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Media;
using System.Drawing;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;
using System;

//Coisas que faltam fazer
//bug tempo 0 segundos garrafas( se eu depurar funciona ), desenho não apaga todo, backtracking no garrafas
int vida = 3;
char Dificuldade = 'a';
string Nick = "slça";
bool Jogo = true, dificul = false, batalha = false;
Console.Write("Favela venceu 2");
Design.TelaInicial();
Design.Loading();
Console.Clear();

//Início

Console.CursorVisible = false;
Stopwatch cronometroGeral = new Stopwatch();
cronometroGeral.Start();
Design.Escrita("Vozes do Além: Após você abrir o site do Lagoas, baixar e executar um arquivo para estudar Classes e Objetos, um Malware foi instalado em seu computador e você foi abduzido para dentro da máquina em seu mundo virtual.\n\nVocê terá a chance de se mostrar capaz da liberdade!!\n\nLute por sua sobrevivência!!\n Boa sorte!!");
Thread.Sleep(5000);
Console.Clear();
Design.Loading();
Console.Clear();
Design.img1();
Thread.Sleep(1000);
Design.Escrita("\n\nMalware : Olá mero mortal. Você entrou no meu domínio... agora prove que merece sair vivo. Você terá que passar por diversos jogos onde será testado a todo momento seu raciocínio, sua sorte e suas habilidades.\n\nMas primeiro, me diga algumas informações:");
Thread.Sleep(1000);
Console.WriteLine("\n\nNick:");
Nick = Console.ReadLine();
while (dificul == false)
{
    Console.WriteLine("\nDificuldade: ( 1 = Fácil ) ( 2 = Média ) ( 3 = Difícil )");
    Dificuldade = Console.ReadKey().KeyChar;

    if (Dificuldade == '1')
    {

        vida = 3;
        dificul = true;
    }
    else if (Dificuldade == '2')
    {
        vida = 2;
        dificul = true;
    }
    else if (Dificuldade == '3')
    {
        vida = 1;
        dificul = true;
    }
    else
    {
        Console.WriteLine("Valor inválido");
        Thread.Sleep(2000);
        Console.Clear();
        dificul = false;
    }
}
Jogador jogador1 = new Jogador(Nick, Dificuldade, vida);
Console.WriteLine("\n\nAHAHAHAHA, Seja bem vindo");
Thread.Sleep(1000);
Console.Clear();
Design.Loading();
jogador1 = Seletor.Escolher(jogador1);
Console.Clear();

//Jogos

while (jogador1.JogosCompletos < 3)
{
    if (jogador1.ChosenGame == -1 || jogador1.Vidas <= 0)
    {
        break;
    }
    else if (jogador1.ChosenGame == 0)
    {
        Design.Loading();
        jogador1 = Seletor.Escolher(jogador1);
    }
    else if (jogador1.ChosenGame == 1)
    {
        Console.Clear();
        Design.Loading();
        Console.Clear();
        jogador1 = PPT.Jogar(jogador1);
        Console.Clear();

    }
    else if (jogador1.ChosenGame == 2)
    {
        Console.Clear();
        Design.Loading();
        Console.Clear();
        jogador1 = Simon.Jogar(jogador1);
        Console.Clear();

    }
    else if (jogador1.ChosenGame == 3)
    {
        Console.Clear();
        Design.Loading();
        Console.Clear();
        jogador1 = Garrafas.Jogar(jogador1);
        Console.Clear();
        
    }
    else if (jogador1.ChosenGame == 4)
    {
        Console.Clear();
        Design.Loading();
        Console.Clear();
        jogador1 = Feira.Visitar(jogador1);
        Console.Clear();
        jogador1.ChosenGame = 0;

    }
    else if (jogador1.ChosenGame == 5)
    {
        Console.Clear();
        jogador1 = Tigrinho.Jogar(jogador1);
        Console.Clear();
        jogador1.ChosenGame = 0;
    }
}

//Final

Console.Clear();
Design.Loading();
Design.img1();
Design.Escrita("\n\nMalware : Quem é vivo, sempre aparece, parabéns por passar pelo os meus desafios, porem não pense que será tão fácil de escapar, como último teste, EU TE DESAFIO PARA UMA BATALHA POKEMONNN!!!!");
Design.Escrita("\nEspero que tenha economizado moedas mero ser infeliz, pois vai precisar, vá ate a loja da Bianca e se prepare!!");
Thread.Sleep(5000);
Design.Loading();





Treinador Player = new Treinador(jogador1.Nome);
Treinador Lagoas = new Treinador("Lagoas");


List<Pokemon> Pokemons = new List<Pokemon>();
List<Pokemon> Pokemons2 = new List<Pokemon>();
List<Pokemon> Pokemons3 = new List<Pokemon>();
List<Pokemon> PokemonsLagoas = new List<Pokemon>();

Pokemon Bulbasaur = new Pokemon(); Bulbasaur.Nome = "Bulbasaur"; Bulbasaur.Tipo = "Planta"; Bulbasaur.Fraqueza = "Fogo"; Bulbasaur.Resistencia = "Água"; Bulbasaur.EstaComEfeito = false; Bulbasaur.TipoEfeito =false;Bulbasaur.ValorEfeito = 0; Bulbasaur.TempoEfeito = 0; Bulbasaur.Vida = 45; Bulbasaur.Defesa = 49; Bulbasaur.Ataque1 = 49; Bulbasaur.EneAtaque1 = 2; Bulbasaur.ValorEfeitoBonus = 10; Bulbasaur.ParalisaOuDanifica = false; Bulbasaur.Ataque2 = 24; Bulbasaur.EneAtaque2 = 1; Bulbasaur.Evolui = true; Bulbasaur.Evolucao = "Ivysaur"; Bulbasaur.Nivel = 1;
Pokemons.Add(Bulbasaur);    
Pokemon Charmander = new Pokemon(); Charmander.Nome = "Charmander"; Charmander.Tipo = "Fogo"; Charmander.Fraqueza = "Água"; Charmander.Resistencia = "Planta"; Charmander.EstaComEfeito = false; Charmander.TipoEfeito = false;Charmander.ValorEfeito = 0;Charmander.TempoEfeito = 0; Charmander.Vida = 39; Charmander.Defesa = 43; Charmander.Ataque1 = 52; Charmander.EneAtaque1 = 2; Charmander.ValorEfeitoBonus = 10; Charmander.ParalisaOuDanifica = false; Charmander.Ataque2 = 26; Charmander.EneAtaque2 = 1; Charmander.Evolui = true; Charmander.Evolucao = "Charmeleon"; Charmander.Nivel = 1;
Pokemons.Add(Charmander);
Pokemon Squirtle = new Pokemon(); Squirtle.Nome = "Squirtle"; Squirtle.Tipo = "Água"; Squirtle.Fraqueza = "Planta"; Squirtle.Resistencia = "Fogo"; Squirtle.EstaComEfeito = false; Squirtle.TipoEfeito = false;Squirtle.ValorEfeito = 0;Squirtle.TempoEfeito = 0; Squirtle.Vida = 44; Squirtle.Defesa = 65; Squirtle.Ataque1 = 48; Squirtle.EneAtaque1 = 2;Squirtle.ValorEfeitoBonus = 0; Squirtle.ParalisaOuDanifica = false; Squirtle.Ataque2 = 24; Squirtle.EneAtaque2 = 1; Squirtle.Evolui = true; Squirtle.Evolucao = "Wartortle"; Squirtle.Nivel = 1;
Pokemons.Add(Squirtle);
Pokemon Pidgey = new Pokemon(); Pidgey.Nome = "Pidgey"; Pidgey.Tipo = "Normal"; Pidgey.Fraqueza = "Elétrico"; Pidgey.Resistencia = "Planta"; Pidgey.EstaComEfeito = false; Pidgey.TipoEfeito = false; Pidgey.ValorEfeito = 0;Pidgey.TempoEfeito = 0; Pidgey.Vida = 40; Pidgey.Defesa = 40; Pidgey.Ataque1 = 45; Pidgey.EneAtaque1 = 2; Pidgey.ValorEfeitoBonus = 0; Pidgey.ParalisaOuDanifica = false; Pidgey.Ataque2 = 23; Pidgey.EneAtaque2 = 1; Pidgey.Evolui = true; Pidgey.Evolucao = "Pidgeotto";Pidgey.Nivel = 1;
Pokemons.Add(Pidgey);
Pokemon Rattata = new Pokemon(); Rattata.Nome = "Rattata"; Rattata.Tipo = "Normal"; Rattata.Fraqueza = "Lutador"; Rattata.Resistencia = "Nenhuma"; Rattata.EstaComEfeito = false; Rattata.TipoEfeito = false; Rattata.ValorEfeito = 0;Rattata.TempoEfeito = 0; Rattata.Vida = 30; Rattata.Defesa = 35; Rattata.Ataque1 = 56; Rattata.EneAtaque1 = 2; Rattata.ValorEfeitoBonus = 0; Rattata.ParalisaOuDanifica = false; Rattata.Ataque2 = 28; Rattata.EneAtaque2 = 1; Rattata.Evolui = true; Rattata.Evolucao = "Raticate"; Rattata.Nivel = 1;
Pokemons.Add(Rattata);
Pokemon Pikachu = new Pokemon(); Pikachu.Nome = "Pikachu"; Pikachu.Tipo = "Elétrico"; Pikachu.Fraqueza = "Nenhuma"; Pikachu.Resistencia = "Elétrico"; Pikachu.EstaComEfeito = false; Pikachu.TipoEfeito = false;Pikachu.ValorEfeito = 0;Pikachu.TempoEfeito = 0; Pikachu.Vida = 35; Pikachu.Defesa = 40; Pikachu.Ataque1 = 55; Pikachu.EneAtaque1 = 2; Pikachu.ValorEfeitoBonus = 0; Pikachu.ParalisaOuDanifica = true; Pikachu.Ataque2 = 30; Pikachu.EneAtaque2 = 1; Pikachu.Evolui = true; Pikachu.Evolucao = "Raichu"; Pikachu.Nivel = 1;
Pokemons.Add(Pikachu);
Pokemon Zubat = new Pokemon(); Zubat.Nome = "Zubat"; Zubat.Tipo = "Venenoso"; Zubat.Fraqueza = "Elétrico"; Zubat.Resistencia = "Planta"; Zubat.EstaComEfeito = false; Zubat.TipoEfeito = false;Zubat.ValorEfeito = 0;Zubat.TempoEfeito = 0; Zubat.Vida = 40; Zubat.Defesa = 35; Zubat.Ataque1 = 45; Zubat.EneAtaque1 = 2; Zubat.ValorEfeitoBonus = 10; Zubat.ParalisaOuDanifica = false; Zubat.Ataque2 = 23; Zubat.EneAtaque2 = 1; Zubat.Evolui = true; Zubat.Evolucao = "Golbat"; Zubat.Nivel = 1;
Pokemons.Add(Zubat);
Pokemon Mankey = new Pokemon(); Mankey.Nome = "Mankey"; Mankey.Tipo = "Lutador"; Mankey.Fraqueza = "Psíquico"; Mankey.Resistencia = "Nenhuma"; Mankey.EstaComEfeito = false; Mankey.TipoEfeito = false;Mankey.ValorEfeito = 0;Mankey.TempoEfeito = 0; Mankey.Vida = 40; Mankey.Defesa = 35; Mankey.Ataque1 = 80; Mankey.EneAtaque1 = 2; Mankey.ValorEfeitoBonus = 0; Mankey.ParalisaOuDanifica = false; Mankey.Ataque2 = 40; Mankey.EneAtaque2 = 1; Mankey.Evolui = true; Mankey.Evolucao = "Primeape";Mankey.Nivel = 1;
Pokemons.Add(Mankey);
Pokemon Abra = new Pokemon(); Abra.Nome = "Abra"; Abra.Tipo = "Psíquico"; Abra.Fraqueza = "Nenhuma"; Abra.Resistencia = "Lutador"; Abra.EstaComEfeito = false; Abra.TipoEfeito = false;Abra.ValorEfeito = 0;Abra.TempoEfeito = 0; Abra.Vida = 25; Abra.Defesa = 15; Abra.Ataque1 = 20; Abra.EneAtaque1 = 2; Abra.ValorEfeitoBonus = 0; Abra.ParalisaOuDanifica = true; Abra.Ataque2 = 10; Abra.EneAtaque2 = 1; Abra.Evolui = true; Abra.Evolucao = "Kadabra";Abra.Nivel = 1;
Pokemons.Add(Abra);
Pokemon Machop = new Pokemon(); Machop.Nome = "Machop"; Machop.Tipo = "Lutador"; Machop.Fraqueza = "Psíquico"; Machop.Resistencia = "Nenhuma"; Machop.EstaComEfeito = false; Machop.TipoEfeito = false; Machop.ValorEfeito = 0;Machop.TempoEfeito = 0; Machop.Vida = 70; Machop.Defesa = 50; Machop.Ataque1 = 80; Machop.EneAtaque1 = 2; Machop.ValorEfeitoBonus = 0; Machop.ParalisaOuDanifica = false; Machop.Ataque2 = 40; Machop.EneAtaque2 = 1; Machop.Evolui = true; Machop.Evolucao = "Machoke";Machop.Nivel = 1;
Pokemons.Add(Machop);
Pokemon Fennekin = new Pokemon(); Fennekin.Nome = "Fennekin"; Fennekin.Tipo = "Fogo"; Fennekin.Fraqueza = "Água"; Fennekin.Resistencia = "Planta"; Fennekin.EstaComEfeito = false; Fennekin.TipoEfeito = false;Fennekin.ValorEfeito = 0;Fennekin.TempoEfeito = 0; Fennekin.Vida = 40; Fennekin.Defesa = 43; Fennekin.Ataque1 = 45; Fennekin.EneAtaque1 = 2; Fennekin.ValorEfeitoBonus = 15; Fennekin.ParalisaOuDanifica = false; Fennekin.Ataque2 = 23; Fennekin.EneAtaque2 = 1; Fennekin.Evolui = true; Fennekin.Evolucao = "Braixen";Fennekin.Nivel = 1;
Pokemons.Add(Fennekin);
Pokemon Turtwig = new Pokemon(); Turtwig.Nome = "Turtwig"; Turtwig.Tipo = "Planta"; Turtwig.Fraqueza = "Fogo"; Turtwig.Resistencia = "Água"; Turtwig.EstaComEfeito = false; Turtwig.TipoEfeito = false; Turtwig.ValorEfeito = 0; Turtwig.TempoEfeito = 0; Turtwig.Vida = 55; Turtwig.Defesa = 64; Turtwig.Ataque1 = 68; Turtwig.EneAtaque1 = 2; Turtwig.ValorEfeitoBonus = 0; Turtwig.ParalisaOuDanifica = false; Turtwig.Ataque2 = 34; Turtwig.EneAtaque2 = 1; Turtwig.Evolui = true; Turtwig.Evolucao = "Grotle";Turtwig.Nivel = 1;
Pokemons.Add(Turtwig);

// Segundo pacote

Pokemon Ivysaur = new Pokemon(); Ivysaur.Nome = "Ivysaur"; Ivysaur.Tipo = "Planta"; Ivysaur.Fraqueza = "Fogo"; Ivysaur.Resistencia = "Água"; Ivysaur.EstaComEfeito = false; Ivysaur.TipoEfeito = false;Ivysaur.ValorEfeito = 0;Ivysaur.TempoEfeito = 0; Ivysaur.Vida = 60; Ivysaur.Defesa = 63; Ivysaur.Ataque1 = 62; Ivysaur.EneAtaque1 = 2; Ivysaur.ValorEfeitoBonus = 15; Ivysaur.ParalisaOuDanifica = false; Ivysaur.Ataque2 = 31; Ivysaur.EneAtaque2 = 1; Ivysaur.Evolui = true; Ivysaur.Evolucao = "Venusaur";Ivysaur.Nivel = 2;
Pokemons2.Add(Ivysaur);
Pokemon Charmeleon = new Pokemon(); Charmeleon.Nome = "Charmeleon"; Charmeleon.Tipo = "Fogo"; Charmeleon.Fraqueza = "Água"; Charmeleon.Resistencia = "Planta"; Charmeleon.EstaComEfeito = false; Charmeleon.TipoEfeito = false;Charmeleon.ValorEfeito = 0;Charmeleon.TempoEfeito = 0; Charmeleon.Vida = 58; Charmeleon.Defesa = 58; Charmeleon.Ataque1 = 64; Charmeleon.EneAtaque1 = 2; Charmeleon.ValorEfeitoBonus = 15; Charmeleon.ParalisaOuDanifica = false; Charmeleon.Ataque2 = 31; Charmeleon.EneAtaque2 = 1; Charmeleon.Evolui = true; Charmeleon.Evolucao = "Charizard";Charmeleon.Nivel = 2;
Pokemons2.Add(Charmeleon);
Pokemon Wartortle = new Pokemon(); Wartortle.Nome = "Wartortle"; Wartortle.Tipo = "Água"; Wartortle.Fraqueza = "Planta"; Wartortle.Resistencia = "Fogo"; Wartortle.EstaComEfeito = false; Wartortle.TipoEfeito = false;Wartortle.ValorEfeito = 0;Wartortle.TempoEfeito = 0; Wartortle.Vida = 59; Wartortle.Defesa = 85; Wartortle.Ataque1 = 63; Wartortle.EneAtaque1 = 2; Wartortle.ValorEfeitoBonus = 0; Wartortle.ParalisaOuDanifica = false; Wartortle.Ataque2 = 31; Wartortle.EneAtaque2 = 1; Wartortle.Evolui = true; Wartortle.Evolucao = "Blastoise";Wartortle.Nivel = 2;
Pokemons2.Add(Wartortle);
Pokemon Pidgeotto = new Pokemon(); Pidgeotto.Nome = "Pidgeotto"; Pidgeotto.Tipo = "Normal"; Pidgeotto.Fraqueza = "Elétrico"; Pidgeotto.Resistencia = "Planta"; Pidgeotto.EstaComEfeito = false; Pidgeotto.TipoEfeito = false;Pidgeotto.ValorEfeito = 0;Pidgeotto.TempoEfeito = 0; Pidgeotto.Vida = 63; Pidgeotto.Defesa = 59; Pidgeotto.Ataque1 = 63; Pidgeotto.EneAtaque1 = 2; Pidgeotto.ValorEfeitoBonus = 0; Pidgeotto.ParalisaOuDanifica = false; Pidgeotto.Ataque2 = 23; Pidgeotto.EneAtaque2 = 1; Pidgeotto.Evolui = true; Pidgeotto.Evolucao = "Pidgeot";Pidgeotto.Nivel = 2;
Pokemons2.Add(Pidgeotto);
Pokemon Raticate = new Pokemon(); Raticate.Nome = "Raticate"; Raticate.Tipo = "Normal"; Raticate.Fraqueza = "Lutador"; Raticate.Resistencia = "Nenhuma"; Raticate.EstaComEfeito = false; Raticate.TipoEfeito = false;Raticate.ValorEfeito = 0;Raticate.TempoEfeito = 0; Raticate.Vida =55; Raticate.Defesa = 60; Raticate.Ataque1 = 81; Raticate.EneAtaque1 = 2; Raticate.ValorEfeitoBonus = 0; Raticate.ParalisaOuDanifica = true; Raticate.Ataque2 = 41; Raticate.EneAtaque2 = 1;  Raticate.Evolui = false;Raticate.Nivel = 2;
Pokemons2.Add(Raticate);
Pokemon Raichu = new Pokemon(); Raichu.Nome = "Raichu"; Raichu.Tipo = "Elétrico"; Raichu.Fraqueza = "Nenhuma"; Raichu.Resistencia = "Elétrico"; Raichu.EstaComEfeito = false; Raichu.TipoEfeito = false; Raichu.ValorEfeito = 0;Raichu.TempoEfeito = 0; Raichu.Vida = 60; Raichu.Defesa = 55; Raichu.Ataque1 = 90; Raichu.EneAtaque1 = 2; Raichu.ValorEfeitoBonus = 0; Raichu.ParalisaOuDanifica = true; Raichu.Ataque2 = 45; Raichu.EneAtaque2 = 1; Raichu.Evolui = false;Raichu.Nivel = 2;
Pokemons2.Add(Raichu);
Pokemon Golbat = new Pokemon(); Golbat.Nome = "Golbat"; Golbat.Tipo = "Venenoso"; Golbat.Fraqueza = "Elétrico"; Golbat.Resistencia = "Planta"; Golbat.EstaComEfeito = false; Golbat.TipoEfeito = false;Golbat.ValorEfeito = 0; Golbat.TempoEfeito = 0; Golbat.Vida = 75; Golbat.Defesa = 70; Golbat.Ataque1 = 80; Golbat.EneAtaque1 = 2; Golbat.ValorEfeitoBonus = 15; Golbat.ParalisaOuDanifica = false; Golbat.Ataque2 = 40; Golbat.EneAtaque2 = 1; Golbat.Evolui = false; Golbat.Nivel = 2;
Pokemons2.Add(Golbat);
Pokemon Primeape = new Pokemon(); Primeape.Nome = "Primeape"; Primeape.Tipo = "Lutador"; Primeape.Fraqueza = "Psíquico"; Primeape.Resistencia = "Nenhuma"; Primeape.EstaComEfeito = false; Primeape.TipoEfeito = false;Primeape.ValorEfeito = 0;Primeape.TempoEfeito = 0; Primeape.Vida = 65; Primeape.Defesa = 60; Primeape.Ataque1 = 105; Primeape.EneAtaque1 = 2; Primeape.ValorEfeitoBonus = 0; Primeape.ParalisaOuDanifica = false; Primeape.Ataque2 = 53; Primeape.EneAtaque2 = 1; Primeape.Evolui = false;Primeape.Nivel = 2;
Pokemons2.Add(Primeape);
Pokemon Kadabra = new Pokemon(); Kadabra.Nome = "Kadabra"; Kadabra.Tipo = "Psíquico"; Kadabra.Fraqueza = "Nenhuma"; Kadabra.Resistencia = "Lutador"; Kadabra.EstaComEfeito = false; Kadabra.TipoEfeito = false;Kadabra.ValorEfeito = 0;Kadabra.TempoEfeito = 0; Kadabra.Vida = 40; Kadabra.Defesa = 30; Kadabra.Ataque1 = 35; Kadabra.EneAtaque1 = 2; Kadabra.ValorEfeitoBonus = 0; Kadabra.ParalisaOuDanifica = true; Kadabra.Ataque2 = 18; Kadabra.EneAtaque2 = 1; Kadabra.Evolui = true; Kadabra.Evolucao = "Alakazam";Kadabra.Nivel = 2;
Pokemons2.Add(Kadabra);
Pokemon Machoke = new Pokemon(); Machoke.Nome = "Machoke"; Machoke.Tipo = "Lutador"; Machoke.Fraqueza = "Psíquico"; Machoke.Resistencia = "Nenhuma"; Machoke.EstaComEfeito = false; Machoke.TipoEfeito = false;Machoke.ValorEfeito = 0; Machoke.TempoEfeito = 0; Machoke.Vida = 70; Machoke.Defesa = 50; Machoke.Ataque1 = 80; Machoke.EneAtaque1 = 2; Machoke.ValorEfeitoBonus = 0; Machoke.ParalisaOuDanifica = false; Machoke.Ataque2 = 40; Machoke.EneAtaque2 = 1; Machoke.Evolui = true; Machoke.Evolucao = "Machoke";Machoke.Nivel = 2;
Pokemons2.Add(Machoke);
Pokemon Braixen = new Pokemon(); Braixen.Nome = "Braixen"; Braixen.Tipo = "Fogo"; Braixen.Fraqueza = "Água"; Braixen.Resistencia = "Planta"; Braixen.EstaComEfeito = false; Braixen.TipoEfeito = false;Braixen.ValorEfeito = 0; Braixen.TempoEfeito = 0; Braixen.Vida = 59; Braixen.Defesa = 58; Braixen.Ataque1 = 59; Braixen.EneAtaque1 = 2; Braixen.ValorEfeitoBonus = 20; Braixen.ParalisaOuDanifica = false; Braixen.Ataque2 = 30; Braixen.EneAtaque2 = 1; Braixen.Evolui = true; Braixen.Evolucao = "Delphox";Braixen.Nivel = 2;
Pokemons2.Add(Braixen);
Pokemon Grotle = new Pokemon(); Grotle.Nome = "Grotle"; Grotle.Tipo = "Planta"; Grotle.Fraqueza = "Fogo"; Grotle.Resistencia = "Água"; Grotle.EstaComEfeito = false; Grotle.TipoEfeito = false; Grotle.ValorEfeito = 0; Grotle.TempoEfeito = 0; Grotle.Vida = 75; Grotle.Defesa = 85; Grotle.Ataque1 = 89; Grotle.EneAtaque1 = 2; Grotle.ValorEfeitoBonus = 0; Grotle.ParalisaOuDanifica = false; Grotle.Ataque2 = 45; Grotle.EneAtaque2 = 1; Grotle.Evolui = true; Grotle.Evolucao = "Torterra";Grotle.Nivel = 2;
Pokemons2.Add(Grotle);

// Terceiro pacote

Pokemon Venusaur = new Pokemon(); Venusaur.Nome = "Venusaur"; Venusaur.Tipo = "Planta"; Venusaur.Fraqueza = "Fogo"; Venusaur.Resistencia = "Água"; Venusaur.EstaComEfeito = false; Venusaur.TipoEfeito = false;Venusaur.ValorEfeito = 0;Venusaur.TempoEfeito = 0; Venusaur.Vida = 80; Venusaur.Defesa = 83; Venusaur.Ataque1 = 82; Venusaur.EneAtaque1 = 3; Venusaur.ValorEfeitoBonus = 30; Venusaur.ParalisaOuDanifica = true; Venusaur.Ataque2 = 41; Venusaur.EneAtaque2 = 1; Venusaur.Evolui = false;Venusaur.Nivel = 3;
Pokemons3.Add(Venusaur);
Pokemon Charizard = new Pokemon(); Charizard.Nome = "Charizard"; Charizard.Tipo = "Fogo"; Charizard.Fraqueza = "Água"; Charizard.Resistencia = "Planta"; Charizard.EstaComEfeito = false; Charizard.TipoEfeito = false;Charizard.ValorEfeito = 0; Charizard.TempoEfeito = 0; Charizard.Vida = 78; Charizard.Defesa = 78; Charizard.Ataque1 = 84; Charizard.EneAtaque1 = 2; Charizard.ValorEfeitoBonus = 30; Charizard.ParalisaOuDanifica = false; Charizard.Ataque2 = 42; Charizard.EneAtaque2 = 1; Charizard.Evolui = false;Charizard.Nivel = 3;
Pokemons3.Add(Charizard);
Pokemon Blastoise = new Pokemon(); Blastoise.Nome = "Blastoise"; Blastoise.Tipo = "Água"; Blastoise.Fraqueza = "Planta"; Blastoise.Resistencia = "Fogo"; Blastoise.EstaComEfeito = false; Blastoise.TipoEfeito = false;Blastoise.ValorEfeito = 0;Blastoise.TempoEfeito = 0; Blastoise.Vida =79; Blastoise.Defesa = 100; Blastoise.Ataque1 = 83; Blastoise.EneAtaque1 = 2; Blastoise.ValorEfeitoBonus = 0; Blastoise.ParalisaOuDanifica = false; Blastoise.Ataque2 =42; Blastoise.EneAtaque2 = 1; Blastoise.Evolui = false; Blastoise.Nivel = 3;
Pokemons3.Add(Blastoise);
Pokemon Pidgeot = new Pokemon(); Pidgeot.Nome = "Pidgeot"; Pidgeot.Tipo = "Normal"; Pidgeot.Fraqueza = "Elétrico"; Pidgeot.Resistencia = "Planta"; Pidgeot.EstaComEfeito = false; Pidgeot.TipoEfeito = false;Pidgeot.ValorEfeito = 0;Pidgeot.TempoEfeito = 0; Pidgeot.Vida = 83; Pidgeot.Defesa =75; Pidgeot.Ataque1 = 80; Pidgeot.EneAtaque1 = 2; Pidgeot.ValorEfeitoBonus = 0; Pidgeot.ParalisaOuDanifica = false; Pidgeot.Ataque2 = 40; Pidgeot.EneAtaque2 = 1; Pidgeot.Evolui = false;Pidgeot.Nivel = 3;
Pokemons3.Add(Pidgeot);
Pokemon Alakazam = new Pokemon(); Alakazam.Nome = "Alakazam"; Alakazam.Tipo = "Psíquico"; Alakazam.Fraqueza = "Nenhuma"; Alakazam.Resistencia = "Lutador"; Alakazam.EstaComEfeito = false; Alakazam.TipoEfeito = false;Alakazam.ValorEfeito = 0;Alakazam.TempoEfeito = 0; Alakazam.Vida = 55; Alakazam.Defesa = 45; Alakazam.Ataque1 = 50; Alakazam.EneAtaque1 = 2; Alakazam.ValorEfeitoBonus = 0; Alakazam.ParalisaOuDanifica = true; Alakazam.Ataque2 = 25; Alakazam.EneAtaque2 = 1; Alakazam.Evolui = false; Alakazam.Nivel = 3;
Pokemons3.Add(Alakazam);
Pokemon Machamp = new Pokemon(); Machamp.Nome = "Machamp"; Machamp.Tipo = "Lutador"; Machamp.Fraqueza = "Psíquico"; Machamp.Resistencia = "Nenhuma"; Machamp.EstaComEfeito = false; Machamp.TipoEfeito = false; Machamp.ValorEfeito = 0; Machamp.TempoEfeito = 0; Machamp.Vida = 90; Machamp.Defesa = 80; Machamp.Ataque1 = 130; Machamp.EneAtaque1 = 2; Machamp.ValorEfeitoBonus = 0; Machamp.ParalisaOuDanifica = false; Machamp.Ataque2 = 65; Machamp.EneAtaque2 = 1; Machamp.Evolui = false;Machamp.Nivel = 3;
Pokemons3.Add(Machamp);
Pokemon Delphox = new Pokemon(); Delphox.Nome = "Delphox"; Delphox.Tipo = "Fogo"; Delphox.Fraqueza = "Água"; Delphox.Resistencia = "Planta"; Delphox.EstaComEfeito = false; Delphox.TipoEfeito = false; Delphox.ValorEfeito = 0; Delphox.TempoEfeito = 0; Delphox.Vida = 75; Delphox.Defesa = 72; Delphox.Ataque1 = 69; Delphox.EneAtaque1 = 2; Delphox.ValorEfeitoBonus = 35; Delphox.ParalisaOuDanifica = false; Delphox.Ataque2 = 40; Delphox.EneAtaque2 = 1; Delphox.Evolui = false;Delphox.Nivel = 3;
Pokemons3.Add(Delphox);
Pokemon Torterra = new Pokemon(); Torterra.Nome = "Torterra"; Torterra.Tipo = "Planta"; Torterra.Fraqueza = "Fogo"; Torterra.Resistencia = "Elétrico"; Torterra.EstaComEfeito = false; Torterra.TipoEfeito = false; Torterra.ValorEfeito = 0; Torterra.TempoEfeito = 0; Torterra.Vida = 95; Torterra.Defesa =105; Torterra.Ataque1 = 109; Torterra.EneAtaque1 = 2; Torterra.ValorEfeitoBonus = 0; Torterra.ParalisaOuDanifica = false; Torterra.Ataque2 = 55; Torterra.EneAtaque2 = 1; Torterra.Evolui = false; Torterra.Nivel = 3;
Pokemons3.Add(Torterra);

// Pokemons do João

Pokemon Mewtwo = new Pokemon(); Mewtwo.Nome = "Mewtwo"; Mewtwo.Tipo = "Psíquico"; Mewtwo.Fraqueza = "Nenhuma"; Mewtwo.Resistencia = "Psíquico"; Mewtwo.EstaComEfeito = false; Mewtwo.TipoEfeito = false; Mewtwo.ValorEfeito = 0; Mewtwo.TempoEfeito = 0; Mewtwo.Vida = 106; Mewtwo.Defesa = 90; Mewtwo.Ataque1 = 110; Mewtwo.EneAtaque1 = 2; Mewtwo.ValorEfeitoBonus = 0; Mewtwo.ParalisaOuDanifica = true; Mewtwo.Ataque2 = 55; Mewtwo.EneAtaque2 = 1; Mewtwo.Evolui = false;
PokemonsLagoas.Add(Mewtwo);
Pokemon Raikou = new Pokemon(); Raikou.Nome = "Raikou"; Raikou.Tipo = "Elétrico"; Raikou.Fraqueza = "Nenhuma"; Raikou.Resistencia = "Elétrico"; Raikou.EstaComEfeito = false; Raikou.TipoEfeito = false; Raikou.ValorEfeito = 0; Raikou.TempoEfeito = 0; Raikou.Vida = 90; Raikou.Defesa = 75; Raikou.Ataque1 = 85; Raikou.EneAtaque1 = 2; Raikou.ValorEfeitoBonus = 20; Raikou.ParalisaOuDanifica = true; Raikou.Ataque2 = 45; Raikou.EneAtaque2 = 1; Raikou.Evolui = false;
PokemonsLagoas.Add(Raikou);
Pokemon Entei = new Pokemon(); Entei.Nome = "Entei"; Entei.Tipo = "Fogo"; Entei.Fraqueza = "Água"; Entei.Resistencia = "Planta"; Entei.EstaComEfeito = false; Entei.TipoEfeito = false; Entei.ValorEfeito = 0; Entei.TempoEfeito = 0; Entei.Vida = 115; Entei.Defesa = 85; Entei.Ataque1 = 115; Entei.EneAtaque1 = 2; Entei.ValorEfeitoBonus = 30; Entei.ParalisaOuDanifica = false; Entei.Ataque2 = 60; Entei.EneAtaque2 = 1; Entei.Evolui = false;
PokemonsLagoas.Add(Entei);
Pokemon Suicune = new Pokemon(); Suicune.Nome = "Suicune"; Suicune.Tipo = "Água"; Suicune.Fraqueza = "Planta"; Suicune.Resistencia = "Fogo"; Suicune.EstaComEfeito = false; Suicune.TipoEfeito = false; Suicune.ValorEfeito = 0; Suicune.TempoEfeito = 0; Suicune.Vida = 100; Suicune.Defesa = 105; Suicune.Ataque1 = 75; Suicune.EneAtaque1 = 2; Suicune.ValorEfeitoBonus = 0; Suicune.ParalisaOuDanifica = false; Suicune.Ataque2 = 38; Suicune.EneAtaque2 = 1; Suicune.Evolui = false;
PokemonsLagoas.Add(Suicune);

Lagoas.CapturarPokemonAva(Mewtwo);
Lagoas.CapturarPokemonAva(Raikou);
Lagoas.CapturarPokemonAva(Entei);
Lagoas.CapturarPokemonAva(Suicune);

//  Continuação do final

Player = Design.Feirante2Mod2(50, Pokemons,Pokemons2,Pokemons3,Player);
Console.Clear();
Design.Loading();
Console.Clear();
bool PodiIr=false;
int cont=0,cont2=0,cont3=0;
while (!PodiIr)
{
    Design.Escrita("Vozes do Além : Antes da batalha, verifique seus pokemons, escolha 1 da lista para ver detalhadamente (Digite o número dele)");
    cont=0;
    for (cont2=0;cont2<Player.PokemonsCapturadosIni.Count;cont2++)
    {
        Console.WriteLine($"\n({cont}-{Player.PokemonsCapturadosIni[cont2].Nome})");
        cont ++;
    }
   
    for (cont2=0; cont2 < Player.PokemonsCapturadosInt.Count;cont2++)
    {
        Console.WriteLine($"\n({cont}-{Player.PokemonsCapturadosInt[cont2].Nome})");
        cont++;
    }
    
    for (cont2=0; cont2 < Player.PokemonsCapturadosAva.Count;cont2++)
    {
        Console.WriteLine($"\n({cont}-{Player.PokemonsCapturadosAva[cont2].Nome})");
        cont++;
    }
    int respPokemon=Convert.ToInt32(Console.ReadLine());
    if (respPokemon < Player.PokemonsCapturadosIni.Count)
    {
        Batalha.VerificarPokemons(Player.PokemonsCapturadosIni[respPokemon]);
    } 
    else if (respPokemon < (Player.PokemonsCapturadosInt.Count+Player.PokemonsCapturadosIni.Count))
    {
        Batalha.VerificarPokemons(Player.PokemonsCapturadosInt[respPokemon-Player.PokemonsCapturadosIni.Count]);
    }
    else if (respPokemon < Player.PokemonsCapturadosAva.Count+(Player.PokemonsCapturadosInt.Count + Player.PokemonsCapturadosIni.Count))
    {
        Batalha.VerificarPokemons(Player.PokemonsCapturadosAva[(respPokemon-Player.PokemonsCapturadosIni.Count)-Player.PokemonsCapturadosInt.Count]);
    }
    Design.Escrita("\nVozes do Além: Digite ( 1 - Verificar outro Pokemon ) ( 2 - Ir para a batalha épica )");
    char resp = Console.ReadKey().KeyChar;
    if (resp == '1')
    {
        Console.Clear();
    }
    else if (resp == '2')
    {
        PodiIr = true;
    }
    else
    {
        Design.Escrita("Valor inválido");
        Thread.Sleep(2000);
        Console.Clear();
    }
}

Console.Clear();
Design.Escrita("Vozes do Além : Bem vindo a arena de batalha pokemon, antes de tudo, entenda algumas regras:\n\n1- Perde quem tiver todos os Pokemons derrotados primeiro.\n2- Duas energias serão ganha por rodada.\n3- Só é permitido evoluir 1 Pokemon e 1 vez por rodada\n");
Thread.Sleep(2000);
Console.Clear();
Design.img1();
Design.Escrita("\nVamos lá");
Thread.Sleep(3000);
Console.Clear();
Design.Escrita("\nEscolha seu Pokemom para iniciar na batalha:");
for (int i = 0; i < Player.PokemonsCapturadosIni.Count; i++)
{
    Console.WriteLine($"\n{i}-{Player.PokemonsCapturadosIni[i].Nome}");
}
string campeão="Sla";
int escolhaPokemonInt=0;
int escolhaPokemonAva=0;
int escolhaPokemonIni = Convert.ToInt32(Console.ReadLine());
Player.Escolhe(Player.PokemonsCapturadosIni[escolhaPokemonIni]);
Player.RemoveIni(escolhaPokemonIni);
int cont10 = Batalha.QuemComeça(jogador1.Nome, "Lagoas");
Thread.Sleep(3000);
Console.Clear();
bool podeirplayer = false, derrotou;
int sorteioPkLagoas = 3;
Lagoas.Escolhe(Suicune);
int contRodada = 1;
bool Playerpodeatacar = true,Lagoaspodeatacar=true;
while (!batalha)
{
    
    Console.Clear();
    
    
    if (cont10 % 2 == 0) // Vez do player
    {
        Playerpodeatacar = true;
        Player.Energias += 2;
        podeirplayer = false; 
        while (!podeirplayer)
        {
            podeirplayer = true;
            
            Console.Clear();
            Design.img1();
            Console.WriteLine($"\n\nRodada: {contRodada}, Vez do {Player.Nome}");
            if (Player.PokemonAtivo.EstaComEfeito==true)
            {
                if (Player.PokemonAtivo.TempoEfeito > 0)
                {
                    if (Player.PokemonAtivo.TipoEfeito == false)
                    {
                        Player.PokemonAtivo.Vida -= Player.PokemonAtivo.ValorEfeito;
                        Design.Escrita($"\n{Player.PokemonAtivo.Nome} está amaldiçoado e recebeu {Player.PokemonAtivo.ValorEfeito} de dano!\n");
                        
                    }
                    else
                    {
                        Playerpodeatacar = false;
                        Design.Escrita($"\n{Player.PokemonAtivo.Nome} está paralisado e perderá essa rodada\n");
                    }
                    Thread.Sleep(2000);
                    Player.PokemonAtivo.TempoEfeito--;
                }
                else
                {
                    Player.PokemonAtivo.EstaComEfeito = false;
                }
            }
            if (Playerpodeatacar == true)
            {
                Console.WriteLine("\n\nVozes do Além: Sua vez. Escolha o Ataque a ser efetuado: ( 1 = Ataque 1 ) ( 2 = Ataque 2 ) ( 3 = Evoluir *Caso possua a carta evoluida* Custo : 3 energias) ( 4 = Pular a vez )");
                Batalha.VerificarPokemons(Player.PokemonAtivo);
                Console.WriteLine("\nSuas energias:" + Player.Energias);
                Console.WriteLine("Pokemon Inimigo Ativo: " + Lagoas.PokemonAtivo.Nome + "\n");
                char EscolhaAtaque = Console.ReadKey().KeyChar;
                if (EscolhaAtaque == '1' && Player.Energias >= 2)
                {
                    derrotou = Batalha.CalculaDano1(Player.PokemonAtivo, Lagoas.PokemonAtivo);
                    if (derrotou)
                    {
                        Design.Escrita("\n" + Lagoas.PokemonAtivo.Nome + " Foi derrotado");
                        Lagoas.PokemonsDerrotados.Add(Lagoas.PokemonAtivo);
                        Lagoas.PokemonsCapturadosAva.RemoveAt(sorteioPkLagoas);
                        Random SorteioPkLagoas = new Random();
                        sorteioPkLagoas = SorteioPkLagoas.Next(0, Lagoas.PokemonsCapturadosAva.Count);
                        Lagoas.PokemonAtivo = Lagoas.PokemonsCapturadosAva[sorteioPkLagoas];
                    }
                    Player.Energias -= 2;
                    Thread.Sleep(6000);

                }
                else if (EscolhaAtaque == '2' && Player.Energias >= 1)
                {
                    derrotou = Batalha.CalculaDano2(Player.PokemonAtivo, Lagoas.PokemonAtivo);
                    if (derrotou)
                    {
                        Design.Escrita(Lagoas.PokemonAtivo.Nome + " Foi derrotado");
                        Lagoas.PokemonsDerrotados.Add(Lagoas.PokemonAtivo);
                        Lagoas.PokemonsCapturadosAva.RemoveAt(sorteioPkLagoas);
                        Player.PokemonsDerrotados.Add(Player.PokemonAtivo);
                        if (Lagoas.PokemonsCapturadosAva.Count <= 0)
                        {
                            batalha = true;
                            campeão = Player.Nome;
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        Random SorteioPkLagoas = new Random();
                        sorteioPkLagoas = SorteioPkLagoas.Next(0, Lagoas.PokemonsCapturadosAva.Count);
                        Lagoas.PokemonAtivo = Lagoas.PokemonsCapturadosAva[sorteioPkLagoas];
                    }
                    Player.Energias -= 1;
                    Thread.Sleep(6000);

                }

                else if (EscolhaAtaque == '3' && Player.Energias >= 3 && Player.PokemonAtivo.Evolui == true)
                {
                    if (Player.PokemonAtivo.Nivel == 1)
                    {
                        for (int z = 0; z < Player.PokemonsCapturadosInt.Count; z++)
                        {
                            if (Player.PokemonAtivo.Evolucao == Player.PokemonsCapturadosInt[z].Nome)
                            {
                                Player.Escolhe(Player.PokemonsCapturadosInt[z]);
                                escolhaPokemonInt = z;
                                Player.RemoveIni(escolhaPokemonIni);
                                Player.Energias -= 3;
                                podeirplayer = false;
                                z = Player.PokemonsCapturadosInt.Count;
                            }
                            else if (z == Player.PokemonsCapturadosInt.Count - 1)
                            {
                                Console.WriteLine("Evolução indisponível");
                                Thread.Sleep(3000);
                                Console.Clear();
                                podeirplayer = false;
                            }
                        }
                    }
                    else if (Player.PokemonAtivo.Nivel == 2)
                    {
                        for (int z = 0; z < Player.PokemonsCapturadosAva.Count; z++)
                        {
                            if (Player.PokemonAtivo.Evolucao == Player.PokemonsCapturadosAva[z].Nome)
                            {
                                Player.Escolhe(Player.PokemonsCapturadosAva[z]);
                                escolhaPokemonAva = z;
                                Player.RemoveInt(escolhaPokemonInt);
                                Player.Energias -= 3;
                                z = Player.PokemonsCapturadosInt.Count;
                            }
                            else if (z == Player.PokemonsCapturadosAva.Count - 1)
                            {
                                Console.WriteLine("Evolução indisponível");
                                Thread.Sleep(3000);
                                Console.Clear();
                                podeirplayer = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Evolução indisponível");
                        Thread.Sleep(3000);
                        Console.Clear();
                        podeirplayer = false;
                    }
                }
                else if (EscolhaAtaque == '4')
                {
                    podeirplayer = true;
                }
                else
                {
                    Console.WriteLine("\nValor inválido, energias insuficiente ou evolução indisponível, tente novamente");
                    Thread.Sleep(3000);
                    Console.Clear();
                    podeirplayer = false;
                }
            }
        }
        contRodada++;
        Console.Clear();
    } 
    else // Vez do lagoas
    {
        Lagoaspodeatacar = true;
        Lagoas.Energias += 2;
        Random EscolhaAtkL = new Random();
        int escolhaAtkL = EscolhaAtkL.Next(1, 2);
        Design.img1();
        Console.WriteLine($"\n\nRodada: {contRodada}, Vez do Lagoas.");
        if (Lagoas.PokemonAtivo.EstaComEfeito == true)
        {
            if (Lagoas.PokemonAtivo.TempoEfeito > 0)
            {
                if (Lagoas.PokemonAtivo.TipoEfeito == false)
                {
                    Lagoas.PokemonAtivo.Vida -= Lagoas.PokemonAtivo.ValorEfeito;
                    Design.Escrita($"\n{Lagoas.PokemonAtivo.Nome} está amaldiçoado e recebeu {Lagoas.PokemonAtivo.ValorEfeito} de dano!\n");

                }
                else
                {
                    Lagoaspodeatacar = false;
                    Design.Escrita($"\n{Lagoas.PokemonAtivo.Nome} está paralisado e perderá essa rodada\n");
                }
                Thread.Sleep(2000);
                Lagoas.PokemonAtivo.TempoEfeito--;
            }
            else
            {
                Lagoas.PokemonAtivo.EstaComEfeito = false;
            }
        }
        if (Lagoaspodeatacar == true)
        {
            Thread.Sleep(1000);
            if (escolhaAtkL == 1 && Lagoas.Energias >= 2)
            {
                derrotou = Batalha.CalculaDano1(Lagoas.PokemonAtivo, Player.PokemonAtivo);
                if (derrotou)
                {
                    Design.Escrita(Player.PokemonAtivo.Nome + " Foi derrotado");
                    Player.PokemonsDerrotados.Add(Player.PokemonAtivo);
                    if (Player.PokemonAtivo.Nivel == 1)
                    {
                        Player.RemoveIni(escolhaPokemonIni);
                    }
                    else if (Player.PokemonAtivo.Nivel == 2)
                    {
                        Player.RemoveInt(escolhaPokemonInt);
                    }
                    else if (Player.PokemonAtivo.Nivel == 3)
                    {
                        Player.RemoveAva(escolhaPokemonAva);
                    }
                    if (Player.PokemonsCapturadosIni.Count <= 0)
                    {
                        batalha = true;
                        campeão = Lagoas.Nome;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Design.Escrita("GAME OVER!!! Você mostrou não ser capaz da liberdade!! Sofra pelo o resto da vida trancado em uma cela sabendo que foi incompetente o suficente para não derrotar o Lagoas");

                    }
                    Thread.Sleep(6000);
                    Console.Clear();
                    Design.Escrita("Escolha seu Pokemom para continuar a batalha:");
                    for (int i = 0; i < Player.PokemonsCapturadosIni.Count; i++)
                    {
                        Console.WriteLine($"\n({i}-{Player.PokemonsCapturadosIni[i].Nome})");
                    }
                    int escolhaPokemonP = Convert.ToInt32(Console.ReadLine());
                    Player.Escolhe(Player.PokemonsCapturadosIni[escolhaPokemonP]);

                }
                Thread.Sleep(4000);

            }
            else if (escolhaAtkL == 2 && Player.Energias >= 1)
            {
                derrotou = Batalha.CalculaDano2(Lagoas.PokemonAtivo, Player.PokemonAtivo);
                if (derrotou)
                {
                    Design.Escrita(Player.PokemonAtivo + " Foi derrotado");
                    Player.PokemonsDerrotados.Add(Player.PokemonAtivo);
                    if (Player.PokemonAtivo.Nivel == 1)
                    {
                        Player.RemoveIni(escolhaPokemonIni);
                    }
                    else if (Player.PokemonAtivo.Nivel == 2)
                    {
                        Player.RemoveInt(escolhaPokemonInt);
                    }
                    else if (Player.PokemonAtivo.Nivel == 3)
                    {
                        Player.RemoveAva(escolhaPokemonAva);
                    }
                    if (Player.PokemonsCapturadosIni.Count <= 0)
                    {
                        batalha = true;
                        campeão = Lagoas.Nome;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Design.Escrita("GAME OVER!!! Você mostrou não ser capaz da liberdade!! Sofra pelo o resto da vida trancado em uma cela sabendo que foi incompetente o suficente para não derrotar o Lagoas");
                    }
                    else
                    {
                        Thread.Sleep(6000);
                        Console.Clear();
                        Design.Escrita("Escolha seu Pokemom para continuar a batalha:");
                        for (int i = 0; i < Player.PokemonsCapturadosIni.Count; i++)
                        {
                            Console.WriteLine($"\n({i}-{Player.PokemonsCapturadosIni[i].Nome}\n)");
                        }
                        int escolhaPokemonP = Convert.ToInt32(Console.ReadLine());
                        Player.Escolhe(Player.PokemonsCapturadosIni[escolhaPokemonP]);
                    }
                }
                Thread.Sleep(6000);
            }
        }
    }
    
        cont10++;
}
if (campeão == Player.Nome)
{
    Console.Clear();
    Design.img1();
    Design.Escrita("Lagoas: Você se mostrou digno da liberdade e retornará ao mundo real, parabéns, estou orgulhoso");
    Thread.Sleep(3000);
    
}

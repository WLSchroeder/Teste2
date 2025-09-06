using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleApp5
{
   
    class Design
    {

        public static void img1()
        {
            string vermelho = "\u001b[38;2;204;0;0m";
            Console.WriteLine(vermelho + "                     ███                                                               ███                       ");
            Console.WriteLine("                  █████                                                                 ████          ");
            Console.WriteLine("                ██████                      ██████████████████████                      ██████          ");
            Console.WriteLine("               ████████               ██████                      ██████                ████████         ");
            Console.WriteLine("              ██████████        ██████                                  ██████         █████████           ");
            Console.WriteLine("            ████████████████████                                              ████████████████████   ");
            Console.WriteLine("            ██████████████                                                          ██████████████            ");
            Console.WriteLine("            █████████████                                                          ███████████████       ");
            Console.WriteLine("            █████████████                                                          ███████████████       ");
            Console.WriteLine("            ███████████████                                                       ██████████████                   ");
            Console.WriteLine("              █████████████      █████                                █████       █████████████                     ");
            Console.WriteLine("                ███████████      █████████████                █████████████      █████████████                   ");
            Console.WriteLine("                   █████████      ████████████████        ████████████████        ███████████                     ");
            Console.WriteLine("                    █████          ████████████              ████████████             █████                       ");
            Console.WriteLine("                    ████           ████████████              ████████████             ████                          ");
            Console.WriteLine("                     ████          ████████████              ████████████            ████                         ");
            Console.WriteLine("                                    ██████████                ██████████                                          ");
        }
        public static void EscritaImg(string texto)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                if (c != ' ')
                {
                    Console.Beep(80, 5);
                }
                Thread.Sleep(1);
            }
            Thread.Sleep(3000);
        }
        public static void Escrita(string texto)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                if (c != ' ')
                {
                    Console.Beep(200, 5);
                }
                Thread.Sleep(8);
            }



        }
        public static void Padrao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void Verde()
        {
            string verdeRGB = "\u001b[38;2;0;128;0m";

            Console.Write(verdeRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(verdeRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(verdeRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(verdeRGB + "           ██████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(verdeRGB + "           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void Vermelho()
        {
            string vermelhoRGB = "\u001b[38;2;200;30;30m";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vermelhoRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vermelhoRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vermelhoRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vermelhoRGB + "        ██████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vermelhoRGB + "██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void Amarelo()
        {
            string amareloRGB = "\u001b[38;2;220;220;0m";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(amareloRGB + "           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(amareloRGB + "           ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(amareloRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(amareloRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(amareloRGB + "           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void Azul()
        {
            string azulRGB = "\u001b[38;2;0;0;200m";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        ██████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(azulRGB + "██  ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(azulRGB + "        ██████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(azulRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(azulRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("           ██████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(azulRGB + "██████████");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static int GarrafasCores(int x, int[,] matriz, int chances)
        {
            List<string> cor = new List<string>();

            cor.Add("\u001b[38;2;230;25;75m");
            cor.Add("\u001b[38;2;60;180;75m");
            cor.Add("\u001b[38;2;0;130;200m");
            cor.Add("\u001b[38;2;255;225;25m");
            cor.Add("\u001b[38;2;245;130;48m");
            cor.Add("\u001b[38;2;145;30;180m");
            cor.Add("\u001b[38;2;218;112;214m");
            int i = 0, cont = x;
            int certas = 0;
            Console.Clear();
            Console.Write(" ");
            for (i = 0; i < cont; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"     {i+1}     ");
                if (i == cont - 1)
                {
                    Console.WriteLine($"     {i+2}    ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("     ████  ");
                if (i == cont - 1)
                {
                    Console.WriteLine("     ████  ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "      ██   ");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "      ██   ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "     ████  ");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "     ████  ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "    ██████ ");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "    ██████ ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "    ██████ ");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "    ██████ ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "    ██████ ");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "    ██████ ");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ████████");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ████████");
                }
            }
            for (i = 0; i < cont; i++)
            {
                Console.Write(cor[matriz[1, i]] + "   ██ ██ ██");
                if (i == cont - 1)
                {
                    Console.WriteLine(cor[matriz[1, i + 1]] + "   ██ ██ ██");
                }
            }
            for (i = 0; i <= cont; i++)
            {
                if (cor[matriz[1, i]] == cor[matriz[2, i]])
                {
                    certas++;
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCertas: " + certas);
            Console.WriteLine("\nChances: " + chances);
            if (chances <= 0 && certas <= cont)
            {

                return 0;
            }
            else if (certas >= cont)
            {
                return 1;
            }
            return -1;
        }

        
        public static void Feirante1()
        {
            List<string> cor = new List<string>();
            cor.Add("\u001b[38;2;92;51;23m");
            cor.Add("\u001b[38;2;210;180;140m");
            cor.Add("\u001b[38;2;60;40;20m");
            cor.Add("\u001b[38;2;70;130;180m");
            cor.Add("\u001b[38;2;204;0;0m");
            cor.Add("\u001b[38;2;255;255;255m");
            cor.Add("\u001b[38;2;205;92;92m");
            cor.Add("\u001b[38;2;128;128;128m");
            cor.Add("\u001b[38;2;237;201;175m");
            cor.Add("\u001b[38;2;139;69;19m");
            cor.Add("\u001b[38;2;255;215;0m");

            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[6] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[6] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[6] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[6] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[6] + "█████████████████████████████████████████████████████████████████████████████");

            Console.WriteLine(cor[0] + "███                                                       " + cor[10] + "█████▄▄▄█████   " + cor[0] + "███");

            Console.WriteLine("███                            " + cor[9] + "▄▄▄▄▄▄▄▄▄▄▄▄▄▄" + cor[10] + "             ▄█▄█▄█▄█▄█▄█▄" + cor[0] + "   ███");

            Console.WriteLine("███          " + cor[9] + "▄▀▄                " + cor[7] + "████████████" + cor[10] + "              █████████████" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + "   ▄▄▄ █ ▄▄▄ " + cor[8] + "               ▀████████▀" + cor[10] + "               ███       ███" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + "  ███████████ " + cor[8] + "                ▀████▀" + cor[10] + "                 ██   ███   ██" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + " █████████████ " + cor[8] + "                 ██" + cor[10] + "                   ███████   ███" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + " █████████████ " + cor[8] + "              ▄██████▄" + cor[10] + "                ██████  █████" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + " █████████████ " + cor[8] + "             ██████████" + cor[10] + "               █████████████" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + "  ███████████ " + cor[8] + "             ████████████" + cor[10] + "              █████   █████" + cor[0] + "   ███");

            Console.WriteLine("███  " + cor[4] + "   ▀▀▀▀ ▀▀▀▀ " + cor[9] + "             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀" + cor[10] + "              ▀▀▀▀▀▀▀▀▀▀▀" + cor[0] + "    ███");

            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███             ██████████████████████████████████████████");
            Console.WriteLine("███                                                                       ███             ████      ███████      █       █      ████");
            Console.WriteLine("███                                                                       ███             ████████  ███████  ██  █  ███  █  ██  ████");
            Console.WriteLine("███                                                                       ███             ████      ███████      █  ███  █       ███");

            Console.Write("███                               ");
            Console.Write(cor[2] + "██████████");
            Console.WriteLine(cor[0] + "                              ███             ████████  ███████  █████  ███  █  ███  ███");

            Console.Write(cor[0] + "███                               ");
            Console.Write(cor[1] + "██▄▄██▄▄██");
            Console.WriteLine(cor[0] + "                              ███             ████      ███████  █████       █  ███  ███");

            Console.Write(cor[0] + "███                               ");
            Console.Write(cor[1] + "██  ██  ██");
            Console.WriteLine(cor[0] + "                              ███             ██████████████████████████████████████████");

            Console.Write(cor[0] + "███                               ");
            Console.Write(cor[1] + "██▄▄██▄▄██");
            Console.WriteLine(cor[0] + "                              ███             █████████████    ███       ███████████████");

            Console.Write(cor[0] + "███                               ");
            Console.Write(cor[1] + "██ ▀▀▀▀ ██");
            Console.WriteLine(cor[0] + "                              ███             █████████████ █  ███  ███  ███████████████");

            Console.Write(cor[0] + "███                               ");
            Console.Write(cor[1] + "██████████");
            Console.WriteLine(cor[0] + "                              ███             ███████████████  ███  ███  ███████████████");

            Console.Write(cor[0] + "███                            ");
            Console.Write(cor[3] + "███████" + cor[1] +
                "██" + cor[3] +
                "███████");
            Console.WriteLine(cor[0] + "                           ███             ███████████████  ███  ███  ███████████████");

            Console.Write(cor[0] + "███                           ");
            Console.Write(cor[3] + "██ ████████████ ██");
            Console.WriteLine(cor[0] + "                          ███             █████████████      █       ███████████████");

            Console.Write(cor[0] + "███                          ");
            Console.Write(cor[1] + "██" + cor[3] +
                "  ████████████  " + cor[1] +
                "██");
            Console.WriteLine(cor[0] + "                         ███             ██████████████████████████████████████████");

            Console.WriteLine(cor[0] + "█████████████████████████████████████████████████████████████████████████████                               ████");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ████");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ████");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ████");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ████");
            Console.WriteLine("███                                                                       ███                               ████");
            Console.WriteLine("███                                                                       ███                               ████");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void Feirante2()
        {
            List<string> cor = new List<string>();
            cor.Add("\u001b[38;2;92;51;23m");
            cor.Add("\u001b[38;2;210;180;140m");
            cor.Add("\u001b[38;2;101;45;15m");
            cor.Add("\u001b[38;2;180;150;255m");
            cor.Add("\u001b[38;2;204;0;0m");
            cor.Add("\u001b[38;2;255;255;255m");
            cor.Add("\u001b[38;2;205;92;92m");
            cor.Add("\u001b[38;2;128;128;128m");
            cor.Add("\u001b[38;2;237;201;175m");
            cor.Add("\u001b[38;2;139;69;19m");
            cor.Add("\u001b[38;2;255;215;0m");
            cor.Add("\u001b[38;2;60;160;60m");
            cor.Add("\u001b[38;2;20;100;20m");
            cor.Add("\u001b[38;2;219;219;219m"); // prata do escudo
            cor.Add("\u001b[38;2;255;0;0m"); // vermelho do escudo
            cor.Add("\u001b[38;2;180;150;255m"); // azul barraca
            cor.Add("\u001b[38;2;255;215;0m"); // amarelo da estrela

            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine(cor[0] + "███   " + cor[11] + "▄▄▄▄▄" + "     ▄▄▄▄▄        " + cor[14] + " ▄▄▄▄▄▄▄▄" + cor[13] + "▄▄▄▄▄▄▄                " + cor[16] + "▄█▄          " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███ " + cor[11] + "▄███████▄" + " ▄███████▄     " + cor[14] + " █████████" + cor[13] + "████████              " + cor[16] + "▄███▄         " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███ " + cor[11] + "█████████" + cor[12] + "█" + cor[11] + "█████████  " + cor[14] + "    █████████" + cor[13] + "████████             " + cor[16] + "▄█████▄        " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███  " + cor[11] + "▀███████" + cor[12] + "█" + cor[11] + "███████▀    " + cor[14] + "   █████████" + cor[13] + "████████      " + cor[16] + "▀███████████████████▀ " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███   " + cor[12] + "▄█████████████▄     " + cor[14] + "   █████████" + cor[13] + "████████        " + cor[16] + "▀███████████████▀   " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███  " + cor[11] + "████████" + cor[12] + "█" + cor[11] + "████████   " + cor[13] + "    █████████" + cor[14] + "████████          " + cor[16] + "▀███████████▀     " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███ " + cor[11] + "█████████" + cor[12] + "█" + cor[11] + "█████████     " + cor[13] + "  ████████" + cor[14] + "███████            " + cor[16] + "███████████      " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███  " + cor[11] + "████████" + cor[12] + "█" + cor[11] + "████████      " + cor[13] + "   ███████" + cor[14] + "██████            " + cor[16] + "█████▀▀▀█████     " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███    " + cor[11] + "▀▀▀▀ " + cor[12] + "▄█" + cor[11] + "  ▀▀▀▀       " + cor[13] + "     ▀█████" + cor[14] + "████▀            " + cor[16] + "████▀     ▀████    " + cor[0] + "███");
            Console.WriteLine(cor[0] + "███       " + cor[12] + "▄█▀" + cor[11] + "                   " + cor[13] + "  ▀▀▀▀" + cor[14] + "▀▀▀             " + cor[16] + "▄██▀         ▀██▄   " + cor[0] + "███");
            Console.WriteLine(cor[0] + "█████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");
            Console.WriteLine("███                                                                       ███");

            Console.Write("███                             " + cor[2] + "▄█");
            Console.Write(cor[2] + "███████████▄");
            Console.WriteLine(cor[0] + "                            ███             ");

            Console.Write(cor[0] + "███                             " + cor[2] + "██");
            Console.Write(cor[1] + "██▄▄██▄▄██" + cor[2] + "██");
            Console.WriteLine(cor[0] + "                            ███             ");

            Console.Write(cor[0] + "███                             " + cor[2] + "██");
            Console.Write(cor[1] + "██  ██  ██" + cor[2] + "██");
            Console.WriteLine(cor[0] + "                            ███             ");

            Console.Write(cor[0] + "███                             " + cor[2] + "██");
            Console.Write(cor[1] + "██▄▄██▄▄██" + cor[2] + "██");
            Console.WriteLine(cor[0] + "                            ███             ");

            Console.Write(cor[0] + "███                            " + cor[2] + " ██");
            Console.Write(cor[1] + "██ ▀▀▀▀ ██" + cor[2] + "██");
            Console.WriteLine(cor[0] + "                            ███             ");

            Console.Write(cor[0] + "███                            " + cor[2] + "▄██");
            Console.Write(cor[1] + "██████████" + cor[2] + "██▄");
            Console.WriteLine(cor[0] + "                           ███             ");

            Console.Write(cor[0] + "███                            ");
            Console.Write(cor[3] + "███████" + cor[1] +
                "██" + cor[3] +
                "███████");
            Console.WriteLine(cor[0] + "                           ███             ");

            Console.Write(cor[0] + "███                           ");
            Console.Write(cor[3] + "██ ████████████ ██");
            Console.WriteLine(cor[0] + "                          ███             ");

            Console.Write(cor[0] + "███                          ");
            Console.Write(cor[1] + "██" + cor[3] + "  ████████████  " + cor[1] + "██");
            Console.WriteLine(cor[0] + "                         ███             ");

            Console.WriteLine(cor[0] + "█████████████████████████████████████████████████████████████████████████████                               ");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
            Console.WriteLine("███                                                                       ███                               ");
            Console.WriteLine("███                                                                       ███                               ");
            
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static Treinador Feirante2Mod2(int moedas, List<Pokemon> PokemonsIni, List<Pokemon> PokemonsInt, List<Pokemon> PokemonsAva, Treinador Player)
        {
            char compra = 'c';
            int IndiceSorteado;
            int QuantidadePokemonsMax = 11;
            int pacoteIni=0, pacoteInt=0, pacoteA = 0;
            List<string> cor = new List<string>();
            cor.Add("\u001b[38;2;92;51;23m");
            cor.Add("\u001b[38;2;210;180;140m");
            cor.Add("\u001b[38;2;101;45;15m");
            cor.Add("\u001b[38;2;180;150;255m");
            cor.Add("\u001b[38;2;204;0;0m");
            cor.Add("\u001b[38;2;255;255;255m");
            cor.Add("\u001b[38;2;205;92;92m");
            cor.Add("\u001b[38;2;128;128;128m");
            cor.Add("\u001b[38;2;237;201;175m");
            cor.Add("\u001b[38;2;139;69;19m");
            cor.Add("\u001b[38;2;255;215;0m");
            cor.Add("\u001b[38;2;60;160;60m");
            cor.Add("\u001b[38;2;20;100;20m");
            cor.Add("\u001b[38;2;219;219;219m"); // prata do escudo
            cor.Add("\u001b[38;2;255;0;0m"); // vermelho do escudo
            cor.Add("\u001b[38;2;180;150;255m"); // azul barraca
            cor.Add("\u001b[38;2;255;215;0m"); // amarelo da estrela
            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
                Console.Clear();
                Console.Clear();
                Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[5] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[15] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine(cor[0] + "███   " + cor[11] + "▄▄▄▄▄" + "     ▄▄▄▄▄        " + cor[14] + " ▄▄▄▄▄▄▄▄" + cor[13] + "▄▄▄▄▄▄▄                " + cor[16] + "▄█▄          " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███ " + cor[11] + "▄███████▄" + " ▄███████▄     " + cor[14] + " █████████" + cor[13] + "████████              " + cor[16] + "▄███▄         " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███ " + cor[11] + "█████████" + cor[12] + "█" + cor[11] + "█████████  " + cor[14] + "    █████████" + cor[13] + "████████             " + cor[16] + "▄█████▄        " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███  " + cor[11] + "▀███████" + cor[12] + "█" + cor[11] + "███████▀    " + cor[14] + "   █████████" + cor[13] + "████████      " + cor[16] + "▀███████████████████▀ " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███   " + cor[12] + "▄█████████████▄     " + cor[14] + "   █████████" + cor[13] + "████████        " + cor[16] + "▀███████████████▀   " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███  " + cor[11] + "████████" + cor[12] + "█" + cor[11] + "████████   " + cor[13] + "    █████████" + cor[14] + "████████          " + cor[16] + "▀███████████▀     " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███ " + cor[11] + "█████████" + cor[12] + "█" + cor[11] + "█████████     " + cor[13] + "  ████████" + cor[14] + "███████            " + cor[16] + "███████████      " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███  " + cor[11] + "████████" + cor[12] + "█" + cor[11] + "████████      " + cor[13] + "   ███████" + cor[14] + "██████            " + cor[16] + "█████▀▀▀█████     " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███    " + cor[11] + "▀▀▀▀ " + cor[12] + "▄█" + cor[11] + "  ▀▀▀▀       " + cor[13] + "     ▀█████" + cor[14] + "████▀            " + cor[16] + "████▀     ▀████    " + cor[0] + "███");
                Console.WriteLine(cor[0] + "███       " + cor[12] + "▄█▀" + cor[11] + "                   " + cor[13] + "  ▀▀▀▀" + cor[14] + "▀▀▀             " + cor[16] + "▄██▀         ▀██▄   " + cor[0] + "███");
                Console.WriteLine(cor[0] + "█████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");
                Console.WriteLine("███                                                                       ███");

                Console.Write("███                             " + cor[2] + "▄█");
                Console.Write(cor[2] + "███████████▄");
                Console.WriteLine(cor[0] + "                            ███             ");

                Console.Write(cor[0] + "███                             " + cor[2] + "██");
                Console.Write(cor[1] + "██▄▄██▄▄██" + cor[2] + "██");
                Console.WriteLine(cor[0] + "                            ███             ");

                Console.Write(cor[0] + "███                             " + cor[2] + "██");
                Console.Write(cor[1] + "██  ██  ██" + cor[2] + "██");
                Console.WriteLine(cor[0] + "                            ███             ");

                Console.Write(cor[0] + "███                             " + cor[2] + "██");
                Console.Write(cor[1] + "██▄▄██▄▄██" + cor[2] + "██");
                Console.WriteLine(cor[0] + "                            ███             ");

                Console.Write(cor[0] + "███                            " + cor[2] + " ██");
                Console.Write(cor[1] + "██ ▀▀▀▀ ██" + cor[2] + "██");
                Console.WriteLine(cor[0] + "                            ███             ");

                Console.Write(cor[0] + "███                            " + cor[2] + "▄██");
                Console.Write(cor[1] + "██████████" + cor[2] + "██▄");
                Console.WriteLine(cor[0] + "                           ███             ");

                Console.Write(cor[0] + "███                            ");
                Console.Write(cor[3] + "███████" + cor[1] +
                    "██" + cor[3] +
                    "███████");
                Console.WriteLine(cor[0] + "                           ███             ");

                Console.Write(cor[0] + "███                           ");
                Console.Write(cor[3] + "██ ████████████ ██");
                Console.WriteLine(cor[0] + "                          ███             ");

                Console.Write(cor[0] + "███                          ");
                Console.Write(cor[1] + "██" + cor[3] + "  ████████████  " + cor[1] + "██");
                Console.WriteLine(cor[0] + "                         ███             ");

                Console.WriteLine(cor[0] + "█████████████████████████████████████████████████████████████████████████████                               ");
                Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
                Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
                Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
                Console.WriteLine("█████████████████████████████████████████████████████████████████████████████                               ");
                Console.WriteLine("███                                                                       ███                               ");
                Console.WriteLine("███                                                                       ███                               ");
                Console.ForegroundColor = ConsoleColor.White;
                if (i == 0) 
                {
                    Design.Escrita("Bianca : Olá, fique sabendo que conseguiu passar por todos os jogos");
                    Thread.Sleep(1000);
                    Design.Escrita("\nCerteza que conseguirá derrotar o Lagoas");
                    Thread.Sleep(1000);
                    Design.Escrita("\nEle vive naquele trono dele se escondendo atrás de uma mascara se dizendo um Malware achando que ninguém nunca chegará nele rsrs");
                    Thread.Sleep(1000);
                    Design.Escrita("\nVou tentar te ajudar a derrotar ele, eu tenho alguns pacotes Pokemons aqui, posso te vender eles por um preço bom");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\nClique ( 1 = Pacote inicial ) ( 2 = Pacote Intermediario ) ( 3 = Pacote Avançado ) para ver a descrição do objeto ou comprar!!. Clique 'p' para ir embora e abrir os pacotes!!");
                    char resp = Console.ReadKey().KeyChar;
                    if (resp == '1')
                    {

                        Console.WriteLine("\n\nPacote inicial: Sempre devemos começar de algum lugar. ( Preço : 1 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (pacoteIni>3)
                        {
                            Design.Escrita("\n\nItem indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (moedas >= 1 & compra == '1')
                        {
                            moedas -= 1;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + moedas);
                            Thread.Sleep(2000);
                            pacoteIni++;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == '2')
                    {
                        Console.WriteLine("\n\nPacote Int : Sempre precisamos evoluir. ( Preço : 3 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (pacoteInt > 3)
                        {
                            Design.Escrita("\n\nItem indisponível");
                            Thread.Sleep(3000);


                        }
                        else if (moedas >= 3 & compra == '1')
                        {
                            moedas -= 3;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + moedas);
                            Thread.Sleep(2000);
                            pacoteInt++;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == '3')
                    {

                        Console.WriteLine("\n\nPacote Avançado : Isso é o que separa os homens dos meninos. ( Preço : 5 )\n\nDeseja comprar? ( 1 = Sim ) ( 2 = Não )");
                        compra = Console.ReadKey().KeyChar;
                        if (pacoteA > 3)
                        {
                            Design.Escrita("\n\nItem indisponível");
                            Thread.Sleep(3000);

                        }
                        else if (moedas >= 5 & compra == '1')
                        {
                            moedas -= 5;
                            Console.WriteLine("\nCompra Feita com sucesso!!!");
                            Console.WriteLine("Moedas Restantes:" + moedas);
                            Thread.Sleep(2000);
                            pacoteA++;
                        }
                        else if (compra == '2')
                        {
                            Console.Clear();
                        }
                    }
                    else if (resp == 'p')
                    {
                        i = 100;
                    }
                }
            }
            Random pokIni = new Random();
            Random pokInt = new Random();
            Random pokA = new Random();
            while (pacoteIni > 0)
            {
                Console.Clear();
                Design.Escrita("Abrindo pacote inicial...");
                for (int i = 0; i < 3; i++)
                {           
                    Thread.Sleep(2000);
                    IndiceSorteado = pokIni.Next(0, PokemonsIni.Count);
                    Player.CapturarPokemonIni(PokemonsIni[IndiceSorteado]);
                    Design.Escrita("\n\nVocê recebeu um " + PokemonsIni[IndiceSorteado].Nome + "!!!");
                    PokemonsIni.RemoveAt(IndiceSorteado);
                }
                Thread.Sleep(4000);
                pacoteIni--;
            }
            
            
            while (pacoteInt > 0)
            {
                Console.Clear();
                Design.Escrita("Abrindo pacote Intermediario...");

                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(2000);
                    IndiceSorteado = pokInt.Next(0, PokemonsInt.Count);
                    Player.CapturarPokemonInt(PokemonsInt[IndiceSorteado]);
                    Design.Escrita("\n\nVocê recebeu um " + PokemonsInt[IndiceSorteado].Nome + "!!!");
                    PokemonsInt.RemoveAt(IndiceSorteado);
                }               
                Thread.Sleep(4000);
                pacoteInt--;
            }
            
            while (pacoteA > 0)
            {
                Console.Clear();
                Design.Escrita("Abrindo pacote Avançado...");
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(2000);
                    IndiceSorteado = pokA.Next(0, PokemonsAva.Count);
                    Player.CapturarPokemonAva(PokemonsAva[IndiceSorteado]);
                    Design.Escrita("\n\nVocê recebeu um " + PokemonsAva[IndiceSorteado].Nome + "!!!");
                    PokemonsAva.RemoveAt(IndiceSorteado);
                }
                Thread.Sleep(4000);
                pacoteA--;
            }
            Design.Escrita("\n\nBianca : Imagino que eu tenha te ajudado bastante, boa sorte contra o Lagoas, vá com tudo!!");
            Thread.Sleep(3000);
            return Player;

        }
        public static int TigrinhoRoleta()
        {
            int velocidade = 1;
            List<string> cor = new List<string>();
            cor.Add("\u001b[38;2;0;255;255m");
            cor.Add("\u001b[38;2;57;255;20m");
            cor.Add("\u001b[38;2;255;215;0m");
            cor.Add("\u001b[38;2;138;43;226m");
            cor.Add("\u001b[38;2;255;0;0m");
            cor.Add("\u001b[38;2;255;255;255m");
            Thread.Sleep(1000);
            Random sorteioDuLitleTiger = new Random();
            int i = sorteioDuLitleTiger.Next(80, 120);
            for (int k = 0; k < 3; k++)
            {
                velocidade *= 2;
                for (int j = 4; j < i / velocidade; j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.WriteLine(cor[0] + "                     ██████" + cor[1] + "██████               ");
                        Console.WriteLine(cor[0] + "                  █████████" + cor[1] + "█████████                    ");
                        Console.WriteLine(cor[0] + "                ███████████" + cor[1] + "███████████            ");
                        Console.WriteLine(cor[0] + "              █████████████" + cor[1] + "█████████████                        ");
                        Console.WriteLine(cor[0] + "              ██████" + cor[5] + "X4" + cor[0] + "█████" + cor[1] + "█████" + cor[5] + "X2" + cor[1] + "██████                      ");
                        Console.WriteLine(cor[0] + "            ███████████████" + cor[1] + "███████████████                       ");
                        Console.WriteLine(cor[0] + "            ███████████████" + cor[1] + "███████████████                     ");
                        Console.WriteLine(cor[0] + "           ████████████████" + cor[1] + "████████████████                     ");
                        Console.WriteLine(cor[2] + "           ████████████████" + cor[3] + "████████████████                     ");
                        Console.WriteLine(cor[2] + "            ███████████████" + cor[3] + "███████████████                     ");
                        Console.WriteLine(cor[2] + "            ███████████████" + cor[3] + "███████████████                 ");
                        Console.WriteLine(cor[2] + "              ██████" + cor[5] + "X0" + cor[2] + "█████" + cor[3] + "█████" + cor[5] + "X5" + cor[3] + "██████                     ");
                        Console.WriteLine(cor[2] + "              █████████████" + cor[3] + "█████████████                     ");
                        Console.WriteLine(cor[2] + "                ███████████" + cor[3] + "███████████                     ");
                        Console.WriteLine(cor[2] + "                  █████████" + cor[3] + "█████████");
                        Console.WriteLine(cor[2] + "                     ██████" + cor[3] + "██████");
                        Console.WriteLine(cor[4] + "                                    ");
                        Console.WriteLine("                     ▄▄               ");
                        Console.WriteLine("                   ▄████▄               ");
                        Console.WriteLine("                 ▄████████▄                ");
                        Console.WriteLine("                    ████            ");
                        Console.WriteLine("                    ████              ");
                        Console.WriteLine("                    ████              ");
                        if (velocidade == 2)
                        {
                            Thread.Sleep(150);
                            Console.Clear();
                        }
                        else if (velocidade == 4)
                        {
                            Thread.Sleep(400);
                            Console.Clear();
                        }
                        else if (velocidade == 8)
                        {
                            if (j == (i / 8) - 1)
                            {
                                return 0;
                            }
                            else
                            {
                                Thread.Sleep(700);
                                Console.Clear();
                            }
                        }

                    }
                    else if ((j - 1) % 4 == 0)
                    {
                        Console.WriteLine(cor[2] + "                     ██████" + cor[0] + "██████               ");
                        Console.WriteLine(cor[2] + "                  █████████" + cor[0] + "█████████                    ");
                        Console.WriteLine(cor[2] + "                ███████████" + cor[0] + "███████████            ");
                        Console.WriteLine(cor[2] + "              █████████████" + cor[0] + "█████████████                        ");
                        Console.WriteLine(cor[2] + "              ██████" + cor[5] + "X0" + cor[2] + "█████" + cor[0] + "█████" + cor[5] + "X4" + cor[0] + "██████                      ");
                        Console.WriteLine(cor[2] + "            ███████████████" + cor[0] + "███████████████                       ");
                        Console.WriteLine(cor[2] + "            ███████████████" + cor[0] + "███████████████                     ");
                        Console.WriteLine(cor[2] + "           ████████████████" + cor[0] + "████████████████                     ");
                        Console.WriteLine(cor[3] + "           ████████████████" + cor[1] + "████████████████                     ");
                        Console.WriteLine(cor[3] + "            ███████████████" + cor[1] + "███████████████                     ");
                        Console.WriteLine(cor[3] + "            ███████████████" + cor[1] + "███████████████                  ");
                        Console.WriteLine(cor[3] + "              ██████" + cor[5] + "X5" + cor[3] + "█████" + cor[1] + "█████" + cor[5] + "X2" + cor[1] + "██████                      ");
                        Console.WriteLine(cor[3] + "              █████████████" + cor[1] + "█████████████                     ");
                        Console.WriteLine(cor[3] + "                ███████████" + cor[1] + "███████████                     ");
                        Console.WriteLine(cor[3] + "                  █████████" + cor[1] + "█████████");
                        Console.WriteLine(cor[3] + "                     ██████" + cor[1] + "██████");
                        Console.WriteLine(cor[4] + "                                    ");
                        Console.WriteLine("                     ▄▄               ");
                        Console.WriteLine("                   ▄████▄               ");
                        Console.WriteLine("                 ▄████████▄                ");
                        Console.WriteLine("                    ████            ");
                        Console.WriteLine("                    ████              ");
                        Console.WriteLine("                    ████              ");
                        if (velocidade == 2)
                        {
                            Thread.Sleep(150);
                            Console.Clear();
                        }
                        else if (velocidade == 4)
                        {
                            Thread.Sleep(400);
                            Console.Clear();
                        }
                        else if (velocidade == 8)
                        {
                            if (j == (i / 8) - 1)
                            {
                                return 5;
                            }
                            else
                            {
                                Thread.Sleep(700);
                                Console.Clear();
                            }
                        }
                    }
                    else if ((j - 2) % 4 == 0)
                    {
                        Console.WriteLine(cor[3] + "                     ██████" + cor[2] + "██████               ");
                        Console.WriteLine(cor[3] + "                  █████████" + cor[2] + "█████████                    ");
                        Console.WriteLine(cor[3] + "                ███████████" + cor[2] + "███████████            ");
                        Console.WriteLine(cor[3] + "              █████████████" + cor[2] + "█████████████                        ");
                        Console.WriteLine(cor[3] + "              ██████" + cor[5] + "X5" + cor[3] + "█████" + cor[2] + "█████" + cor[5] + "X0" + cor[2] + "██████                      ");
                        Console.WriteLine(cor[3] + "            ███████████████" + cor[2] + "███████████████                       ");
                        Console.WriteLine(cor[3] + "            ███████████████" + cor[2] + "███████████████                     ");
                        Console.WriteLine(cor[3] + "           ████████████████" + cor[2] + "████████████████                     ");
                        Console.WriteLine(cor[1] + "           ████████████████" + cor[0] + "████████████████                     ");
                        Console.WriteLine(cor[1] + "            ███████████████" + cor[0] + "███████████████                     ");
                        Console.WriteLine(cor[1] + "            ███████████████" + cor[0] + "███████████████                    ");
                        Console.WriteLine(cor[1] + "              ██████" + cor[5] + "X2" + cor[1] + "█████" + cor[0] + "█████" + cor[5] + "X4" + cor[0] + "██████                      ");
                        Console.WriteLine(cor[1] + "              █████████████" + cor[0] + "█████████████                     ");
                        Console.WriteLine(cor[1] + "                ███████████" + cor[0] + "███████████                     ");
                        Console.WriteLine(cor[1] + "                  █████████" + cor[0] + "█████████");
                        Console.WriteLine(cor[1] + "                     ██████" + cor[0] + "██████");
                        Console.WriteLine(cor[4] + "                                    ");
                        Console.WriteLine("                     ▄▄               ");
                        Console.WriteLine("                   ▄████▄               ");
                        Console.WriteLine("                 ▄████████▄                ");
                        Console.WriteLine("                    ████            ");
                        Console.WriteLine("                    ████              ");
                        Console.WriteLine("                    ████              ");
                        if (velocidade == 2)
                        {
                            Thread.Sleep(150);
                            Console.Clear();
                        }
                        else if (velocidade == 4)
                        {
                            Thread.Sleep(400);
                            Console.Clear();
                        }
                        else if (velocidade == 8)
                        {
                            if (j == (i / 8) - 1)
                            {
                                return 2;
                            }
                            else
                            {
                                Thread.Sleep(700);
                                Console.Clear();
                            }
                        }
                    }
                    else if ((j - 3) % 4 == 0)
                    {
                        Console.WriteLine(cor[1] + "                     ██████" + cor[3] + "██████               ");
                        Console.WriteLine(cor[1] + "                  █████████" + cor[3] + "█████████                    ");
                        Console.WriteLine(cor[1] + "                ███████████" + cor[3] + "███████████            ");
                        Console.WriteLine(cor[1] + "              █████████████" + cor[3] + "█████████████                        ");
                        Console.WriteLine(cor[1] + "              ██████" + cor[5] + "X2" + cor[1] + "█████" + cor[3] + "█████" + cor[5] + "X5" + cor[3] + "██████                      ");
                        Console.WriteLine(cor[1] + "            ███████████████" + cor[3] + "███████████████                       ");
                        Console.WriteLine(cor[1] + "            ███████████████" + cor[3] + "███████████████                     ");
                        Console.WriteLine(cor[1] + "           ████████████████" + cor[3] + "████████████████                     ");
                        Console.WriteLine(cor[0] + "           ████████████████" + cor[2] + "████████████████                     ");
                        Console.WriteLine(cor[0] + "            ███████████████" + cor[2] + "███████████████                     ");
                        Console.WriteLine(cor[0] + "            ███████████████" + cor[2] + "███████████████                   ");
                        Console.WriteLine(cor[0] + "              ██████" + cor[5] + "X4" + cor[0] + "█████" + cor[2] + "█████" + cor[5] + "X0" + cor[2] + "██████                      ");
                        Console.WriteLine(cor[0] + "              █████████████" + cor[2] + "█████████████                     ");
                        Console.WriteLine(cor[0] + "                ███████████" + cor[2] + "███████████                     ");
                        Console.WriteLine(cor[0] + "                  █████████" + cor[2] + "█████████");
                        Console.WriteLine(cor[0] + "                     ██████" + cor[2] + "██████");
                        Console.WriteLine(cor[4] + "                                    ");
                        Console.WriteLine("                     ▄▄               ");
                        Console.WriteLine("                   ▄████▄               ");
                        Console.WriteLine("                 ▄████████▄                ");
                        Console.WriteLine("                    ████            ");
                        Console.WriteLine("                    ████              ");
                        Console.WriteLine("                    ████              ");
                        if (velocidade == 2)
                        {
                            Thread.Sleep(150);
                            Console.Clear();
                        }
                        else if (velocidade == 4)
                        {
                            Thread.Sleep(400);
                            Console.Clear();
                        }
                        else if (velocidade == 8)
                        {
                            if (j == (i / 8) - 1)
                            {
                                return 4;
                            }
                            else
                            {
                                Thread.Sleep(700);
                                Console.Clear();
                            }
                        }
                    }
                }
            }
            return -1;

        }
        public static void Loading()
        {
            string cor = "\u001b[38;2;173;216;230m";
            for (int k = 0; k < 5; k++)
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (i == 1)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine(cor + "      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 2 || i == 6)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                                   ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                                   ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                                 ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                         ▄▄▄▄▄▄                                   ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                       ▄████████▄        ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                      ████████████     ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████        ▀████████▀     ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████          ▀▀▀▀▀▀        ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀                          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 3 || i == 5)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                                   ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                                   ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                        ▄▄▄▄▄▄                                  ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                       ▄████████▄                                 ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                      ████████████       ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                      ████████████     ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████        ▀████████▀     ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████          ▀▀▀▀▀▀       ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████                        ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀                          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 4)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                                   ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀          ▄▄▄▄▄▄                             ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                      ▄████████▄                            ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                      ████████████                                ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                      ████████████       ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                      ████████████     ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████      ▀████████▀     ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████          ▀▀▀▀▀▀       ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████                       ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████                        ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀                          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                }






                for (int i = 1; i <= 6; i++)
                {
                    if (i == 1)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 2 || i == 6)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                         ▄▄▄▄▄▄            ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄        ▄████████▄        ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄     ████████████     ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████     ▀████████▀     ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀        ▀▀▀▀▀▀        ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀                          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 3 || i == 5)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                        ▄▄▄▄▄▄             ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                       ▄████████▄            ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄       ████████████       ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄     ████████████     ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████     ▀████████▀     ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████       ▀▀▀▀▀▀       ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀                      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀                          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 4)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                          ▄▄▄▄▄▄                  ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                      ▄████████▄   ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                      ████████████          ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄       ████████████       ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄     ████████████     ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████     ▀████████▀     ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████       ▀▀▀▀▀▀       ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████                    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀                      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀                          ▀▀▀▀▀▀   ");
                    }
                }




                for (int i = 1; i <= 7; i++)
                {
                    if (i == 1 || i == 7)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄          ▄▄▄▄▄▄   ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄      ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀      ▀████████▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀   ");
                    }
                    else if (i == 2 || i == 6)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                           ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                         ▄▄▄▄▄▄");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄        ▄████████▄ ");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄     ████████████");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████     ▀████████▀");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀        ▀▀▀▀▀▀ ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀             ");
                    }
                    else if (i == 3 || i == 5)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                            ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                        ▄▄▄▄▄▄ ");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                       ▄████████▄");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄       ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄     ████████████");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████    ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████     ▀████████▀");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████       ▀▀▀▀▀▀");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀         ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀             ");
                    }
                    else if (i == 4)
                    {
                        Thread.Sleep(60);
                        Console.Clear();
                        Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                        Console.WriteLine("      ▄███▄          ▄██████████████▄    ▄███████████████▄    ██████████████▄      ████   ██████▄          ████   ▄█████████████████▄                                        ");
                        Console.WriteLine("      █████          ████████████████   ▄████▀▀▀▀▀▀▀▀▀████▄   ████▀▀▀▀▀▀▀▀▀███▄    ▀▀▀▀   ████████         ████   ██████████████████▀                                          ▄▄▄▄▄▄  ");
                        Console.WriteLine("      █████          ████▀      ▀████   ████           ████   ████          ███▄          ████ ████        ████   ████▀                                                      ▄████████▄");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████  ████       ████   ████                                                      ████████████");
                        Console.WriteLine("      █████          ████        ████   ████           ████   ████          ████   ████   ████   ████      ████   ████                         ▄▄▄▄▄▄          ▄▄▄▄▄▄       ████████████");
                        Console.WriteLine("      █████          ████        ████   █████▄▄▄▄▄▄▄▄▄█████   ████          ████   ████   ████    ████     ████   ████                       ▄████████▄      ▄████████▄     ████████████");
                        Console.WriteLine("      █████          ████        ████   ███████████████████   ████          ████   ████   ████     ████    ████   ████       ██████████     ████████████    ████████████     ▀████████▀");
                        Console.WriteLine("      █████          ████        ████   █████▀▀▀▀▀▀▀▀▀█████   ████          ████   ████   ████      ████   ████   ████          █████       ████████████    ████████████       ▀▀▀▀▀▀");
                        Console.WriteLine("      █████          ████▄      ▄████   ████           ████   ████          ███▀   ████   ████       ████  ████   ████▄        ▄█████       ████████████    ████████████       ");
                        Console.WriteLine("      ███████████▄   ████████████████   ████           ████   ████▄▄▄▄▄▄▄▄▄███▀    ████   ████        █████████   ███████████████████        ▀████████▀      ▀████████▀         ");
                        Console.WriteLine("      ▀██████████▀   ▀██████████████▀   ███▀           ▀███   ██████████████▀      ████   ████         ▀███████   ▀█████████████████▀          ▀▀▀▀▀▀          ▀▀▀▀▀▀             ");
                    }
                }
            }
            Console.Beep(1500, 300);
            Console.ForegroundColor = ConsoleColor.White;


        }
        public static void TelaInicial()
        {
            int psl, psc, i = 0;
            bool play = false, continuar = false, play2 = false;
            while (play2 == false)
            {
                while (play == false)
                {

                    if (i == 0)
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                     █▄                                             ");
                        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███▄              ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("      ████████████████████            █        Jogar          █      ");
                        Console.WriteLine("      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀███▀              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                     █▀                                           ");
                    }
                    else
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                                                                 ");
                        Console.WriteLine("                                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("                                      █        Jogar          █      ");
                        Console.WriteLine("                                       ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                                                                ");
                    }
                    if (i == 1)
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                     █▄                                             ");
                        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███▄              ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("      ████████████████████            █       Créditos        █      ");
                        Console.WriteLine("      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀███▀              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                     █▀                                           ");
                    }
                    else
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                                                                 ");
                        Console.WriteLine("                                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("                                      █       Créditos        █      ");
                        Console.WriteLine("                                       ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                                                                ");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                     █▄                                             ");
                        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███▄              ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("      ████████████████████            █        Contato        █      ");
                        Console.WriteLine("      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀███▀              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                     █▀                                           ");
                    }
                    else
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                                                                 ");
                        Console.WriteLine("                                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("                                      █        Contato        █      ");
                        Console.WriteLine("                                       ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                                                                ");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                     █▄                                             ");
                        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███▄              ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("      ████████████████████            █         Sair          █      ");
                        Console.WriteLine("      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀███▀              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                     █▀                                           ");
                    }
                    else
                    {
                        Console.WriteLine("                                                                    ");
                        Console.WriteLine("                                                                 ");
                        Console.WriteLine("                                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄    ");
                        Console.WriteLine("                                      █         Sair          █      ");
                        Console.WriteLine("                                       ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀      ");
                        Console.WriteLine("                                                                ");
                    }
                    Console.WriteLine("\n\nDigite 'p' para confirmar, ou 'w' para subir, ou 's' para descer a seta\n");
                    char resp = Console.ReadKey().KeyChar;
                    if (resp == 'w' && i <= 3 && i > 0)
                    {
                        i--;
                    }
                    else if (resp == 's' && i >= 0 && i < 3)
                    {
                        i++;
                    }
                    else if (resp == 'p')
                    {
                        play = true;
                    }
                    Console.Clear();
                }
                continuar = false;
                while (continuar == false)
                {
                    if (i == 0)
                    {
                        continuar = true;
                        Console.Clear();
                        play2 = true;
                    }
                    else if (i == 1)
                    {
                        Design.Escrita("Desenvolvedor Sênior: Schroeder");
                        Thread.Sleep(800);
                        Design.Escrita("\n\nTech Lead: João Lagoas");
                        Thread.Sleep(800);
                        Design.Escrita("\n\nEngenheiros de Testes: Antonio Netto, William Motta");
                        Thread.Sleep(800);
                        Design.Escrita("\n\nConsultores: João Cesar e Bianca");
                        Thread.Sleep(800);
                        Design.Escrita("\n\nDesigner: Schroeder");
                        Thread.Sleep(400);
                        Design.Escrita("\n\nAgradeço aos envolvidos S2");
                        Thread.Sleep(3000);
                        Console.Clear();

                        continuar = true;
                        play2 = false;
                        play = false;
                    }
                    else if (i == 2)
                    {
                        Console.Clear();
                        Design.Escrita("willian.lima1408@gmail.com");
                        Thread.Sleep(10000);
                        continuar = true;
                        play2 = false;
                        play = false;
                        Console.Clear();
                    }
                    else if (i == 3)
                    {
                        break;
                    }
                }
            }
        }
    }
    

}

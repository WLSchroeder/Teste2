using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{  
    internal class Sudoku
    {
        public static Jogador Sorteia(Jogador jogador1)
        {
            int indiceSorteado = 0;
            int[,] matriz = new int[9, 9];
            int tentativas = 0;
            int linha = 0, coluna = 0, cubo = 0, gambiarra1, gambiarra2, teste1, teste2;
            bool PodeIrLinha = true, PodeIrColuna = true, PodeIrCubo = true, PodeIr = false;
            List<int> sort1 = new List<int>();


            Random random = new Random();
            for (linha = 0; linha < 9; linha++)
            {
                sort1.Clear();
                sort1.Add(1);
                sort1.Add(2);
                sort1.Add(3);
                sort1.Add(4);
                sort1.Add(5);
                sort1.Add(6);
                sort1.Add(7);
                sort1.Add(8);
                sort1.Add(9);
                for (coluna = 0; coluna < 9; coluna++)
                {
                    
                    PodeIr = false; // adicionei pois se o numero sair 1x do while ele não virava true e não poderia retornar ao while nunca mais, acabou resolvendo os números ficarem repetindo igual = [8,8,8,8,8,8]
                    while (!PodeIr)
                    {
                        
                        PodeIrLinha = true;
                        PodeIrColuna = true;
                        PodeIrCubo = true;

                        indiceSorteado = random.Next(0, sort1.Count);
                        for (int a = 0; a < 9; a++)
                        {
                            if (sort1[indiceSorteado] == matriz[a, coluna])
                            {
                                PodeIrColuna = false;
                            }

                        }
                        for (int b = 0; b < 9; b++)
                        {
                            if (sort1[indiceSorteado] == matriz[linha, b])
                            {
                                PodeIrLinha = false;
                            }
                        }
                        int ii = VerificaBloco(linha);
                        int jj = VerificaBloco(coluna);
                        for (int i = (3*ii); i <(3*ii)+3; i++) 
                        {
                            for(int j = (3 * jj); j <(3 * jj)+3; j++)
                            {
                                if(sort1[indiceSorteado] == matriz[i, j])
                                {
                                    PodeIrCubo = false;
                                }
                             
                            }
                        }
                        
                        
                        if (PodeIrLinha)
                        {
                            if (PodeIrColuna)
                            {
                                if (PodeIrCubo)
                                {
                                    PodeIr = true;
                                }
                            }
                        }
                        tentativas++;
                        if (tentativas > 20)
                        {
                            coluna=0;
                            tentativas = 0;
                            sort1.Clear();
                            sort1.Add(1);
                            sort1.Add(2);
                            sort1.Add(3);
                            sort1.Add(4);
                            sort1.Add(5);
                            sort1.Add(6);
                            sort1.Add(7);
                            sort1.Add(8);
                            sort1.Add(9);
                        }
                    }

                    matriz[linha, coluna] = sort1[indiceSorteado];
                    Console.WriteLine(matriz[linha, coluna] + "  " + linha + "   " + coluna);
                    sort1.RemoveAt(indiceSorteado);



                }
            }
            
            return jogador1 ;

        }
        public static int VerificaBloco( int k)
        {
           if(0<=k && k < 3)
            {
                return 0;
            }
           else if(3 <=k && k < 6)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }

}

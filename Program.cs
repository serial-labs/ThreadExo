using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //bool v = false;
            //Console.WriteLine("donnez un entier positif inferieur a 100");
            //n = int.Parse(Console.ReadLine());
            //while (v == false)
            //{
            //    if (n > 100)
            //    {
            //        Console.WriteLine("donnez un entier positif inferieur a 100");
            //        n = int.Parse(Console.ReadLine());
            //    }
            //    else if (n < 100)
            //    {
            //        Console.WriteLine("merci pour le nombre {0}", n);
            //        v = true;
            //    }
            //}
            //Console.ReadLine();


            //5.7

            //for(int i = 7; i <= 20; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            //const int nbmax = 30;
            //char c;
            //int i = 0;
            //Console.WriteLine("mot en min qui finit avec un espace");
            //string ligne = Console.ReadLine();
            //do
            //{
            //    c = ligne[i];
            //    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
            //    {
            //        Console.Write(c);
            //    }
            //    i++;
            //} while ((c != ' ') && (i < nbmax));


            



            Console.ReadLine();
        }



        
        
    }


    public static class Exos
    {
        public static int n = 0,m=0;
        //public static int[,]matrice = new int[n,m];
        public static int[,] initMatrice(int[,]matrice1,int[,]matrice2)
        {
            matrice1 = new int[n, m];
            matrice2 = new int[n, m];
            int[,] M=new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    M[i, j] = matrice1[i, j] + matrice2[i, j];
                }
            }
            return M;
        }

        public static int[] fusionTab(int[] T1, int[] T2)
        {
            int[] T = new int[(T1.Length+T2.Length)];
            int iT1 = 0, iT2 = 0;
            for(int i=0;i<(T1.Length + T2.Length); i++)
            {
                if (T1[iT1] <= T2[iT2])
                {
                    T[i] = T1[iT1];
                    iT1++;
                }
                else
                {
                    T[i] = T2[iT2];
                    iT2++;
                }
            }
            return T;
        }

        public static int chercheEle(int[] T, int val)
        {
            for(int i = 0; i < T.Length - 1; i++)
            {
                if (T[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int chercheMin(int[] T)
        {
            int min = T[0];
            for (int i = 0; i < T.Length - 1; i++)
            {
                if (T[i] < min)
                {
                    min = T[i];
                }
            }
            return min;
        }

        //public static float zero()
        //{

        //}



    }
}

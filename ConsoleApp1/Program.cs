using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
  
    class Program
    {

        static List<int> hatalar;
        static List<List<int[,]>> tumfiltreler;
        static int[] currkupon;

        static void Main(string[] args)
        {

            hatalar = new List<int>();
            tumfiltreler = new List<List<int[,]>>();

            currkupon = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(currkupon[i]);
            }

            Console.ReadLine();
            hatalar.Add(0);

            for (int i = 0; i < 14; i++)
            {
                tumfiltreler.Add(new List<int[,]>());
            }

            
              int max = 14;

            for (int i = 0; i < 14; i++)
            {

                for (int a = 0; a < max - i; a++)
                {
                    int[,] f = new int[3, 3];

                    
                    
                    tumfiltreler[i].Add(f);

                    

                }

                

            }

            tumfiltreler[0][0][0, 0] = 1;

            int s0= Kuponsayi(0, 0,0);
            int s1 = Kuponsayi(0, 1,0);
            int s2 = Kuponsayi(0, 2,0);

            Console.WriteLine(s0+s1+s2);

            Console.ReadLine();



        }

        static int Kuponsayi(int level,int sonuc,int hatasayisi) {

            if (level == 14)
            {
                return 1;
            }

            currkupon[level] = sonuc;

            for (int i = 0; i < level-1; i++)
            {
                if (tumfiltreler[i][level-i-1][currkupon[i],sonuc]==1)
                {
                    hatasayisi++;
                }
            }

            if (!hatalar.Contains(hatasayisi))
            {
                return 0;
            }

         
            int s0 = Kuponsayi(level+1, 0, hatasayisi);
            int s1 = Kuponsayi(level+1, 1, hatasayisi);
            int s2 = Kuponsayi(level+1, 2, hatasayisi);


            return s0 + s1 + s2;


          
            
        }


    }
}

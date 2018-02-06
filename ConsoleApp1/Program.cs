using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    struct olusankupon
    {
        public short hata;
        public Sonuc[] kupon;
    };


    [Flags]


    public enum Sonuc : byte
    {
        bos = 0x0,
        m1 = 0x1,
        m0 = 0x2,
        m2 = 0x4,
        m10 = m1 | m0, m01 = m1 | m0,
        m02 = m2 | m0, m20 = m2 | m0,
        m12 = m1 | m2, m21 = m1 | m2,
        m102 = m1 | m0 | m2,
    }


    [Flags]
    public enum ikili : short
    {
        // Decimal     // Binary
        sbos = 0,
        s11 = 1,        // 00000000
        s10 = 2,        // 00000001
        s12 = 4,        // 00000010
        s01 = 8,        // 00000100
        s00 = 16,        // 00001000
        s02 = 32,       // 00010000
        s21 = 64,       // 00100000
        s20 = 128,       // 01000000
        s22 = 256,      // 10000000

    }

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

            var sira1 = new List<int[,]>();
            var sira2 = new List<int[,]>();
            var sira3 = new List<int[,]>();
            var sira4 = new List<int[,]>();
            var sira5 = new List<int[,]>();
            var sira6 = new List<int[,]>();
            var sira7 = new List<int[,]>();
            var sira8 = new List<int[,]>();
            var sira9 = new List<int[,]>();
            var sira10 = new List<int[,]>();
            var sira11 = new List<int[,]>();
            var sira12 = new List<int[,]>();
            var sira13 = new List<int[,]>();
            var sira14 = new List<int[,]>();

            

            tumfiltreler.Add(sira1);
            tumfiltreler.Add(sira2);
            tumfiltreler.Add(sira3);
            tumfiltreler.Add(sira4);
            tumfiltreler.Add(sira5);
            tumfiltreler.Add(sira6);
            tumfiltreler.Add(sira7);
            tumfiltreler.Add(sira8);
            tumfiltreler.Add(sira9);
            tumfiltreler.Add(sira10);
            tumfiltreler.Add(sira11);
            tumfiltreler.Add(sira12);
            tumfiltreler.Add(sira13);
            tumfiltreler.Add(sira14);

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

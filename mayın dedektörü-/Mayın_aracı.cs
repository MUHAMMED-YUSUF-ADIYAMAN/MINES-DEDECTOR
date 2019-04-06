using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_dedektörü_
{
    class Mayın_aracı
    {
        public int i = 0;
        public int X = 1;
        public int Y = 1;
        public int skor = 0;
        public int hak = 10;

        public void ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("M");
        }
        public void hareket(ConsoleKeyInfo tus)
        {
            if (hak != 0)
            {
                if (tus.Key == (ConsoleKey.RightArrow) || (tus.Key == ConsoleKey.D)) X++;
                if (tus.Key == (ConsoleKey.LeftArrow) || (tus.Key == ConsoleKey.A)) X--;
                if (tus.Key == (ConsoleKey.DownArrow) || (tus.Key == ConsoleKey.S)) Y++;
                if (tus.Key == (ConsoleKey.UpArrow) || (tus.Key == ConsoleKey.W)) Y--;
                if (tus.Key == (ConsoleKey.Spacebar) || (tus.Key == ConsoleKey.B)) hak--;
                if (X == 31) X = 30;
                if (X == -1) X = 0;
                if (Y == 31) Y = 30;
                if (Y == -1) Y = 0;
            }
        }
        public void mayinaramasi()
        {
            Console.SetCursorPosition(35, 23);
            Console.WriteLine("{0} hakkiniz kaldı.", hak);
            if (hak == 0)
            {
                Console.SetCursorPosition(11, 16);
                Console.WriteLine("GAME OVER");

            }

        }

        public bool Buldugunda(Mayın oanki)

        {
            bool sonuc = false;

            if (((X == oanki.dizi[0]) && (Y == oanki.dizi2[0]) || (X == oanki.dizi[1]) && (Y == oanki.dizi2[1]) || (X == oanki.dizi[2]) && (Y == oanki.dizi2[2]) || (X == oanki.dizi[3]) && (Y == oanki.dizi2[3]) || (X == oanki.dizi[4]) && (Y == oanki.dizi2[4])) && (Console.ReadKey().Key == ConsoleKey.B) && (hak != 0))

            {
                skor++;
                sonuc = true;
                {
                    Console.SetCursorPosition(X, Y);
                    Console.WriteLine("Y");

                }
                return sonuc;
            }

            return false;

        }
        public void puan()
        {

            {
                Console.SetCursorPosition(35, 20);
                Console.WriteLine("skor:" + skor);
                if (skor == 6)
                {
                    hak = 0;
                    Console.SetCursorPosition(11, 18);
                    Console.WriteLine("Oyun Acıgı Kullandıgınız Icin BANLANDINIZ.");
                }
            }

        }


    }
}

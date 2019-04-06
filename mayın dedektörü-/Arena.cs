using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_dedektörü_
{
    class Arena
    {
        public int X = 0;
        public int Y = 0;
        public void alan()
        {

            for (X = 0; X < 32; X++)
                for (Y = 0; Y < 32; Y++)
                {
                    if (X == 0 || X == 31)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine("|");
                    }
                    if (Y == 0 || Y == 31)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine("-");
                    }
                }
            Console.SetCursorPosition(21, 31);
            Console.WriteLine("Made by MYA");
            {
                Console.SetCursorPosition(35, 3);
                Console.WriteLine("B ye basarak bomba imha edilir.");
                Console.SetCursorPosition(35, 4);
                Console.WriteLine("Yön veya W,A,D,E tuşları ile oynanır ");
                Console.SetCursorPosition(35, 5);
                Console.WriteLine("Mayın gözükmemesi icin mayın clasından mayın göster fonksiyonunu içindeki ");
                Console.SetCursorPosition(35, 6);
                Console.WriteLine("a karekterini veya Console.WriteLine komutunuz siliniz.");
                Console.SetCursorPosition(35, 7);
                Console.WriteLine("2 birim kareden sonra mayin birakir (a--a)");
            }
        }


    }
}

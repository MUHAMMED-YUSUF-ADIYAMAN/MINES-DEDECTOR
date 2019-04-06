using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_dedektörü_
{
    class Mayın
    {

        public int[] dizi = new int[5];
        public int[] dizi2 = new int[5];
        Random sayiGen = new Random();


        public void MayınUret()

        {

            for (int i = 0; i < 5; i++)
            {

                dizi[i] = sayiGen.Next(2, 31);
                dizi2[i] = sayiGen.Next(2, 31);

                if (i > 0)
                {
                    
                        for (int k = 0; k < i; k++)
                        {
                            if (((Math.Abs(dizi[k] - dizi[i])) < 3) || ((Math.Abs(dizi2[k] - dizi2[i]) < 3)))
                            {
                                i--;
                                continue;
                            }
                        }

                }
                Console.SetCursorPosition(dizi[i], dizi2[i]);
            }



        }
        public void mayıngos()
        {
            {
                for (int a = 0; a < 5; a++)
                {
                    Console.SetCursorPosition(dizi[a], dizi2[a]);
                    Console.WriteLine("a");
                }
            }
        }







    }
}

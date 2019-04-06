using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_dedektörü_
{
    class Program
    {
        static void Main(string[] args)
        {
                    Mayın_aracı M_A = new Mayın_aracı();
                    Arena y = new Arena();
                    Mayın m = new Mayın();

                    M_A.ciz();
                    y.alan();
                    m.MayınUret();
                    m.mayıngos();



                    ConsoleKeyInfo tus;
                    do
                    {


                        tus = Console.ReadKey();
                       Console.ForegroundColor = ConsoleColor.Red;
                        M_A.hareket(tus);
                        M_A.ciz();
                        m.mayıngos();
                        y.alan();


                        if (M_A.Buldugunda(m) == true)

                        {

                            Console.Beep();

                        }

                        M_A.puan();
                        M_A.mayinaramasi();


                    } while (tus.Key != ConsoleKey.Escape);

            
                }
            }
        }
    


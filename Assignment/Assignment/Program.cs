using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
 

            Pack myPack = new Pack();
            myPack.PrintPack();
            Console.WriteLine(" [1] - Fisher-Yates Shuffle, " +
                "[2] - Riffle Shuffle, [3] - No Shuffle");

            Pack.shuffleCardPack(1);
            myPack.PrintPack();
            Console.WriteLine("");
            Pack.shuffleCardPack(2);
            myPack.PrintPack();
            Console.WriteLine("");
            Pack.shuffleCardPack(3);
            
            Console.WriteLine("\nDeal card:\n");
            Console.WriteLine(Pack.dealCard().GetCard);

            Console.WriteLine("\n\n");
            myPack.PrintPack();


            Console.ReadLine();
        }
    }
}

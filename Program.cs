using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int qt, di, ni, pe, input;
            qt = 0;
            di = 0;
            ni = 0;
            pe = 0;

            int qCount = 3;
            int dCount = 10;
            int nCount = 17;
            int pCount = 32;

            Console.WriteLine("Please enter your total amount (in cents):");
            input = int.Parse(Console.ReadLine());

            while (input > 0)
            {
                if ((input >= 25) && (qCount > 0))
                {
                    input -= 25;
                    qt += 1;
                    qCount -= 1;
                }
                else if ((input >= 10) && (dCount > 0))
                {
                    input -= 10;
                    di += 1;
                    dCount -= 1;
                }
                else if ((input >= 5) && (nCount > 0))
                {
                    input -= 5;
                    ni += 1;
                    nCount -= 1;
                }
                else if (pCount > 0)
                {
                    input -= 1;
                    pe += 1;
                    pCount -= 1;
                }
                else { Console.WriteLine($"The machine has run out of change - IOU: {input} cents."); break; }
            }
            Console.WriteLine($"Your change is {qt} quarter(s), {di} dime(s), {ni} nickel(s), and {pe} cent(s).");
        }
    }
}

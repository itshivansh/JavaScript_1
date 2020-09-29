using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pattern";
            int i, j,k;
            for (i = 1; i <= 6; i++)
            {
                k = 1;
                for (j = 1; j <= 11; j++)
                {
                   if ((j>=i) && (j<=12-i) && (k==1))
                    {
                        Console.Write("*");
                        k = 0;
                    }else
                    {
                        Console.Write(" ");
                        k = 1;
                    }
                }
                   Console.Write("\n");
            }
            
        }
    }
}

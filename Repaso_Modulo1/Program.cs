namespace Repaso_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================");
            Console.WriteLine("Repaso bucles");

            /*
             * 
             * * 
             * * * 
             * * * *
             * * * * *
             */
            int i, j, filas;
            Console.WriteLine("Ingrese el número de filas");
            filas = Convert.ToInt32(Console.ReadLine());    

            for ( i = 1; i <= filas; i++) {

                for ( j = 1; j <= i; j++)
                {
                    
                        Console.Write('*');

                }
                Console.Write('\n');

            }


            for (int k = 1; k <= filas; k++)
            {

                for (int l = 1; l <= k; l++)
                {

                    Console.Write(l);

                }
                Console.Write('\n');

            }

            for (int m = 1; m <=5 ; m++)
            {

                for (int n = 5; 1 <= n; n--)
                {
                    Console.Write('-');
                    if (m == n)
                    {
                        for(int o = 1; o <= m; o++)
                        {
                            Console.Write("* ");
                        }
                        break;
                    }
                }
                Console.Write('\n');
            }


            //for (int k = 5; k >= 1; k--)
            //{

            //    for (int l = 1; l <= 5; l++)
            //    {

            //        if (k == l)
            //        {
            //            Console.WriteLine('*' + " ");
            //            break;
            //        }
            //        Console.Write('*' + " ");
            //    }

            //}

        }
    }
}

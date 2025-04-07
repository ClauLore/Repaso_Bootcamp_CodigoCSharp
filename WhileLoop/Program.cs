namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los while loop");
            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine("El valor es: " + contador);
                contador++;
            }
            Console.WriteLine("Se acabó el bucle");

            //Tabla de multiplicar
            int valorTabla, contador1=0;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            valorTabla = Convert.ToInt32(Console.ReadLine());

            while (contador1 <= 12)
            {
                int resultado;
                Console.WriteLine("El número es " + contador1);
                resultado = valorTabla * contador1;
                Console.WriteLine("La tabla del número  " + valorTabla + "es igual a " + valorTabla + " x " + contador1 + " = " + resultado);

                contador1++;
            }


            int inicio = 1;
            while (inicio <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                inicio++;
            }

            ///////////////////////////
            ///Reto patrón
            ///
            int inicio2 = 1;
            while (inicio2 <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    if (inicio2 == b)
                    {
                        break;
                    }
                    b++;
                }
                Console.WriteLine();
                inicio2++;
            }

            ///////////////////////////
            ///Reto patrón2
            ///
            int inicio3 = 1;
            while (inicio3 <= 5)
            {
                int b = 5;
                while (b >= 1)
                {
                   
                    if (inicio3 == b)
                    {
                        int c = 1;
                        while (c <= inicio3)
                        {
                            Console.Write(c + " ");

                            c++;
                        }
                        break;

                    }
                    else
                    {
                        Console.Write("* ");
                    }
                        b--;
                }
                Console.WriteLine();
                inicio3++;
            }

            int contadorDO = 1;
            do
            {
                Console.WriteLine(contadorDO);
                contadorDO++;
            }
            while (contadorDO <= 6);


            //TAREA: Tabla de multiplicar Bucle for
            Console.WriteLine("====================================");
            Console.WriteLine("===TABLA DE MULTIPLICAR BUCLE FOR===");
            Console.WriteLine("====================================");
            Console.WriteLine("Ingrese el número para listar la tabla de multiplicar:");
            int numeroTM = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                int resultado = numeroTM * i;
                Console.WriteLine("La tabla del número  " + numeroTM + " es igual a " + numeroTM + " x " + i + " = " + resultado);
            }

            ///////////////////////////
            ///Reto patrón 1 for
            ///
            Console.WriteLine("====================================");
            Console.WriteLine("===TAREA BUCLE FOR===");
            Console.WriteLine("====================================");
            for (int l = 1; l <= 5; l++)
            {
                for (int m = 1; m <= 5; m++)

                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }

            ///////////////////////////
            ///Reto patrón 2 for
            ///
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= 5;k++)
                {
                    Console.Write(k + " ");
                    if (j == k)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }


        }
    }

}
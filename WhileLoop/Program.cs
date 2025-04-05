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
            valorTabla =Convert.ToInt32(Console.ReadLine());

            while (contador1 <= 12)
            {
                int resultado;
                Console.WriteLine("El número es " + contador1);
                resultado = valorTabla * contador1;
                Console.WriteLine("La tabla del número  " + valorTabla+ "es igual a "+valorTabla+" x "+contador1+" = "+resultado);

                contador1++;
            }


            int inicio = 1;
            while(inicio <= 5)
            {
                int b = 1;
                while(b<=5)
                {
                    Console.Write(b+ " ");
                    b++;
                }
                Console.WriteLine();
                inicio++;
            }
        }
    }

}
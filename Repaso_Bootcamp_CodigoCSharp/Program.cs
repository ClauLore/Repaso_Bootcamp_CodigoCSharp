namespace Repaso_Bootcamp_CodigoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int edad = 18;
            int dni = 25485258;
            double numeroDecimal = 10.00;
            char caracter = '1';
            bool esMayordeEdad = true;
            string nombre = "Claudia"; // tipo de datos por referencia


            if (edad > 18 && dni != 46547578)//Operador relacional
            {
                Console.WriteLine("Soy mayor de edad");
            }
            if (dni == 25485258 || !esMayordeEdad)
            {
                Console.WriteLine("Sí, es mi número de DNI");
            }
            else {
                Console.WriteLine("No es mi DNI");
            }

            Console.WriteLine(numero);
            Console.WriteLine("Hello, World!");

            //Días de la semana
            Console.WriteLine("===========================");
            Console.WriteLine("Días de la semana");
            string diaSemana = "Lunes";


            switch (diaSemana) 
            {
                case "Lunes":
                    Console.WriteLine("El día es lunes");
                    break;
                case "Martes":
                    Console.WriteLine("El día es martes");
                    break;
                default:
                    Console.WriteLine("No es un día de la semana");
                    break;
            }
            Console.WriteLine("Saliendo de la aplicación");

            //Comprobar si un número es impar
            Console.WriteLine("");
            Console.WriteLine("========================================");
            int numeroaComprobar;
            Console.WriteLine("Ingresa el valor a comprobar: ");
            numeroaComprobar = Convert.ToInt32(Console.ReadLine());

            if (numeroaComprobar % 2 == 0)
            {
                Console.WriteLine("El número es par");

            }
            else 
            {
                Console.WriteLine("El número es impar");
            }





        }
    }
}

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
            Console.WriteLine("Ingresa el valor a comprobar: ");
            Console.WriteLine("========================================");
            int numeroaComprobar;
            numeroaComprobar = Convert.ToInt32(Console.ReadLine());

            if (numeroaComprobar % 2 == 0)
            {
                Console.WriteLine("El número es par");

            }
            else 
            {
                Console.WriteLine("El número es impar");
            }


            //Comprobar si un número es impar
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("Número mayor de 3 números: ");
            Console.WriteLine("========================================");
            int primerNumero, segundoNumero, tercerNumero, numeroMayor;
            Console.WriteLine("Ingrese el primer número: ");

            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");

            segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");

            tercerNumero = Convert.ToInt32(Console.ReadLine());
            
            if (primerNumero > segundoNumero)
            {
                numeroMayor = primerNumero;
                if (numeroMayor > tercerNumero)
                {
                    Console.WriteLine("El número mayor es el primer número: " + numeroMayor);
                }
                else
                {
                    Console.WriteLine("El número mayor es el tercer número: " + tercerNumero);
                }
            }
            else
            {
                numeroMayor = segundoNumero;
                if (numeroMayor > tercerNumero)
                {
                    Console.WriteLine("El número mayor es el segundo número: " + numeroMayor);
                }
                else
                {
                    Console.WriteLine("El número mayor es el tercer número: " + tercerNumero);
                }
            }



            //Comprobar si has escogido círculo o rectángulo
            int li_opcion;

            Console.WriteLine("");
            Console.WriteLine("=====================CALCULAR ÁREAS===========================");
            Console.WriteLine("1. ÁREA DEL CÍRCULO");
            Console.WriteLine("2. ÁREA DEL RECTÁNGULO");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingresa la opción para comprobar: ");
            li_opcion = Convert.ToInt32(Console.ReadLine());

            switch(li_opcion)
            {
                case 1:
                    decimal ld_radio;
                    Console.WriteLine("Ingrese el radio del círculo: ");
                    ld_radio = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("El área del círculo es: " + (Convert.ToDecimal(Math.PI)* Convert.ToDecimal(Math.Pow(Convert.ToDouble(ld_radio),2 ))));

                    break;
                case 2:
                    decimal ld_base, ld_altura;

                    Console.WriteLine("Ingrese la base del rectángulo: ");
                    ld_base = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo: ");
                    ld_altura = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("El área del rectángulo es: " + (ld_base*ld_altura));

                    break;
                default: Console.WriteLine("La opción ingresado no existe!!");
                    break ;
            }



        }
    }
}

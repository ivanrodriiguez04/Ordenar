namespace Ordenar 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 11102023 -> irm
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 11102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        { 
            //Variables
            int num1, num2, num3;
            //Le asignamos valor a las variables
            num1 = PedirNumero();
            num2 = PedirNumero();
            num3 = PedirNumero();

            //Comenzamos el bucle para ordenar los numeros introducidos
            if (num1>num2) 
            {
                int cambio = num1;
                num1 = num2;
                num2 = cambio;
            }
            if (num2 > num3)
            {
                int cambio = num2;
                num2 = num3;
                num3 = cambio;
            }
            if (num1 > num2)
            {
                int cambio = num1;
                num1 = num2;
                num2 = cambio;
            }

            //Mostramos por consola el orden de los numeros ya ordenados
            Console.WriteLine("Orden: {0},{1},{2}",num1,num2,num3);
        }

        /// <summary>
        /// Metodo para pedir los numeros necesarios
        /// </summary>
        /// <returns></returns>
        static int PedirNumero() 
        {
            int numero;
            Console.WriteLine("Introduzca un numero");
            numero=Convert.ToInt32(Console.ReadLine());

            return numero;
        }

    }
}

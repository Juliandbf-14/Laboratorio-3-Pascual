namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar un vector de números reales
            double[] numerosReales = { 1.5, 2.0, 3.7, 4.2, 5.1 };

            // Inicializar la variable para almacenar la suma
            double suma = 0.0;

            // Utilizar un bucle para sumar los elementos del vector
            foreach (double numero in numerosReales)
            {
                Console.WriteLine($"El número es: {numero}");
                suma += numero;
            }

            // Mostrar la suma en la consola
            Console.WriteLine("\nLa suma de los elementos del vector es: " + suma);

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Dale a la tecla enter para terminar el programa..");
            Console.ReadLine();
        }
    }
}

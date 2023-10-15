namespace EjercicioCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar un vector de cadenas
            string[] palabras = { "Auto", "moto", "barco", "helicóptero", "tren" };

            // Ordenar el vector alfabéticamente utilizando LINQ
            palabras = palabras.OrderBy(palabra => palabra).ToArray();

            // Mostrar el vector ordenado en la consola
            Console.WriteLine("Vector ordenado alfabéticamente:");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Presione la tecla enter para finalizar el programa.");
            Console.ReadLine();
        }
    }
}
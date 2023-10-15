namespace EjercicioUno
{
    class Program
    {
        static void Main()
        {
            // Declarar una matriz de enteros
            int[,] matrizEnteros = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            // Obtener las dimensiones de la matriz
            int filas = matrizEnteros.GetLength(0);
            int columnas = matrizEnteros.GetLength(1);

            // Mostrar el contenido de la matriz en la consola
            Console.WriteLine("Contenido de la matriz de enteros:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizEnteros[i, j] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila
            }

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Presione la tecla enter para finalizar el programa..");
            Console.ReadLine();
        }
    }
}

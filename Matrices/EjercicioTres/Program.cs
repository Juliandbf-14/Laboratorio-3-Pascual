namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar y crear una matriz
            int filas = 3;
            int columnas = 3;
            int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            // Definir el escalar
            int escalar = 2; // El valor por el cual se multiplicará la matriz

            // Declarar una matriz para almacenar el resultado
            int[,] matrizResultado = new int[filas, columnas];

            // Realizar la multiplicación de la matriz por el escalar
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizResultado[i, j] = matriz[i, j] * escalar;
                }
            }

            // Mostrar la matriz resultado en la consola
            Console.WriteLine("Matriz original:");
            MostrarInformacionMatriz(matriz);

            Console.WriteLine("Matriz multiplicada por el escalar:");
            MostrarInformacionMatriz(matrizResultado);

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Presiona la tecla enter para finalizar el programa");
            Console.ReadLine();
        }

        static void MostrarInformacionMatriz(int[,] matriz)
        {   
            // GetLength() sirve para obtener la cantidad de la dimensión de la matriz
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila
            }
        }
    }
}
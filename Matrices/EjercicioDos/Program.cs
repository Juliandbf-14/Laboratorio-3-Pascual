namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar y crear dos matrices con las mismas dimensiones
            int filas = 3;
            int columnas = 3;
            int[,] matrizA = {
            {4, 7, 8},
            {4, 5, 10},
            {1, 3, 10}
        };

            int[,] matrizB = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

            // Declarar una matriz para almacenar el resultado
            int[,] matrizResultante = new int[filas, columnas];

            // Realizar la suma de las matrices
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizResultante[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            // Mostrar la matriz resultado en la consola
            Console.WriteLine("Matriz A:");
            InformacionMatriz(matrizA);

            Console.WriteLine("Matriz B:");
            InformacionMatriz(matrizB);

            Console.WriteLine("Matriz Resultado:");
            InformacionMatriz(matrizResultante);

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Presione la tecla Enter para finalizar el programa..");
            Console.ReadLine();
        }

        static void InformacionMatriz(int[,] matriz)
        {
            // GetLength() sirve para obtener el tamaño de la dimensión 
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
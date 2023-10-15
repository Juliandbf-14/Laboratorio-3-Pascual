using System.Numerics;

namespace EjercicioCuatro
{
    class Program
    {
        static void Main()
        {
            // Declarar y crear una matriz cuadrada
            int n = 3; // El tamaño de la matriz (3x3 en este ejemplo)
            Complex[,] matriz = new Complex[n, n];

            // Rellenar la matriz con valores (pueden ser números complejos)
            matriz[0, 0] = new Complex(1, 0);
            matriz[0, 1] = new Complex(2, 0);
            matriz[0, 2] = new Complex(3, 0);
            matriz[1, 0] = new Complex(4, 0);
            matriz[1, 1] = new Complex(5, 0);
            matriz[1, 2] = new Complex(6, 0);
            matriz[2, 0] = new Complex(7, 0);
            matriz[2, 1] = new Complex(8, 0);
            matriz[2, 2] = new Complex(9, 0);

            // Calcular el determinante de la matriz
            Complex determinante = Determinante(matriz);

            // Mostrar el determinante en la consola
            Console.WriteLine("El determinante de la matriz es: " + determinante);

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine();
            Console.ReadLine();
        }

        static Complex Determinante(Complex[,] matriz)
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                throw new ArgumentException("La matriz no es cuadrada.");
            }
            int n = matriz.GetLength(0);
            if (n == 1)
            {
                return matriz[0, 0];
            }
            if (n == 2)
            {
                return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
            }
            Complex det = new Complex(0, 0);
            for (int j = 0; j < n; j++)
            {
                Complex subDeterminante = Determinante(GetSubMatrix(matriz, 0, j));
                det += matriz[0, j] * subDeterminante * (j % 2 == 0 ? 1 : -1);
            }
            return det;
        }

        static Complex[,] GetSubMatrix(Complex[,] matriz, int excludeRow, int excludeCol)
        {
            int n = matriz.GetLength(0);
            Complex[,] subMatrix = new Complex[n - 1, n - 1];

            for (int i = 0, r = 0; i < n; i++)
            {
                if (i == excludeRow)
                {
                    continue;
                }
                for (int j = 0, c = 0; j < n; j++)
                {
                    if (j == excludeCol)
                    {
                        continue;
                    }
                    subMatrix[r, c] = matriz[i, j];
                    c++;
                }
                r++;
            }
            return subMatrix;
        }
    }
}


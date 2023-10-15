namespace EjercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar un vector de números enteros
            int[] numeros = { 55, 100, 24, 84, 11, 10, 2 };

            // Inicializar las variables para el valor máximo y mínimo
            int valorMaximo = numeros[0];
            int valorMinimo = numeros[0];

            // Recorrer el vector para encontrar el máximo y el mínimo
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > valorMaximo)
                {
                    valorMaximo = numeros[i];
                }
                if (numeros[i] < valorMinimo)
                {
                    valorMinimo = numeros[i];
                }
            }

            // Mostrar los resultados en la consola
            Console.WriteLine("El elemento más grande es: " + valorMaximo);
            Console.WriteLine("El elemento más pequeño es: " + valorMinimo);

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Presiona la tecla enter para finalizar el programa..");
            Console.ReadLine();
        }
    }
}
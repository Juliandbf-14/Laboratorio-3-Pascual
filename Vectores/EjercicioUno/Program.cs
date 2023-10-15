
namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar un vector de números enteros y darle un tamaño de 5 
            int[] numeros = new int[5];

            // Inicializar el vector con valores
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Mostrar el contenido del vector en la consola
            Console.WriteLine("Contenido del vector de números enteros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Elemento " + i + ": " + numeros[i]);
            }

            // Esperar a que el usuario presione Enter antes de salir
            Console.WriteLine("Oprima la tecla enter para finalizar el programa..");
            Console.ReadLine();
        }
    }
}

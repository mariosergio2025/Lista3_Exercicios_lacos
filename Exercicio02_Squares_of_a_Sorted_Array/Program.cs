using System.Diagnostics.Contracts;

namespace Exercicio02_Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = { -7, -3, -2, 0, 2, 4, 7, 8 };

            int[] arrayQuadrada = new int[arrays.Length];

            int i = 0;
            int troca = 0;

            //transforma em quadrado
            foreach (int numeros in arrays)
            {

                arrayQuadrada[i] = numeros * numeros;
                i++;
            }

            /*//impressao dos resultados iniciais
            Console.Write("{ ");
            i = 0;
            while (i < arrayQuadrada.Length - 1)
            {

                Console.Write(arrayQuadrada[i] + " ,");

                i++;
            }
            Console.WriteLine(arrayQuadrada[i] + " }");
            */

            //ordenar ordem crecente
            for (int j = 0; j < arrays.Length; j++)
            {
                for (int k = 0; k < arrays.Length; k++)
                {
                    if (arrayQuadrada[j] < arrayQuadrada[k])
                    {
                        troca = arrayQuadrada[j];
                        arrayQuadrada[j] = arrayQuadrada[k];
                        arrayQuadrada[k] = troca;
                    }
                }

            }

            //impressao dos resultados
            Console.Write("{ ");
            i = 0;
            while (i < arrayQuadrada.Length - 1)
            {

                Console.Write(arrayQuadrada[i] + " ,");

                i++;
            }
            Console.Write(arrayQuadrada[i] + " }");


        }
    }
}

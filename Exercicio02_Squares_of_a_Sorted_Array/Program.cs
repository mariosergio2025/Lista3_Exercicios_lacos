using System.Diagnostics.Contracts;

namespace Exercicio02_Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista = Entrada(); //Entrado dos dados
            int n = lista.Count;

            int[] arrays =new int[n]; // = { -7, -3, -2, 0, 2, 4, 7, 8 };

            int[] arrayQuadrada = new int[arrays.Length];

            arrays = lista.ToArray();

            int i = 0;
            int troca = 0;

            //transforma em quadrado
            foreach (int numeros in arrays)
            {

                arrayQuadrada[i] = numeros * numeros;
                i++;
            }

            //impressao dos resultados iniciais
            Console.WriteLine();
            Console.WriteLine("O Array digitado foi: ");
                        
            Console.Write("{ ");
            i = 0;
            while (i < arrays.Length - 1)
            {

                Console.Write(arrays[i] + " ,");

                i++;
            }
            Console.WriteLine(arrays[i] + " }");
            Console.WriteLine();

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
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("O Array ao quadrado em ordem crescente: ");
            Console.Write("{ ");
            i = 0;
            while (i < arrayQuadrada.Length - 1)
            {

                Console.Write(arrayQuadrada[i] + " ,");

                i++;
            }
            Console.Write(arrayQuadrada[i] + " }");
            Console.WriteLine();


        }
        static List<int> Entrada()
        {
            Console.WriteLine("Squares of a Sroted Array");
            Console.WriteLine("-----------------------------------------");
            bool entrada = true;
            int cont = 0;
            List<int> elementos = new List<int>();
            string verEntrada = "";
            while (entrada)
            {
                Console.Write($"Digite <ENTER> para fim ou um numero inteiros para lista ({cont}):");
                verEntrada = Console.ReadLine();
                if (verEntrada != "")
                {
                    elementos.Add(Convert.ToInt32(verEntrada));
                    cont++;
                }
                else
                {
                    entrada = false;
                }
            }
            return elementos;
        }



    }
}

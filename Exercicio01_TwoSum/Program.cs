using System.ComponentModel;

namespace Exercicio01_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int[] array1 = { 3, 2, 4  };
            //int alvo = 6;
            List<int> lista = new List<int>();
            lista = Entrada();
            int n=lista.Count;
            int[] array1 = new int[n];
            array1=lista.ToArray();
            Console.WriteLine("----------------------");
            Console.Write("Digite o alvo: ");
            int alvo = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine(TwoSum(array1,alvo));
        }

        static (int a, int b, string al) TwoSum(int[] vetor, int alvo)
        {
            int soma = 0;
            int[] resulta = new int[2];
            string al = "Alvo não encontrado";
            
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j= 1; j < vetor.Length; j++)
                {
                    soma = vetor[i] + vetor[j];
                    if (soma == alvo)
                    {
                        al = "Alvo encontrado";
                        resulta[0] = vetor[i];
                        resulta[1] = vetor[j];
                        
                        break;

                    }
                }
            }
            return (resulta[0], resulta[1],al);
           
            
        }

        static List<int> Entrada()
        {
            Console.WriteLine("Soma de dois elementos e busca de um alvo");
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

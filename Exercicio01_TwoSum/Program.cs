using System.ComponentModel;

namespace Exercicio01_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 2, 4  };
            int alvo = 6;

           Console.WriteLine(TwoSum(array1, alvo));
        }

        static (int a, int b) TwoSum(int[] vetor, int alvo)
        {
            int soma = 0;
            int[] resulta = new int[2];           

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j= 1; j < vetor.Length; j++)
                {
                    soma = vetor[i] + vetor[j];
                    if (soma == alvo)
                    {
                        resulta[0] = vetor[i];
                        resulta[1] = vetor[j];
                        
                        break;
                    }
                }
            }
            return (resulta[0], resulta[1]);
           
            
        }

       
    }
}

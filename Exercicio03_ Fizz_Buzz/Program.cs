namespace Exercicio03__Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Fizz Buzz");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.Write("Qual o numero de interações: ");
            int i = Convert.ToInt32(Console.ReadLine());

            List<string> interacoes = new List<string>();
            
            int n= 1;
            
            while (n <= i)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    interacoes.Add("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    interacoes.Add("Fizz");
                }
                else if (n % 5 == 0)
                {
                    interacoes.Add("Buzz");
                }
                else
                {
                    interacoes.Add(Convert.ToString(n));
                }
                n++;
            }

            n = 1;
            Console.Write("{ ");
            foreach (string numeros in interacoes)
            {

                if (interacoes.Count == n)
                {
                    Console.Write(numeros + "}");
                }
                else
                {
                    Console.Write(numeros + ",");
                }
                n++;
            }


        }
    
   
    }
}

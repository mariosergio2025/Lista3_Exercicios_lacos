namespace Exercicio04_Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse String");
            Console.WriteLine("-------------");
            Console.Write("Qual palavra deseja reverte: ");
            string palavra = Console.ReadLine();

            string troca = "";
            char[] arrays = new char[palavra.Length];

            int contador = 0;           
            while(contador < palavra.Length)
            {
                arrays[contador]=palavra[contador];
                contador++;
            }
            contador = palavra.Length-1;
            Console.WriteLine(contador);
            string palavraReverse = "";
            Console.Write("{ ");
            while (contador >= 0)
            {
                if (contador ==0)
                {
                    Console.Write(arrays[contador] + " }");
                }
                else
                {
                    Console.Write(arrays[contador] + ", ");
                }
                    
                palavraReverse = palavraReverse + arrays[contador];
                contador--;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Palavra reverse é {palavraReverse}");



        }
    }
}

namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Jogo Da Adivinhação");
                Console.WriteLine("----------------------------------------");


                Random gdn = new Random();
                int ns = gdn.Next(1, 21);

                Console.Write("Digite um número (de 1 à 20 )para Chutar: ");
                int Numerochute = Convert.ToInt32(Console.ReadLine());

                if (Numerochute == ns)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Parabéns você acertou! ");
                    Console.WriteLine("----------------------------------------");
                }
                else if (Numerochute > ns)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O numero digitado foi maior que o número secreto!");
                    Console.WriteLine("----------------------------------------");
                }
                else  
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O numero digitado foi Menor que o número secreto!");
                    Console.WriteLine("----------------------------------------");
                }





                    Console.ReadLine();



            }
        }
    }
}

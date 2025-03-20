namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo Da Adivinhação");
            Console.WriteLine("----------------------------------------");

            Console.Write("Digite um número para Chutar: ");
            int Numerochute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você dugitou o numero: " + Numerochute);



            Console.ReadLine(); 
        }
    }
}

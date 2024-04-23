namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Somma
            Console.WriteLine("Somma di 3 e 5: " + CalcoliHelper.Somma(3, 5));
            Console.WriteLine("Somma di 2.5 e 3.7: " + CalcoliHelper.Somma(2.5, 3.7));
        }
    }
}

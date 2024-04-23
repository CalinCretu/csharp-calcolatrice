namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Somma
            Console.WriteLine("Somma di 3 e 5: " + CalcoliHelper.Somma(3, 5));
            Console.WriteLine("Somma di 2.5 e 3.7: " + CalcoliHelper.Somma(2.5, 3.7));

            // Differenza
            Console.WriteLine("Differenza tra 8 e 3: " + CalcoliHelper.Differenza(8, 3));
            Console.WriteLine("Differenza tra 5.2 e 1.8: " + CalcoliHelper.Differenza(5.2, 1.8));

        }
    }
}

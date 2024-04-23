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

            // Moltiplicazione
            Console.WriteLine("Moltiplicazione tra 4 e 6: " + CalcoliHelper.Moltiplicazione(4, 6));
            Console.WriteLine("Moltiplicazione tra 2.5 e 1.5: " + CalcoliHelper.Moltiplicazione(2.5, 1.5));

            // Valore assoluto
            Console.WriteLine("Valore assoluto di -7: " + CalcoliHelper.ValoreAssoluto(-7));
            Console.WriteLine("Valore assoluto di -2.3: " + CalcoliHelper.ValoreAssoluto(-2.3));

         
        }
    }
}

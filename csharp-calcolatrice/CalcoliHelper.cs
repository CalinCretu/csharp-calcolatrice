using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper // Polimorfismo: gli stessi metodi possono essere chiamati con tipi di parametro diversi
    {
        // Metodo per la somma di due numeri interi
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        // Metodo per la somma di due numeri double
        public static double Somma(double a, double b)
        {
            return a + b;
        }

        // Metodo per la differenza tra due numeri interi
        public static int Differenza(int a, int b)
        {
            return a - b;
        }

        // Metodo per la differenza tra due numeri double
        public static double Differenza(double a, double b)
        {
            return a - b;
        }

        // Metodo per la moltiplicazione di due numeri interi
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        // Metodo per la moltiplicazione di due numeri double
        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        // Metodo per il valore assoluto di un numero intero
        public static int ValoreAssoluto(int a)
        {
            return a < 0 ? -a : a;
        }

        // Metodo per il valore assoluto di un numero double
        public static double ValoreAssoluto(double a)
        {
            return a < 0 ? -a : a;
        }

        // Metodo per il minimo tra due numeri interi
        public static int Minimo(int a, int b)
        {
            return a < b ? a : b;
        }

        // Metodo per il minimo tra due numeri double
        public static double Minimo(double a, double b)
        {
            return a < b ? a : b;
        }

        // Metodo per il massimo tra due numeri interi
        public static int Massimo(int a, int b)
        {
            return a > b ? a : b;
        }

        // Metodo per il massimo tra due numeri double
        public static double Massimo(double a, double b)
        {
            return a > b ? a : b;
        }

        // Metodo per l'elevamento a potenza
        public static string Potenza(int valoreBase, int esponente)
        {
            if (valoreBase == 0)
            {
                // Se la base è zero e l'esponente è zero, restituisco 1 (convenzione informatica)
                if (esponente == 0)
                    return "1";
                //Se la base è zero e l'esponente è negativo, restituisco infinito positivo
                else if (esponente < 0)
                    return "Infinito Positivo";
                // Se la base è zero e l'esponente è diverso da zero, restituisco 0
                else
                    return "0";
            }
            // Calcolo l'elevamento a potenza e gestisco il caso dell'esponente negativo
            double risultato = 1;
            int esponenteAssoluto = ValoreAssoluto(esponente);
            for (int i = 0; i < esponenteAssoluto; i++)
            {
                risultato *= valoreBase;
            }
            // Con esponente negativo
            if (esponente < 0)
                risultato = 1 / risultato;

            return risultato.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
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
    }
}

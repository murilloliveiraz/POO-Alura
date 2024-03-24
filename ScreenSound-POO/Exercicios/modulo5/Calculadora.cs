using System.Reflection.Metadata.Ecma335;

namespace ScreenSound_POO.Exercicios.modulo5
{
    internal class Calculadora
    {
        public static double Calcular(double n1, double n2, char operacao)
        {
            return operacao == '+' ? Soma(n1, n2) :
            operacao == '-' ? Subtracao(n1, n2) :
            operacao == '*' ? Multiplicacao(n1, n2) :
            operacao == '/' ? Divisao(n1, n2) :
            operacao == '^' ? Potenciacao(n1, n2) :
            operacao == 'r' ? RaizQuadrada(n1) :
             0;
            
        }

        public static double Soma (double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtracao (double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicacao (double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divisao(double n1, double n2)
        {
            if (n2 != 0) return n1 / n2;
            Console.WriteLine("ERRO: divisão por Zero");
            return 0;
        }

        public static double Potenciacao (double n1, double n2)
        {
            return Math.Pow(n1 , n2);
        }

        public static double RaizQuadrada(double n1)
        {
            return Math.Sqrt(n1);
        }
    }
}

/**
 * using ScreenSound_POO.Exercicios.modulo5;

Console.WriteLine(Calculadora.Calcular(9, 8, '+'));
Console.WriteLine(Calculadora.Calcular(9, 8, '-'));
Console.WriteLine(Calculadora.Calcular(9, 8, '*'));
Console.WriteLine(Calculadora.Calcular(9, 8, '/'));
Console.WriteLine(Calculadora.Calcular(9, 8, '^'));
Console.WriteLine(Calculadora.Calcular(9, 0, 'r'))**/
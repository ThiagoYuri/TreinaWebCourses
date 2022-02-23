using System;

namespace DelegatesGenerics
{
    class Program
    {
      //  delegate T CalculoMatematico<T>(T a, T b);
        static void Main(string[] args)
        {
            Program p = new Program();
            //  CalculoMatematico<int> c1 = new CalculoMatematico<int>(p.Somar);
            Func<int, int, int> calculo1 = p.Somar;
            //Console.WriteLine(calculo1(1, 1));
            //ExibirInformacoesDelegate(c1);
            Action<int> impressao = p.imprimirResultado;
            impressao(calculo1(1,1));
            // CalculoMatematico<decimal> c2 = new CalculoMatematico<decimal>(p.SomarDecimal);
            Func<decimal, decimal, decimal> calculo2 = p.SomarDecimal;
            Console.WriteLine(calculo2(1.1M, 1M));
           // ExibirInformacoesDelegate(c2);
            Console.ReadKey();
        }

        //private static void ExibirInformacoesDelegate<T>(CalculoMatematico<T> c2)
        //{
        //    Console.WriteLine(c2.Target);
        //    Console.WriteLine(c2.Method);
        //}
        void imprimirResultado(int resultao)
        {
            Console.WriteLine(resultao);
        }

        int Somar(int v1, int v2)
        {
            return v1 + v2;
        }
        decimal SomarDecimal(decimal v1, decimal v2)
        {
            return v1 + v2;
        }
    }
}

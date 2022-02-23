using System;

namespace DelegatesMulticast
{
    class Program
    {

        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificadorIdade;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu sexo:");
            string sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32( Console.ReadLine());

            if (sexoUsuario.Equals("H"))
            {
                verificadorIdade = new VerificacaoIdade(VerificarIdadeHomem);
                verificadorIdade += VerificarCarregamentoHomem;
            }else
            {
                verificadorIdade = new VerificacaoIdade(VerificarIdadeMulher);
                verificadorIdade += VerificarCarregamentoMulher;
            }
            verificadorIdade(idade);
            Console.ReadKey();
        }
        //Homens
        static void VerificarIdadeHomem(int idade)
        {
            if(idade < 21)
            {
                Console.WriteLine("Você ainda está crecendo");
            }
            else
            {
                Console.WriteLine("Você já Creceu");
            }
        }

        static void VerificarCarregamentoHomem(int idade)
        {
            if (idade > 25)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar bastante peso");
            }
        }
        //Mulheres
        static void VerificarIdadeMulher(int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine("Você ainda está crecendo");
            }
            else
            {
                Console.WriteLine("Você já Creceu");
            }
        }

        static void VerificarCarregamentoMulher(int idade)
        {
            if (idade > 30)
            {
                Console.WriteLine("Você pode carregar bastante peso");
            }
            else
            {
                Console.WriteLine("Você não pode carregar bastante peso");
            }
        }
    }
}

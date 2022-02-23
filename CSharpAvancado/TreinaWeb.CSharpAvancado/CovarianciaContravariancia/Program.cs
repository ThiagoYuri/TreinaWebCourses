using System;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<string> ftp = new ManipuladorFTP<string>();

            ftp.Armazenar("teste");
            Console.WriteLine(ftp.Recuperar(0));
            Console.ReadKey();
        }
    }
}

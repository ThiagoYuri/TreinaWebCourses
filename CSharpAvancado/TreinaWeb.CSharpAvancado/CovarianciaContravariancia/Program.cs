using System;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManipuladorFTP<Nivel2> ftp = new ManipuladorFTP<Nivel2>();

            IArmazenador<Nivel3> armazenador = ftp;

            Console.WriteLine(new Nivel3());
            Console.ReadKey();
        }
    }
}

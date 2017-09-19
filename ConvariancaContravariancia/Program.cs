using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvariancaContravariancia
{
  class Program
  {
    static void Main(string[] args)
    {
      ManipuladorFtp<Nivel2> ftp = new ManipuladorFtp<Nivel2>();
      IArmazenador<Nivel3> armazenador = ftp;
      armazenador.Armazenar(new Nivel3());

      IRecuperador<Nivel1> recuperador = ftp;
      Console.WriteLine(recuperador.Recuperar(0));
      Console.WriteLine();
      Console.ReadKey();
    }
  }
}

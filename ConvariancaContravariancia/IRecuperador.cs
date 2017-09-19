using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvariancaContravariancia
{
  interface IRecuperador<out T>
  {
    T Recuperar(int codigo);
  }
}

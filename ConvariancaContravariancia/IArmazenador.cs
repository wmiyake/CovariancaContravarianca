using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvariancaContravariancia
{
  interface IArmazenador<in T>
  {
    void Armazenar(T item);
  }
}

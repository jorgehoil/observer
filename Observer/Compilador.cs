using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Compilador : IObserver
    {
        public void update()
        {
            Console.WriteLine("Compilación de código correcto");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Instalador : IObserver
    {
        public void update()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}

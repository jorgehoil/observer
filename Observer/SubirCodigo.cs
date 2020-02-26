using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SubirCodigo : IObserver
    {
        public void update()
        {
            Console.WriteLine("Commit de código de la versión 1.1");

        }
    }
}

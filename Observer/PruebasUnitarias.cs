using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class PruebasUnitarias : IObserver
    {
        public void update()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}

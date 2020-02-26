using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Notificador : IObserver
    {
        public void update()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}

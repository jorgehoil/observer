using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IPublicador
    {
        void RegistrarObservador(IObserver observador);
        void QuitarObservador(IObserver observador);
        void Notificar();
    }
}

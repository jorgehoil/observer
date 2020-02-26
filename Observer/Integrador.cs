using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Integrador:IPublicador
    {
        List<IObserver> lstObservadores = new List<IObserver>();

        public void Notificar()
        {
            foreach (IObserver observador in lstObservadores)
            {
                observador.update();
            }
        }
        public Integrador(List<IObserver> _lstObserver)
        {
            lstObservadores = _lstObserver;

        }

        public void QuitarObservador(IObserver _observador)
        {
            lstObservadores.Add(_observador);
        }

        public void RegistrarObservador(IObserver _observador)
        {
            lstObservadores.Remove(_observador);
        }
    }
}

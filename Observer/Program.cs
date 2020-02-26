using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Integrador integrador;
            List<IObserver> lstObservadores= new List<IObserver>();
            mostrarMenu();
            int iOpcion=0;
            do {
                int.TryParse(Console.ReadLine(),out iOpcion);
                switch (iOpcion)
                {
                    case 2:
                        lstObservadores.Add(new Notificador());
                        break;
                    case 3:
                        lstObservadores.Add(new Compilador());
                        break;
                    case 4:
                        lstObservadores.Add(new PruebasUnitarias());
                        break;
                    case 5:
                        lstObservadores.Add(new Instalador());
                        break;
                }
                
            }
            while (iOpcion!=1);
            integrador = new Integrador(lstObservadores);
            integrador.Notificar();
            Console.ReadKey();

        }

        static void mostrarMenu()
        {
            Console.WriteLine("1...Subir Código");
            Console.WriteLine("2...Agregar Notificador");
            Console.WriteLine("3...Agregar Compilador");
            Console.WriteLine("4...Agregar Ejecutor de Pruebas Unitarias");
            Console.WriteLine("5...Agregar Instalador");
        


        }
        static void agregarSuscriptores(List<IObserver> lstObservers)
        {
            

        }

    }
}

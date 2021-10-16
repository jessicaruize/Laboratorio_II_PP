using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;
        /// <summary>
        /// propiedad le lectura para la lista de troopers
        /// </summary>
        public List<Trooper> Troopers { get => this.troopers; }
        /// <summary>
        /// Constructor por defecto que instancia la lista de troopers
        /// </summary>
        private EjercitoImperial()
        {
            troopers = new List<Trooper>();
        }
        /// <summary>
        /// Constructor parametrizado que instancia indirectamente la lista de tropers e inicializa la cantidad con el parametro recibido
        /// </summary>
        /// <param name="capacidad"></param>Parametro con el valor a cargar en el atributo cantidad
        public EjercitoImperial(int capacidad) : this()
        {
            if(capacidad > 0)
            this.capacidad = capacidad;
        }
        /// <summary>
        /// Sobrecarga del operador menos que resta un soldado de la lista de troopers
        /// </summary>
        /// <param name="ejercito"></param>Lista recibida de troopers
        /// <param name="soldado"></param>Soldado a comparar su tipo con los tipos de los soldados de la lista para eliminar la primer ocurrencia del mismo.
        /// <returns></returns>
        public static EjercitoImperial operator - (EjercitoImperial ejercito, Trooper soldado)
        {
            if (!(ejercito is null) && !(soldado is null))
            {
                foreach (Trooper item in ejercito.Troopers)
                {
                    if (soldado.Equals(item))
                    {
                        ejercito.troopers.Remove(item);
                        break;
                    }
                }
            }
            return ejercito;
        }
        /// <summary>
        /// Sobrecarga del operador mas que suma un soldado de la lista de troopers
        /// </summary>
        /// <param name="ejercito"></param>Lista recibida de troopers
        /// <param name="soldado"></param>Soldado a sumar en la lista en caso de haber lugar
        /// <returns></returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if(!(ejercito is null) && !(soldado is null) && ejercito.capacidad > ejercito.troopers.Count)
            {
                ejercito.troopers.Add(soldado);
            }
            return ejercito;
        }


    }
}

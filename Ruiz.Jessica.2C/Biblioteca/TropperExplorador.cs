using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TrooperExplorador : Trooper
    {
        private string vehiculo;
        /// <summary>
        /// Propiedad de lectura que devuelve el tipo en string
        /// </summary>
        public override string Tipo { get => "Soldado de exploraciòn"; }
        /// <summary>
        /// Propiedad de lectura y escitura para Vehiculo
        /// </summary>
        public string Vehiculo
        {
            get
            {
                return vehiculo;
            }
            set
            {
                if(value.Length > 0)
                {
                    vehiculo = value;
                }
                else
                {
                    vehiculo = "Indefinido";
                }
            }
        }
        /// <summary>
        /// Contructor que asigna vehiculo y por defecto el blaster en EC17
        /// </summary>
        /// <param name="vehiculo"></param>
        public TrooperExplorador(string vehiculo) : base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }
        /// <summary>
        /// Metodo a devolver la informacion del trooper en un string 
        /// </summary>
        /// <returns></returns>
        public override string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoTrooper());
            sb.AppendLine($"-Vehìculo: {this.Vehiculo}");
            return sb.ToString();
        }
    }
}
/*Explorador por defecto se carga con Blaster EC17, podria modificarlo crenaod un constructor que permita recibir el blaster requerido o una propiedad set.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        /// <summary>
        /// Asigna el armamento e inicializa el esClon en false.
        /// </summary>
        /// <param name="armamento"></param>valor a ingresar en el atributo armamento.
        public Trooper(Blaster armamento):this(armamento, false)
        {
        }
        /// <summary>
        /// Constructor parametrizado que carga el armamento y el esClon.
        /// </summary>
        /// <param name="armamento"></param>
        /// <param name="esClon"></param>
        public Trooper(Blaster armamento, bool esClon)
        {
            this.armamento = armamento;
            this.esClon = esClon;
        }
        /// <summary>
        /// Propiedad de lectura de armamento
        /// </summary>
        public Blaster Armamento { get => armamento; }
        /// <summary>
        /// Propiedad de lectura y escritura de esClon
        /// </summary>
        public bool EsClon { get => esClon; set => esClon = value; }
        /// <summary>
        /// Propiedad abstracta de Tipo
        /// </summary>
        public abstract string Tipo { get; }
        /// <summary>
        /// Sobrescritura de Equals que compara si son del mismo tipo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(!(obj is null))
            {
                return obj.GetType() == this.GetType();
            }
            return false;
        }
        /// <summary>
        ///  Metodo a devolver la informacion del trooper en un string 
        /// </summary>
        /// <returns></returns>
        public virtual string InfoTrooper()
        {
            string aux = "NO";
            if(this.esClon)
            {
                aux = "SI";
            }
            return string.Format($"{this.Tipo} armado con {this.Armamento}, {aux} es clon");
        }
        
    }
}

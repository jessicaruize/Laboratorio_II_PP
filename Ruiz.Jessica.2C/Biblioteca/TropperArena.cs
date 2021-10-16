using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TrooperArena : Trooper
    {
        /// <summary>
        /// Propiedad de lectura que devuelve el tipo en string
        /// </summary>
        public override string Tipo { get => "Soldados de asalto en terrenos desèrticos "; }
        /// <summary>
        /// Constructor que carga el valor del armamento
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperArena(Blaster armamento)
            : base(armamento)
        {
        }
    }

}

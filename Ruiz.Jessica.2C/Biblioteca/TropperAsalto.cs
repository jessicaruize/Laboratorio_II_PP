using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TrooperAsalto : Trooper
    {
        /// <summary>
        /// Propiedad de lectura que devuelve el tipo en string
        /// </summary>
        public override string Tipo { get => "Comando para misiones de infiltraciòn "; }
        /// <summary>
        /// Constructor que inicializa el armamento con el parametro recibido y por defecto pone a esClon en true.
        /// </summary>
        /// <param name="armamento"></param>Valor a cargar en el armamento.
        public TrooperAsalto(Blaster armamento)
            : base(armamento, true)
        {
        }
    }
}

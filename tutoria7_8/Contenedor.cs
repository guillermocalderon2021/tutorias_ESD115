using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria7
{
    internal class Contenedor
    {
        public int NumeroContenedor { get; set; }
        public string Encargado { get; set; }
        public string Rubro { get; set; }
        public int NumeroCajas { get; set; }
        public decimal Valor { get; set; }
        public string PaisProcedencia { get; set; }
        public int tiempoAtencion { get; set; }

        public override string ToString()
        {
            return $"Numero de contenedor: {this.NumeroContenedor} \n " +
                $"Encargado: {this.Encargado} \n Rubro:  {this.Rubro}";
        }
    }
}

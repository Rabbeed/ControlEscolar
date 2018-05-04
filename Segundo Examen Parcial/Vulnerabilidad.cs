using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Examen_Parcial
{
    [Serializable()]
    class Vulnerabilidad
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private DateTime fecha;

        public Vulnerabilidad(string _clave, string _vendedor,string _desc, string _tipo, DateTime _fecha) : this()
        {
            clave = _clave;
            vendedor = _vendedor;
            descripcion = _desc;
            tipo = _tipo;
            fecha = _fecha;
        }

        public string Clave { get => clave; set => clave = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

       
    }
}

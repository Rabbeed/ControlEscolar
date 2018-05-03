using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Examen_Parcial
{
    [Serializable()]
    class Red
    {
        private string empresa;
        private string propietario;
        private string domicilio;
        private List <Nodo> nodos;

        public Red()
        {
            nodos = new List<Nodo>();
        }

        public Red(string emp, string pro, string dom)
        {
            Empresa = emp;
            Propietario = pro;
            Domicilio = dom;      

        }

        public string Empresa { get => empresa; set => empresa = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        public void AgregarNodo(Nodo nodo)
        {
            nodos.Add(nodo);
        }

        public void EliminarNodo(int indice)
        {
            nodos.RemoveAt(indice);
        
        }

        public List <Nodo> ObtenNodos()
        {
            return nodos;
        }

        public string RegresaDatos()
        {
            return string.Format("Empresa: {0}, Propietario: {1}" + "\nDomicilio: {2}",
            empresa, propietario, domicilio);
        }
    }
}

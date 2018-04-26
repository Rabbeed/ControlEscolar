using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar
{
    [Serializable()]
    class Escuela
    {
        private string nombre;
        private string responsable;
        private string direccion;
        private string telefono;
        private List <Grupo> grupos;
        public Escuela()
        {
            grupos = new List <Grupo>();
        }
        public Escuela(string valn, string valr, string vald, string valt) : this()
        {
            nombre = valn;
            responsable = valr;
            direccion = vald;
            telefono = valt;
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void AgregaGrupo(Grupo gpo)
        {
            grupos.Add(gpo);
        }
        public void EliminaGrupo(int indice)
        {
            grupos.RemoveAt(indice);
        }
        public List  <Grupo> ObtenGrupos()
        {
            return grupos;
        }
        public string RegresaDatos()
        {
            return string.Format("Nombre: {0}, Responsable: {1}" + "\nDireccion: {2}, \nTelefono: {3}",
            nombre, responsable, direccion, telefono);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Examen_Parcial
{
    [Serializable()]
    class Nodo
    {
        private string ip;
        private string tipo;
        private int pAbiertos;
        private int sObjetivo;
        private string so;
        private List<Vulnerabilidad> vulnerabilidades;

        public Nodo()
        {
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        public Nodo(string _ip, string _tipo, int _pAbiertos, int _sObjetivo, string _SO) : this()
        {
            ip = _ip;
            tipo = _tipo;
            pAbiertos = _pAbiertos;
            sObjetivo = _sObjetivo;
            so = _SO;
        }

       
        public string Tipo { get => tipo; set => tipo = value; }
        public int PAbiertos { get => pAbiertos; set => pAbiertos = value; }
        public int SObjetivo { get => sObjetivo; set => sObjetivo = value; }
        public string Ip { get => ip; set => ip = value; }
        public string So { get => so; set => so = value; }

        public void agregarVulnerabilidad(Vulnerabilidad vul)
        {
            vulnerabilidades.Add(vul);
        }

        public void eliminarVulnerabilidad(int indice)
        {
            vulnerabilidades.RemoveAt(indice);
        }

        public List<Vulnerabilidad> obtenVulnerabilidades()
        {
            return vulnerabilidades;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar
{
    [Serializable()]

    class Alumno
    {
        private string nombre;
        private int edad;
        private List<float> califs;

        public Alumno()
        {
            califs = new List<float>();
        }
        public Alumno(string valnombre, int valedad): this()
        {
            nombre = valnombre;
            edad = valedad;
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void AgregaCalif(float cal)
        {
            califs.Add(cal);
        }
        public void EliminaCalif(int indice)
        {
            califs.RemoveAt(indice);
        }
        public List <float> ObtenCalifs()
        {
            return califs;
        }
        public float Promedio()
        {
            float suma = 0.0f;
            foreach (float cal in califs) suma += cal;
            return (suma / califs.Count());
        }

        public string DespliegaCalifs()
        {
            string cals="";
            foreach(float cal in califs)
            {
                cals += cal + " ";

            }
            return cals;
        }

    }
}

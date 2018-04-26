using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar
{
    [Serializable()]
    class Grupo
    {
        private string nombreProfesor;
        private int grado;
        private List <Alumno> alumnos;

        public Grupo()
        {
            alumnos = new List <Alumno>();
        }
        public Grupo(string valnomp, int valgrado) : this()
        {
            nombreProfesor = valnomp;
            grado = valgrado;
        }
        public int Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        public string NombreProfesor
        {
            get { return nombreProfesor; }
            set { nombreProfesor = value; }
        }
        public void AgregaAlumno(Alumno al)
        {
            alumnos.Add(al);
        }
        public void EliminaAlumno(int indice)
        {
            alumnos.RemoveAt(indice);
        }
        public List <Alumno> ObtenAlumnos()
        {
            return alumnos;
        }
        public float MediaGeneral()
        {
            float suma = 0.0f;
            foreach
            (Alumno al in alumnos) suma += al.Promedio();
            return (suma / alumnos.Count());
        }
    }
}

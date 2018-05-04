using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControlEscolar
{
    // clase para declarar variables globales o funciones estáticas que se usen
    // en todo el proyecto

    class Globales
    {
        public static Escuela miEscuela;
        public static Grupo miGrupo;
        public static Alumno miAlumno;

        public static void Serializar(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fs, Globales.miEscuela);
            fs.Close();
        }
        public static void DesSerializar(string archivo)
        {
            Globales.miEscuela = new Escuela();
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormat = new BinaryFormatter();
            Globales.miEscuela = (Escuela)binFormat.Deserialize(fs);
            fs.Close();
        }
    }
}

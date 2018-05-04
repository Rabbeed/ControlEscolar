using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Segundo_Examen_Parcial
{
    class Globales
    {

        public static Red miRed;
        public static Nodo miNodo;
        public static Vulnerabilidad miVul;

        public static void Serializar(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fs, Globales.miRed);
            fs.Close();
        }

        public static void DesSerializar(string archivo)
        {
            Globales.miRed = new Red();
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormat = new BinaryFormatter();
            Globales.miRed = (Red)binFormat.Deserialize(fs);
            fs.Close();
        }
    }
}

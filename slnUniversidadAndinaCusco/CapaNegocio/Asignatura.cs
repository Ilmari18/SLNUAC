using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // Atributos
        private string nombreAsig;
        private string facultad;
        private int antiguedad;
        
        // Propiedades
        public string NombreAsig
        {
            get { return nombreAsig; } // lectura de atributo
            set { nombreAsig = value; } // escritura de atributo
        }
        public string Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }
       
        //metodos
        public string Ensenar()
        {
            return "No se ha implementado el metodo enseñar.";
        }
        public string AlmacenarInfo()
        {
            return "No se ha implementado el metodo almacenar informacion.";
        }
        public string ContratarProfes()
        {
            return "No se ha implementado el metodo contratar profesores.";
        }
    }
}

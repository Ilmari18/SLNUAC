using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string dni;
        private DateTime fechaNacimiento;
        private string profesion;
        //propiedades
        public string Apellidos
        {
            get { return apellidos; } // lectura de atributo
            set { apellidos = value; } // escritura de atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; } 
            set { fechaNacimiento = value; } 
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        //metodos
        public string Ensenar()
        {
            return "No se ha implementado el metodo ensenar";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo Matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaropobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}

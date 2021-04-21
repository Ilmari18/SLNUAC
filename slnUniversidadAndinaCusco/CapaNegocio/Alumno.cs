using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        // Propiedades
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
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; }
            set { this.lugarNacimiento = value; }
        }
        //metodos
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aprobar examen";
        }
        public string PresentarTrabajo()
        {
            return "No se ha implementado el metodo presentar trabajo";
        }
    }
}

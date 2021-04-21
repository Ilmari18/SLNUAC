using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //atributos
        private string nombres;
        private string apellidos;
        private int edad;
        private string dni;
        private string profesion;
        

        //propiedades
       
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
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
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        // metodos
        public string Ensenar()
        {
            return "No se ha implementado el metodo enseñar.";
        }
        public string OrientarEstud()
        {
            return "No se ha implementado el metodo orientar a los estudiantes.";
        }
        public string Apoyar()
        {
            return "No se ha implementado el metodo apoyar.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //atributos
        private string nombres;
        private string apellidos;
        private int edad;
        private string profesion;
        private string gradEstu;

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
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string GradEstu
        {
            get { return gradEstu; }
            set { gradEstu = value; }
        }

        //metodos
        public string Representar()
        {
            return "No se ha implementado el metodo representar";
        }
        public string Firmar()
        {
            return "No se ha implementado el metodo firmar";
        }
        public string Evaluar() 
        {
            return "No se ha implementado el metodo evaluar";
        }

    }
}

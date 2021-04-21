using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // Atibutos
        private string carrera;
        private int tiempo;
        private string especialidad;
         //propiedades
        public string Carrera
        {
            get { return carrera; } 
            set { carrera = value; } 
        }
        public int Tiempo
        {
            get { return tiempo; } 
            set { tiempo = value; } 
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        // metodos
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Desarollar()
        {
            return "No se ha implementado el metodo desarrollar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
    }
}

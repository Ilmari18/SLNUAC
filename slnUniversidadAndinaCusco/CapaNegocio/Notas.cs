using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // Atributos
        private int cantNotas;
        private string curso;

        // Propiedades
        public int CantNotas
        {
            get { return cantNotas; }
            set { cantNotas = value; }
        }

        public string Curso
        {
            get { return this.curso; }
            set { this.curso = value; }
        }

        //Metodos
        public string Registrar()
        {
            return "No se ha implementado el metodo registrar.";
        }
        public string DefApro()
        {
            return "No se ha implementado el metodo definir aprobados.";
        }
    }
}

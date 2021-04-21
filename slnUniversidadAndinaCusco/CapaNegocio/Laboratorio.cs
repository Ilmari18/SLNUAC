using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // atributos
        private int aforo;
        private int cantMicros;
        private string tipoLab;
        private string tipoPersonal;
        private int periodoLimpieza;
        // propiedades
        public int Aforo
        {
            get { return this.aforo; }
            set { this.aforo = value; }
        }
        public int CantMicros
        {
            get { return this.cantMicros; }
            set { this.cantMicros = value; }
        }
        public string TipoLab
        {
            get { return this.tipoLab; }
            set { this.tipoLab = value; }
        }
        public string TipoPersonal
        {
            get { return this.tipoPersonal; }
            set { this.tipoPersonal = value; }
        }
        public int PeriodoLimpieza
        {
            get { return this.periodoLimpieza; }
            set { this.periodoLimpieza = value; }
        }
        //Metodos
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string RecopilarDatos()
        {
            return "No se ha implementado el metodo Recopilar datos";
        }
    }
}

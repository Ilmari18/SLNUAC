using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PPP ppp1 = new CapaNegocio.PPP();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text;
            int tiempo = int.Parse(txtTiempo.Text);
            string especialidad = TxtEspecialidad.Text;
            ppp1.Carrera = carrera;
            ppp1.Tiempo = tiempo;
            ppp1.Especialidad = especialidad;
            MessageBox.Show("Los datos de las practicas Pre Profesionales se han registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string carrera = ppp1.Carrera;
            int tiempo = ppp1.Tiempo;
            string especialidad = ppp1.Especialidad;
            MessageBox.Show("Carrera: " + carrera + " Tiempo: " + tiempo+" Especialidad: "+especialidad);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Investigar());
        }

        private void btnDesarrollar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Desarollar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Trabajar());
        }
    }
}

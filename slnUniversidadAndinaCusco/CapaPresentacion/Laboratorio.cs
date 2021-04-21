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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            int aforo = int.Parse(txtAforo.Text);
            int cantMicros = int.Parse(txtCantMicros.Text);
            string tipoLab = txtTipoLab.Text;
            string tipoPersonal = txtTipoPersonal.Text;
            int periodoLimpieza = int.Parse(txtPeriodoLimpieza.Text);
            laboratorio1.Aforo = aforo;
            laboratorio1.CantMicros = cantMicros;
            laboratorio1.TipoLab = tipoLab;
            laboratorio1.TipoPersonal = tipoPersonal;
            laboratorio1.PeriodoLimpieza = periodoLimpieza;
            MessageBox.Show("Se ha registrado correctamente la informacion del laboratorio.");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            int aforo = laboratorio1.Aforo;
            int cantMicros = laboratorio1.CantMicros;
            string tipoLab = laboratorio1.TipoLab;
            string tipoPersonal = laboratorio1.TipoPersonal;
            int periodoLimpieza = laboratorio1.PeriodoLimpieza;
            MessageBox.Show("Aforo: " + aforo + " Cantidad de Microscopios: " + cantMicros + " Tipo de laboratorio: " +
                tipoLab + " Tipo de Personal: " + tipoPersonal + " Periodo de Limpieza: " + periodoLimpieza+" dias");

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Estudiar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnRecopilarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.RecopilarDatos());
        }
    }
}

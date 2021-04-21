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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombreAsig = txtNombreAsig.Text;
            string facultad = txtFacultad.Text;
            int antiguedad = int.Parse(txtAntiguedad.Text);
            asignatura1.NombreAsig = nombreAsig;
            asignatura1.Facultad = facultad;
            asignatura1.Antiguedad = antiguedad;
            MessageBox.Show("Se ha registrado correctamente la informacion de la asignatura.");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombreAsig = asignatura1.NombreAsig;
            string facultad = asignatura1.Facultad;
            int antiguedad = asignatura1.Antiguedad;
            MessageBox.Show("Nombre de la asignatura: "+nombreAsig+" Facultad: "+facultad+" Antiguedad en años: "+antiguedad);
        }

        private void btnEnsenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Ensenar());
        }

        private void btnAlmacenarInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.AlmacenarInfo());
        }

        private void btnContraProfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.ContratarProfes());
        }
    }
}

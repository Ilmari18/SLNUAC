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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            int cantNotas = int.Parse(txtCantNotas.Text);
            string curso = txtCurso.Text;
            notas1.CantNotas = cantNotas;
            notas1.Curso = curso;
            MessageBox.Show("Se ha registrado correctamente la informacion del curso");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            int cantNotas =notas1.CantNotas;
            string curso = notas1.Curso;
            MessageBox.Show("Cantidad de notas: " + cantNotas + " Curso: " + curso); 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Registrar());
        }

        private void btnDefApro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.DefApro());
        }
    }
}

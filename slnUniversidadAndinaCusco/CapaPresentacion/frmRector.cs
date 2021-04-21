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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            string gradEstu = txtGradEstu.Text;
            rector1.Nombres = nombres;
            rector1.Apellidos = apellidos;
            rector1.Edad = edad;
            rector1.Profesion = profesion;
            rector1.GradEstu = gradEstu;
            MessageBox.Show("Se ha registrado correctamente los datos del rector.");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = rector1.Nombres;
            string apellidos = rector1.Apellidos;
            int edad = rector1.Edad;
            string profesion = rector1.Profesion;
            string gradEstu = rector1.GradEstu;
            MessageBox.Show("Nombres: " + nombres+" Apellidos: " + apellidos + " Edad: " + edad + " Profesion: " + profesion+ " Grado Estudios: " + gradEstu);
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Representar());
        }

        private void btnFirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Firmar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Evaluar());
        }
    }
}

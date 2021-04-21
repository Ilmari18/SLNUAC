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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();


        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string dni = txtDni.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Edad = edad;
            docente1.Dni = dni;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos del docente");

        }
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            int edad = docente1.Edad;
            string dni = docente1.Dni;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Dni: " + dni + " Fecha de Nacimiento: " + fechaNacimiento + " Profesion: " + profesion);
        }

        private void btnEnsenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Ensenar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaropobar());
        }   

       
    }
}

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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }
        // instanciar la clase a traves de un objeto
        // se declaran variables globales
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();
        
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos del alumno");

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Estudiar());
            MessageBox.Show("Ha estudiado satisfactoriamente");
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
            MessageBox.Show("Ha trabajado satisfactoriamente");
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
            MessageBox.Show("Ha aprobado exitosamente el examen");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // mostrar los datos almacendos en el objeto 1
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres +" Edad: " + edad + " Lugar de Nacimiento: " + lugarNacimiento );
        }

        private void btnPresentarTrabajo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.PresentarTrabajo());
        }

        
    }
}

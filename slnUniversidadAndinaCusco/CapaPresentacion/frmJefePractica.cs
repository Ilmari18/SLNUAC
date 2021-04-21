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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text);
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            jefePractica1.Nombres = nombres;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Edad = edad;
            jefePractica1.Dni = dni;
            jefePractica1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos del jefe de practica");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefePractica1.Apellidos;
            string nombres = jefePractica1.Nombres;
            int edad = jefePractica1.Edad;
            string dni = jefePractica1.Dni;
            string profesion = jefePractica1.Profesion;
            MessageBox.Show("Nombres: " + nombres+ " Apellidos: " + apellidos  + " Edad: " + edad + " Dni: " + dni + " Profesion: " + profesion);
        }

        private void btnEnsenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Ensenar());
        }

        private void btnOrientarEstud_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.OrientarEstud());
        }

        private void btnApoyar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Apoyar());
        }
    }
    
}

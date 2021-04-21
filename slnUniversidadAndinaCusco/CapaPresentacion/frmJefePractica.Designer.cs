
namespace CapaPresentacion
{
    partial class frmJefePractica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnEnsenar = new System.Windows.Forms.Button();
            this.btnOrientarEstud = new System.Windows.Forms.Button();
            this.btnApoyar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(260, 154);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 13;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(260, 86);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 12;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(104, 48);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 14;
            this.txtNombres.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(104, 86);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 15;
            this.txtApellidos.Text = "Apellidos";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(104, 124);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 16;
            this.txtEdad.Text = "Edad";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(104, 157);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 17;
            this.txtDni.Text = "Dni";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(104, 196);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtProfesion.TabIndex = 18;
            this.txtProfesion.Text = "Profesion";
            // 
            // btnEnsenar
            // 
            this.btnEnsenar.Location = new System.Drawing.Point(45, 275);
            this.btnEnsenar.Name = "btnEnsenar";
            this.btnEnsenar.Size = new System.Drawing.Size(75, 23);
            this.btnEnsenar.TabIndex = 19;
            this.btnEnsenar.Text = "Enseñar";
            this.btnEnsenar.UseVisualStyleBackColor = true;
            this.btnEnsenar.Click += new System.EventHandler(this.btnEnsenar_Click);
            // 
            // btnOrientarEstud
            // 
            this.btnOrientarEstud.Location = new System.Drawing.Point(145, 275);
            this.btnOrientarEstud.Name = "btnOrientarEstud";
            this.btnOrientarEstud.Size = new System.Drawing.Size(125, 23);
            this.btnOrientarEstud.TabIndex = 20;
            this.btnOrientarEstud.Text = "Orientar Estudiantes";
            this.btnOrientarEstud.UseVisualStyleBackColor = true;
            this.btnOrientarEstud.Click += new System.EventHandler(this.btnOrientarEstud_Click);
            // 
            // btnApoyar
            // 
            this.btnApoyar.Location = new System.Drawing.Point(300, 274);
            this.btnApoyar.Name = "btnApoyar";
            this.btnApoyar.Size = new System.Drawing.Size(75, 23);
            this.btnApoyar.TabIndex = 21;
            this.btnApoyar.Text = "Apoyar";
            this.btnApoyar.UseVisualStyleBackColor = true;
            this.btnApoyar.Click += new System.EventHandler(this.btnApoyar_Click);
            // 
            // frmJefePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 340);
            this.Controls.Add(this.btnApoyar);
            this.Controls.Add(this.btnOrientarEstud);
            this.Controls.Add(this.btnEnsenar);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmJefePractica";
            this.Text = "frmJefePractica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Button btnEnsenar;
        private System.Windows.Forms.Button btnOrientarEstud;
        private System.Windows.Forms.Button btnApoyar;
    }
}

namespace CapaPresentacion
{
    partial class frmRector
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtGradEstu = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnRepresentar = new System.Windows.Forms.Button();
            this.btnFirmar = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(48, 32);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(111, 20);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(48, 75);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(111, 20);
            this.txtApellidos.TabIndex = 1;
            this.txtApellidos.Text = "Apellidos";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(48, 159);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(111, 20);
            this.txtProfesion.TabIndex = 3;
            this.txtProfesion.Text = "Profesion";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(48, 116);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(111, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "Edad";
            // 
            // txtGradEstu
            // 
            this.txtGradEstu.Location = new System.Drawing.Point(48, 204);
            this.txtGradEstu.Name = "txtGradEstu";
            this.txtGradEstu.Size = new System.Drawing.Size(111, 20);
            this.txtGradEstu.TabIndex = 4;
            this.txtGradEstu.Text = "Grado de estudios";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(239, 75);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(239, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnRepresentar
            // 
            this.btnRepresentar.Location = new System.Drawing.Point(39, 250);
            this.btnRepresentar.Name = "btnRepresentar";
            this.btnRepresentar.Size = new System.Drawing.Size(75, 23);
            this.btnRepresentar.TabIndex = 10;
            this.btnRepresentar.Text = "Representar";
            this.btnRepresentar.UseVisualStyleBackColor = true;
            this.btnRepresentar.Click += new System.EventHandler(this.btnRepresentar_Click);
            // 
            // btnFirmar
            // 
            this.btnFirmar.Location = new System.Drawing.Point(144, 250);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(75, 23);
            this.btnFirmar.TabIndex = 9;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseVisualStyleBackColor = true;
            this.btnFirmar.Click += new System.EventHandler(this.btnFirmar_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(254, 250);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 8;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 296);
            this.Controls.Add(this.btnRepresentar);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtGradEstu);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Name = "frmRector";
            this.Text = "frmRector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtGradEstu;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnRepresentar;
        private System.Windows.Forms.Button btnFirmar;
        private System.Windows.Forms.Button btnEvaluar;
    }
}
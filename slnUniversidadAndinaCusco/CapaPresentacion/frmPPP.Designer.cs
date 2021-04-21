
namespace CapaPresentacion
{
    partial class frmPPP
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
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnDesarrollar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(201, 120);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 13;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(201, 52);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 12;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(34, 188);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 27);
            this.btnInvestigar.TabIndex = 14;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnDesarrollar
            // 
            this.btnDesarrollar.Location = new System.Drawing.Point(150, 188);
            this.btnDesarrollar.Name = "btnDesarrollar";
            this.btnDesarrollar.Size = new System.Drawing.Size(75, 27);
            this.btnDesarrollar.TabIndex = 15;
            this.btnDesarrollar.Text = "Desarollar";
            this.btnDesarrollar.UseVisualStyleBackColor = true;
            this.btnDesarrollar.Click += new System.EventHandler(this.btnDesarrollar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(274, 188);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 27);
            this.btnTrabajar.TabIndex = 16;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(38, 34);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 17;
            this.txtCarrera.Text = "Carrera";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(38, 84);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 18;
            this.txtTiempo.Text = "Tiempo en meses";
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(38, 138);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.TxtEspecialidad.TabIndex = 19;
            this.TxtEspecialidad.Text = "Especialidad";
            // 
            // frmPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 251);
            this.Controls.Add(this.TxtEspecialidad);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnDesarrollar);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmPPP";
            this.Text = "frmPPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnDesarrollar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox TxtEspecialidad;
    }
}
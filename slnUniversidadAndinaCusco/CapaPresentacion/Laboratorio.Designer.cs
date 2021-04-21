
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.txtCantMicros = new System.Windows.Forms.TextBox();
            this.txtTipoLab = new System.Windows.Forms.TextBox();
            this.txtTipoPersonal = new System.Windows.Forms.TextBox();
            this.txtPeriodoLimpieza = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnRecopilarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(100, 46);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(69, 20);
            this.txtAforo.TabIndex = 0;
            this.txtAforo.Text = "Aforo";
            // 
            // txtCantMicros
            // 
            this.txtCantMicros.Location = new System.Drawing.Point(100, 84);
            this.txtCantMicros.Name = "txtCantMicros";
            this.txtCantMicros.Size = new System.Drawing.Size(134, 20);
            this.txtCantMicros.TabIndex = 1;
            this.txtCantMicros.Text = "Cantidad de Microscopios";
            // 
            // txtTipoLab
            // 
            this.txtTipoLab.Location = new System.Drawing.Point(100, 123);
            this.txtTipoLab.Name = "txtTipoLab";
            this.txtTipoLab.Size = new System.Drawing.Size(100, 20);
            this.txtTipoLab.TabIndex = 2;
            this.txtTipoLab.Text = "Tipo de Laboratorio";
            // 
            // txtTipoPersonal
            // 
            this.txtTipoPersonal.Location = new System.Drawing.Point(100, 163);
            this.txtTipoPersonal.Name = "txtTipoPersonal";
            this.txtTipoPersonal.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPersonal.TabIndex = 3;
            this.txtTipoPersonal.Text = "Tipo de Personal";
            // 
            // txtPeriodoLimpieza
            // 
            this.txtPeriodoLimpieza.Location = new System.Drawing.Point(100, 204);
            this.txtPeriodoLimpieza.Name = "txtPeriodoLimpieza";
            this.txtPeriodoLimpieza.Size = new System.Drawing.Size(141, 20);
            this.txtPeriodoLimpieza.TabIndex = 4;
            this.txtPeriodoLimpieza.Text = "Periodo de Limpieza en dias";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(311, 84);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(311, 139);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(75, 266);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 7;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(187, 266);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigar.TabIndex = 8;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnRecopilarDatos
            // 
            this.btnRecopilarDatos.Location = new System.Drawing.Point(284, 265);
            this.btnRecopilarDatos.Name = "btnRecopilarDatos";
            this.btnRecopilarDatos.Size = new System.Drawing.Size(102, 23);
            this.btnRecopilarDatos.TabIndex = 9;
            this.btnRecopilarDatos.Text = "Recopilar Datos";
            this.btnRecopilarDatos.UseVisualStyleBackColor = true;
            this.btnRecopilarDatos.Click += new System.EventHandler(this.btnRecopilarDatos_Click);
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this.btnRecopilarDatos);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtPeriodoLimpieza);
            this.Controls.Add(this.txtTipoPersonal);
            this.Controls.Add(this.txtTipoLab);
            this.Controls.Add(this.txtCantMicros);
            this.Controls.Add(this.txtAforo);
            this.Name = "frmLaboratorio";
            this.Text = "Trabajar con clase laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.TextBox txtCantMicros;
        private System.Windows.Forms.TextBox txtTipoLab;
        private System.Windows.Forms.TextBox txtTipoPersonal;
        private System.Windows.Forms.TextBox txtPeriodoLimpieza;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnRecopilarDatos;
    }
}
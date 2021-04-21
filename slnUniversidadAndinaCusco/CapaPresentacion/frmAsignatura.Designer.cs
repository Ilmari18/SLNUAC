
namespace CapaPresentacion
{
    partial class frmAsignatura
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
            this.txtNombreAsig = new System.Windows.Forms.TextBox();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.btnEnsenar = new System.Windows.Forms.Button();
            this.btnAlmacenarInfo = new System.Windows.Forms.Button();
            this.btnContraProfe = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreAsig
            // 
            this.txtNombreAsig.Location = new System.Drawing.Point(61, 46);
            this.txtNombreAsig.Name = "txtNombreAsig";
            this.txtNombreAsig.Size = new System.Drawing.Size(130, 20);
            this.txtNombreAsig.TabIndex = 0;
            this.txtNombreAsig.Text = "Nombre de la Asignatura";
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(61, 95);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(100, 20);
            this.txtFacultad.TabIndex = 1;
            this.txtFacultad.Text = "Facultad";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(61, 143);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(114, 20);
            this.txtAntiguedad.TabIndex = 2;
            this.txtAntiguedad.Text = "Antiguedad en años";
            // 
            // btnEnsenar
            // 
            this.btnEnsenar.Location = new System.Drawing.Point(38, 214);
            this.btnEnsenar.Name = "btnEnsenar";
            this.btnEnsenar.Size = new System.Drawing.Size(75, 23);
            this.btnEnsenar.TabIndex = 3;
            this.btnEnsenar.Text = "Enseñar";
            this.btnEnsenar.UseVisualStyleBackColor = true;
            this.btnEnsenar.Click += new System.EventHandler(this.btnEnsenar_Click);
            // 
            // btnAlmacenarInfo
            // 
            this.btnAlmacenarInfo.Location = new System.Drawing.Point(130, 214);
            this.btnAlmacenarInfo.Name = "btnAlmacenarInfo";
            this.btnAlmacenarInfo.Size = new System.Drawing.Size(126, 23);
            this.btnAlmacenarInfo.TabIndex = 4;
            this.btnAlmacenarInfo.Text = "Almacenar informacion";
            this.btnAlmacenarInfo.UseVisualStyleBackColor = true;
            this.btnAlmacenarInfo.Click += new System.EventHandler(this.btnAlmacenarInfo_Click);
            // 
            // btnContraProfe
            // 
            this.btnContraProfe.Location = new System.Drawing.Point(280, 214);
            this.btnContraProfe.Name = "btnContraProfe";
            this.btnContraProfe.Size = new System.Drawing.Size(113, 23);
            this.btnContraProfe.TabIndex = 5;
            this.btnContraProfe.Text = "Contratar profesores";
            this.btnContraProfe.UseVisualStyleBackColor = true;
            this.btnContraProfe.Click += new System.EventHandler(this.btnContraProfe_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(280, 42);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 6;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(280, 118);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 376);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnContraProfe);
            this.Controls.Add(this.btnAlmacenarInfo);
            this.Controls.Add(this.btnEnsenar);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.txtNombreAsig);
            this.Name = "frmAsignatura";
            this.Text = "frmAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAsig;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Button btnEnsenar;
        private System.Windows.Forms.Button btnAlmacenarInfo;
        private System.Windows.Forms.Button btnContraProfe;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}
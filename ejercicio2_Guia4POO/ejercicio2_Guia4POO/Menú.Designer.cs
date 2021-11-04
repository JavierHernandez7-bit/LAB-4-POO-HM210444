
namespace ejercicio2_Guia4POO
{
    partial class Menú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndocente = new System.Windows.Forms.Button();
            this.btnestudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndocente
            // 
            this.btndocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocente.Location = new System.Drawing.Point(111, 202);
            this.btndocente.Name = "btndocente";
            this.btndocente.Size = new System.Drawing.Size(212, 88);
            this.btndocente.TabIndex = 1;
            this.btndocente.Text = "Registro \r\nDocentes";
            this.btndocente.UseVisualStyleBackColor = true;
            this.btndocente.Click += new System.EventHandler(this.btndocente_Click);
            // 
            // btnestudiante
            // 
            this.btnestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiante.Location = new System.Drawing.Point(450, 202);
            this.btnestudiante.Name = "btnestudiante";
            this.btnestudiante.Size = new System.Drawing.Size(212, 88);
            this.btnestudiante.TabIndex = 2;
            this.btnestudiante.Text = "Registro \r\nEstudiantes";
            this.btnestudiante.UseVisualStyleBackColor = true;
            this.btnestudiante.Click += new System.EventHandler(this.btnestudiante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Por favor, mantenga sus datos a la mano \r\nal seleccionar una de las opciones:";
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnestudiante);
            this.Controls.Add(this.btndocente);
            this.Name = "Menú";
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btndocente, 0);
            this.Controls.SetChildIndex(this.btnestudiante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndocente;
        private System.Windows.Forms.Button btnestudiante;
        private System.Windows.Forms.Label label1;
    }
}

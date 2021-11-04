
namespace P4_Ejercicio_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiantes.Location = new System.Drawing.Point(76, 21);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(190, 63);
            this.btnestudiantes.TabIndex = 1;
            this.btnestudiantes.Text = "Registro Estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = true;
            this.btnestudiantes.Click += new System.EventHandler(this.btnestudiantes_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(429, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Registro Docentes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(969, 106);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnestudiantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menú";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnestudiantes, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Button button3;
    }
}

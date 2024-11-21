
namespace Clave5_Grupo6
{
    partial class FormInicio
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
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionSalas = new System.Windows.Forms.Button();
            this.btnGestionReservas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(66, 139);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(131, 126);
            this.btnGestionUsuarios.TabIndex = 0;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionSalas
            // 
            this.btnGestionSalas.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGestionSalas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGestionSalas.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionSalas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGestionSalas.Location = new System.Drawing.Point(243, 139);
            this.btnGestionSalas.Name = "btnGestionSalas";
            this.btnGestionSalas.Size = new System.Drawing.Size(124, 126);
            this.btnGestionSalas.TabIndex = 1;
            this.btnGestionSalas.Text = "Gestion Salas ";
            this.btnGestionSalas.UseVisualStyleBackColor = false;
            this.btnGestionSalas.Click += new System.EventHandler(this.btnGestionSalas_Click_1);
            // 
            // btnGestionReservas
            // 
            this.btnGestionReservas.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGestionReservas.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionReservas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGestionReservas.Location = new System.Drawing.Point(425, 139);
            this.btnGestionReservas.Name = "btnGestionReservas";
            this.btnGestionReservas.Size = new System.Drawing.Size(125, 126);
            this.btnGestionReservas.TabIndex = 2;
            this.btnGestionReservas.Text = "Gestion Reservas";
            this.btnGestionReservas.UseVisualStyleBackColor = false;
            this.btnGestionReservas.Click += new System.EventHandler(this.btnGestionReservas_Click_1);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.btnGestionReservas);
            this.Controls.Add(this.btnGestionSalas);
            this.Controls.Add(this.btnGestionUsuarios);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "FormInicio";
            this.Text = "FormGestionSalas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionSalas;
        private System.Windows.Forms.Button btnGestionReservas;
    }
}


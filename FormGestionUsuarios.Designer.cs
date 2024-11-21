
namespace Clave5_Grupo6
{
    partial class FormGestionUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.btnEditarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnCargarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(42, 59);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(517, 175);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarUsuarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(42, 262);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(136, 68);
            this.btnAgregarUsuarios.TabIndex = 1;
            this.btnAgregarUsuarios.Text = "Agregar Usuarios";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnEditarUsuarios
            // 
            this.btnEditarUsuarios.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEditarUsuarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarUsuarios.Location = new System.Drawing.Point(184, 262);
            this.btnEditarUsuarios.Name = "btnEditarUsuarios";
            this.btnEditarUsuarios.Size = new System.Drawing.Size(122, 68);
            this.btnEditarUsuarios.TabIndex = 2;
            this.btnEditarUsuarios.Text = "Editar Usuarios";
            this.btnEditarUsuarios.UseVisualStyleBackColor = false;
            this.btnEditarUsuarios.Click += new System.EventHandler(this.btnEditarUsuarios_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(312, 262);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(127, 68);
            this.btnEliminarUsuarios.TabIndex = 3;
            this.btnEliminarUsuarios.Text = "Eliminar Usuarios";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = false;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnCargarUsuarios
            // 
            this.btnCargarUsuarios.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCargarUsuarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarUsuarios.Location = new System.Drawing.Point(455, 262);
            this.btnCargarUsuarios.Name = "btnCargarUsuarios";
            this.btnCargarUsuarios.Size = new System.Drawing.Size(116, 68);
            this.btnCargarUsuarios.TabIndex = 4;
            this.btnCargarUsuarios.Text = "Cargar Usuarios";
            this.btnCargarUsuarios.UseVisualStyleBackColor = false;
            this.btnCargarUsuarios.Click += new System.EventHandler(this.btnCargarUsuarios_Click);
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(608, 386);
            this.Controls.Add(this.btnCargarUsuarios);
            this.Controls.Add(this.btnEliminarUsuarios);
            this.Controls.Add(this.btnEditarUsuarios);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormGestionUsuarios";
            this.Text = "FormGestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Button btnEditarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnCargarUsuarios;
    }
}
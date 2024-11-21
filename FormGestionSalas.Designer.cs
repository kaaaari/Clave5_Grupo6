
namespace Clave5_Grupo6
{
    partial class FormGestionSalas
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
            this.btnAgregarSala = new System.Windows.Forms.Button();
            this.btnEditarSala = new System.Windows.Forms.Button();
            this.btnCargarSala = new System.Windows.Forms.Button();
            this.btnEliminarSala = new System.Windows.Forms.Button();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarSala
            // 
            this.btnAgregarSala.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAgregarSala.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSala.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarSala.Location = new System.Drawing.Point(71, 268);
            this.btnAgregarSala.Name = "btnAgregarSala";
            this.btnAgregarSala.Size = new System.Drawing.Size(120, 36);
            this.btnAgregarSala.TabIndex = 0;
            this.btnAgregarSala.Text = "Agregar Sala";
            this.btnAgregarSala.UseVisualStyleBackColor = false;
            this.btnAgregarSala.Click += new System.EventHandler(this.btnAgregarSala_Click_1);
            // 
            // btnEditarSala
            // 
            this.btnEditarSala.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEditarSala.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSala.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarSala.Location = new System.Drawing.Point(224, 268);
            this.btnEditarSala.Name = "btnEditarSala";
            this.btnEditarSala.Size = new System.Drawing.Size(108, 36);
            this.btnEditarSala.TabIndex = 1;
            this.btnEditarSala.Text = "Editar Sala";
            this.btnEditarSala.UseVisualStyleBackColor = false;
            this.btnEditarSala.Click += new System.EventHandler(this.btnEditarSala_Click_1);
            // 
            // btnCargarSala
            // 
            this.btnCargarSala.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCargarSala.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarSala.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarSala.Location = new System.Drawing.Point(366, 268);
            this.btnCargarSala.Name = "btnCargarSala";
            this.btnCargarSala.Size = new System.Drawing.Size(115, 36);
            this.btnCargarSala.TabIndex = 2;
            this.btnCargarSala.Text = "Cargar Sala";
            this.btnCargarSala.UseVisualStyleBackColor = false;
            this.btnCargarSala.Click += new System.EventHandler(this.btnCargarSala_Click);
            // 
            // btnEliminarSala
            // 
            this.btnEliminarSala.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminarSala.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSala.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarSala.Location = new System.Drawing.Point(505, 268);
            this.btnEliminarSala.Name = "btnEliminarSala";
            this.btnEliminarSala.Size = new System.Drawing.Size(120, 36);
            this.btnEliminarSala.TabIndex = 3;
            this.btnEliminarSala.Text = "Eliminar Sala";
            this.btnEliminarSala.UseVisualStyleBackColor = false;
            this.btnEliminarSala.Click += new System.EventHandler(this.btnEliminarSala_Click_1);
            // 
            // dgvSalas
            // 
            this.dgvSalas.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Location = new System.Drawing.Point(71, 70);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.Size = new System.Drawing.Size(554, 163);
            this.dgvSalas.TabIndex = 4;
            // 
            // FormGestionSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(699, 356);
            this.Controls.Add(this.dgvSalas);
            this.Controls.Add(this.btnEliminarSala);
            this.Controls.Add(this.btnCargarSala);
            this.Controls.Add(this.btnEditarSala);
            this.Controls.Add(this.btnAgregarSala);
            this.Name = "FormGestionSalas";
            this.Text = "FormGestionSalas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSala;
        private System.Windows.Forms.Button btnEditarSala;
        private System.Windows.Forms.Button btnCargarSala;
        private System.Windows.Forms.Button btnEliminarSala;
        private System.Windows.Forms.DataGridView dgvSalas;
    }
}
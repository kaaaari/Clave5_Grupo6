
namespace Clave5_Grupo6
{
    partial class FormGestionReservas
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnCargarReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(51, 55);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(483, 171);
            this.dgvReservas.TabIndex = 0;
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarReserva.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReserva.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarReserva.Location = new System.Drawing.Point(51, 252);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(123, 60);
            this.btnAgregarReserva.TabIndex = 1;
            this.btnAgregarReserva.Text = "Agregar Reserva";
            this.btnAgregarReserva.UseVisualStyleBackColor = false;
            this.btnAgregarReserva.Click += new System.EventHandler(this.btnAgregarReserva_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEditarReserva.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarReserva.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarReserva.Location = new System.Drawing.Point(190, 252);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(106, 60);
            this.btnEditarReserva.TabIndex = 2;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = false;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminarReserva.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReserva.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarReserva.Location = new System.Drawing.Point(314, 252);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(108, 60);
            this.btnEliminarReserva.TabIndex = 3;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = false;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // btnCargarReservas
            // 
            this.btnCargarReservas.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCargarReservas.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarReservas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarReservas.Location = new System.Drawing.Point(431, 252);
            this.btnCargarReservas.Name = "btnCargarReservas";
            this.btnCargarReservas.Size = new System.Drawing.Size(103, 60);
            this.btnCargarReservas.TabIndex = 4;
            this.btnCargarReservas.Text = "Cargar Reservas";
            this.btnCargarReservas.UseVisualStyleBackColor = false;
            this.btnCargarReservas.Click += new System.EventHandler(this.btnCargarReservas_Click);
            // 
            // FormGestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(588, 363);
            this.Controls.Add(this.btnCargarReservas);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.dgvReservas);
            this.Name = "FormGestionReservas";
            this.Text = "FormGestionReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnCargarReservas;
    }
}
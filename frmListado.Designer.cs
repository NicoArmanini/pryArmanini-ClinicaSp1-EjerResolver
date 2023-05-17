namespace pryArmanini_ClinicaSp1_EjerResolver
{
    partial class frmListado
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistroMedico = new System.Windows.Forms.Button();
            this.btnRegistroEspecialidad = new System.Windows.Forms.Button();
            this.mrcConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(678, 341);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.btnActualizar);
            this.mrcConsulta.Controls.Add(this.btnLimpiar);
            this.mrcConsulta.Controls.Add(this.lblSeleccionar);
            this.mrcConsulta.Controls.Add(this.cmbEspecialidad);
            this.mrcConsulta.Controls.Add(this.lblMedicos);
            this.mrcConsulta.Controls.Add(this.btnConsultar);
            this.mrcConsulta.Controls.Add(this.lblEspecialidad);
            this.mrcConsulta.Controls.Add(this.dgvConsulta);
            this.mrcConsulta.Location = new System.Drawing.Point(13, 23);
            this.mrcConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.mrcConsulta.Size = new System.Drawing.Size(607, 340);
            this.mrcConsulta.TabIndex = 12;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta Médico";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(467, 39);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 26);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "&Reiniciar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(467, 217);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(27, 39);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(145, 16);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Especialidad a buscar:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(199, 36);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(160, 24);
            this.cmbEspecialidad.TabIndex = 1;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(27, 80);
            this.lblMedicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(78, 16);
            this.lblMedicos.TabIndex = 3;
            this.lblMedicos.Text = "Médicos de";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(467, 169);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(107, 80);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(0, 16);
            this.lblEspecialidad.TabIndex = 4;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsulta.Location = new System.Drawing.Point(31, 118);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(404, 185);
            this.dgvConsulta.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matrícula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido y Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // btnRegistroMedico
            // 
            this.btnRegistroMedico.Location = new System.Drawing.Point(643, 103);
            this.btnRegistroMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroMedico.Name = "btnRegistroMedico";
            this.btnRegistroMedico.Size = new System.Drawing.Size(135, 43);
            this.btnRegistroMedico.TabIndex = 11;
            this.btnRegistroMedico.Text = "&Registrar Médico";
            this.btnRegistroMedico.UseVisualStyleBackColor = true;
            // 
            // btnRegistroEspecialidad
            // 
            this.btnRegistroEspecialidad.Location = new System.Drawing.Point(643, 38);
            this.btnRegistroEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroEspecialidad.Name = "btnRegistroEspecialidad";
            this.btnRegistroEspecialidad.Size = new System.Drawing.Size(135, 43);
            this.btnRegistroEspecialidad.TabIndex = 10;
            this.btnRegistroEspecialidad.Text = "&Registrar Especialidad";
            this.btnRegistroEspecialidad.UseVisualStyleBackColor = true;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.btnRegistroMedico);
            this.Controls.Add(this.btnRegistroEspecialidad);
            this.Name = "frmListado";
            this.Text = "Consulta Medico por Especialidad";
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRegistroMedico;
        private System.Windows.Forms.Button btnRegistroEspecialidad;
    }
}
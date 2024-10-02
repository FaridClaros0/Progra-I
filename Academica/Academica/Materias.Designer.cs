namespace Academica
{
    partial class Materias
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
            this.lblBuscarMateria = new System.Windows.Forms.Label();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grdDatosMateria = new System.Windows.Forms.DataGridView();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevaMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMaterias = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimerMateria = new System.Windows.Forms.Button();
            this.grbDatosMaterias = new System.Windows.Forms.GroupBox();
            this.lblUvMaterias = new System.Windows.Forms.Label();
            this.txtUvMaterias = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtNombreMaterias = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.txtCodigoMaterias = new System.Windows.Forms.TextBox();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).BeginInit();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarMateria
            // 
            this.lblBuscarMateria.AutoSize = true;
            this.lblBuscarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMateria.Location = new System.Drawing.Point(522, 27);
            this.lblBuscarMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarMateria.Name = "lblBuscarMateria";
            this.lblBuscarMateria.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarMateria.TabIndex = 11;
            this.lblBuscarMateria.Text = "BUSCAR:";
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(647, 30);
            this.txtBuscarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(562, 22);
            this.txtBuscarMateria.TabIndex = 10;
            this.txtBuscarMateria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMateria_KeyUp);
            // 
            // grdDatosMateria
            // 
            this.grdDatosMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMateria.Location = new System.Drawing.Point(527, 59);
            this.grdDatosMateria.Name = "grdDatosMateria";
            this.grdDatosMateria.RowHeadersWidth = 51;
            this.grdDatosMateria.RowTemplate.Height = 24;
            this.grdDatosMateria.Size = new System.Drawing.Size(683, 246);
            this.grdDatosMateria.TabIndex = 9;
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnNuevaMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(349, 333);
            this.grbEdicionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Size = new System.Drawing.Size(401, 123);
            this.grbEdicionMateria.TabIndex = 8;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(252, 34);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(131, 46);
            this.btnEliminarMateria.TabIndex = 5;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(113, 34);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(146, 46);
            this.btnModificarMateria.TabIndex = 4;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnNuevaMateria
            // 
            this.btnNuevaMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMateria.Location = new System.Drawing.Point(8, 34);
            this.btnNuevaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaMateria.Name = "btnNuevaMateria";
            this.btnNuevaMateria.Size = new System.Drawing.Size(107, 46);
            this.btnNuevaMateria.TabIndex = 3;
            this.btnNuevaMateria.Text = "Nuevo";
            this.btnNuevaMateria.UseVisualStyleBackColor = true;
            this.btnNuevaMateria.Click += new System.EventHandler(this.btnNuevaMateria_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblRegistrosMaterias);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimerMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(13, 333);
            this.grbNavegacionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(321, 123);
            this.grbNavegacionMateria.TabIndex = 7;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblRegistrosMaterias
            // 
            this.lblRegistrosMaterias.AutoSize = true;
            this.lblRegistrosMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosMaterias.Location = new System.Drawing.Point(97, 43);
            this.lblRegistrosMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosMaterias.Name = "lblRegistrosMaterias";
            this.lblRegistrosMaterias.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosMaterias.TabIndex = 4;
            this.lblRegistrosMaterias.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(213, 34);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(62, 46);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">>";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(179, 34);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(40, 46);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(49, 34);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(40, 46);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimerMateria
            // 
            this.btnPrimerMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerMateria.Location = new System.Drawing.Point(0, 34);
            this.btnPrimerMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimerMateria.Name = "btnPrimerMateria";
            this.btnPrimerMateria.Size = new System.Drawing.Size(53, 46);
            this.btnPrimerMateria.TabIndex = 0;
            this.btnPrimerMateria.Text = "<<";
            this.btnPrimerMateria.UseVisualStyleBackColor = true;
            this.btnPrimerMateria.Click += new System.EventHandler(this.btnPrimerMateria_Click);
            // 
            // grbDatosMaterias
            // 
            this.grbDatosMaterias.Controls.Add(this.lblUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.txtUvMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblNombreMateria);
            this.grbDatosMaterias.Controls.Add(this.txtNombreMaterias);
            this.grbDatosMaterias.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMaterias.Controls.Add(this.txtCodigoMaterias);
            this.grbDatosMaterias.Enabled = false;
            this.grbDatosMaterias.Location = new System.Drawing.Point(13, 13);
            this.grbDatosMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosMaterias.Name = "grbDatosMaterias";
            this.grbDatosMaterias.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosMaterias.Size = new System.Drawing.Size(488, 292);
            this.grbDatosMaterias.TabIndex = 6;
            this.grbDatosMaterias.TabStop = false;
            this.grbDatosMaterias.Text = "Datos Alumnos";
            // 
            // lblUvMaterias
            // 
            this.lblUvMaterias.AutoSize = true;
            this.lblUvMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUvMaterias.Location = new System.Drawing.Point(21, 140);
            this.lblUvMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMaterias.Name = "lblUvMaterias";
            this.lblUvMaterias.Size = new System.Drawing.Size(51, 29);
            this.lblUvMaterias.TabIndex = 5;
            this.lblUvMaterias.Text = "UV:";
            // 
            // txtUvMaterias
            // 
            this.txtUvMaterias.Location = new System.Drawing.Point(143, 140);
            this.txtUvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.txtUvMaterias.Name = "txtUvMaterias";
            this.txtUvMaterias.Size = new System.Drawing.Size(132, 22);
            this.txtUvMaterias.TabIndex = 4;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(21, 92);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(107, 29);
            this.lblNombreMateria.TabIndex = 3;
            this.lblNombreMateria.Text = "Nombre:";
            // 
            // txtNombreMaterias
            // 
            this.txtNombreMaterias.Location = new System.Drawing.Point(143, 92);
            this.txtNombreMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMaterias.Name = "txtNombreMaterias";
            this.txtNombreMaterias.Size = new System.Drawing.Size(331, 22);
            this.txtNombreMaterias.TabIndex = 2;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMateria.Location = new System.Drawing.Point(21, 46);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoMateria.TabIndex = 1;
            this.lblCodigoMateria.Text = "Codigo:";
            // 
            // txtCodigoMaterias
            // 
            this.txtCodigoMaterias.Location = new System.Drawing.Point(143, 46);
            this.txtCodigoMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMaterias.Name = "txtCodigoMaterias";
            this.txtCodigoMaterias.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoMaterias.TabIndex = 0;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "ID";
            this.idMateria.MinimumWidth = 6;
            this.idMateria.Name = "idMateria";
            this.idMateria.Visible = false;
            this.idMateria.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.MinimumWidth = 6;
            this.uv.Name = "uv";
            this.uv.Width = 125;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 620);
            this.Controls.Add(this.lblBuscarMateria);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.grdDatosMateria);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMaterias);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).EndInit();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMaterias.ResumeLayout(false);
            this.grbDatosMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.DataGridView grdDatosMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevaMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblRegistrosMaterias;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimerMateria;
        private System.Windows.Forms.GroupBox grbDatosMaterias;
        private System.Windows.Forms.Label lblUvMaterias;
        private System.Windows.Forms.TextBox txtUvMaterias;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtNombreMaterias;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.TextBox txtCodigoMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}
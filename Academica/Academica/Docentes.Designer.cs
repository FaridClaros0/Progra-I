namespace Academica
{
    partial class Docentes
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
            this.lblBuscarDocente = new System.Windows.Forms.Label();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimerDocente = new System.Windows.Forms.Button();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.lblDuiDocente = new System.Windows.Forms.Label();
            this.txtDuiDocente = new System.Windows.Forms.TextBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.txtEmailDocente = new System.Windows.Forms.TextBox();
            this.lblEmailDocente = new System.Windows.Forms.Label();
            this.lblEspecialidadDocente = new System.Windows.Forms.Label();
            this.cmbxEspecialidadDocente = new System.Windows.Forms.ComboBox();
            this.idDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbDatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocente
            // 
            this.lblBuscarDocente.AutoSize = true;
            this.lblBuscarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocente.Location = new System.Drawing.Point(522, 27);
            this.lblBuscarDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarDocente.Name = "lblBuscarDocente";
            this.lblBuscarDocente.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarDocente.TabIndex = 11;
            this.lblBuscarDocente.Text = "BUSCAR:";
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(647, 30);
            this.txtBuscarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(822, 22);
            this.txtBuscarDocente.TabIndex = 10;
            this.txtBuscarDocente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocente_KeyUp);
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocente,
            this.codigo,
            this.nombre,
            this.direccion,
            this.dui,
            this.telefono,
            this.Email,
            this.Especialidad});
            this.grdDatosDocentes.Location = new System.Drawing.Point(527, 59);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.RowHeadersWidth = 51;
            this.grdDatosDocentes.RowTemplate.Height = 24;
            this.grdDatosDocentes.Size = new System.Drawing.Size(942, 246);
            this.grdDatosDocentes.TabIndex = 9;
            this.grdDatosDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosDocentes_CellClick);
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnNuevoDocente);
            this.grbEdicionDocente.Location = new System.Drawing.Point(363, 463);
            this.grbEdicionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocente.Size = new System.Drawing.Size(401, 123);
            this.grbEdicionDocente.TabIndex = 8;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(252, 34);
            this.btnEliminarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(131, 46);
            this.btnEliminarDocente.TabIndex = 5;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(113, 34);
            this.btnModificarDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(146, 46);
            this.btnModificarDocente.TabIndex = 4;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.Location = new System.Drawing.Point(8, 34);
            this.btnNuevoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(107, 46);
            this.btnNuevoDocente.TabIndex = 3;
            this.btnNuevoDocente.Text = "Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblRegistrosDocentes);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimerDocente);
            this.grbNavegacionDocente.Location = new System.Drawing.Point(13, 463);
            this.grbNavegacionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocente.Size = new System.Drawing.Size(321, 123);
            this.grbNavegacionDocente.TabIndex = 7;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblRegistrosDocentes
            // 
            this.lblRegistrosDocentes.AutoSize = true;
            this.lblRegistrosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocentes.Location = new System.Drawing.Point(97, 43);
            this.lblRegistrosDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosDocentes.Name = "lblRegistrosDocentes";
            this.lblRegistrosDocentes.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosDocentes.TabIndex = 4;
            this.lblRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(213, 34);
            this.btnUltimoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(62, 46);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">>";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(179, 34);
            this.btnSiguienteDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(40, 46);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(49, 34);
            this.btnAnteriorDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(40, 46);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimerDocente
            // 
            this.btnPrimerDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerDocente.Location = new System.Drawing.Point(0, 34);
            this.btnPrimerDocente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimerDocente.Name = "btnPrimerDocente";
            this.btnPrimerDocente.Size = new System.Drawing.Size(53, 46);
            this.btnPrimerDocente.TabIndex = 0;
            this.btnPrimerDocente.Text = "<<";
            this.btnPrimerDocente.UseVisualStyleBackColor = true;
            this.btnPrimerDocente.Click += new System.EventHandler(this.btnPrimerDocente_Click);
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.cmbxEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.lblEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.txtEmailDocente);
            this.grbDatosDocente.Controls.Add(this.lblEmailDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblDuiDocente);
            this.grbDatosDocente.Controls.Add(this.txtDuiDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Enabled = false;
            this.grbDatosDocente.Location = new System.Drawing.Point(13, 13);
            this.grbDatosDocente.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosDocente.Size = new System.Drawing.Size(507, 404);
            this.grbDatosDocente.TabIndex = 6;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "Datos Alumnos";
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDocente.Location = new System.Drawing.Point(36, 183);
            this.lblTelefonoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(116, 29);
            this.lblTelefonoDocente.TabIndex = 9;
            this.lblTelefonoDocente.Text = "Telefono:";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(160, 190);
            this.txtTelefonoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoDocente.TabIndex = 8;
            // 
            // lblDuiDocente
            // 
            this.lblDuiDocente.AutoSize = true;
            this.lblDuiDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiDocente.Location = new System.Drawing.Point(97, 233);
            this.lblDuiDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuiDocente.Name = "lblDuiDocente";
            this.lblDuiDocente.Size = new System.Drawing.Size(55, 29);
            this.lblDuiDocente.TabIndex = 7;
            this.lblDuiDocente.Text = "Dui:";
            // 
            // txtDuiDocente
            // 
            this.txtDuiDocente.Location = new System.Drawing.Point(169, 233);
            this.txtDuiDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuiDocente.Name = "txtDuiDocente";
            this.txtDuiDocente.Size = new System.Drawing.Size(132, 22);
            this.txtDuiDocente.TabIndex = 6;
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDocente.Location = new System.Drawing.Point(31, 135);
            this.lblDireccionDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(121, 29);
            this.lblDireccionDocente.TabIndex = 5;
            this.lblDireccionDocente.Text = "Direccion:";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(169, 142);
            this.txtDireccionDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(132, 22);
            this.txtDireccionDocente.TabIndex = 4;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocente.Location = new System.Drawing.Point(36, 92);
            this.lblNombreDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(107, 29);
            this.lblNombreDocente.TabIndex = 3;
            this.lblNombreDocente.Text = "Nombre:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(169, 92);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(331, 22);
            this.txtNombreDocente.TabIndex = 2;
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocente.Location = new System.Drawing.Point(36, 46);
            this.lblCodigoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoDocente.TabIndex = 1;
            this.lblCodigoDocente.Text = "Codigo:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(169, 46);
            this.txtCodigoDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDocente.TabIndex = 0;
            // 
            // txtEmailDocente
            // 
            this.txtEmailDocente.Location = new System.Drawing.Point(169, 276);
            this.txtEmailDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailDocente.Name = "txtEmailDocente";
            this.txtEmailDocente.Size = new System.Drawing.Size(311, 22);
            this.txtEmailDocente.TabIndex = 11;
            // 
            // lblEmailDocente
            // 
            this.lblEmailDocente.AutoSize = true;
            this.lblEmailDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDocente.Location = new System.Drawing.Point(83, 276);
            this.lblEmailDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailDocente.Name = "lblEmailDocente";
            this.lblEmailDocente.Size = new System.Drawing.Size(80, 29);
            this.lblEmailDocente.TabIndex = 10;
            this.lblEmailDocente.Text = "Email:";
            // 
            // lblEspecialidadDocente
            // 
            this.lblEspecialidadDocente.AutoSize = true;
            this.lblEspecialidadDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadDocente.Location = new System.Drawing.Point(8, 319);
            this.lblEspecialidadDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidadDocente.Name = "lblEspecialidadDocente";
            this.lblEspecialidadDocente.Size = new System.Drawing.Size(159, 29);
            this.lblEspecialidadDocente.TabIndex = 12;
            this.lblEspecialidadDocente.Text = "Especialidad:";
            // 
            // cmbxEspecialidadDocente
            // 
            this.cmbxEspecialidadDocente.FormattingEnabled = true;
            this.cmbxEspecialidadDocente.Items.AddRange(new object[] {
            "Medicina",
            "Tecnologia",
            "Derecho",
            "Comunicacion",
            "Artistico",
            "Contaduria",
            "Humanidades"});
            this.cmbxEspecialidadDocente.Location = new System.Drawing.Point(169, 326);
            this.cmbxEspecialidadDocente.Name = "cmbxEspecialidadDocente";
            this.cmbxEspecialidadDocente.Size = new System.Drawing.Size(219, 24);
            this.cmbxEspecialidadDocente.TabIndex = 13;
            // 
            // idDocente
            // 
            this.idDocente.DataPropertyName = "IdDocente";
            this.idDocente.HeaderText = "ID";
            this.idDocente.MinimumWidth = 6;
            this.idDocente.Name = "idDocente";
            this.idDocente.ReadOnly = true;
            this.idDocente.Visible = false;
            this.idDocente.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // dui
            // 
            this.dui.DataPropertyName = "dui";
            this.dui.HeaderText = "DUI";
            this.dui.MinimumWidth = 6;
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            this.dui.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "EMAIL";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "especialidad";
            this.Especialidad.HeaderText = "ESPECIALIDAD";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 125;
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 643);
            this.Controls.Add(this.lblBuscarDocente);
            this.Controls.Add(this.txtBuscarDocente);
            this.Controls.Add(this.grdDatosDocentes);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocente;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimerDocente;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label lblDuiDocente;
        private System.Windows.Forms.TextBox txtDuiDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.Label lblEspecialidadDocente;
        private System.Windows.Forms.TextBox txtEmailDocente;
        private System.Windows.Forms.Label lblEmailDocente;
        private System.Windows.Forms.ComboBox cmbxEspecialidadDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}
namespace GestorTareas
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BuscadorDTGV = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorFecha = new System.Windows.Forms.Button();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.dtpfechamaxima = new System.Windows.Forms.DateTimePicker();
            this.dtmfechaminima = new System.Windows.Forms.DateTimePicker();
            this.cbxBusqueda = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscadorDTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.lblEstado);
            this.tabPage1.Controls.Add(this.lblLugar);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Controls.Add(this.dgvTareas);
            this.tabPage1.Controls.Add(this.cmbEstado);
            this.tabPage1.Controls.Add(this.dtpFecha);
            this.tabPage1.Controls.Add(this.txtLugar);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(306, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(306, 23);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(153, 78);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 14;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(153, 23);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo:";
            // 
            // dgvTareas
            // 
            this.dgvTareas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(21, 171);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(488, 193);
            this.dgvTareas.TabIndex = 10;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "No realizada",
            "En proceso",
            "Terminada"});
            this.cmbEstado.Location = new System.Drawing.Point(309, 37);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 9;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(309, 94);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(156, 94);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 7;
            this.txtLugar.TextChanged += new System.EventHandler(this.txtLugar_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(156, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(21, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(412, 370);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(289, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(156, 370);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aqua;
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.BuscadorDTGV);
            this.tabPage2.Controls.Add(this.btnBuscarPorFecha);
            this.tabPage2.Controls.Add(this.btnBuscarEstado);
            this.tabPage2.Controls.Add(this.btnBuscarCodigo);
            this.tabPage2.Controls.Add(this.dtpfechamaxima);
            this.tabPage2.Controls.Add(this.dtmfechaminima);
            this.tabPage2.Controls.Add(this.cbxBusqueda);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fecha Maxima";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha Minima";
            // 
            // BuscadorDTGV
            // 
            this.BuscadorDTGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BuscadorDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscadorDTGV.Location = new System.Drawing.Point(8, 195);
            this.BuscadorDTGV.Name = "BuscadorDTGV";
            this.BuscadorDTGV.Size = new System.Drawing.Size(514, 219);
            this.BuscadorDTGV.TabIndex = 7;
            this.BuscadorDTGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuscadorDTGV_CellContentClick);
            // 
            // btnBuscarPorFecha
            // 
            this.btnBuscarPorFecha.Location = new System.Drawing.Point(357, 105);
            this.btnBuscarPorFecha.Name = "btnBuscarPorFecha";
            this.btnBuscarPorFecha.Size = new System.Drawing.Size(110, 23);
            this.btnBuscarPorFecha.TabIndex = 6;
            this.btnBuscarPorFecha.Text = "Buscar Por Fecha";
            this.btnBuscarPorFecha.UseVisualStyleBackColor = true;
            this.btnBuscarPorFecha.Click += new System.EventHandler(this.btnBuscarPorFecha_Click);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Location = new System.Drawing.Point(152, 76);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarEstado.TabIndex = 5;
            this.btnBuscarEstado.Text = "Buscar por Estado";
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(6, 80);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarCodigo.TabIndex = 4;
            this.btnBuscarCodigo.Text = "Buscar por Codigo";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // dtpfechamaxima
            // 
            this.dtpfechamaxima.Location = new System.Drawing.Point(308, 79);
            this.dtpfechamaxima.Name = "dtpfechamaxima";
            this.dtpfechamaxima.Size = new System.Drawing.Size(200, 20);
            this.dtpfechamaxima.TabIndex = 3;
            this.dtpfechamaxima.ValueChanged += new System.EventHandler(this.dtpfechamaxima_ValueChanged);
            // 
            // dtmfechaminima
            // 
            this.dtmfechaminima.Location = new System.Drawing.Point(308, 28);
            this.dtmfechaminima.Name = "dtmfechaminima";
            this.dtmfechaminima.Size = new System.Drawing.Size(200, 20);
            this.dtmfechaminima.TabIndex = 2;
            this.dtmfechaminima.ValueChanged += new System.EventHandler(this.dtmfechaminima_ValueChanged);
            // 
            // cbxBusqueda
            // 
            this.cbxBusqueda.FormattingEnabled = true;
            this.cbxBusqueda.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbxBusqueda.Items.AddRange(new object[] {
            "No realizada",
            "En proceso",
            "Terminada"});
            this.cbxBusqueda.Location = new System.Drawing.Point(152, 43);
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cbxBusqueda.TabIndex = 1;
            this.cbxBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbxBusqueda_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestor de Tareas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscadorDTGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridView BuscadorDTGV;
        private System.Windows.Forms.Button btnBuscarPorFecha;
        private System.Windows.Forms.Button btnBuscarEstado;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.DateTimePicker dtpfechamaxima;
        private System.Windows.Forms.DateTimePicker dtmfechaminima;
        private System.Windows.Forms.ComboBox cbxBusqueda;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
    }
}


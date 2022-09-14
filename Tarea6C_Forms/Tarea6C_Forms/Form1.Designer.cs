namespace Tarea6C_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCambio = new System.Windows.Forms.Button();
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtShipperId = new System.Windows.Forms.TextBox();
            this.lblShipperID = new System.Windows.Forms.Label();
            this.gridShippers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarCambio);
            this.groupBox1.Controls.Add(this.btnGuardarCambio);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.txtShipperId);
            this.groupBox1.Controls.Add(this.lblShipperID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelarCambio
            // 
            this.btnCancelarCambio.Location = new System.Drawing.Point(527, 134);
            this.btnCancelarCambio.Name = "btnCancelarCambio";
            this.btnCancelarCambio.Size = new System.Drawing.Size(119, 41);
            this.btnCancelarCambio.TabIndex = 7;
            this.btnCancelarCambio.Text = "Cancelar";
            this.btnCancelarCambio.UseVisualStyleBackColor = true;
            this.btnCancelarCambio.Click += new System.EventHandler(this.btnCancelarCambio_Click);
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.Location = new System.Drawing.Point(527, 81);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(119, 41);
            this.btnGuardarCambio.TabIndex = 6;
            this.btnGuardarCambio.Text = "Guardar";
            this.btnGuardarCambio.UseVisualStyleBackColor = true;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(203, 137);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(268, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(203, 83);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(268, 34);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(21, 87);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(157, 28);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtShipperId
            // 
            this.txtShipperId.Enabled = false;
            this.txtShipperId.Location = new System.Drawing.Point(203, 33);
            this.txtShipperId.Name = "txtShipperId";
            this.txtShipperId.Size = new System.Drawing.Size(139, 34);
            this.txtShipperId.TabIndex = 1;
            // 
            // lblShipperID
            // 
            this.lblShipperID.AutoSize = true;
            this.lblShipperID.Location = new System.Drawing.Point(21, 37);
            this.lblShipperID.Name = "lblShipperID";
            this.lblShipperID.Size = new System.Drawing.Size(104, 28);
            this.lblShipperID.TabIndex = 0;
            this.lblShipperID.Text = "Shipper ID";
            // 
            // gridShippers
            // 
            this.gridShippers.AllowUserToAddRows = false;
            this.gridShippers.AllowUserToDeleteRows = false;
            this.gridShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShippers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridShippers.Location = new System.Drawing.Point(30, 317);
            this.gridShippers.Name = "gridShippers";
            this.gridShippers.RowHeadersWidth = 51;
            this.gridShippers.RowTemplate.Height = 29;
            this.gridShippers.Size = new System.Drawing.Size(692, 188);
            this.gridShippers.TabIndex = 1;
            this.gridShippers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShippers_CellClick);
            this.gridShippers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridShippers_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Image = global::Tarea6C_Forms.Properties.Resources.insert;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(30, 511);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Image = global::Tarea6C_Forms.Properties.Resources.edit;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(216, 511);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 44);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = global::Tarea6C_Forms.Properties.Resources.remove;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(392, 511);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 44);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = global::Tarea6C_Forms.Properties.Resources.stop_error;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(573, 511);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 603);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gridShippers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShippers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtShipperId;
        private Label lblShipperID;
        private DataGridView gridShippers;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewCheckBoxColumn Column1;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private TextBox txtPhone;
        private Label label1;
        private Button btnCancelarCambio;
        private Button btnGuardarCambio;
    }
}
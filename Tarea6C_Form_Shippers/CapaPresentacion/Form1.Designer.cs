namespace CapaPresentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDistribuidor = new System.Windows.Forms.TextBox();
            this.btnNuevoDistribuidor = new System.Windows.Forms.Button();
            this.btnEditarDistribuidor = new System.Windows.Forms.Button();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gridDistribuidores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarDistribuidor
            // 
            this.txtBuscarDistribuidor.Location = new System.Drawing.Point(93, 51);
            this.txtBuscarDistribuidor.Name = "txtBuscarDistribuidor";
            this.txtBuscarDistribuidor.Size = new System.Drawing.Size(317, 27);
            this.txtBuscarDistribuidor.TabIndex = 1;
            this.txtBuscarDistribuidor.TextChanged += new System.EventHandler(this.txtBuscarDistribuidor_TextChanged);
            // 
            // btnNuevoDistribuidor
            // 
            this.btnNuevoDistribuidor.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btnNuevoDistribuidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDistribuidor.Location = new System.Drawing.Point(753, 51);
            this.btnNuevoDistribuidor.Name = "btnNuevoDistribuidor";
            this.btnNuevoDistribuidor.Size = new System.Drawing.Size(125, 41);
            this.btnNuevoDistribuidor.TabIndex = 3;
            this.btnNuevoDistribuidor.Text = "Nuevo";
            this.btnNuevoDistribuidor.UseVisualStyleBackColor = true;
            this.btnNuevoDistribuidor.Click += new System.EventHandler(this.btnNuevoDistribuidor_Click);
            // 
            // btnEditarDistribuidor
            // 
            this.btnEditarDistribuidor.Image = global::CapaPresentacion.Properties.Resources.app_preferences;
            this.btnEditarDistribuidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDistribuidor.Location = new System.Drawing.Point(622, 51);
            this.btnEditarDistribuidor.Name = "btnEditarDistribuidor";
            this.btnEditarDistribuidor.Size = new System.Drawing.Size(125, 41);
            this.btnEditarDistribuidor.TabIndex = 4;
            this.btnEditarDistribuidor.Text = "Editar";
            this.btnEditarDistribuidor.UseVisualStyleBackColor = true;
            this.btnEditarDistribuidor.Click += new System.EventHandler(this.btnEditarDistribuidor_Click);
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(47, 323);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RowHeadersWidth = 51;
            this.gridOrders.RowTemplate.Height = 29;
            this.gridOrders.Size = new System.Drawing.Size(1102, 188);
            this.gridOrders.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1024, 51);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gridDistribuidores
            // 
            this.gridDistribuidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribuidores.Location = new System.Drawing.Point(47, 115);
            this.gridDistribuidores.Name = "gridDistribuidores";
            this.gridDistribuidores.RowHeadersWidth = 51;
            this.gridDistribuidores.RowTemplate.Height = 29;
            this.gridDistribuidores.Size = new System.Drawing.Size(1102, 188);
            this.gridDistribuidores.TabIndex = 8;
            this.gridDistribuidores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDistribuidores_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.file_del;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(885, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 41);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.find;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(453, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 41);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar Código";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 606);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gridDistribuidores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.btnEditarDistribuidor);
            this.Controls.Add(this.btnNuevoDistribuidor);
            this.Controls.Add(this.txtBuscarDistribuidor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distribuidores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribuidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBuscarDistribuidor;
        private Button btnNuevoDistribuidor;
        private Button btnEditarDistribuidor;
        private DataGridView gridOrders;
        private Button btnSalir;
        private DataGridView gridDistribuidores;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}
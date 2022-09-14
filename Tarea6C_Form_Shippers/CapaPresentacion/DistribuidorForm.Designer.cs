namespace CapaPresentacion
{
    partial class DistribuidorForm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCacelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDistribuidorId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(517, 35);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCacelar
            // 
            this.btnCacelar.Location = new System.Drawing.Point(517, 98);
            this.btnCacelar.Name = "btnCacelar";
            this.btnCacelar.Size = new System.Drawing.Size(94, 29);
            this.btnCacelar.TabIndex = 1;
            this.btnCacelar.Text = "Cancelar";
            this.btnCacelar.UseVisualStyleBackColor = true;
            this.btnCacelar.Click += new System.EventHandler(this.btnCacelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(107, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Distribuidor ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre de Compania";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(48, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Télefono";
            // 
            // txtDistribuidorId
            // 
            this.txtDistribuidorId.Location = new System.Drawing.Point(227, 35);
            this.txtDistribuidorId.Name = "txtDistribuidorId";
            this.txtDistribuidorId.Size = new System.Drawing.Size(125, 27);
            this.txtDistribuidorId.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(227, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 27);
            this.txtTelefono.TabIndex = 7;
            // 
            // DistribuidorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 186);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDistribuidorId);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCacelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "DistribuidorForm";
            this.Text = "Formulario Distribuidor";
            this.Load += new System.EventHandler(this.DistribuidorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardar;
        private Button btnCacelar;
        private Label lblID;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtDistribuidorId;
        private TextBox txtNombre;
        private TextBox txtTelefono;
    }
}
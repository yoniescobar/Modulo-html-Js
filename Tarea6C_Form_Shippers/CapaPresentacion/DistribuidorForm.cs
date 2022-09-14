using CapaDato.Datos;
using CapaDato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DistribuidorForm : Form
    {
        public bool Editar { get; set; }
        public int ShipperId { get; set; }
        public DistribuidorForm()
        {
            InitializeComponent();
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DistribuidorForm_Load(object sender, EventArgs e)
        {
            txtDistribuidorId.Enabled = false;
            if (this.Editar)
            {
                txtDistribuidorId.Text = this.ShipperId.ToString();
                using (Northwind db = new())
                {
                    Shipper s = db.Shippers.First(s => s.ShipperID == this.ShipperId);
                    if (s != null)
                    {
                        txtNombre.Text = s.CompanyName;
                        txtTelefono.Text = s.Phone;
                    }
                    else
                    {
                        MessageBox.Show("Categoria No existe");
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Debe tener un nombre");
                return;
            }
            using (Northwind db = new())
            {
                Shipper newShp = null;

                if (this.Editar)
                {
                    newShp = db.Shippers.First(s => s.ShipperID == this.ShipperId);
                }
                else
                {
                    newShp = new Shipper();
                }
                newShp.CompanyName = txtNombre.Text;
                newShp.Phone = txtTelefono.Text;

                if (!this.Editar)
                {
                    db.Shippers.Add(newShp);
                }
                if (db.SaveChanges() == 1)
                {
                    string Mensaje = (this.Editar) ? "Edicion realizada con" : "Agragado realizado con";
                    MessageBox.Show($"{Mensaje} éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}

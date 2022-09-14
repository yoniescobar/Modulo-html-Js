using CapaDato.Datos;
using CapaDato.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDistribuidores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarDistribuidores()
        {
            using (Northwind db = new())
            {
                var shippers = db.Shippers.Select(s => new { s.ShipperID, s.CompanyName, s.Phone});
                // MessageBox.Show($"{shippers.ToQueryString()}");
                if (shippers is null)
                {
                    MessageBox.Show("No hay Distribuidores", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridDistribuidores.DataSource = shippers.ToList();

            }

        }

        private void gridDistribuidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int shipperID = (int)gridDistribuidores.Rows[e.RowIndex].Cells["ShipperID"].Value;
            using (Northwind db = new())
            {
                //IQueryable se usa la interfaz para ser Query de lista
                IQueryable<Order> orders = db.Orders.Where(o => o.ShipVia == shipperID);

                if (orders is null)
                {
                    MessageBox.Show("No hay Ordenes", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridOrders.DataSource = orders.ToList();
            }

        }

        private void btnNuevoDistribuidor_Click(object sender, EventArgs e)
        {
            DistribuidorForm distribuidorForm = new DistribuidorForm();
            distribuidorForm.Editar = false;
            distribuidorForm.ShowDialog();
            cargarDistribuidores();
        }

        private void btnEditarDistribuidor_Click(object sender, EventArgs e)
        {
            DistribuidorForm distribuidorForm = new DistribuidorForm();
            distribuidorForm.Editar = true;
            if (gridDistribuidores.SelectedRows.Count > 0)
            {
                distribuidorForm.ShipperId = (int)gridDistribuidores.SelectedRows[0].Cells["ShipperId"].Value;
                distribuidorForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe  Elegir un Distribuidor", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cargarDistribuidores();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridDistribuidores.SelectedRows.Count > 0)
            {

                DialogResult res = MessageBox.Show("Esta Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res != DialogResult.Yes)
                {
                    return;
                }
                int intDist = (int)gridDistribuidores.SelectedRows[0].Cells["ShipperId"].Value;
                using (Northwind db = new())
                {
                    Shipper shipperDelete = db.Shippers.First(s => s.ShipperID == intDist);
                    if (shipperDelete is null)
                    {
                        MessageBox.Show("Categoria no existe");
                        return;
                    }
                    db.Shippers.Remove(shipperDelete);
                    if (db.SaveChanges() == 1)
                    {
                        MessageBox.Show("Registro Eliminado Exitosamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error ! Registro Eliminado Exitosamente!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe  Elegir un Distribuidor", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cargarDistribuidores();
        }

        private void txtBuscarDistribuidor_TextChanged(object sender, EventArgs e)
        {
            using (Northwind db = new())
            {
                var query = from dato in db.Shippers
                            where dato.CompanyName.Contains(txtBuscarDistribuidor.Text) || dato.Phone.Contains(txtBuscarDistribuidor.Text)
                            select dato;

                gridDistribuidores.DataSource = query.ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // var shippers = db.Shippers.Select(s => new { s.ShipperID, s.CompanyName, s.Phone });

            using (Northwind db = new())
            {

                if (txtBuscarDistribuidor.Text == "" || !(Regex.IsMatch(txtBuscarDistribuidor.Text, @"^[0-9]+$")))
                {



                    MessageBox.Show("Debe Ingresar el código del Distribuidor");
                }

                else
                {

                    var query = from dato in db.Shippers
                                where dato.ShipperID == Convert.ToInt32(txtBuscarDistribuidor.Text)
                                select dato;

                    gridDistribuidores.DataSource = query.ToList();
                }


            }

        }
    }
}
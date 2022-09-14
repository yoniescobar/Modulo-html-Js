using Microsoft.EntityFrameworkCore;
using Tarea6C_Forms.Data;

namespace Tarea6C_Forms
{
    public partial class Form1 : Form
    {
        int Seleccion;

        public bool Editar { get; set; }
        public int ShippersId { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            //lo ideal es dbNorthwinds
            using (Northwinds db = new())
            {
                DbSet<Shippers>? shippers = db.Shippers;
                if (shippers is null)
                {
                    MessageBox.Show("No hay Cargadores", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //salir del metodo para no agregar el else
                }

                gridShippers.DataSource = shippers.ToList();
                gridShippers.Columns["Column1"].DisplayIndex = 3; //depende cuantas columnas tiene

            }
        }
        private void eliminarShippers(int shippersId)
        {
          
                using (Northwinds db = new())
                {
                    db.Shippers?.Remove(db.Shippers.First(s=>s.ShipperID == shippersId));
                    db.SaveChanges();
                }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridShippers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int shippersId = (int)gridShippers.Rows[e.RowIndex].Cells["ShipperID"].Value;
            //using (Northwinds db = new())
            //{
            //    //consulta con  IQueryable
            //    IQueryable<Shippers>? shippers = db.Shippers.Where(s => s.ShipperID == shippersId);

            //    if (shippers is null)
            //    {
            //        MessageBox.Show("No hay Cargadores", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return; //salir del metodo para no agregar el else
            //    }
            //    //gridShippers.DataSource = shippers.ToList();
            //    Seleccion = ShippersId;
            //}





        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // int totalSeleccion = gridShippers.Rows.Cast<DataGridView>().
            int totalSeleccion = gridShippers.Rows.Cast<DataGridViewRow>().
                Where(s => Convert.ToBoolean(s.Cells["Column1"].Value)).Count();

            DialogResult dg;
            int shippersId;

            if (totalSeleccion == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un registro");
            }
            else if (totalSeleccion == 1)
            {
                dg = MessageBox.Show("Desea Eliminar el Registro seleccionadoo", "Sistema Galileo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in gridShippers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column1"].Value))
                        {
                            shippersId = Convert.ToInt32(row.Cells["ShipperID"].Value);
                            eliminarShippers(shippersId);
                        }
                    }
                }
            }
            else if (totalSeleccion >= 2)
            {
                dg = MessageBox.Show("Desea Eliminar los  " + totalSeleccion +
                    "Registro seleccionados", "Sistema Galileo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in gridShippers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column1"].Value))
                        {
                            shippersId = Convert.ToInt32(row.Cells["ShipperID"].Value);
                            eliminarShippers(shippersId);
                        }
                    }
                }

            }
            cargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Activar los campos
            txtShipperId.Enabled = true;
            txtCompanyName.Enabled = true;
            txtPhone.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

            txtShipperId.Enabled = true;
            txtCompanyName.Enabled = true;
            txtPhone.Enabled = true;

            

            
        
        }

        private void gridShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int shippersId = (int)gridShippers.Rows[e.RowIndex].Cells["ShipperID"].Value;
            using (Northwinds db = new())
            {
                //consulta con  IQueryable
                IQueryable<Shippers>? shippers = db.Shippers.Where(s => s.ShipperID == shippersId);

                if (shippers is null)
                {
                    MessageBox.Show("No hay Cargadores", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //salir del metodo para no agregar el else
                }
                //gridShippers.DataSource = shippers.ToList();
                
                txtShipperId.Text = shippersId.ToString();
            }


        }

        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCambio_Click(object sender, EventArgs e)
        {
            txtCompanyName.Enabled = true;
            txtCompanyName.Enabled=true;
            txtPhone.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardarCambio.Visible=false;
            btnCancelarCambio.Visible=false;
        }
    }
}
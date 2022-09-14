using CapaDato.Datos;
using CapaDato.Models;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        //crear codigo encapsular para no tener mucho codigo a la vista
        #region HELPER 
        private void refrescar()
        {

            using (Colegio db = new())
            {
                var subjects = db.Subjects.Select(s => new { s.Id, s.Name });
                if (subjects is null)
                {
                    MessageBox.Show("No hay Cursos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridSubjects.DataSource = subjects.ToList();
            }
        }


        private int? getIdCurso()
        {
            try
            {
                //obteniendo datos del dataGridview seleccionando su id
                return int.Parse(gridSubjects.Rows[gridSubjects.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
        }

        #endregion

        private void gridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int subjectId = (int)gridSubjects.Rows[e.RowIndex].Cells[0].Value;
            using (Colegio db = new())
            {
                //IQueryable se usa la interfaz para ser Query de lista
                IQueryable<Grade> grades = db.Grades.Where(o => o.Id == subjectId);

                if (grades is null)
                {
                    MessageBox.Show("No hay Asignaturas", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridAsignaturas.DataSource = grades.ToList();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSubject frmSubject = new FrmSubject();
            frmSubject.Editar = false;
            frmSubject.ShowDialog();
            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmSubject frmSubject = new FrmSubject();
            frmSubject.Editar = true;

            if (gridSubjects.SelectedRows.Count > 0)
            {
                frmSubject.idCurso = (int)gridSubjects.SelectedRows[0].Cells["Id"].Value;
                frmSubject.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe  Elegir un Curso", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            refrescar();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridSubjects.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Esta Seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res != DialogResult.Yes)
                {
                    return;
                }

                int intCurso = (int)gridSubjects.SelectedRows[0].Cells[0].Value;

                using (Colegio db = new())
                {
                    Subject subjectDelete = db.Subjects.First(s => s.Id == intCurso);
                    if (subjectDelete is null)
                    {
                        MessageBox.Show("Curso no existe");
                        return;
                    }
                    db.Subjects.Remove(subjectDelete);
                    if (db.SaveChanges() == 1)
                    {
                        MessageBox.Show("Registro Eliminado Exitosamente!");
                    }
                    else
                    {
                        MessageBox.Show("Error ! Registro No Eliminado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe  Elegir un Curso", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            refrescar();

        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            using (Colegio db = new())
            {
                if (txtBuscar.Text == "" || !(Regex.IsMatch(txtBuscar.Text, @"^[0-9]+$")))
                {
                    MessageBox.Show("Debe Ingresar el código del Asignatura");
                }
                else
                {
                    var query = from dato in db.Subjects
                                where dato.Id == Convert.ToInt32(txtBuscar.Text)
                                select dato;

                    gridSubjects.DataSource = query.ToList();
                }

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (Colegio db = new())
            {
                var query = from dato in db.Subjects
                            where dato.Name.Contains(txtBuscar.Text)
                            select dato;

                gridSubjects.DataSource = query.ToList();
            }
        }

        private void gridSubjects_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int codAsignatura = (int)gridSubjects.Rows[e.RowIndex].Cells["Id"].Value;
            using (Colegio db = new())
            {
                //IQueryable se usa la interfaz para ser Query de lista
                IQueryable<Grade> grades = db.Grades.Where(o => o.SubjectId== codAsignatura);

                if (grades is null)
                {
                    MessageBox.Show("No hay Ordenes", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                gridAsignaturas.DataSource = grades.ToList();

                /*
                var estudianteGrado = from idGrado in db.Grades
                                      join idAsignacion in db.Subjects
                                      on idGrado.Id equals idAsignacion.Id
                                      select new
                                      {
                                          Nombre = idGrado.StudentUser.FirstName,
                                          descripcionSubj = idAsignacion.Name,
                                          comentario = idGrado.Assessment,
                                          // Apellido = idEstudiante.LastName,
                                          Asignatura = codAsignatura,//idGrado.Subject.Name,
                                          nombreAsig = idGrado.StudentUserId,
                                      
                                      };
                gridAsignaturas.DataSource = estudianteGrado.ToList();

              */

            }
        }

        private void gridAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
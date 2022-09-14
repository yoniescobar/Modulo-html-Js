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

namespace Presentacion
{
    public partial class FrmSubject : Form
    {

        public bool Editar { get; set; } //codigo curso
        public int idCurso { get; set; }
        public FrmSubject() //envio id curso
        {
            InitializeComponent();
            
        }
        private void cargaDatos()
        {
            using (Colegio db = new())
            {
                Subject subject = db.Subjects.Find(idCurso);
                txtIdCurso.Text = Convert.ToString(subject.Id);
                txtNombreCurso.Text = subject.Name;
                txtIdCurso.Enabled = false;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreCurso.Text.Length==0)
            {
                MessageBox.Show("Debe tener un nombre");
                return;
            }
            using (Colegio db = new())
            {
                Subject newAsig = null;

                if (this.Editar)
                {
                    newAsig = db.Subjects.First(s => s.Id == this.idCurso);
                }
                else
                {
                    newAsig = new Subject();
                }
                newAsig.Name = txtNombreCurso.Text;
               
                if (!this.Editar)
                {
                    db.Subjects.Add(newAsig);
                }
                if (db.SaveChanges() == 1)
                {
                    string Mensaje = (this.Editar) ? "Edicion realizada con" : "Agragado realizado con";
                    MessageBox.Show($"{Mensaje} éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            txtIdCurso.Enabled=false;
            if (this.Editar)
            {
                txtIdCurso.Text = this.idCurso.ToString();
                using (Colegio db = new())
                {
                    Subject s = db.Subjects.First(s => s.Id == this.idCurso);
                    if (s!=null)
                    {
                        txtNombreCurso.Text = s.Name;
                    }
                    else
                    {
                        MessageBox.Show("Asignatura No existe");
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

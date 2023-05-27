using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_ClinicaSp1_EjerResolver
{
    public partial class frmMedico : Form
    {

        private string NombreArchivoMed; //var que guarda el nombre de los medicos

        public frmMedico(string nombreArchivoMed)
        {
            InitializeComponent();
            NombreArchivoMed = nombreArchivoMed;
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + "Especialidades.txt"))
            {
                cmbEspecialidad.Items.Clear();
                return;
            }

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = Application.StartupPath + "\\" + "Especialidades.txt";

            List<clsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cmbEspecialidad.Items.Clear();

            foreach (clsEspecialidad especialidad in ListaEspecialidad)
            {
                cmbEspecialidad.Items.Add(especialidad.Nombre);
            }
        }

        private clsMedico CrearMedico()
        {
            clsMedico NuevoMedico = new clsMedico();

            NuevoMedico.Matricula = txtMatricula.Text;
            NuevoMedico.Nombre = txtNombre.Text;
            NuevoMedico.NumEspecialidad = cmbEspecialidad.Text;

            return NuevoMedico;
        }

        public bool ValidarDatos()
        {
            bool resultado = false;

            if (txtMatricula.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (cmbEspecialidad.Text != "")
                    {
                        clsArchivo Matricula = new clsArchivo();
                        Matricula.NombreArchivo = NombreArchivoMed;

                        if (Matricula.BuscarMatricula(txtMatricula.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                clsMedico NuevoMedico = CrearMedico();
                clsArchivo Medico = new clsArchivo();
                Medico.NombreArchivo = NombreArchivoMed;
                Medico.GrabarMedicos(NuevoMedico);

                txtMatricula.Text = "";
                txtNombre.Text = "";
                cmbEspecialidad.SelectedIndex = -1;
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a ingrsar los Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

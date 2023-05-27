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
    public partial class frmListado : Form
    {

        private string NombreArchivoMed = "Medicos.txt";
        private string NombreArchivoEsp = "Especialidades.txt";

        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            ListarEspecialidades();
            dgvConsulta.Rows.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnRegistroEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidad frm = new frmEspecialidad(NombreArchivoEsp);
            frm.ShowDialog();
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            frmMedico frm = new frmMedico(NombreArchivoMed);
            frm.ShowDialog();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEspecialidad.Text = cmbEspecialidad.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(NombreArchivoMed) || cmbEspecialidad.Text == "")
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            clsArchivo Medico = new clsArchivo();
            Medico.NombreArchivo = NombreArchivoMed;
            List<clsMedico> ListaMedicos = Medico.ListarMedicos();

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEsp;
            List<clsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();

            dgvConsulta.Rows.Clear();

            bool control = false;
            foreach (clsEspecialidad especialidad in ListaEspecialidad)
            {
                if (especialidad.Nombre == cmbEspecialidad.Text)
                {
                    foreach (clsMedico medico in ListaMedicos)
                    {
                        if (especialidad.Nombre == medico.NumEspecialidad)
                        {
                            dgvConsulta.Rows.Add(medico.Matricula, medico.Nombre);
                            control = true;
                        }
                    }
                }
            }

            if (control == false)
            {
                MessageBox.Show("No hay médicos registrados en esta especialidad.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarEspecialidades();
        }

        public void ListarEspecialidades()
        {
            if (!File.Exists(NombreArchivoEsp))
            {
                cmbEspecialidad.Items.Clear();
                return;
            }

            clsArchivo Especialidad = new clsArchivo();
            Especialidad.NombreArchivo = NombreArchivoEsp;
            List<clsEspecialidad> ListaEspecialidad = Especialidad.ListarEspecialidad();
            cmbEspecialidad.Items.Clear();

            foreach (clsEspecialidad especialidad in ListaEspecialidad)
            {
                cmbEspecialidad.Items.Add(especialidad.Nombre);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

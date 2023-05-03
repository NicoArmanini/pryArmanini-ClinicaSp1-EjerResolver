using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_ClinicaSp1_EjerResolver
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            //buscar las especialidad
            clsEspecialidad objEspecialidad = new clsEspecialidad();

            objEspecialidad.ListarEspecialidad(cboEspecialidad);
        }
    }
}

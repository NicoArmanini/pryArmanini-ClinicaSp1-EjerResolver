﻿using System;
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
    public partial class frmEspecialidad : Form
    {
        private string NombreArchivoEsp;

        public frmEspecialidad(string NombreArchivo)
        {
            InitializeComponent(); 
            NombreArchivoEsp = NombreArchivo;
        }

        private clsEspecialidad CrearEspecialidad()
        {
            clsEspecialidad NuevaEspecialidad = new clsEspecialidad();

            NuevaEspecialidad.Nombre = txtCodigo.Text;
            NuevaEspecialidad.Codigo = txtNombre.Text;

            return NuevaEspecialidad;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                clsEspecialidad NuevaEspecialidad = CrearEspecialidad();
                clsArchivo Especialidad = new clsArchivo();
                Especialidad.NombreArchivo = NombreArchivoEsp;
                Especialidad.GrabarEspecialidad(NuevaEspecialidad);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                MessageBox.Show("¡Registro exitoso!", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos erróneos. Vuelve a intentarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtCodigo.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    clsArchivo Especialidad = new clsArchivo();
                    Especialidad.NombreArchivo = NombreArchivoEsp;

                    if (Especialidad.BuscarNumeroEspecialidad(txtCodigo.Text) == false)
                    {
                        if (Especialidad.BuscarNombreEspecialidad(txtNombre.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

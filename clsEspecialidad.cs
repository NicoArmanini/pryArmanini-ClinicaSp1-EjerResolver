using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace pryArmanini_ClinicaSp1_EjerResolver
{
    internal class clsEspecialidad
    {
        int codigo { get; set; }
        string nombre { get; set; }

        public void RegistrarEspecialidad(int txtCodigo, string txtNombre)
        {
            codigo = txtCodigo;
            nombre = txtNombre;


            //grabar
            StreamWriter grabarArchivo = new StreamWriter("Especialidad", true);
            
            grabarArchivo.WriteLine(codigo + ", " + nombre);
            grabarArchivo.Close();




        }
    }
}

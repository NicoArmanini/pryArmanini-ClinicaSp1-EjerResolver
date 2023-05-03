using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

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

            //validaciones - chequear que el còdigo no estè repetido
            ValidarCodigo();

            //si el código està repetido, aviso, caso contrario grabar
            StreamWriter grabarArchivo = new StreamWriter("Especialidad", true);

            grabarArchivo.WriteLine(codigo + ", " + nombre);

            grabarArchivo.Close();


        }

        private void ValidarCodigo()
        {
            string linea = "";
            int codigoAvalidar = 0;

            StreamReader lectorArchivo = new StreamReader("Especialidad");

            while (lectorArchivo.EndOfStream == false)
            {
                linea = lectorArchivo.ReadLine();

                codigoAvalidar = Convert.ToInt32(linea.Split(',')[0]);

                if (codigoAvalidar == codigo)
                {
                    //decirle que el còdigo està repetido
                }

            }
        }

        public void ListarEspecialidad()
        {
            StreamReader lectorArchivo = new StreamReader("Especialidad");
            while (lectorArchivo.EndOfStream == false)
            {
                lectorArchivo.ReadLine();
            }
        }

        public void ListarEspecialidad(ComboBox listaDesplegable)
        {
            StreamReader lectorArchivo = new StreamReader("Especialidad");
            while (lectorArchivo.EndOfStream == false)
            {
                listaDesplegable.Items.Add(lectorArchivo.ReadLine());
            }
        }

    }
}

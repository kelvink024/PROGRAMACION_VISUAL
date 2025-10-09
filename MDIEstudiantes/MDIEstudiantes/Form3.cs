using System;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();

            if (DatosCompartidos.Estudiantes.Count > 0)
            {
                foreach (var estudiante in DatosCompartidos.Estudiantes)
                {

                    foreach (var asig in estudiante.Asignaturas)
                    {
                        dgvDatos.Rows.Add(estudiante.Carnet, estudiante.Nombre, asig.Nombre, asig.Nota);
                    }

                    dgvDatos.Rows.Add("", "");
                }

            }
            else
            {
                MessageBox.Show("No hay datos de estudiante cargados.");
            }
        }
    }
}

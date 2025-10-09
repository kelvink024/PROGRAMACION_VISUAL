﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            Estudiante estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };

            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    estudiante.Asignaturas.Add(new Asignatura
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Nota = Convert.ToDouble(fila.Cells[1].Value)
                    });
                }
            }

            DatosCompartidos.Estudiantes.Add(estudiante);
            MessageBox.Show("Datos guardados correctamente");
            this.Close();
        }
    }
}

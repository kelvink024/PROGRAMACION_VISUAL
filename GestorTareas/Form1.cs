using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareas
{

    public partial class Form1 : Form
    {
        public class Tarea
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Lugar { get; set; }
            public string Estado { get; set; }
        }

        List<Tarea> listaTareas = new List<Tarea>();
        private int intentosBusquedaEstado = 0;
        private int intentosBusquedaCodigo = 0;
        private int intentosBusquedaFecha = 0;
        
        

        public Form1()
        {
            InitializeComponent();
        }
        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void MostrarTodo()
        {
            BuscadorDTGV.DataSource = null;
            BuscadorDTGV.DataSource = listaTareas;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
        private void BuscarPorFecha(DateTime fecha)
        {
            var resultado = listaTareas
                .Where(t => t.Fecha.Date == fecha.Date)
                .ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = resultado;
        }

        private void BuscarPorEstado(string estado)
        {
            var resultado = listaTareas
                .Where(t => t.Estado == estado)
                .ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = resultado;
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigoIngresado))
            {
                MessageBox.Show("El código no puede estar vacío.");
                return;
            }

            if (cmbEstado.SelectedIndex == -1) // 👈 Validación del estado
            {
                MessageBox.Show("Debe seleccionar un estado antes de guardar la tarea.");
                return;
            }

            bool codigoExiste = listaTareas.Any(t => t.Codigo == codigoIngresado);
            if (codigoExiste)
            {
                MessageBox.Show("Ya existe una tarea con ese código. Ingrese uno diferente.");
                return;
            }

            Tarea nueva = new Tarea()
            {
                Codigo = codigoIngresado,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                if (cmbEstado.SelectedIndex == -1) // 👈 Validación del estado
                {
                    MessageBox.Show("Debe seleccionar un estado antes de editar la tarea.");
                    return;
                }

                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("la tarea fue eliminada correctamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtLugar.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void BuscadorDTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = btnBuscarCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MostrarTodo();
                intentosBusquedaCodigo = 0;
                return;
            }

            var tareaEncontrada = listaTareas.Where(t => t.Codigo.Contains(codigo)).ToList();

            if (tareaEncontrada.Any())
            {
                BuscadorDTGV.DataSource = null;
                BuscadorDTGV.DataSource = tareaEncontrada;
                intentosBusquedaCodigo = 0;
            }
            else
            {
                intentosBusquedaCodigo++;
                if (intentosBusquedaCodigo < 3)
                {
                    MessageBox.Show($"No se encontró ninguna tarea con ese código. Intento {intentosBusquedaCodigo} de 3.");
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna tarea con ese código en 3 intentos. Mostrando todas las tareas.");
                    MostrarTodo();
                    intentosBusquedaCodigo = 0;
                }
            }
        }

        private void cbxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            if (cbxBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            string estado = cbxBusqueda.SelectedItem.ToString();
            var resultado = listaTareas
                .Where(t => t.Estado == estado)
                .ToList();

            if (resultado.Any())
            {
                BuscadorDTGV.DataSource = null;
                BuscadorDTGV.DataSource = resultado;
                intentosBusquedaEstado = 0;
            }
            else
            {
                intentosBusquedaEstado++;
                if (intentosBusquedaEstado < 3)
                {
                    MessageBox.Show($"No hay tareas con ese estado. Intento {intentosBusquedaEstado} de 3.");
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna tarea con ese estado en 3 intentos. Mostrando todas las tareas.");
                    MostrarTodo();
                    intentosBusquedaEstado = 0;
                }
            }
        }

        private void dtmfechaminima_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpfechamaxima_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtmfechaminima.Value.Date;
            DateTime fechaFin = dtpfechamaxima.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.");
                return;
            }

            var resultado = listaTareas
                .Where(t => t.Fecha.Date >= fechaInicio && t.Fecha.Date <= fechaFin)
                .ToList();

            if (resultado.Any())
            {
                BuscadorDTGV.DataSource = null;
                BuscadorDTGV.DataSource = resultado;
                intentosBusquedaFecha = 0;
            }
            else
            {
                intentosBusquedaFecha++;
                if (intentosBusquedaFecha < 3)
                {
                    MessageBox.Show($"No hay tareas en ese rango de fechas. Intento {intentosBusquedaFecha} de 3.");
                }
                else
                {
                    MessageBox.Show("No se encontraron tareas en ese rango de fechas en 3 intentos. Mostrando todas las tareas.");
                    MostrarTodo();
                    intentosBusquedaFecha = 0;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            dtmfechaminima.Value = DateTime.Now;
            dtpfechamaxima.Value = DateTime.Now;
            cbxBusqueda.SelectedIndex = -1;
        }
    }
}

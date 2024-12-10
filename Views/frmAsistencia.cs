using ClosedXML.Excel;
using Controllers;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Utilidades;

namespace Views
{
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            List<Empleados> lista = new CEmpleados().Listar();
            cbempleados.Items.Add(new OpcionesComboBox { Valor = 0, Texto = "Todos" });
            foreach (Empleados item in lista)
            {
                cbempleados.Items.Add(new OpcionesComboBox() { Valor = item.idempleado, Texto = item.nombres + ' ' + item.apellidos });
            }
            cbempleados.DisplayMember = "Texto";
            cbempleados.ValueMember = "Valor";
            cbempleados.SelectedIndex = 0;

            List<Asistencia> listaEmpleados = new CAsistencia().Listar();
            foreach(Asistencia item in listaEmpleados)
            {
                tablahorario.Rows.Add(new object[] { item.fecharegistro, item.oEmpleados.documento, item.oEmpleados.nombres, item.horaentrada, item.horasalida, item.horastrabajadas });
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (dtfechainicio.Value > dtfechafin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaInicio = dtfechainicio.Value;
            DateTime fechaFin = dtfechafin.Value;

            int idEmpleado = Convert.ToInt32(((OpcionesComboBox)cbempleados.SelectedItem).Valor);

            List<Asistencia> listaFiltrada = new CAsistencia().Listar(fechaInicio, fechaFin, idEmpleado);

            tablahorario.Rows.Clear();

            foreach (Asistencia item in listaFiltrada)
            {
                tablahorario.Rows.Add(new object[]
                {
                    item.fecharegistro,
                    item.oEmpleados.documento,
                    item.oEmpleados.nombres,
                    item.horaentrada,
                    item.horasalida,
                    item.horastrabajadas
                });
            }
            MessageBox.Show($"Se encontraron {listaFiltrada.Count} asistencias.");
        }

        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (tablahorario.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn columna in tablahorario.Columns)
            {
                dt.Columns.Add(columna.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in tablahorario.Rows)
            {
                if (row.Visible)
                {
                    var values = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        values.Add(cell.Value?.ToString() ?? string.Empty);
                    }
                    dt.Rows.Add(values.ToArray());
                }
            }

            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = $"ReporteAsistencias_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx", 
                Filter = "Excel Files | *.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add(dt, "Asistencias");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                    }

                    MessageBox.Show("Reporte generado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = savefile.FileName,
                            UseShellExecute = true
                        });
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo abrir el archivo automáticamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

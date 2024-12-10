using Controllers;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Dashboard : Form
    {
        private static Usuarios usuarioActual;
        public Dashboard(Entity.Usuarios objusuario = null)
        {
            InitializeComponent();
            usuarioActual = objusuario;
        }

        private Form activeForm = null;
        private void formularioAbierto(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(childForm);
            panelFormularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            formularioAbierto(new frmUsuarios());
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            MarcadorAsistencia asistencia = new MarcadorAsistencia();
            asistencia.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            panelFormularios.BringToFront();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            formularioAbierto(new frmHorarios());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            formularioAbierto(new frmCargos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            formularioAbierto(new frmEmpleados());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            formularioAbierto(new frmAsistencia());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            lblfecha.Text = $"Fecha ingreso: {fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}";
            lblhora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss tt");

            CargarChartEmpleadosPorDia();
            CargarChartEmpleadosPorMes();
        }

        private CAsistencia obj_casistencia = new CAsistencia();

        private void CargarChartEmpleadosPorDia()
        {
            DataTable dt = obj_casistencia.ObtenerEmpleadosPorDia();

            chartAsistencias.Series.Clear();
            chartAsistencias.Series.Add("Empleados");
            chartAsistencias.Series["Empleados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                string fecha = Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy");
                int totalEmpleados = Convert.ToInt32(row["EmpleadosQueAsistieron"]);

                chartAsistencias.Series["Empleados"].Points.AddXY(fecha, totalEmpleados);
            }
        }

        private void CargarChartEmpleadosPorMes()
        {
            DataTable dt = obj_casistencia.ObtenerEmpleadosPorMes();

            chartAsisMes.Series.Clear();
            chartAsisMes.Series.Add("Empleados");
            chartAsisMes.Series["Empleados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (DataRow row in dt.Rows)
            {
                string mes = row["Mes"].ToString();
                int totalEmpleados = Convert.ToInt32(row["EmpleadosQueAsistieron"]);

                chartAsisMes.Series["Empleados"].Points.AddXY(mes, totalEmpleados);
            }
        }

    }
}

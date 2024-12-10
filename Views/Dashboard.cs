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
        public Dashboard(Usuarios objusuario = null)
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
    }
}

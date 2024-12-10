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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Views
{
    public partial class MarcadorAsistencia : Form
    {
        private CAsistencia obj_casistencia = new CAsistencia();
        public MarcadorAsistencia()
        {
            InitializeComponent();
            txtasistencia.Select();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnloginadmin_Click(object sender, EventArgs e)
        {
            Login iniciar = new Login();
            iniciar .Show();
            this.Hide();
        }

        private void MarcadorAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MarcadorAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void btnregistroasistencia_Click(object sender, EventArgs e)
        {
            string documentoEmpleado = txtasistencia.Text;

            Asistencia asistencia = new Asistencia
            {
                oEmpleados = new Empleados { documento = documentoEmpleado }
            };

            string mensaje = string.Empty;
            int resultado = obj_casistencia.Registrar(asistencia, out mensaje);

            if (resultado > 0)
            {
                this.Alert("Asistencia Registrada", Form_Alert.enmType.Success);
            }
            else
            {
                this.Alert("Verifique su DNI", Form_Alert.enmType.Error);
            }

            Limpiar();
        }

        private void Limpiar()
        {
            txtasistencia.Text = "";
            txtasistencia.Select();
        }

    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtusuarios.Select();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Usuarios usuariologin = new CUsuarios().IniciarSesion().Where(u => u.nombreusuario == txtusuarios.Text && u.clave == txtpassword.Text).FirstOrDefault();
            if (usuariologin != null)
            {
                if (usuariologin.oNivelAcceso != null)
                {
                    Dashboard inicio = new Dashboard();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error en los datos de acceso.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al Iniciar Sesión", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
        }
    }
}

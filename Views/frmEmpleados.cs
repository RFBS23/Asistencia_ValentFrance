using Controllers;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Utilidades;

namespace Views
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            lblfecha.Text = $"{fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}";

            foreach (DataGridViewColumn columna in tablaempleados.Columns)
            {
                if (columna.Visible == true)
                {
                    listabuscar.Items.Add(new OpcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listabuscar.DisplayMember = "Texto";
                listabuscar.ValueMember = "Valor";
                listabuscar.SelectedIndex = 0;
            }

            List<Cargos> listacargos = new CCargos().Listar();
            cbcargo.Items.Add(new OpcionesComboBox() { Valor = 0, Texto = "Elija el cargo" });
            foreach (Cargos item in listacargos)
            {
                cbcargo.Items.Add(new OpcionesComboBox() { Valor = item.idcargo, Texto = item.nombrecargo });
            }
            cbcargo.DisplayMember = "Texto";
            cbcargo.ValueMember = "Valor";
            cbcargo.SelectedIndex = 0;

            cbhorario.Items.Clear();
            cbhorario.Items.Add(new OpcionesComboBox() { Valor = 0, Texto = "Elija un horario" });
            cbhorario.DisplayMember = "Texto";
            cbhorario.ValueMember = "Valor";
            cbhorario.SelectedIndex = 0;

            List<Empleados> listaEmpleado = new CEmpleados().Listar();
            foreach (Empleados item in listaEmpleado)
            {
                tablaempleados.Rows.Add(new object[] { "", item.idempleado, item.documento, item.nombres, item.apellidos, item.oCargo.idcargo, item.oCargo.nombrecargo, item.oHorario.idhorario, item.oHorario.horainicio + " - " + item.oHorario.horasalida });
            }
        }

        private void CargarHorarios(int idCargo)
        {
            cbhorario.Items.Clear();
            cbhorario.Items.Add(new OpcionesComboBox() { Valor = 0, Texto = "Elija el Horario" });

            if (idCargo == 0) return;
            List<Horarios> listaHorarios = new CHorarios().FiltrosHorarios(idCargo);

            foreach (Horarios item in listaHorarios)
            {
                cbhorario.Items.Add(new OpcionesComboBox()
                {
                    Valor = item.idhorario,
                    Texto = item.horainicio + " - " + item.horasalida
                });
            }

            cbhorario.DisplayMember = "Texto";
            cbhorario.ValueMember = "Valor";
            cbhorario.SelectedIndex = 0;
        }

        private void cbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcargo.SelectedIndex > 0)
            {
                int idCargo = Convert.ToInt32(((OpcionesComboBox)cbcargo.SelectedItem).Valor);
                CargarHorarios(idCargo);
            }
        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";

            txtddocumento.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            cbcargo.SelectedIndex = 0;
            cbhorario.SelectedIndex = 0;

            txtddocumento.Enabled = true;

            txtddocumento.Select();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Empleados objempleados = new Empleados()
            {
                idempleado = Convert.ToInt32(txtid.Text),
                documento = txtddocumento.Text,
                nombres = txtnombres.Text,
                apellidos = txtapellidos.Text,
                oCargo = new Cargos() { idcargo = Convert.ToInt32(((OpcionesComboBox)cbcargo.SelectedItem).Valor) },
                oHorario = new Horarios() { idhorario = Convert.ToInt32(((OpcionesComboBox)cbhorario.SelectedItem).Valor) }
            };
            if (btnAgregar.Text == "    Agregar")
            {
                int idusuariogenerado = new CEmpleados().Registrar(objempleados, out mensaje);
                if (idusuariogenerado != 0)
                {
                    tablaempleados.Rows.Add(new object[] {"", idusuariogenerado, txtddocumento.Text, txtnombres.Text, txtapellidos.Text,
                        ((OpcionesComboBox)cbcargo.SelectedItem).Valor.ToString(),
                        ((OpcionesComboBox)cbcargo.SelectedItem).Texto.ToString(),
                        ((OpcionesComboBox)cbhorario.SelectedItem).Valor.ToString(),
                        ((OpcionesComboBox)cbhorario.SelectedItem).Texto.ToString()
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else if (btnAgregar.Text == "    Editar")
            {
                
                bool resultado = new CEmpleados().Editar(objempleados, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = tablaempleados.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idempleado"].Value = Convert.ToInt32(txtid.Text);
                    row.Cells["documento"].Value = txtddocumento.Text;
                    row.Cells["nombres"].Value = txtnombres.Text;
                    row.Cells["apellidos"].Value = txtapellidos.Text;
                    row.Cells["idcargo"].Value = ((OpcionesComboBox)cbcargo.SelectedItem).Valor.ToString();
                    row.Cells["nombrecargo"].Value = ((OpcionesComboBox)cbcargo.SelectedItem).Texto.ToString();
                    row.Cells["idhorario"].Value = ((OpcionesComboBox)cbhorario.SelectedItem).Valor.ToString();
                    row.Cells["horario"].Value = ((OpcionesComboBox)cbhorario.SelectedItem).Texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                btnAgregar.Text = "    Agregar";
                txtddocumento.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private async void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtddocumento.Text.Length == 8)
            {
                string apiUrl = $"https://api.apis.net.pe/v1/dni?numero={txtddocumento.Text}";
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                            if (json != null)
                            {
                                txtnombres.Text = $"{json.nombres}";
                                txtapellidos.Text = $"{json.apellidoPaterno} {json.apellidoMaterno}";
                            }
                            else
                            {
                                MessageBox.Show("La respuesta de la API no tiene el formato esperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No se ha podido encontrar el dni buscado..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener la información del DNI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tablaempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaempleados.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = tablaempleados.Rows[indice].Cells["idempleado"].Value.ToString();
                    txtddocumento.Text = tablaempleados.Rows[indice].Cells["documento"].Value.ToString();
                    txtnombres.Text = tablaempleados.Rows[indice].Cells["nombres"].Value.ToString();
                    txtapellidos.Text = tablaempleados.Rows[indice].Cells["apellidos"].Value.ToString();

                    foreach (OpcionesComboBox ocb in cbcargo.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(tablaempleados.Rows[indice].Cells["idcargo"].Value))
                        {
                            int indice_combo = cbcargo.Items.IndexOf(ocb);
                            cbcargo.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionesComboBox oc in cbhorario.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(tablaempleados.Rows[indice].Cells["idhorario"].Value))
                        {
                            int indice_combo = cbhorario.Items.IndexOf(oc);
                            cbhorario.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    txtddocumento.Enabled = false;
                    btnAgregar.Text = "    Editar";
                }
            }
        }

        private void tablaempleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check1.Width;
                var h = Properties.Resources.check1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check1, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnbuscarlista_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((OpcionesComboBox)listabuscar.SelectedItem).Valor.ToString();
            if (tablaempleados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tablaempleados.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in tablaempleados.Rows)
            {
                row.Visible = true;
            }
            txtbuscar.Select();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar al trabajador?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Empleados objusuarios = new Empleados()
                    {
                        idempleado = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CEmpleados().Eliminar(objusuarios, out mensaje);
                    if (respuesta)
                    {
                        tablaempleados.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiar();
            }
        }
    }
}

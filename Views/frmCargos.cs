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
using Views.Utilidades;

namespace Views
{
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            lblfecha.Text = $"{fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}";

            foreach (DataGridViewColumn columna in tablacargos.Columns)
            {
                if (columna.Visible == true)
                {
                    listabuscar.Items.Add(new OpcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listabuscar.DisplayMember = "Texto";
                listabuscar.ValueMember = "Valor";
                listabuscar.SelectedIndex = 0;
            }

            cbestado.Items.Add(new OpcionesComboBox() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new OpcionesComboBox() { Valor = 0, Texto = "Inactivo" });
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;

            List<Cargos> listaUsuario = new CCargos().Listar();
            foreach (Cargos item in listaUsuario)
            {
                tablacargos.Rows.Add(new object[] { "", item.idcargo, item.nombrecargo, item.estado == true ? 1 : 0, item.estado == true ? "Activo" : "Inactivo", item.fecharegistro});
            }

        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";

            txtnombrecargo.Text = "";

            cbestado.SelectedIndex = 0;
            txtnombrecargo.Select();
        }

        private void tablacargos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void tablacargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablacargos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = tablacargos.Rows[indice].Cells["idcargo"].Value.ToString();
                    txtnombrecargo.Text = tablacargos.Rows[indice].Cells["nombrecargo"].Value.ToString();
                    foreach (OpcionesComboBox oc in cbestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(tablacargos.Rows[indice].Cells["valorestado"].Value))
                        {
                            int indice_combo = cbestado.Items.IndexOf(oc);
                            cbestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    btnAgregar.Text = "    Editar";
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in tablacargos.Rows)
            {
                row.Visible = true;
            }
            txtbuscar.Select();
        }

        private void btnbuscarlista_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((OpcionesComboBox)listabuscar.SelectedItem).Valor.ToString();
            if (tablacargos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tablacargos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cargos objcargos = new Cargos()
            {
                idcargo = Convert.ToInt32(txtid.Text),
                nombrecargo = txtnombrecargo.Text,
                estado = Convert.ToInt32(((OpcionesComboBox)cbestado.SelectedItem).Valor) == 1 ? true : false,
            };
            if (btnAgregar.Text == "    Agregar")
            {
                int idusuariogenerado = new CCargos().Registrar(objcargos, out mensaje);
                if (idusuariogenerado != 0)
                {
                    tablacargos.Rows.Add(new object[] {"", idusuariogenerado, txtnombrecargo.Text,
                        ((OpcionesComboBox)cbestado.SelectedItem).Valor.ToString(),
                        ((OpcionesComboBox)cbestado.SelectedItem).Texto.ToString()
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
                bool resultado = new CCargos().Editar(objcargos, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = tablacargos.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idcargo"].Value = Convert.ToInt32(txtid.Text);
                    row.Cells["nombrecargo"].Value = txtnombrecargo.Text;
                    row.Cells["valorestado"].Value = ((OpcionesComboBox)cbestado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionesComboBox)cbestado.SelectedItem).Texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                btnAgregar.Text = "    Agregar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el cargo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cargos objcargos = new Cargos()
                    {
                        idcargo = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CCargos().Eliminar(objcargos, out mensaje);
                    if (respuesta)
                    {
                        tablacargos.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
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

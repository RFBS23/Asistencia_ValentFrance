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
    public partial class frmHorarios : Form
    {
        public frmHorarios()
        {
            InitializeComponent();
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            cbcargo.Items.Clear();

            DateTime fechaActual = DateTime.Now;
            lblfecha.Text = $"{fechaActual.Year}-{fechaActual.Month}-{fechaActual.Day}";

            List<Cargos> listacat = new CCargos().ListarCargos();
            cbcargo.Items.Add(new OpcionesComboBox() { Valor = 0, Texto = "Elija un cargo" });
            foreach (Cargos item in listacat)
            {
                cbcargo.Items.Add(new OpcionesComboBox() { Valor = item.idcargo, Texto = item.nombrecargo });
            }
            cbcargo.DisplayMember = "Texto";
            cbcargo.ValueMember = "Valor";
            cbcargo.SelectedIndex = 0;
            /*
            List<Horarios> listahorario = new CHorarios().Listar();
            foreach (Horarios item in listahorario)
            {
                tablahorario.Rows.Add(new object[] { "", item.idhorario, item.oCargo.idcargo, item.oCargo.nombrecargo, item.horainicio, item.horasalida });
            }*/
            RecargarHorarios();
        }

        private void RecargarHorarios()
        {
            tablahorario.Rows.Clear();
            List<Horarios> listahorario = new CHorarios().Listar();
            foreach (Horarios item in listahorario)
            {
                tablahorario.Rows.Add(new object[]
                {
                    "", item.idhorario, item.oCargo.idcargo, item.oCargo.nombrecargo, item.horainicio, item.horasalida
                });
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Horarios objhorario = new Horarios()
            {
                idhorario = Convert.ToInt32(txtid.Text),
                oCargo = new Cargos() { idcargo = Convert.ToInt32(((OpcionesComboBox)cbcargo.SelectedItem).Valor) },
                horainicio = txthorainicio.Text,
                horasalida = txthorasalida.Text,
            };
            if (objhorario.idhorario == 0 | btnAgregar.Text == "    Agregar")
            {
                int idhorariogenerado = new CHorarios().Registrar(objhorario, out mensaje);

                if (idhorariogenerado != 0)
                {
                    tablahorario.Rows.Add(new object[] { "", idhorariogenerado,
                        ((OpcionesComboBox)cbcargo.SelectedItem).Valor.ToString(),
                        ((OpcionesComboBox)cbcargo.SelectedItem).Texto.ToString(),
                        txthorainicio.Text,
                        txthorasalida.Text
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
                bool resultado = new CHorarios().Editar(objhorario, out mensaje);
                
                if (resultado)
                {
                    DataGridViewRow row = tablahorario.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idhorario"].Value = txtid.Text;
                    row.Cells["idcargo"].Value = ((OpcionesComboBox)cbcargo.SelectedItem).Valor.ToString();
                    row.Cells["nombrecargo"].Value = ((OpcionesComboBox)cbcargo.SelectedItem).Texto.ToString();
                    row.Cells["horainicio"].Value = txthorainicio.Text;
                    row.Cells["horasalida"].Value = txthorasalida.Text;
                    RecargarHorarios();
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";

            cbcargo.SelectedIndex = 0;
            cbcargo.Select();
        }

        private void tablahorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablahorario.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = tablahorario.Rows[indice].Cells["idhorario"].Value.ToString();
                    foreach (OpcionesComboBox ocb in cbcargo.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(tablahorario.Rows[indice].Cells["idcargo"].Value))
                        {
                            int indice_combo = cbcargo.Items.IndexOf(ocb);
                            cbcargo.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    txthorainicio.Text = tablahorario.Rows[indice].Cells["horainicio"].Value.ToString();
                    txthorasalida.Text = tablahorario.Rows[indice].Cells["horasalida"].Value.ToString();
                    btnAgregar.Text = "    Editar";
                }
            }
        }

        private void tablahorario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}

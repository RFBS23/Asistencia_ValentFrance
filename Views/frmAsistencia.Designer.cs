namespace Views
{
    partial class frmAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltallas = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbempleados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexportarexcel = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfechafin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtfechainicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnbuscar = new Guna.UI2.WinForms.Guna2Button();
            this.lbldni = new System.Windows.Forms.Label();
            this.tablahorario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtindice = new Guna.UI2.WinForms.Guna2TextBox();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horastrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltallas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablahorario)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltallas
            // 
            this.paneltallas.AutoScroll = true;
            this.paneltallas.BackColor = System.Drawing.SystemColors.Control;
            this.paneltallas.Controls.Add(this.label4);
            this.paneltallas.Controls.Add(this.cbempleados);
            this.paneltallas.Controls.Add(this.label3);
            this.paneltallas.Controls.Add(this.btnexportarexcel);
            this.paneltallas.Controls.Add(this.label2);
            this.paneltallas.Controls.Add(this.dtfechafin);
            this.paneltallas.Controls.Add(this.dtfechainicio);
            this.paneltallas.Controls.Add(this.btnbuscar);
            this.paneltallas.Controls.Add(this.lbldni);
            this.paneltallas.Controls.Add(this.tablahorario);
            this.paneltallas.Controls.Add(this.txtid);
            this.paneltallas.Controls.Add(this.txtindice);
            this.paneltallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltallas.Location = new System.Drawing.Point(0, 0);
            this.paneltallas.Name = "paneltallas";
            this.paneltallas.Size = new System.Drawing.Size(1479, 676);
            this.paneltallas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(758, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 28);
            this.label4.TabIndex = 81;
            this.label4.Text = "Selecciona al Trabajador";
            // 
            // cbempleados
            // 
            this.cbempleados.BackColor = System.Drawing.Color.Transparent;
            this.cbempleados.BorderRadius = 10;
            this.cbempleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbempleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbempleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbempleados.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.cbempleados.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.cbempleados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbempleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbempleados.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.cbempleados.ItemHeight = 30;
            this.cbempleados.Location = new System.Drawing.Point(762, 138);
            this.cbempleados.Name = "cbempleados";
            this.cbempleados.Size = new System.Drawing.Size(421, 36);
            this.cbempleados.TabIndex = 80;
            this.cbempleados.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1304, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Exportar en Excel";
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.Animated = true;
            this.btnexportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexportarexcel.BorderRadius = 10;
            this.btnexportarexcel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnexportarexcel.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnexportarexcel.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnexportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportarexcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexportarexcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexportarexcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexportarexcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexportarexcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnexportarexcel.FocusedColor = System.Drawing.Color.Transparent;
            this.btnexportarexcel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportarexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(221)))), ((int)(((byte)(55)))));
            this.btnexportarexcel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnexportarexcel.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnexportarexcel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(221)))), ((int)(((byte)(55)))));
            this.btnexportarexcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexportarexcel.Location = new System.Drawing.Point(1308, 138);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.PressedColor = System.Drawing.Color.Transparent;
            this.btnexportarexcel.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnexportarexcel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnexportarexcel.Size = new System.Drawing.Size(159, 55);
            this.btnexportarexcel.TabIndex = 78;
            this.btnexportarexcel.Text = "  EXCEL";
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Fecha Fin:";
            // 
            // dtfechafin
            // 
            this.dtfechafin.BorderRadius = 10;
            this.dtfechafin.Checked = true;
            this.dtfechafin.CustomFormat = "dd/mm/yyyy";
            this.dtfechafin.FillColor = System.Drawing.Color.Gainsboro;
            this.dtfechafin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtfechafin.Location = new System.Drawing.Point(386, 132);
            this.dtfechafin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtfechafin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtfechafin.Name = "dtfechafin";
            this.dtfechafin.Size = new System.Drawing.Size(314, 61);
            this.dtfechafin.TabIndex = 76;
            this.dtfechafin.Value = new System.DateTime(2024, 7, 6, 4, 34, 51, 88);
            // 
            // dtfechainicio
            // 
            this.dtfechainicio.BorderRadius = 10;
            this.dtfechainicio.Checked = true;
            this.dtfechainicio.CustomFormat = "dd/mm/yyyy";
            this.dtfechainicio.FillColor = System.Drawing.Color.Gainsboro;
            this.dtfechainicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtfechainicio.Location = new System.Drawing.Point(12, 132);
            this.dtfechainicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtfechainicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtfechainicio.Name = "dtfechainicio";
            this.dtfechainicio.Size = new System.Drawing.Size(320, 61);
            this.dtfechainicio.TabIndex = 75;
            this.dtfechainicio.Value = new System.DateTime(2024, 7, 6, 4, 34, 49, 755);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Animated = true;
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BorderRadius = 10;
            this.btnbuscar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnbuscar.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnbuscar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnbuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnbuscar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnbuscar.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnbuscar.Image = global::Views.Properties.Resources.buscar;
            this.btnbuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnbuscar.Location = new System.Drawing.Point(1214, 132);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.PressedColor = System.Drawing.Color.Transparent;
            this.btnbuscar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnbuscar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnbuscar.Size = new System.Drawing.Size(68, 61);
            this.btnbuscar.TabIndex = 74;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(8, 109);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(126, 20);
            this.lbldni.TabIndex = 73;
            this.lbldni.Text = "Fecha Inicio:";
            // 
            // tablahorario
            // 
            this.tablahorario.AllowUserToAddRows = false;
            this.tablahorario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablahorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablahorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablahorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablahorario.ColumnHeadersHeight = 37;
            this.tablahorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablahorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecharegistro,
            this.documento,
            this.nombre_completo,
            this.horainicio,
            this.horasalida,
            this.horastrabajadas});
            this.tablahorario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablahorario.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablahorario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablahorario.Location = new System.Drawing.Point(12, 271);
            this.tablahorario.MultiSelect = false;
            this.tablahorario.Name = "tablahorario";
            this.tablahorario.ReadOnly = true;
            this.tablahorario.RowHeadersVisible = false;
            this.tablahorario.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablahorario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablahorario.RowTemplate.Height = 30;
            this.tablahorario.Size = new System.Drawing.Size(1455, 393);
            this.tablahorario.TabIndex = 48;
            this.tablahorario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablahorario.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablahorario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablahorario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablahorario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablahorario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablahorario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablahorario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablahorario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablahorario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tablahorario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablahorario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablahorario.ThemeStyle.HeaderStyle.Height = 37;
            this.tablahorario.ThemeStyle.ReadOnly = true;
            this.tablahorario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablahorario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablahorario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablahorario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablahorario.ThemeStyle.RowsStyle.Height = 30;
            this.tablahorario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablahorario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtid
            // 
            this.txtid.BorderRadius = 10;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "0";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(339, 22);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(30, 29);
            this.txtid.TabIndex = 34;
            this.txtid.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.BorderRadius = 8;
            this.txtindice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtindice.DefaultText = "-1";
            this.txtindice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtindice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtindice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtindice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtindice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtindice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtindice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtindice.Location = new System.Drawing.Point(290, 22);
            this.txtindice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtindice.Name = "txtindice";
            this.txtindice.PasswordChar = '\0';
            this.txtindice.PlaceholderText = "";
            this.txtindice.SelectedText = "";
            this.txtindice.Size = new System.Drawing.Size(41, 29);
            this.txtindice.TabIndex = 33;
            this.txtindice.Visible = false;
            // 
            // fecharegistro
            // 
            this.fecharegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecharegistro.HeaderText = "Fecha Registro";
            this.fecharegistro.MinimumWidth = 6;
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fecharegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecharegistro.Width = 139;
            // 
            // documento
            // 
            this.documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.documento.HeaderText = "Documento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.documento.Width = 94;
            // 
            // nombre_completo
            // 
            this.nombre_completo.HeaderText = "Nombres y Apellidos";
            this.nombre_completo.MinimumWidth = 6;
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            // 
            // horainicio
            // 
            this.horainicio.HeaderText = "Hora Inicio";
            this.horainicio.MinimumWidth = 6;
            this.horainicio.Name = "horainicio";
            this.horainicio.ReadOnly = true;
            // 
            // horasalida
            // 
            this.horasalida.HeaderText = "Hora Salida";
            this.horasalida.MinimumWidth = 6;
            this.horasalida.Name = "horasalida";
            this.horasalida.ReadOnly = true;
            // 
            // horastrabajadas
            // 
            this.horastrabajadas.HeaderText = "Horas Trabajadas";
            this.horastrabajadas.MinimumWidth = 6;
            this.horastrabajadas.Name = "horastrabajadas";
            this.horastrabajadas.ReadOnly = true;
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 676);
            this.Controls.Add(this.paneltallas);
            this.Name = "frmAsistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.paneltallas.ResumeLayout(false);
            this.paneltallas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablahorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltallas;
        private Guna.UI2.WinForms.Guna2DataGridView tablahorario;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtindice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbempleados;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnexportarexcel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtfechafin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtfechainicio;
        private Guna.UI2.WinForms.Guna2Button btnbuscar;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horastrabajadas;
    }
}
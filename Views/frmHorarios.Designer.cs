namespace Views
{
    partial class frmHorarios
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
            this.paneltallas = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorasalida = new System.Windows.Forms.DateTimePicker();
            this.txthorainicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablahorario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idhorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiarbuscador = new Guna.UI2.WinForms.Guna2Button();
            this.listabuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscarlista = new Guna.UI2.WinForms.Guna2Button();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtindice = new Guna.UI2.WinForms.Guna2TextBox();
            this.paneltallas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablahorario)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltallas
            // 
            this.paneltallas.AutoScroll = true;
            this.paneltallas.BackColor = System.Drawing.SystemColors.Control;
            this.paneltallas.Controls.Add(this.label1);
            this.paneltallas.Controls.Add(this.txthorasalida);
            this.paneltallas.Controls.Add(this.txthorainicio);
            this.paneltallas.Controls.Add(this.label10);
            this.paneltallas.Controls.Add(this.label3);
            this.paneltallas.Controls.Add(this.cbcargo);
            this.paneltallas.Controls.Add(this.label2);
            this.paneltallas.Controls.Add(this.tablahorario);
            this.paneltallas.Controls.Add(this.btnlimpiarbuscador);
            this.paneltallas.Controls.Add(this.listabuscar);
            this.paneltallas.Controls.Add(this.label9);
            this.paneltallas.Controls.Add(this.btnbuscarlista);
            this.paneltallas.Controls.Add(this.txtbuscar);
            this.paneltallas.Controls.Add(this.btnEliminar);
            this.paneltallas.Controls.Add(this.btnLimpiar);
            this.paneltallas.Controls.Add(this.btnAgregar);
            this.paneltallas.Controls.Add(this.lblfecha);
            this.paneltallas.Controls.Add(this.txtid);
            this.paneltallas.Controls.Add(this.txtindice);
            this.paneltallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltallas.Location = new System.Drawing.Point(0, 0);
            this.paneltallas.Name = "paneltallas";
            this.paneltallas.Size = new System.Drawing.Size(1479, 676);
            this.paneltallas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Salida";
            // 
            // txthorasalida
            // 
            this.txthorasalida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txthorasalida.Location = new System.Drawing.Point(382, 216);
            this.txthorasalida.Name = "txthorasalida";
            this.txthorasalida.ShowUpDown = true;
            this.txthorasalida.Size = new System.Drawing.Size(200, 34);
            this.txthorasalida.TabIndex = 60;
            // 
            // txthorainicio
            // 
            this.txthorainicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txthorainicio.Location = new System.Drawing.Point(382, 136);
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.ShowUpDown = true;
            this.txthorainicio.Size = new System.Drawing.Size(200, 34);
            this.txthorainicio.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 56;
            this.label10.Text = "Agrega tus tallas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Entrada";
            // 
            // cbcargo
            // 
            this.cbcargo.BackColor = System.Drawing.Color.Transparent;
            this.cbcargo.BorderRadius = 10;
            this.cbcargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbcargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.cbcargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.cbcargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbcargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbcargo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.cbcargo.ItemHeight = 30;
            this.cbcargo.Location = new System.Drawing.Point(30, 134);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(301, 36);
            this.cbcargo.TabIndex = 53;
            this.cbcargo.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Seleccione el Cargo";
            // 
            // tablahorario
            // 
            this.tablahorario.AllowUserToAddRows = false;
            this.tablahorario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablahorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablahorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablahorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablahorario.ColumnHeadersHeight = 37;
            this.tablahorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablahorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.idhorario,
            this.idcargo,
            this.nombrecargo,
            this.horainicio,
            this.horasalida});
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
            this.tablahorario.Location = new System.Drawing.Point(12, 297);
            this.tablahorario.MultiSelect = false;
            this.tablahorario.Name = "tablahorario";
            this.tablahorario.ReadOnly = true;
            this.tablahorario.RowHeadersVisible = false;
            this.tablahorario.RowHeadersWidth = 51;
            this.tablahorario.RowTemplate.Height = 30;
            this.tablahorario.Size = new System.Drawing.Size(1455, 367);
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
            this.tablahorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablahorario_CellContentClick);
            this.tablahorario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tablahorario_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "Seleccionar";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            // 
            // idhorario
            // 
            this.idhorario.HeaderText = "idhorario";
            this.idhorario.MinimumWidth = 6;
            this.idhorario.Name = "idhorario";
            this.idhorario.ReadOnly = true;
            this.idhorario.Visible = false;
            // 
            // idcargo
            // 
            this.idcargo.HeaderText = "idcargo";
            this.idcargo.MinimumWidth = 6;
            this.idcargo.Name = "idcargo";
            this.idcargo.ReadOnly = true;
            this.idcargo.Visible = false;
            // 
            // nombrecargo
            // 
            this.nombrecargo.HeaderText = "Nombre de cargo";
            this.nombrecargo.MinimumWidth = 6;
            this.nombrecargo.Name = "nombrecargo";
            this.nombrecargo.ReadOnly = true;
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
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiarbuscador.Animated = true;
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarbuscador.BorderRadius = 10;
            this.btnlimpiarbuscador.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnlimpiarbuscador.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnlimpiarbuscador.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlimpiarbuscador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlimpiarbuscador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlimpiarbuscador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlimpiarbuscador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnlimpiarbuscador.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnlimpiarbuscador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnlimpiarbuscador.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnlimpiarbuscador.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnlimpiarbuscador.Image = global::Views.Properties.Resources.escoba;
            this.btnlimpiarbuscador.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(1408, 22);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.PressedColor = System.Drawing.Color.Transparent;
            this.btnlimpiarbuscador.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnlimpiarbuscador.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(59, 48);
            this.btnlimpiarbuscador.TabIndex = 47;
            // 
            // listabuscar
            // 
            this.listabuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listabuscar.BackColor = System.Drawing.Color.Transparent;
            this.listabuscar.BorderRadius = 10;
            this.listabuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listabuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listabuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listabuscar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.listabuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.listabuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listabuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.listabuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.listabuscar.ItemHeight = 30;
            this.listabuscar.Location = new System.Drawing.Point(792, 19);
            this.listabuscar.Name = "listabuscar";
            this.listabuscar.Size = new System.Drawing.Size(265, 36);
            this.listabuscar.TabIndex = 43;
            this.listabuscar.Tag = "";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(713, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "Buscar:";
            // 
            // btnbuscarlista
            // 
            this.btnbuscarlista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscarlista.Animated = true;
            this.btnbuscarlista.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarlista.BorderRadius = 10;
            this.btnbuscarlista.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnbuscarlista.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscarlista.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnbuscarlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarlista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscarlista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscarlista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbuscarlista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbuscarlista.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnbuscarlista.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnbuscarlista.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnbuscarlista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnbuscarlista.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnbuscarlista.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnbuscarlista.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnbuscarlista.Image = global::Views.Properties.Resources.buscar;
            this.btnbuscarlista.ImageSize = new System.Drawing.Size(30, 30);
            this.btnbuscarlista.Location = new System.Drawing.Point(1339, 19);
            this.btnbuscarlista.Name = "btnbuscarlista";
            this.btnbuscarlista.PressedColor = System.Drawing.Color.Transparent;
            this.btnbuscarlista.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnbuscarlista.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnbuscarlista.Size = new System.Drawing.Size(59, 48);
            this.btnbuscarlista.TabIndex = 45;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Animated = true;
            this.txtbuscar.BorderRadius = 10;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.txtbuscar.Location = new System.Drawing.Point(1081, 19);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "Buscar ...";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.Size = new System.Drawing.Size(229, 48);
            this.txtbuscar.TabIndex = 44;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnEliminar.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(29)))));
            this.btnEliminar.FocusedColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(26)))));
            this.btnEliminar.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.btnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEliminar.Location = new System.Drawing.Point(1281, 134);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.Transparent;
            this.btnEliminar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnEliminar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Size = new System.Drawing.Size(165, 48);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Animated = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderRadius = 10;
            this.btnLimpiar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnLimpiar.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FocusedColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnLimpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(97)))), ((int)(((byte)(230)))));
            this.btnLimpiar.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(248)))));
            this.btnLimpiar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLimpiar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLimpiar.Location = new System.Drawing.Point(1062, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.PressedColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnLimpiar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Size = new System.Drawing.Size(188, 48);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "    Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAgregar.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAgregar.FocusedColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(97)))), ((int)(((byte)(230)))));
            this.btnAgregar.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.btnAgregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAgregar.Location = new System.Drawing.Point(862, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.PressedColor = System.Drawing.Color.Transparent;
            this.btnAgregar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnAgregar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Size = new System.Drawing.Size(165, 48);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "    Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(398, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(40, 16);
            this.lblfecha.TabIndex = 35;
            this.lblfecha.Text = "fecha";
            this.lblfecha.Visible = false;
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
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 676);
            this.Controls.Add(this.paneltallas);
            this.Name = "frmHorarios";
            this.Text = "frmHorarios";
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            this.paneltallas.ResumeLayout(false);
            this.paneltallas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablahorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltallas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbcargo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView tablahorario;
        private Guna.UI2.WinForms.Guna2Button btnlimpiarbuscador;
        private Guna.UI2.WinForms.Guna2ComboBox listabuscar;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnbuscarlista;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.Label lblfecha;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtindice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txthorasalida;
        private System.Windows.Forms.DateTimePicker txthorainicio;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalida;
    }
}
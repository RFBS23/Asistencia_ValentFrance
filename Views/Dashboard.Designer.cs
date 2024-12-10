namespace Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelFormularios = new Guna.UI2.WinForms.Guna2Panel();
            this.banner = new Guna.UI2.WinForms.Guna2Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAsistencia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnHorarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmpleados = new Guna.UI2.WinForms.Guna2Button();
            this.btninformacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.panelFormularios.SuspendLayout();
            this.banner.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.Controls.Add(this.banner);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 131);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1519, 592);
            this.panelFormularios.TabIndex = 3;
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.BackColor = System.Drawing.Color.Transparent;
            this.banner.BorderRadius = 20;
            this.banner.Controls.Add(this.lblhora);
            this.banner.Controls.Add(this.lblfecha);
            this.banner.Controls.Add(this.label3);
            this.banner.Controls.Add(this.label2);
            this.banner.Controls.Add(this.lblnombre);
            this.banner.Controls.Add(this.guna2Panel2);
            this.banner.FillColor = System.Drawing.Color.White;
            this.banner.Location = new System.Drawing.Point(19, 12);
            this.banner.Name = "banner";
            this.banner.ShadowDecoration.BorderRadius = 10;
            this.banner.ShadowDecoration.Depth = 20;
            this.banner.ShadowDecoration.Enabled = true;
            this.banner.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.banner.Size = new System.Drawing.Size(1476, 202);
            this.banner.TabIndex = 1;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(24, 160);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(64, 17);
            this.lblhora.TabIndex = 7;
            this.lblhora.Text = "00:00:00";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(24, 143);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(80, 17);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "00/00/0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "las asistencias de cada personal.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Una solucion integral diseñada para optimizar y gestionar eficientemente";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblnombre.Location = new System.Drawing.Point(23, 37);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(168, 23);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "nombre apellido";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(1194, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(282, 202);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.ErrorImage")));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(282, 202);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderRadius = 20;
            this.panelMenu.Controls.Add(this.btnAsistencia);
            this.panelMenu.Controls.Add(this.guna2HtmlLabel1);
            this.panelMenu.Controls.Add(this.btnHorarios);
            this.panelMenu.Controls.Add(this.btnCargos);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btninformacion);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.FillColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1519, 131);
            this.panelMenu.TabIndex = 2;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Animated = true;
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.BorderRadius = 10;
            this.btnAsistencia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAsistencia.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAsistencia.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsistencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsistencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAsistencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAsistencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnAsistencia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnAsistencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnAsistencia.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAsistencia.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAsistencia.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnAsistencia.Image = global::Views.Properties.Resources.horas_laborales;
            this.btnAsistencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAsistencia.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAsistencia.IndicateFocus = true;
            this.btnAsistencia.Location = new System.Drawing.Point(1312, 25);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.PressedColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnAsistencia.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnAsistencia.Size = new System.Drawing.Size(232, 68);
            this.btnAsistencia.TabIndex = 14;
            this.btnAsistencia.Text = "       Asistencias";
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1820, 37);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(28, 47);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "  ";
            // 
            // btnHorarios
            // 
            this.btnHorarios.Animated = true;
            this.btnHorarios.BackColor = System.Drawing.Color.Transparent;
            this.btnHorarios.BorderRadius = 10;
            this.btnHorarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnHorarios.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnHorarios.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHorarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHorarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHorarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHorarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnHorarios.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnHorarios.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnHorarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnHorarios.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnHorarios.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnHorarios.Image = global::Views.Properties.Resources.horas_laborales;
            this.btnHorarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHorarios.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHorarios.IndicateFocus = true;
            this.btnHorarios.Location = new System.Drawing.Point(1056, 25);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.PressedColor = System.Drawing.Color.Transparent;
            this.btnHorarios.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnHorarios.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnHorarios.Size = new System.Drawing.Size(232, 68);
            this.btnHorarios.TabIndex = 13;
            this.btnHorarios.Text = "       Horarios";
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Animated = true;
            this.btnCargos.BackColor = System.Drawing.Color.Transparent;
            this.btnCargos.BorderRadius = 10;
            this.btnCargos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnCargos.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargos.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCargos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCargos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnCargos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnCargos.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargos.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnCargos.Image = global::Views.Properties.Resources.carnet_de_identidad;
            this.btnCargos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCargos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCargos.IndicateFocus = true;
            this.btnCargos.Location = new System.Drawing.Point(789, 25);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.PressedColor = System.Drawing.Color.Transparent;
            this.btnCargos.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnCargos.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnCargos.Size = new System.Drawing.Size(232, 68);
            this.btnCargos.TabIndex = 12;
            this.btnCargos.Text = "       Cargos";
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Animated = true;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BorderRadius = 10;
            this.btnEmpleados.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnEmpleados.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmpleados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmpleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnEmpleados.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnEmpleados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnEmpleados.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnEmpleados.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnEmpleados.Image = global::Views.Properties.Resources.empleados;
            this.btnEmpleados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpleados.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEmpleados.IndicateFocus = true;
            this.btnEmpleados.Location = new System.Drawing.Point(530, 25);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.PressedColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnEmpleados.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnEmpleados.Size = new System.Drawing.Size(232, 68);
            this.btnEmpleados.TabIndex = 11;
            this.btnEmpleados.Text = "       Empleados";
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btninformacion
            // 
            this.btninformacion.Animated = true;
            this.btninformacion.BackColor = System.Drawing.Color.Transparent;
            this.btninformacion.BorderRadius = 10;
            this.btninformacion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btninformacion.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btninformacion.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btninformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninformacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btninformacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btninformacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btninformacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btninformacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btninformacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btninformacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btninformacion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btninformacion.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btninformacion.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btninformacion.Image = ((System.Drawing.Image)(resources.GetObject("btninformacion.Image")));
            this.btninformacion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btninformacion.ImageSize = new System.Drawing.Size(50, 50);
            this.btninformacion.IndicateFocus = true;
            this.btninformacion.Location = new System.Drawing.Point(1565, 25);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.PressedColor = System.Drawing.Color.Transparent;
            this.btninformacion.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btninformacion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btninformacion.Size = new System.Drawing.Size(251, 68);
            this.btninformacion.TabIndex = 10;
            this.btninformacion.Text = "         Información";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BorderRadius = 10;
            this.btnUsuarios.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnUsuarios.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnUsuarios.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnUsuarios.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUsuarios.IndicateFocus = true;
            this.btnUsuarios.Location = new System.Drawing.Point(276, 25);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.PressedColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnUsuarios.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Size = new System.Drawing.Size(232, 68);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "       Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Animated = true;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BorderRadius = 10;
            this.btnInicio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnInicio.CheckedState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnInicio.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnInicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(122)))), ((int)(((byte)(141)))));
            this.btnInicio.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnInicio.HoverState.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnInicio.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInicio.ImageSize = new System.Drawing.Size(50, 50);
            this.btnInicio.IndicateFocus = true;
            this.btnInicio.Location = new System.Drawing.Point(19, 25);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.PressedColor = System.Drawing.Color.Transparent;
            this.btnInicio.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnInicio.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnInicio.Size = new System.Drawing.Size(232, 68);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "      Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 723);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panelFormularios.ResumeLayout(false);
            this.banner.ResumeLayout(false);
            this.banner.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelFormularios;
        private Guna.UI2.WinForms.Guna2Panel banner;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btninformacion;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnEmpleados;
        private Guna.UI2.WinForms.Guna2Button btnHorarios;
        private Guna.UI2.WinForms.Guna2Button btnCargos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAsistencia;
    }
}
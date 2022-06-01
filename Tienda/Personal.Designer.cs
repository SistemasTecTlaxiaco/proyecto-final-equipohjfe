namespace Tienda
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.listViewCajero = new System.Windows.Forms.ListView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.CboxCajeroConsulta = new System.Windows.Forms.ComboBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.TabPage();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.lblCorreroeditar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltelefonoeditar = new System.Windows.Forms.Label();
            this.lbldireccioneditar = new System.Windows.Forms.Label();
            this.lblNombreeditar = new System.Windows.Forms.Label();
            this.lblcedulaeditar = new System.Windows.Forms.Label();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtDireccionEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.txtIDEditar = new System.Windows.Forms.TextBox();
            this.comboBoxConsultarEditar = new System.Windows.Forms.ComboBox();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Agregar.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.Editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Agregar);
            this.tabControl1.Controls.Add(this.Consultar);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Controls.Add(this.Editar);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1451, 709);
            this.tabControl1.TabIndex = 3;
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Agregar.Controls.Add(this.lblDireccion);
            this.Agregar.Controls.Add(this.lblTelefono);
            this.Agregar.Controls.Add(this.txtCorreo);
            this.Agregar.Controls.Add(this.lblUsuario);
            this.Agregar.Controls.Add(this.lblemail);
            this.Agregar.Controls.Add(this.lblNombre);
            this.Agregar.Controls.Add(this.lblCedula);
            this.Agregar.Controls.Add(this.buttonGuardar);
            this.Agregar.Controls.Add(this.txtTelefono);
            this.Agregar.Controls.Add(this.txtDireccion);
            this.Agregar.Controls.Add(this.txtNombre);
            this.Agregar.Controls.Add(this.txtID);
            this.Agregar.Location = new System.Drawing.Point(4, 25);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(4);
            this.Agregar.Size = new System.Drawing.Size(1443, 680);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(451, 249);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 28;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(451, 290);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(543, 322);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(381, 22);
            this.txtCorreo.TabIndex = 25;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(451, 294);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 23;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(455, 322);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 16);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "E-mail";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(451, 212);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(451, 169);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(20, 16);
            this.lblCedula.TabIndex = 13;
            this.lblCedula.Text = "ID";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(652, 400);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 44);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(543, 288);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(381, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(543, 245);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(381, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(543, 206);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(381, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(543, 166);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(381, 22);
            this.txtID.TabIndex = 0;
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.listViewCajero);
            this.Consultar.Controls.Add(this.lblCliente);
            this.Consultar.Controls.Add(this.CboxCajeroConsulta);
            this.Consultar.Controls.Add(this.buttonConsultar);
            this.Consultar.Location = new System.Drawing.Point(4, 25);
            this.Consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(4);
            this.Consultar.Size = new System.Drawing.Size(1443, 680);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // listViewCajero
            // 
            this.listViewCajero.HideSelection = false;
            this.listViewCajero.Location = new System.Drawing.Point(275, 304);
            this.listViewCajero.Margin = new System.Windows.Forms.Padding(4);
            this.listViewCajero.Name = "listViewCajero";
            this.listViewCajero.Size = new System.Drawing.Size(827, 176);
            this.listViewCajero.TabIndex = 3;
            this.listViewCajero.UseCompatibleStateImageBehavior = false;
            this.listViewCajero.View = System.Windows.Forms.View.Details;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(347, 148);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(63, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "ID Cajero";
            // 
            // CboxCajeroConsulta
            // 
            this.CboxCajeroConsulta.FormattingEnabled = true;
            this.CboxCajeroConsulta.Location = new System.Drawing.Point(421, 148);
            this.CboxCajeroConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.CboxCajeroConsulta.Name = "CboxCajeroConsulta";
            this.CboxCajeroConsulta.Size = new System.Drawing.Size(593, 24);
            this.CboxCajeroConsulta.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(628, 219);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(141, 43);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.label11);
            this.Eliminar.Controls.Add(this.comboBoxEliminar);
            this.Eliminar.Controls.Add(this.buttonEliminar);
            this.Eliminar.Location = new System.Drawing.Point(4, 25);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(4);
            this.Eliminar.Size = new System.Drawing.Size(1443, 680);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 270);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cajero";
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Location = new System.Drawing.Point(499, 260);
            this.comboBoxEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(455, 24);
            this.comboBoxEliminar.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(657, 313);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(129, 48);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Controls.Add(this.txtCorreoEditar);
            this.Editar.Controls.Add(this.lblCorreroeditar);
            this.Editar.Controls.Add(this.label6);
            this.Editar.Controls.Add(this.lbltelefonoeditar);
            this.Editar.Controls.Add(this.lbldireccioneditar);
            this.Editar.Controls.Add(this.lblNombreeditar);
            this.Editar.Controls.Add(this.lblcedulaeditar);
            this.Editar.Controls.Add(this.txtTelefonoEditar);
            this.Editar.Controls.Add(this.txtDireccionEditar);
            this.Editar.Controls.Add(this.txtNombreEditar);
            this.Editar.Controls.Add(this.txtIDEditar);
            this.Editar.Controls.Add(this.comboBoxConsultarEditar);
            this.Editar.Controls.Add(this.buttonGuardarCambios);
            this.Editar.Controls.Add(this.buttonBuscar);
            this.Editar.Location = new System.Drawing.Point(4, 25);
            this.Editar.Margin = new System.Windows.Forms.Padding(4);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(4);
            this.Editar.Size = new System.Drawing.Size(1443, 680);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(473, 405);
            this.txtCorreoEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(439, 22);
            this.txtCorreoEditar.TabIndex = 15;
            // 
            // lblCorreroeditar
            // 
            this.lblCorreroeditar.AutoSize = true;
            this.lblCorreroeditar.Location = new System.Drawing.Point(352, 407);
            this.lblCorreroeditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreroeditar.Name = "lblCorreroeditar";
            this.lblCorreroeditar.Size = new System.Drawing.Size(48, 16);
            this.lblCorreroeditar.TabIndex = 14;
            this.lblCorreroeditar.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cajero";
            // 
            // lbltelefonoeditar
            // 
            this.lbltelefonoeditar.AutoSize = true;
            this.lbltelefonoeditar.Location = new System.Drawing.Point(352, 366);
            this.lbltelefonoeditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefonoeditar.Name = "lbltelefonoeditar";
            this.lbltelefonoeditar.Size = new System.Drawing.Size(61, 16);
            this.lbltelefonoeditar.TabIndex = 10;
            this.lbltelefonoeditar.Text = "Teléfono";
            // 
            // lbldireccioneditar
            // 
            this.lbldireccioneditar.AutoSize = true;
            this.lbldireccioneditar.Location = new System.Drawing.Point(352, 325);
            this.lbldireccioneditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldireccioneditar.Name = "lbldireccioneditar";
            this.lbldireccioneditar.Size = new System.Drawing.Size(64, 16);
            this.lbldireccioneditar.TabIndex = 9;
            this.lbldireccioneditar.Text = "Dirección";
            // 
            // lblNombreeditar
            // 
            this.lblNombreeditar.AutoSize = true;
            this.lblNombreeditar.Location = new System.Drawing.Point(352, 281);
            this.lblNombreeditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreeditar.Name = "lblNombreeditar";
            this.lblNombreeditar.Size = new System.Drawing.Size(56, 16);
            this.lblNombreeditar.TabIndex = 8;
            this.lblNombreeditar.Text = "Nombre";
            // 
            // lblcedulaeditar
            // 
            this.lblcedulaeditar.AutoSize = true;
            this.lblcedulaeditar.Location = new System.Drawing.Point(352, 236);
            this.lblcedulaeditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcedulaeditar.Name = "lblcedulaeditar";
            this.lblcedulaeditar.Size = new System.Drawing.Size(20, 16);
            this.lblcedulaeditar.TabIndex = 7;
            this.lblcedulaeditar.Text = "ID";
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(473, 362);
            this.txtTelefonoEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(439, 22);
            this.txtTelefonoEditar.TabIndex = 4;
            // 
            // txtDireccionEditar
            // 
            this.txtDireccionEditar.Location = new System.Drawing.Point(473, 321);
            this.txtDireccionEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionEditar.Name = "txtDireccionEditar";
            this.txtDireccionEditar.Size = new System.Drawing.Size(439, 22);
            this.txtDireccionEditar.TabIndex = 3;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(473, 277);
            this.txtNombreEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(439, 22);
            this.txtNombreEditar.TabIndex = 2;
            // 
            // txtIDEditar
            // 
            this.txtIDEditar.Location = new System.Drawing.Point(473, 236);
            this.txtIDEditar.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEditar.Name = "txtIDEditar";
            this.txtIDEditar.Size = new System.Drawing.Size(439, 22);
            this.txtIDEditar.TabIndex = 1;
            // 
            // comboBoxConsultarEditar
            // 
            this.comboBoxConsultarEditar.FormattingEnabled = true;
            this.comboBoxConsultarEditar.Location = new System.Drawing.Point(473, 158);
            this.comboBoxConsultarEditar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxConsultarEditar.Name = "comboBoxConsultarEditar";
            this.comboBoxConsultarEditar.Size = new System.Drawing.Size(439, 24);
            this.comboBoxConsultarEditar.TabIndex = 0;
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarCambios.Image")));
            this.buttonGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarCambios.Location = new System.Drawing.Point(599, 449);
            this.buttonGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(181, 49);
            this.buttonGuardarCambios.TabIndex = 12;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(631, 191);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(109, 38);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "consultar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 709);
            this.Controls.Add(this.tabControl1);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.tabControl1.ResumeLayout(false);
            this.Agregar.ResumeLayout(false);
            this.Agregar.PerformLayout();
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.Editar.ResumeLayout(false);
            this.Editar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.ListView listViewCajero;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox CboxCajeroConsulta;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TabPage Editar;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.Label lblCorreroeditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltelefonoeditar;
        private System.Windows.Forms.Label lbldireccioneditar;
        private System.Windows.Forms.Label lblNombreeditar;
        private System.Windows.Forms.Label lblcedulaeditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtDireccionEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.TextBox txtIDEditar;
        private System.Windows.Forms.ComboBox comboBoxConsultarEditar;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Button buttonBuscar;
    }
}
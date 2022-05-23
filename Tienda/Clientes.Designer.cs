
namespace Tienda
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.CboxClienteConsulta = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.Editar = new System.Windows.Forms.TabPage();
            this.txtCorreoEditar = new System.Windows.Forms.TextBox();
            this.lblCorreroeditar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.lbltelefonoeditar = new System.Windows.Forms.Label();
            this.lbldireccioneditar = new System.Windows.Forms.Label();
            this.lblNombreeditar = new System.Windows.Forms.Label();
            this.lblcedulaeditar = new System.Windows.Forms.Label();
            this.txtTelefonoEditar = new System.Windows.Forms.TextBox();
            this.txtDireccionEditar = new System.Windows.Forms.TextBox();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.txtCedulaEditar = new System.Windows.Forms.TextBox();
            this.comboBoxConsultarEditar = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // Agregar
            // 
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
            this.Agregar.Controls.Add(this.txtCedula);
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Agregar.Size = new System.Drawing.Size(790, 420);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click_1);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(196, 155);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 28;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(196, 189);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(265, 215);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(287, 20);
            this.txtCorreo.TabIndex = 25;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(196, 192);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 23;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(199, 215);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "E-mail";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(196, 90);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 13;
            this.lblCedula.Text = "Cedula";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(369, 278);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(265, 187);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(287, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(265, 152);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(287, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(287, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(265, 88);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(287, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.listViewClientes);
            this.Consultar.Controls.Add(this.buttonConsultar);
            this.Consultar.Controls.Add(this.lblCliente);
            this.Consultar.Controls.Add(this.CboxClienteConsulta);
            this.Consultar.Location = new System.Drawing.Point(4, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Consultar.Size = new System.Drawing.Size(790, 420);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // listViewClientes
            // 
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(71, 177);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(621, 144);
            this.listViewClientes.TabIndex = 3;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.Details;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(362, 111);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(125, 50);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // CboxClienteConsulta
            // 
            this.CboxClienteConsulta.FormattingEnabled = true;
            this.CboxClienteConsulta.Location = new System.Drawing.Point(181, 50);
            this.CboxClienteConsulta.Name = "CboxClienteConsulta";
            this.CboxClienteConsulta.Size = new System.Drawing.Size(446, 21);
            this.CboxClienteConsulta.TabIndex = 0;
            this.CboxClienteConsulta.SelectedIndexChanged += new System.EventHandler(this.CboxClienteConsulta_SelectedIndexChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.label11);
            this.Eliminar.Controls.Add(this.buttonEliminar);
            this.Eliminar.Controls.Add(this.comboBoxEliminar);
            this.Eliminar.Location = new System.Drawing.Point(4, 22);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Eliminar.Size = new System.Drawing.Size(790, 420);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Producto";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(350, 216);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Location = new System.Drawing.Point(238, 168);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(342, 21);
            this.comboBoxEliminar.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.Controls.Add(this.txtCorreoEditar);
            this.Editar.Controls.Add(this.lblCorreroeditar);
            this.Editar.Controls.Add(this.label6);
            this.Editar.Controls.Add(this.button2);
            this.Editar.Controls.Add(this.buttonBuscar);
            this.Editar.Controls.Add(this.lbltelefonoeditar);
            this.Editar.Controls.Add(this.lbldireccioneditar);
            this.Editar.Controls.Add(this.lblNombreeditar);
            this.Editar.Controls.Add(this.lblcedulaeditar);
            this.Editar.Controls.Add(this.txtTelefonoEditar);
            this.Editar.Controls.Add(this.txtDireccionEditar);
            this.Editar.Controls.Add(this.txtNombreEditar);
            this.Editar.Controls.Add(this.txtCedulaEditar);
            this.Editar.Controls.Add(this.comboBoxConsultarEditar);
            this.Editar.Location = new System.Drawing.Point(4, 22);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Editar.Size = new System.Drawing.Size(790, 420);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // txtCorreoEditar
            // 
            this.txtCorreoEditar.Location = new System.Drawing.Point(242, 271);
            this.txtCorreoEditar.Name = "txtCorreoEditar";
            this.txtCorreoEditar.Size = new System.Drawing.Size(330, 20);
            this.txtCorreoEditar.TabIndex = 15;
            // 
            // lblCorreroeditar
            // 
            this.lblCorreroeditar.AutoSize = true;
            this.lblCorreroeditar.Location = new System.Drawing.Point(151, 273);
            this.lblCorreroeditar.Name = "lblCorreroeditar";
            this.lblCorreroeditar.Size = new System.Drawing.Size(38, 13);
            this.lblCorreroeditar.TabIndex = 14;
            this.lblCorreroeditar.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar Cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(360, 97);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "consultar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // lbltelefonoeditar
            // 
            this.lbltelefonoeditar.AutoSize = true;
            this.lbltelefonoeditar.Location = new System.Drawing.Point(151, 239);
            this.lbltelefonoeditar.Name = "lbltelefonoeditar";
            this.lbltelefonoeditar.Size = new System.Drawing.Size(49, 13);
            this.lbltelefonoeditar.TabIndex = 10;
            this.lbltelefonoeditar.Text = "Teléfono";
            // 
            // lbldireccioneditar
            // 
            this.lbldireccioneditar.AutoSize = true;
            this.lbldireccioneditar.Location = new System.Drawing.Point(151, 206);
            this.lbldireccioneditar.Name = "lbldireccioneditar";
            this.lbldireccioneditar.Size = new System.Drawing.Size(52, 13);
            this.lbldireccioneditar.TabIndex = 9;
            this.lbldireccioneditar.Text = "Dirección";
            // 
            // lblNombreeditar
            // 
            this.lblNombreeditar.AutoSize = true;
            this.lblNombreeditar.Location = new System.Drawing.Point(151, 170);
            this.lblNombreeditar.Name = "lblNombreeditar";
            this.lblNombreeditar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreeditar.TabIndex = 8;
            this.lblNombreeditar.Text = "Nombre";
            // 
            // lblcedulaeditar
            // 
            this.lblcedulaeditar.AutoSize = true;
            this.lblcedulaeditar.Location = new System.Drawing.Point(151, 134);
            this.lblcedulaeditar.Name = "lblcedulaeditar";
            this.lblcedulaeditar.Size = new System.Drawing.Size(40, 13);
            this.lblcedulaeditar.TabIndex = 7;
            this.lblcedulaeditar.Text = "Cédula";
            // 
            // txtTelefonoEditar
            // 
            this.txtTelefonoEditar.Location = new System.Drawing.Point(242, 236);
            this.txtTelefonoEditar.Name = "txtTelefonoEditar";
            this.txtTelefonoEditar.Size = new System.Drawing.Size(330, 20);
            this.txtTelefonoEditar.TabIndex = 4;
            // 
            // txtDireccionEditar
            // 
            this.txtDireccionEditar.Location = new System.Drawing.Point(242, 203);
            this.txtDireccionEditar.Name = "txtDireccionEditar";
            this.txtDireccionEditar.Size = new System.Drawing.Size(330, 20);
            this.txtDireccionEditar.TabIndex = 3;
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(242, 167);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(330, 20);
            this.txtNombreEditar.TabIndex = 2;
            // 
            // txtCedulaEditar
            // 
            this.txtCedulaEditar.Location = new System.Drawing.Point(242, 134);
            this.txtCedulaEditar.Name = "txtCedulaEditar";
            this.txtCedulaEditar.Size = new System.Drawing.Size(330, 20);
            this.txtCedulaEditar.TabIndex = 1;
            // 
            // comboBoxConsultarEditar
            // 
            this.comboBoxConsultarEditar.FormattingEnabled = true;
            this.comboBoxConsultarEditar.Location = new System.Drawing.Point(242, 70);
            this.comboBoxConsultarEditar.Name = "comboBoxConsultarEditar";
            this.comboBoxConsultarEditar.Size = new System.Drawing.Size(330, 21);
            this.comboBoxConsultarEditar.TabIndex = 0;
            this.comboBoxConsultarEditar.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsultarEditar_SelectedIndexChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
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
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox CboxClienteConsulta;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.TabPage Editar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label lbltelefonoeditar;
        private System.Windows.Forms.Label lbldireccioneditar;
        private System.Windows.Forms.Label lblNombreeditar;
        private System.Windows.Forms.Label lblcedulaeditar;
        private System.Windows.Forms.TextBox txtTelefonoEditar;
        private System.Windows.Forms.TextBox txtDireccionEditar;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.TextBox txtCedulaEditar;
        private System.Windows.Forms.ComboBox comboBoxConsultarEditar;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCorreoEditar;
        private System.Windows.Forms.Label lblCorreroeditar;
    }
}

namespace Tienda
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxExistencias = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigoBarra = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.listViewProductos = new System.Windows.Forms.ListView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProductosConsulta = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.Editar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCantidadEditar = new System.Windows.Forms.TextBox();
            this.textBoxValorEditar = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionEditar = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEditar = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(803, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.label4);
            this.Agregar.Controls.Add(this.label3);
            this.Agregar.Controls.Add(this.label2);
            this.Agregar.Controls.Add(this.label1);
            this.Agregar.Controls.Add(this.buttonGuardar);
            this.Agregar.Controls.Add(this.textBoxExistencias);
            this.Agregar.Controls.Add(this.textBoxPrecio);
            this.Agregar.Controls.Add(this.textBoxDescripcion);
            this.Agregar.Controls.Add(this.textBoxCodigoBarra);
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.Agregar.Size = new System.Drawing.Size(795, 426);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Existencias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Barra";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(137, 245);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxExistencias
            // 
            this.textBoxExistencias.Location = new System.Drawing.Point(137, 198);
            this.textBoxExistencias.Name = "textBoxExistencias";
            this.textBoxExistencias.Size = new System.Drawing.Size(287, 20);
            this.textBoxExistencias.TabIndex = 3;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(137, 149);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(287, 20);
            this.textBoxPrecio.TabIndex = 2;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(137, 95);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(287, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxCodigoBarra
            // 
            this.textBoxCodigoBarra.Location = new System.Drawing.Point(137, 43);
            this.textBoxCodigoBarra.Name = "textBoxCodigoBarra";
            this.textBoxCodigoBarra.Size = new System.Drawing.Size(287, 20);
            this.textBoxCodigoBarra.TabIndex = 0;
            this.textBoxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoBarra_KeyPress);
            // 
            // Consultar
            // 
            this.Consultar.Controls.Add(this.listViewProductos);
            this.Consultar.Controls.Add(this.buttonConsultar);
            this.Consultar.Controls.Add(this.label5);
            this.Consultar.Controls.Add(this.comboBoxProductosConsulta);
            this.Consultar.Location = new System.Drawing.Point(4, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(3);
            this.Consultar.Size = new System.Drawing.Size(795, 426);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // listViewProductos
            // 
            this.listViewProductos.HideSelection = false;
            this.listViewProductos.Location = new System.Drawing.Point(73, 169);
            this.listViewProductos.Name = "listViewProductos";
            this.listViewProductos.Size = new System.Drawing.Size(621, 144);
            this.listViewProductos.TabIndex = 3;
            this.listViewProductos.UseCompatibleStateImageBehavior = false;
            this.listViewProductos.View = System.Windows.Forms.View.Details;
            this.listViewProductos.SelectedIndexChanged += new System.EventHandler(this.listViewProductos_SelectedIndexChanged);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(234, 94);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Producto";
            // 
            // comboBoxProductosConsulta
            // 
            this.comboBoxProductosConsulta.FormattingEnabled = true;
            this.comboBoxProductosConsulta.Location = new System.Drawing.Point(181, 50);
            this.comboBoxProductosConsulta.Name = "comboBoxProductosConsulta";
            this.comboBoxProductosConsulta.Size = new System.Drawing.Size(446, 21);
            this.comboBoxProductosConsulta.TabIndex = 0;
            this.comboBoxProductosConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductosConsulta_SelectedIndexChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.label11);
            this.Eliminar.Controls.Add(this.buttonEliminar);
            this.Eliminar.Controls.Add(this.comboBoxEliminar);
            this.Eliminar.Location = new System.Drawing.Point(4, 22);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(795, 426);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Producto";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(297, 106);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Location = new System.Drawing.Point(185, 58);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(342, 21);
            this.comboBoxEliminar.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.Controls.Add(this.label6);
            this.Editar.Controls.Add(this.button2);
            this.Editar.Controls.Add(this.buttonBuscar);
            this.Editar.Controls.Add(this.label10);
            this.Editar.Controls.Add(this.label9);
            this.Editar.Controls.Add(this.label8);
            this.Editar.Controls.Add(this.label7);
            this.Editar.Controls.Add(this.textBoxCantidadEditar);
            this.Editar.Controls.Add(this.textBoxValorEditar);
            this.Editar.Controls.Add(this.textBoxDescripcionEditar);
            this.Editar.Controls.Add(this.textBoxCodigoEditar);
            this.Editar.Controls.Add(this.comboBoxConsultarEditar);
            this.Editar.Location = new System.Drawing.Point(4, 22);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3);
            this.Editar.Size = new System.Drawing.Size(795, 426);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar Cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(302, 75);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "consultar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Código";
            // 
            // textBoxCantidadEditar
            // 
            this.textBoxCantidadEditar.Location = new System.Drawing.Point(184, 256);
            this.textBoxCantidadEditar.Name = "textBoxCantidadEditar";
            this.textBoxCantidadEditar.Size = new System.Drawing.Size(330, 20);
            this.textBoxCantidadEditar.TabIndex = 4;
            // 
            // textBoxValorEditar
            // 
            this.textBoxValorEditar.Location = new System.Drawing.Point(184, 215);
            this.textBoxValorEditar.Name = "textBoxValorEditar";
            this.textBoxValorEditar.Size = new System.Drawing.Size(330, 20);
            this.textBoxValorEditar.TabIndex = 3;
            // 
            // textBoxDescripcionEditar
            // 
            this.textBoxDescripcionEditar.Location = new System.Drawing.Point(184, 171);
            this.textBoxDescripcionEditar.Name = "textBoxDescripcionEditar";
            this.textBoxDescripcionEditar.Size = new System.Drawing.Size(330, 20);
            this.textBoxDescripcionEditar.TabIndex = 2;
            // 
            // textBoxCodigoEditar
            // 
            this.textBoxCodigoEditar.Location = new System.Drawing.Point(184, 123);
            this.textBoxCodigoEditar.Name = "textBoxCodigoEditar";
            this.textBoxCodigoEditar.Size = new System.Drawing.Size(330, 20);
            this.textBoxCodigoEditar.TabIndex = 1;
            this.textBoxCodigoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoEditar_KeyPress);
            // 
            // comboBoxConsultarEditar
            // 
            this.comboBoxConsultarEditar.FormattingEnabled = true;
            this.comboBoxConsultarEditar.Location = new System.Drawing.Point(184, 48);
            this.comboBoxConsultarEditar.Name = "comboBoxConsultarEditar";
            this.comboBoxConsultarEditar.Size = new System.Drawing.Size(330, 21);
            this.comboBoxConsultarEditar.TabIndex = 0;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
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
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.TabPage Editar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxExistencias;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigoBarra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProductosConsulta;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.ComboBox comboBoxConsultarEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCantidadEditar;
        private System.Windows.Forms.TextBox textBoxValorEditar;
        private System.Windows.Forms.TextBox textBoxDescripcionEditar;
        private System.Windows.Forms.TextBox textBoxCodigoEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label11;
    }
}
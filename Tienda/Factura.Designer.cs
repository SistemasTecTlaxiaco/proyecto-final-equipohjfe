﻿
namespace Tienda
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.dataGridViewTabla = new System.Windows.Forms.DataGridView();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.buttonTotal);
            this.groupBox1.Controls.Add(this.dataGridViewTabla);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.comboBoxProducto);
            this.groupBox1.Controls.Add(this.comboBoxClientes);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 577);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Image = global::Tienda.Properties.Resources.borrar;
            this.buttonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Location = new System.Drawing.Point(577, 450);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(90, 37);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::Tienda.Properties.Resources.disquete;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(689, 449);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(94, 38);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar ";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(406, 465);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(134, 22);
            this.textBoxTotal.TabIndex = 12;
            // 
            // buttonTotal
            // 
            this.buttonTotal.Image = ((System.Drawing.Image)(resources.GetObject("buttonTotal.Image")));
            this.buttonTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTotal.Location = new System.Drawing.Point(245, 450);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(119, 36);
            this.buttonTotal.TabIndex = 10;
            this.buttonTotal.Text = "Total factura";
            this.buttonTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTabla
            // 
            this.dataGridViewTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.dataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla.Location = new System.Drawing.Point(202, 263);
            this.dataGridViewTabla.Name = "dataGridViewTabla";
            this.dataGridViewTabla.Size = new System.Drawing.Size(651, 150);
            this.dataGridViewTabla.TabIndex = 9;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(366, 199);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(212, 22);
            this.textBoxCantidad.TabIndex = 8;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(366, 156);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(212, 21);
            this.comboBoxProducto.TabIndex = 7;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(366, 117);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(301, 21);
            this.comboBoxClientes.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(646, 171);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 30);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.DataGridView dataGridViewTabla;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

namespace Tienda
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.pantallaCompleta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pantallaCompleta
            // 
            this.pantallaCompleta.AutoSize = true;
            this.pantallaCompleta.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaCompleta.Location = new System.Drawing.Point(318, 184);
            this.pantallaCompleta.Name = "pantallaCompleta";
            this.pantallaCompleta.Size = new System.Drawing.Size(285, 45);
            this.pantallaCompleta.TabIndex = 0;
            this.pantallaCompleta.Text = "Pantalla Completa";
            this.pantallaCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(632, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Maximizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(632, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Flotante";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pantalla Flotante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pantallaCompleta);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pantallaCompleta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
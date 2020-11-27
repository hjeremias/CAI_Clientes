namespace Clientes.Formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contenido = new System.Windows.Forms.Panel();
            this.botClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 513);
            this.panel1.TabIndex = 0;
            // 
            // Contenido
            // 
            this.Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenido.Location = new System.Drawing.Point(178, 0);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(714, 513);
            this.Contenido.TabIndex = 1;
            // 
            // botClientes
            // 
            this.botClientes.Location = new System.Drawing.Point(0, 160);
            this.botClientes.Name = "botClientes";
            this.botClientes.Size = new System.Drawing.Size(178, 30);
            this.botClientes.TabIndex = 0;
            this.botClientes.Text = "CLIENTES";
            this.botClientes.UseVisualStyleBackColor = true;
            this.botClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 513);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Contenido;
        private System.Windows.Forms.Button botClientes;
    }
}


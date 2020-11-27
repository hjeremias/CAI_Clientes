using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.Contenido.Controls.Count > 0)
                this.Contenido.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenido.Controls.Add(fh);
            this.Contenido.Tag = fh;
            fh.Show();

            string s = ConfigurationManager.AppSettings["Legajo"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormClientes());
        }
    }


}

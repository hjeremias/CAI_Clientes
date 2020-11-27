using Clientes.Entidades;
using Clientes.Entidades.Exceptions;
using Clientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes.Formularios
{
    public partial class FormClientes : Form
    {
        private OperadorCliente _clienteServicio;

        public FormClientes()
        {
            InitializeComponent();
            this._clienteServicio = new OperadorCliente();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = this._clienteServicio.TraerClientes();
        }

        private void botonCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string apellido = textBoxApellido.Text;
                string nombre = textBoxNombre.Text;
                string stringDNI = textBoxDNI.Text;
                DateTime fechaNac = dateTimePicker1.Value;

                this._clienteServicio.InsertarCliente(Validar.Cliente(apellido, nombre, stringDNI, fechaNac));
            }
            catch (NoInsertoClienteException ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            catch (DniInvalidoException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            catch (NoCamposVaciosException ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            catch (MenorDeEdadException ex4)
            {
                MessageBox.Show(ex4.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}

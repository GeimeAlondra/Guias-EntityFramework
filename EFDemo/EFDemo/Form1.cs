using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private CustomerRepository cr = new CustomerRepository();

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerTodos();
            dgvCustomers.DataSource = cliente;
        }

        private void btnObtenerPorId_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(txtObtenerPorId.Text);
            List<Customers> listaId = new List<Customers> { cliente };

            if (cliente != null)
            {
                LlenarCampos(cliente);
            }
            dgvCustomers.DataSource = listaId;
        }

        private Customers CrearCliente()
        {
            var cliente = new Customers()
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text,
            };
            return cliente;
        }

        private void LlenarCampos(Customers customers)
        {
            txtCustomerID.Text = customers.CustomerID; 
            txtCompanyName.Text = customers.CompanyName;
            txtContactName.Text = customers.ContactName;
            txtContactTitle.Text = customers.ContactTitle;
            txtAddress.Text = customers.Address;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var resultado = cr.InsertarCliente(cliente);
            MessageBox.Show($"El número de elementos modificados es: {resultado}");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            cr.UpdateCliente(cliente);
            var resultado = cr.ObtenerPorID(cliente.CustomerID);
            List<Customers> lista1 = new List<Customers> { resultado };
            dgvCustomers.DataSource = lista1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminar = cr.DeleteCliente(txtCustomerID.Text);
            MessageBox.Show($"El número de elementos borrados es: {eliminar}");
        }
    }
}

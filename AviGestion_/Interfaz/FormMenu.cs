using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviGestion_.UI
{
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarVisibilidadPorRol();
        }

        private void btnUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios(usuarioActual);
            usuarios.Show();
            this.Hide();
        }

        private void ConfigurarVisibilidadPorRol()
        {
            // Por defecto, ocultamos todo excepto Ayuda (que ven todos)
            btnClientes.Visible = false;
            btnUsuarios.Visible = false;
            btnPedidos.Visible = false;
            btnProductos.Visible = false;
            btnAsignarPedidos.Visible = false;
            btnStock.Visible = false;
            btnCategorias.Visible = false;
            btnVehiculos.Visible = false;
            btnAyuda.Visible = true;

            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    btnClientes.Visible = true;
                    btnUsuarios.Visible = true;
                    btnProductos.Visible=true;
                    break;

                case "Administrador de pedidos":
                    btnPedidos.Visible = true;
                    break;

                case "Jefe de depósito":
                    btnProductos.Visible = true;
                    btnAsignarPedidos.Visible = true;
                    btnVehiculos.Visible = true;
                    btnStock.Visible = true;
                    btnCategorias.Visible = true;
                    break;
            }
        }

        private void btnClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Paint(object sender, PaintEventArgs e)
        {
        }   

        private void lblProductosTitulo_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
            this.Hide();
        }
        

        

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto();
            frm.Show();
            this.Hide();
        }




    }

}

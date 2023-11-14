using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.RegistrarCliente(DataConsulta);

        }

        private void TxtDNI_TextChanged(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.RegistrarCliente(DataConsulta, TxtDni.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            MessageBox.Show(con.insertarCliente(TxtDni.Text, TxtNombre.Text, TxtDireccion.Text, TxtTelefono.Text, TxtCorreo.Text));
            TxtDni.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtCorreo.Text = string.Empty;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            MessageBox.Show(con.eliminarCliente(TxtDni.Text));
            con.eliminarCliente(con.eliminarCliente(TxtDni.Text));
            TxtDireccion.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtCorreo.Text = string.Empty;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            MessageBox.Show(con.actualizarCliente(TxtDni.Text, TxtNombre.Text, TxtDireccion.Text, TxtTelefono.Text, TxtCorreo.Text));
            TxtDireccion.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtCorreo.Text = string.Empty;

        }


                





                private void btnForms2_Click(object sender, EventArgs e)
                {

                }
            
        
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btCancelReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 NuevoLogin = new Form1();
            NuevoLogin.Show();
        }

        private void btGuardarReg_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtPass.Text != txtConfirmar.Text || txtPass.Text == "")
            {
                MessageBox.Show("Por favor complete los campos");
                txtPass.Text = "";
                txtConfirmar.Text = "";
            }

            else
            {
                try
                {
                    string cmd = string.Format("insert into Usuarios (Nombre, Usuario, Passwd) values ('{0}', '{1}', '{2}')", txtNombre.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim());
                    BaseDatos.Ejecutar(cmd);
                    
                    MessageBox.Show("Los datos se Guardaron");
                    this.Close();
                    Form1 NuevoLogin = new Form1();
                    NuevoLogin.Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
                
            }
        }
    }
}

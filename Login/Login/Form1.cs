using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static String IdUsuario = "";

        private void btRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro NuevoRegistro = new Registro();
            NuevoRegistro.Show();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select * from Usuarios where Usuario = '{0}' and Passwd = '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                DataSet ds = BaseDatos.Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Existe ese usuario o contraseña");
                }
                else
                {
                    string user = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                    string pass = ds.Tables[0].Rows[0]["Passwd"].ToString().Trim();
                    IdUsuario = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

                    if (user == textBox1.Text.Trim() && pass == textBox2.Text.Trim())
                    {
                        MessageBox.Show("Ha iniciado");
                        this.Hide();
                        Menu NuevoMenu = new Menu();
                        NuevoMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en el Usuario o Contraseña");
                    }
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}

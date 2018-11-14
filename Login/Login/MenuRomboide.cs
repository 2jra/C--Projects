using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuRomboide : Form
    {
        public MenuRomboide()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu NuevoMenu = new Menu();
            NuevoMenu.Show();
        }

        private void btPerimetro_Click(object sender, EventArgs e)
        {
            if (txtLado1.Text.Trim() == "" || txtBase.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtLado1.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Romboide where IdUsuario = {0} and Lado = {1} and Base = {2}", Form1.IdUsuario, txtLado1.Text.Trim(), txtBase.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriRomboide(int.Parse(txtLado1.Text.Trim()), int.Parse(txtBase.Text.Trim()));
                        MessageBox.Show("El perimetro es " + Resultado);

                        string salvar = string.Format("insert into Romboide (IdUsuario, Ejercicio, Lado, Base, Perimetro) values ({0}, 'Perimetro', {1}, {2}, {3})", Form1.IdUsuario, txtLado1.Text.Trim(), txtBase.Text.Trim(), Resultado);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
                        txtLado1.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }

        private void btArea_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text.Trim() == "" || txtBase.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtBase.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Romboide where IdUsuario = {0} and Altura = {1} and Base = {2}", Form1.IdUsuario, txtAltura.Text.Trim(), txtBase.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado1 = Area.AreaRomboide(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        MessageBox.Show("El Area es " + Resultado1);

                        string salvar = string.Format("insert into Romboide (IdUsuario, Ejercicio, Altura, Base, Area) values ({0}, 'Area', {1}, {2}, {3})", Form1.IdUsuario, txtAltura.Text.Trim(), txtBase.Text.Trim(), Resultado1);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
                        txtLado1.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }
    }
}

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
    public partial class MenuCuadrado : Form
    {
        public MenuCuadrado()
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
            if (txtLado.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Cuadrado where IdUsuario = {0} and Lado = {1}", Form1.IdUsuario, txtLado.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriCuadrado(int.Parse(txtLado.Text.Trim()));
                        int Resultado2 = Area.AreaCuadrado(int.Parse(txtLado.Text.Trim()));
                        MessageBox.Show("El perimetro es " + Resultado);

                        string salvar = string.Format("insert into Cuadrado (IdUsuario, Ejercicio, Lado, Perimetro, Area) values ({0}, 'Perimetro', {1}, {2}, {3})", Form1.IdUsuario, txtLado.Text.Trim(), Resultado, Resultado2);
                        BaseDatos.Ejecutar(salvar);

                        txtLado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
                        txtLado.Text = "";
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
            if (txtLado.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Cuadrado where IdUsuario = {0} and Lado = {1}", Form1.IdUsuario, txtLado.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriCuadrado(int.Parse(txtLado.Text.Trim()));
                        int Resultado2 = Area.AreaCuadrado(int.Parse(txtLado.Text.Trim()));
                        MessageBox.Show("El Area es " + Resultado2);

                        string salvar = string.Format("insert into Cuadrado (IdUsuario, Ejercicio, Lado, Perimetro, Area) values ({0}, 'Area', {1}, {2}, {3})", Form1.IdUsuario, txtLado.Text.Trim(), Resultado, Resultado2);
                        BaseDatos.Ejecutar(salvar);

                        txtLado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
                        txtLado.Text = "";
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

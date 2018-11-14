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
    public partial class MenuTriangulo : Form
    {
        public MenuTriangulo()
        {
            InitializeComponent();
        }

        private void btPerimetro_Click(object sender, EventArgs e)
        {
            if (txtLado1.Text.Trim() == "" || txtLado2.Text.Trim() == "" || txtBase.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Triangulo where IdUsuario = {0} and Lado1 = {1} and Lado2 = {2} and Base = {3}", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim(), txtBase.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriTriangulo(int.Parse(txtLado1.Text.Trim()), int.Parse(txtLado2.Text.Trim()), int.Parse(txtBase.Text.Trim()));
                        MessageBox.Show("El perimetro es " + Resultado);

                        string salvar = string.Format("insert into Triangulo (IdUsuario, Ejercicio, Lado1, Lado2, Base, Perimetro) values ({0}, 'Perimetro', {1}, {2}, {3}, {4})", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim(), txtBase.Text.Trim(), Resultado);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
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

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu NuevoMenu = new Menu();
            NuevoMenu.Show();
        }

        private void btArea_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text.Trim() == "" || txtBase.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Triangulo where IdUsuario = {0} and Altura = {1} and Base = {2}", Form1.IdUsuario, txtAltura.Text.Trim(), txtBase.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado1 = Area.AreaTriangulo(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        MessageBox.Show("El Area es " + Resultado1);

                        string salvar = string.Format("insert into Triangulo (IdUsuario, Ejercicio, Altura, Base, Area) values ({0}, 'Area', {1}, {2}, {3})", Form1.IdUsuario, txtAltura.Text.Trim(), txtBase.Text.Trim(), Resultado1);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
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

        private void MenuTriangulo_Load(object sender, EventArgs e)
        {

        }
    }
}

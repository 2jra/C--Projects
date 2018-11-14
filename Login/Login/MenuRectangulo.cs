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
    public partial class MenuRectangulo : Form
    {
        public MenuRectangulo()
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
            if (txtBase.Text.Trim() == "" || txtAltura.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Rectangulo where IdUsuario = {0} and Base = {1} and Altura = {2}", Form1.IdUsuario, txtBase.Text.Trim(), txtAltura.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado1 = Perimetro.PeriRectangulo(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        int Resultado2 = Area.AreaRectangulo(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        MessageBox.Show("El perimetro es " + Resultado1);

                        string salvar = string.Format("insert into Rectangulo (IdUsuario, Ejercicio, Base, Altura, Perimetro, Area) values ({0}, 'Perimetro', {1}, {2}, {3}, {4})", Form1.IdUsuario, txtBase.Text.Trim(), txtAltura.Text.Trim(), Resultado1, Resultado2);
                        BaseDatos.Ejecutar(salvar);

                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
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
            if (txtBase.Text.Trim() == "" || txtAltura.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Rectangulo where IdUsuario = {0} and Base = {1} and Altura = {2}", Form1.IdUsuario, txtBase.Text.Trim(), txtAltura.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado1 = Perimetro.PeriRectangulo(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        int Resultado2 = Area.AreaRectangulo(int.Parse(txtBase.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        MessageBox.Show("El Area es " + Resultado2);

                        string salvar = string.Format("insert into Rectangulo (IdUsuario, Ejercicio, Base, Altura, Perimetro, Area) values ({0}, 'Perimetro', {1}, {2}, {3}, {4})", Form1.IdUsuario, txtBase.Text.Trim(), txtAltura.Text.Trim(), Resultado1, Resultado2);
                        BaseDatos.Ejecutar(salvar);

                        txtBase.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
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

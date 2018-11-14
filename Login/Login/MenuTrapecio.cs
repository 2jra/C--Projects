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
    public partial class MenuTrapecio : Form
    {
        public MenuTrapecio()
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
            if (txtLado1.Text.Trim() == "" || txtLado2.Text.Trim() == "" || txtBase.Text.Trim() == "" || txtBase2.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtLado1.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Trapecio where IdUsuario = {0} and Lado1 = {1} and Lado2 = {2} and Base1 = {3} and Base2 = {4}", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim(), txtBase.Text.Trim(), txtBase2.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriTrapecio(int.Parse(txtLado1.Text.Trim()), int.Parse(txtLado2.Text.Trim()), int.Parse(txtBase.Text.Trim()), int.Parse(txtBase2.Text.Trim()));
                        MessageBox.Show("El perimetro es " + Resultado);

                        string salvar = string.Format("insert into Trapecio (IdUsuario, Ejercicio, Lado1, Lado2, Base1, Base2, Perimetro) values ({0}, 'Perimetro', {1}, {2}, {3}, {4}, {5})", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim(), txtBase.Text.Trim(), txtBase2.Text.Trim(), Resultado);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtBase2.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtBase2.Text = "";
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
            if (txtAltura.Text.Trim() == "" || txtBase.Text.Trim() == "" || txtBase2.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtAltura.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from Trapecio where IdUsuario = {0} and Base1 = {1} and Base2 = {2} and Altura = {3}", Form1.IdUsuario, txtBase.Text.Trim(), txtBase2.Text.Trim(), txtAltura.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado1 = Area.AreaTrapecio(int.Parse(txtBase.Text.Trim()), int.Parse(txtBase2.Text.Trim()), int.Parse(txtAltura.Text.Trim()));
                        MessageBox.Show("El Area es " + Resultado1);

                        string salvar = string.Format("insert into Trapecio (IdUsuario, Ejercicio, Base1, Base2, Altura, Area) values ({0}, 'Area', {1}, {2}, {3}, {4})", Form1.IdUsuario, txtBase.Text.Trim(), txtBase2.Text.Trim(), txtAltura.Text.Trim(), Resultado1);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtBase2.Text = "";
                        txtAltura.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
                        txtBase.Text = "";
                        txtBase2.Text = "";
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

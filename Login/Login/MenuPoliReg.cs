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
    public partial class MenuPoliReg : Form
    {
        public MenuPoliReg()
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
            if (txtLado1.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtLado1.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from PoliRegular where IdUsuario = {0} and Lado1 = {1}", Form1.IdUsuario, txtLado1.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriPoligReg(int.Parse(txtLado1.Text.Trim()));
                        MessageBox.Show("El Perimetro es " + Resultado);

                        string salvar = string.Format("insert into PoliRegular (IdUsuario, Ejercicio, Lado1, Perimetro) values ({0}, 'Perimetro', {1}, {2})", Form1.IdUsuario, txtLado1.Text.Trim(), Resultado);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Perimetro es " + ds.Tables[0].Rows[0]["Perimetro"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
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
            if (txtLado1.Text.Trim() == "" || txtLado2.Text.Trim() == "")
            {
                MessageBox.Show("Por Favor Complete los Campos");
                txtLado1.Focus();
            }
            else
            {
                try
                {
                    string cmd = string.Format("Select * from PoliRegular where IdUsuario = {0} and Lado1 = {1} and Lado2 = {2}", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim());
                    DataSet ds = BaseDatos.Ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        int Resultado = Perimetro.PeriPoligReg(int.Parse(txtLado1.Text.Trim()));
                        int Resultado2 = Area.AreaPoligonoRegular(int.Parse(txtLado1.Text.Trim()), int.Parse(txtLado2.Text.Trim()));

                        MessageBox.Show("El Area es " + Resultado2);

                        string salvar = string.Format("insert into PoliRegular (IdUsuario, Ejercicio, Lado1, Lado2, Perimetro, Area) values ({0}, 'Area', {1}, {2}, {3}, {4})", Form1.IdUsuario, txtLado1.Text.Trim(), txtLado2.Text.Trim(), Resultado, Resultado2);
                        BaseDatos.Ejecutar(salvar);

                        txtLado1.Text = "";
                        txtLado2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Area es " + ds.Tables[0].Rows[0]["Area"].ToString().Trim());
                        txtLado1.Text = "";
                        txtLado2.Text = "";
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

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btTriangulo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTriangulo NuevoTriangulo = new MenuTriangulo();
            NuevoTriangulo.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 NuevoForm1 = new Form1();
            NuevoForm1.Show();
        }

        private void btCuadrado_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCuadrado NuevoCuadrado = new MenuCuadrado();
            NuevoCuadrado.Show();
        }

        private void btRectangulo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRectangulo NuevoRectangulo = new MenuRectangulo();
            NuevoRectangulo.Show();
        }

        private void btRombo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRombo NuevoRombo = new MenuRombo();
            NuevoRombo.Show();
        }

        private void btRomboide_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuRomboide NuevoRomboide = new MenuRomboide();
            NuevoRomboide.Show();
        }

        private void btTrapecio_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTrapecio NuevoTrapecio = new MenuTrapecio();
            NuevoTrapecio.Show();
        }

        private void btTrapezoide_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTrapezoide NuevoTrapezoide = new MenuTrapezoide();
            NuevoTrapezoide.Show();
        }

        private void btPoligonoReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPoliReg NuevoPoliReg = new MenuPoliReg();
            NuevoPoliReg.Show();
        }
    }
}

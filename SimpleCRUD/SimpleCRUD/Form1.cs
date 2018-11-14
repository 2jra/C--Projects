using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Boton Cancelar para Limpiar los campos
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        //Boton Agregar para guardar en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string guardar = string.Format("insert into Prueba (Nombre, FechaNac, Cedula) values ('{0}', '{1}', '{2}')", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
                BaseDatos.Ejecutar(guardar);
                MessageBox.Show("Guardado con exito");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la conexión: " + error.Message);
            }
        }

        //Boton Actualizar para abrir el Menu de Actualizar los datos
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar nuevoActualizar = new Actualizar();
            nuevoActualizar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

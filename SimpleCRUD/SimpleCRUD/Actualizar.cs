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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        string id; //Para guardar el Id del area seleccionada en el Datagrid ya que lo oculte para que no se vea.

        private void Actualizar_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select * from Prueba");
                DataSet ds = BaseDatos.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
                //Para Ocultar la columna del Id en el Datagrid
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["FechaNac"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error en la conexión: " + error.Message);
            }
            
        }

        //Boton Volver para regresar a la Ventana de Inicio
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 nuevoForm1 = new Form1();
            nuevoForm1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                

                id = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtFecha.Text = string.Format("{0:yyyy/MM/dd}", DateTime.Parse(row.Cells["FechaNac"].Value.ToString()));
                txtCedula.Text = row.Cells["Cedula"].Value.ToString();
                
            }
        }

        //Boton Actualizar para actualizar los campos en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtFecha.Text.Trim() == "" || txtCedula.Text.Trim() == "")
            {
                MessageBox.Show("Por favor llenar todos los campos");
            }
            else
            {
                try
                {
                    string actualiza = string.Format("update Prueba set Nombre = '{0}', FechaNac = '{1}', Cedula = '{2}' where Id = {3}", txtNombre.Text.Trim(), txtFecha.Text.Trim(), txtCedula.Text.Trim(), int.Parse(id));
                    BaseDatos.Ejecutar(actualiza);
                    MessageBox.Show("Datos Actualizados");
                    this.Hide();
                    Actualizar nuevoAct = new Actualizar();
                    nuevoAct.Show();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error en la conexión: " + error.Message);
                }
            }
        }

        //Boton Eliminar para eliminar los campos en la Base de Datos
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtFecha.Text.Trim() == "" || txtCedula.Text.Trim() == "")
            {
                MessageBox.Show("Por favor llenar todos los campos");
            }
            else
            {
                string eliminar = string.Format("DELETE FROM Prueba where Id = {0}", int.Parse(id));
                BaseDatos.Ejecutar(eliminar);
                MessageBox.Show("Datos Eliminados");
                this.Hide();
                Actualizar nuevoAct = new Actualizar();
                nuevoAct.Show();
            }
        }
    }
}

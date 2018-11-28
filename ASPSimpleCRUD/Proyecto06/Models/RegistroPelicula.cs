using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto06.Models
{
    public class RegistroPelicula
    {
        private SqlConnection con;
        

        //Conectarse a la BD
        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            //string constr = string.Format(@"Data Source=WHITECLAW-PC\MONOGRAFICO30;Initial Catalog=PeliculasDB;User ID=sa;Password=weaponx22");
            con = new SqlConnection(constr); 
        }

        //Grabar un Registro en la BD
        public int GrabarPelicula(Pelicula peli)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Insert into Pelicula (Titulo, Director, AutorPrincipal, No_Actores, Duracion, Estreno) " +
                                                "values (@Titulo, @Director, @AutorPrincipal, @No_Actores, @Duracion, @Estreno)", con);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters.Add("@Director", SqlDbType.VarChar);
            comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            comando.Parameters.Add("@No_Actores", SqlDbType.Int);
            comando.Parameters.Add("@Duracion", SqlDbType.Float);
            comando.Parameters.Add("@Estreno", SqlDbType.Int);
            comando.Parameters["@Titulo"].Value = peli.Titulo;
            comando.Parameters["@Director"].Value = peli.Director;
            comando.Parameters["@AutorPrincipal"].Value = peli.AutorPrincipal;
            comando.Parameters["@No_Actores"].Value = peli.numAutores;
            comando.Parameters["@Duracion"].Value = peli.Duracion;
            comando.Parameters["@Estreno"].Value = peli.Estreno;
            con.Open();
            int i = comando.ExecuteNonQuery();
            return i;
        }

        //Mostrar todos los registros de la BD
        public List<Pelicula> RecuperarTodos()
        {
            Conectar();
            List<Pelicula> peliculas = new List<Pelicula>();

            SqlCommand com = new SqlCommand("Select * from Pelicula", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Pelicula peli = new Pelicula
                {
                    Codigo = int.Parse(registros["Codigo"].ToString()),
                    Titulo = registros["Titulo"].ToString(),
                    Director = registros["Director"].ToString(),
                    AutorPrincipal = registros["AutorPrincipal"].ToString(),
                    numAutores = int.Parse(registros["No_Actores"].ToString()),
                    Duracion = double.Parse(registros["Duracion"].ToString()),
                    Estreno = int.Parse(registros["Estreno"].ToString())
                };
                peliculas.Add(peli);
            }
            con.Close();
            return peliculas;
        }

        //Mostrar un registro especifico de la DB
        public Pelicula Recuperar(int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Select * from Pelicula where Codigo = @codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = codigo;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Pelicula pelicula = new Pelicula();
            if (registros.Read())
            {
                pelicula.Codigo = int.Parse(registros["Codigo"].ToString());
                pelicula.Titulo = registros["Titulo"].ToString();
                pelicula.Director = registros["Director"].ToString();
                pelicula.AutorPrincipal = registros["AutorPrincipal"].ToString();
                pelicula.numAutores = int.Parse(registros["No_Actores"].ToString());
                pelicula.Duracion = double.Parse(registros["Duracion"].ToString());
                pelicula.Estreno = int.Parse(registros["Estreno"].ToString());
            }
            con.Close();
            return pelicula;
        }

        //Modificar un registro especifico  de la DB
        public int Modificar(Pelicula peli)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("update Pelicula set Titulo = @Titulo, Director = @Director, AutorPrincipal = @AutorPrincipal, No_Actores = @No_Actores, Duracion = @Duracion, Estreno = @Estreno where Codigo = @Codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = peli.Codigo;
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters["@Titulo"].Value = peli.Titulo;
            comando.Parameters.Add("@Director", SqlDbType.VarChar);
            comando.Parameters["@Director"].Value = peli.Director;
            comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            comando.Parameters["@AutorPrincipal"].Value = peli.AutorPrincipal;
            comando.Parameters.Add("@No_Actores", SqlDbType.Int);
            comando.Parameters["@No_Actores"].Value = peli.numAutores;
            comando.Parameters.Add("@Duracion", SqlDbType.Float);
            comando.Parameters["@Duracion"].Value = peli.Duracion;
            comando.Parameters.Add("@Estreno", SqlDbType.Int);
            comando.Parameters["@Estreno"].Value = peli.Estreno;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        //Borrar un registro especifico de la DB
        public int Borrar(int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("delete from Pelicula where Codigo = @codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = codigo;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
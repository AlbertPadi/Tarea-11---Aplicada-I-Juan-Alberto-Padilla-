using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;



namespace RegistroPelicula
{
    
    class Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public Conexion()
        {

            try
            {
                con = new SqlConnection("Data Source=APACHEW-PC\\SQLEXPRESS;Initial Catalog=Pelicula;Integrated Security=True");
                con.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se registro" + ex.ToString());
            }
        }

        public string insert(string Descripcion) {
            string salida = "Listo";

            try
            {
                cmd = new SqlCommand(string.Format("insert into registroPelicula(descripcion) values('{0}')", Descripcion), con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("registrado");
            }
            catch (Exception ex)
            {

                salida ="No se pudo terminar"+ex.ToString();
            }
            return salida;
        }

        public int peliculaRegistrada(int CategoriaId)
        {
            int cont = 0;

            try
            {
                cmd = new SqlCommand(string.Format("select *from registroPelicula where categoriaId = {0}", CategoriaId), con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cont++;
                }
     
                dr.Close();
            }
           
            catch (Exception ex)
            {

                MessageBox.Show("No hay Vida: "+ex.ToString ());
            }
            return cont;
            
        }
    }
    }


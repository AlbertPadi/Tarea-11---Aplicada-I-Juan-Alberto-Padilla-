using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace RegistroPelicula
{
    public partial class RegistroPelicula : Form
    {
        Conexion c = new Conexion();
        public RegistroPelicula()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }

        private void RegistroPelicula_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
         
        }

       

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
                c.peliculaRegistrada(Convert.ToInt32(textBoxCategoria.Text));
                c.insert(textBoxDescripcion.Text);
            
        }
    }
}

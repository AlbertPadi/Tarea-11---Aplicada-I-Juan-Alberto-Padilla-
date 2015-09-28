using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPelicula
{
    
    public partial class Consulta : Form
    {
        Conexion c = new Conexion();
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBoxIdCategoria.Text);
            dataGridView1.DataSource = c.peliculaRegistrada(valor);
            
        }
    }
}

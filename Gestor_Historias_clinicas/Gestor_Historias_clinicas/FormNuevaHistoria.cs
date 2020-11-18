using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Historias_clinicas
{
    public partial class FormNuevaHistoria : Form
    {
        Conexion cn = new Conexion();

        public FormNuevaHistoria()
        {
            InitializeComponent();
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FormNuevaHistoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.insertar(Convert.ToInt32(textBoxCI.Text), textBoxNombre.Text, textBoxApellidos.Text);
        }

        ///HOLA SOY JERSON
    }
}

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
    public partial class FormVerHistoria : Form
    {
        public FormVerHistoria()
        {
            InitializeComponent();
        }

        private void FormHistoria_Load(object sender, EventArgs e)
        {
            //Hola soy sebas
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta formConsulta = new Consulta();
            formConsulta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdenMedica ordenMedica  = new OrdenMedica();
            ordenMedica.ShowDialog();
        }
    }
}

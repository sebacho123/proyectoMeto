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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Conexion conex = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            //hola luis
            FormHistoria formHistoria = new FormHistoria();
            formHistoria.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNuevaHistoria formNuevaHistoria = new FormNuevaHistoria();
            formNuevaHistoria.ShowDialog();
        }
    }
}

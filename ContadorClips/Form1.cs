using System;
using System.Windows.Forms;

namespace ContadorClicsApp
{
    public partial class Form1 : Form
    {
        // Variable privada de instancia: el estado interno del contador
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = "Clics realizados: " + contador;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            contador = 0;
            lblContador.Text = "Clics realizados: 0";
        }
    }
}
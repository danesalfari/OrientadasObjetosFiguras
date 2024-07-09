using Figuras.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura f = new Figura();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo();
        }
        public void tipo()
        {
            string tipo = cbxTipo.SelectedItem.ToString();
            f.tipof(tipo);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            perimetro();
        }
        public void perimetro()
        {
            double alto = double.Parse(txtAlto.Text);
            double largo = double.Parse(txtLargo.Text);
            double ancho = double.Parse(txtAncho.Text);
            f.Perimetro(alto, largo, ancho);

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            area();
        }
        public void area()
        {
            double alto = double.Parse(txtAlto.Text);
            double largo = double.Parse(txtLargo.Text);
            double ancho = double.Parse(txtAncho.Text);
            f.Area(alto, largo, ancho);

        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {

        }
        public void volumen()
        {
            double alto = double.Parse(txtAlto.Text);
            double largo = double.Parse(txtLargo.Text);
            double ancho = double.Parse(txtAncho.Text);
            f.Volumen(alto, largo, ancho);
        }
        public void color()
        {
            string c = cbxColor.SelectedItem.ToString();
            f.Colorf(c);

            switch (c)
            {
                case "Amarillo":
                    MessageBox.Show("La figura es Amarillo");
                    break;

                case "Azul":
                    MessageBox.Show("La figura es Azul");
                    break;
                case "Rojo":
                    MessageBox.Show("La figura es Roja");
                    break;
                case "Verde":
                    MessageBox.Show("La figura es Verde");
                    break;
                case "Naranja":
                    MessageBox.Show("La figura es Naranja");
                    break;  
            }

        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            color();
        }
        public void rrellenar()
        {
            string r = cbxColor.SelectedItem.ToString();
            f.Colorf(r);

            switch (r)
            {
                case "Amarillo":
                    MessageBox.Show("la figura se ha rrellenado de Amarillo");
                    break;

                case "Azul":
                    MessageBox.Show("la figura se ha rrellenado de Azul");
                    break;
                case "Rojo":
                    MessageBox.Show("la figura se ha rrellenado de Roja");
                    break;
                case "Verde":
                    MessageBox.Show("la figura se ha rrellenado de Verde");
                    break;
                case "Naranja":
                    MessageBox.Show("la figura se ha rrellenado de Naranja");
                    break;
            }

        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            rrellenar();
        }
    }
}

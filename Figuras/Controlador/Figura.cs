using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras.Controlador
{
    class Figura
    {
        private string tipo;
        private double alto;
        private double largo;
        private double ancho;
        private string color;
        private bool relleno;

        public string Tipo { get => tipo; set => tipo = value; }
        public double Alto { get => alto; set => alto = value; }
        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public string Color { get => color; set => color = value; }
        public bool Relleno { get => relleno; set => relleno = value; }

        public void tipof(string tipo)
        {
            this.Tipo = tipo;
        }



        public double Perimetro(double alto, double ancho, double largo)
        {
            string t = this.Tipo;
            double perime;

            if (tipo == "Cuadrado")
            {
                perime = largo * 4;
                MessageBox.Show("El perimetro del cuadrado es: " + perime);
                

            }
            else if (tipo == "Triangulo Equilatero")
            {
                perime = largo * 3;
                MessageBox.Show("El perimetro del Triangulo Rquilatero es: " + perime);
            }
            else
            {
                perime = (largo * 2) + (alto * 2);
                MessageBox.Show("El perimetro del Rectangulo es: " + perime);
            }
            return (perime);
        }
        public double Volumen(double alto, double ancho, double largo)
        {
            string t = this.Tipo;
            double volu;

            if (tipo == "Cuadrado")
            {
                volu = largo * 3;
                MessageBox.Show("El volumen del Cuadrado es: " + volu);
            }
            else if (tipo == "Triangulo Equilatero")
            {
                double ar = (largo * alto) / 2;
                volu = (ar * alto) / 3;
                MessageBox.Show("El volumen del Triangulo Equilatero es: " + volu);
            }
            else
            {
                volu = ancho * largo * alto;
                MessageBox.Show("El volumen del Rectangulo es: " + volu);
            }
            return (volu );

        }
        public double Area(double alto, double ancho, double largo)
        {
            
            string t = this.Tipo;
            double area;
            if (tipo == "cuadrado")
            {
                area = (largo * alto) / 2;
                MessageBox.Show("El area del cuadrado es: " + area);
            }
            else if (tipo == "Triangulo Equilatero")
            {
                area = (largo * alto) / 2;
                MessageBox.Show("El area del Triangulo Equilatero es: " + area);
            }
            else
            {
                area = largo * alto;
                MessageBox.Show("El area del Rectangulo es: " + area);
            }
            return (area);
        }
        public void Colorf(string color)
        {
        }
    }
}

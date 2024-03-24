using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_POO.Exercicios.modulo6
{
    internal class Circulo : FormaGeometrica
    {
        public  double raio { get; set; }

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override void Perimetro()
        {
            double perimetro = 2 * 3.14 * raio;
            Console.WriteLine("o permetro do circul é:" + perimetro);
        }

        public override void Area()
        {
            double area = 3.14 * (raio * raio);
            Console.WriteLine(" a area do circulo é :"+ area);
        }
    }
}

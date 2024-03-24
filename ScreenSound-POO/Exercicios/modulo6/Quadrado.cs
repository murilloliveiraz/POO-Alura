namespace ScreenSound_POO.Exercicios.modulo6
{
    internal class Quadrado : FormaGeometrica
    {
        public double lado { get; set; }

        public Quadrado(double lado) {
            this.lado = lado;
        }

        public override void Perimetro()
        {
            double perimetro = lado * 4;
            Console.WriteLine("O perimetro do quadrado é: "+ perimetro);
        }

        public override void Area()
        {
            double area = lado * lado;
            Console.WriteLine("A area do quadrado é :" + area);
        }
    }
}

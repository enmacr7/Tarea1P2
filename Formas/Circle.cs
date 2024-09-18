namespace Formas
{
    class Circle : Shape
    {
        public Circle(double radio) : base(radio, radio) { }

        public override double CalculateSurface()
        {
            double radio = Ancho;
            return Math.PI * radio * radio;
        }
    }
}

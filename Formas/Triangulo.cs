namespace Formas
{
    class Triangulo : Shape
    {
        public Triangulo(double ancho, double alto) : base(ancho, alto) { }

        public override double CalculateSurface()
        {
            return (Ancho * Alto) / 2;
        }
    }
}

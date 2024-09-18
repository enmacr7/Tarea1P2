namespace Formas
{
    class Rectangulo : Shape
    {
        public Rectangulo(double ancho, double alto) : base(ancho, alto) { }

        public override double CalculateSurface()
        {
            return Ancho * Alto;
        }
    }
}

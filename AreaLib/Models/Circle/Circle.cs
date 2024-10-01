namespace AreaLib.Models.Circle
{
    public class Circle : ICircle
    {
        public double Radius { get; }
        public Circle(double radius) 
        {
            if (radius < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Radius), _validateError);
            }
            Radius = radius;
        }

        /// <summary>
        /// Метод, вычисляющий площадь круга
        /// </summary>
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private const string _validateError = "Радиус не может быть меньше или равен нулю";
    }
}

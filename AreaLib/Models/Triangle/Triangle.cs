namespace AreaLib.Models.Triangle
{
    public class Triangle : ITriangle
    {
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0 || !CheckIsTriangle(edgeA, edgeB, edgeC)) 
            {
                throw new ArgumentException(_validateError);
            }

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }

        /// <summary>
        /// Метод, определяющий является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled()
        {
            return Math.Pow(EdgeA, 2) == Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2) ||
                       Math.Pow(EdgeB, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2) ||
                       Math.Pow(EdgeC, 2) == Math.Pow(EdgeB, 2) + Math.Pow(EdgeA, 2);
        }
        /// <summary>
        /// Метод, вычисляющий площадь треугольника
        /// </summary>
        public double Area()
        {
            var p = (EdgeA + EdgeB + EdgeC) / 2;
                return Math.Sqrt(p* (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
        }

        /// <summary>
        /// Метод для валидации треугольника по трем сторонам
        /// </summary>
        /// <param name="edgeA">
        /// Сторона А треугольника
        /// </param>
        /// /// <param name="edgeB">
        /// Сторона B треугольника
        /// </param>
        /// /// <param name="edgeC">
        /// Сторона C треугольника
        /// </param>
        private bool CheckIsTriangle(double edgeA, double edgeB, double edgeC) => (edgeA + edgeB) >= edgeC && (edgeA + edgeC) >= edgeB && (edgeC + edgeB) >= edgeA;

        private const string _validateError = "Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.";
    }
}

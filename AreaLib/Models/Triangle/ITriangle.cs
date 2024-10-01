using AreaLib.Models.Common;

namespace AreaLib.Models.Triangle
{
    public interface ITriangle : IFigure
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }
        bool IsRightAngled();
    }
}

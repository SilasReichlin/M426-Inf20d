using Geometry.ThirdParty;

namespace Geometry
{
    public class RectangleAdapter : IRectangular
    {
        private readonly IQuadratic square;

        public RectangleAdapter(IQuadratic square)
        {
            this.square = square;
        }

        public int GetWidth()
        {
            return square.GetSide();
        }

        public int GetHeight()
        {
            return square.GetSide();
        }
    }
}
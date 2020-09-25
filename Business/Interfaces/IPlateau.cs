using Entity;

namespace Business.Interfaces
{
    public interface IPlateau
    {
        /// <summary>
        /// Creates a new plateau
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        Plateau createPlateau(int width, int height);
    }
}

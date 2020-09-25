using Business.Interfaces;
using Entity;

namespace Business.Services
{
    public class SPlateau : IPlateau
    {
        public Plateau createPlateau(int width, int height)
        {
            Plateau plateau = new Plateau()
            {
                width = width,
                height = height,
            };

            return plateau;
        }
    }
}

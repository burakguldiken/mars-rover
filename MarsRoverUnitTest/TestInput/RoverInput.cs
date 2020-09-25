using Core.Enum;

namespace MarsRoverUnitTest.TestInput
{
    public class RoverInput
    {
        public int testXCoordinateInput;
        public int testYCoordinateInput;
        public  enumMainDirections testDirection;

        public RoverInput()
        {
            testXCoordinateInput = 1;
            testYCoordinateInput = 2;
            testDirection = enumMainDirections.N;
        }
    }
}

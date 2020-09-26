using Business.Interfaces;
using Business.Services;
using Entity;
using MarsRoverUnitTest.TestInput;
using System.Linq;
using Xunit;

namespace MarsRoverUnitTest
{
    public class RoverTest
    {
        #region Variables
        public static IBase _SBase = new SBase();
        public static ICommand _SCommand = new SCommand(_SBase);
        public static ILocation _SLocation = new SLocation(_SCommand);
        public static IRover _SRover = new SRover(_SCommand, _SBase, _SLocation);
        public static IPlateau _SPlateau = new SPlateau();

        RoverInput roverInput = new RoverInput();
        PlateauInput plateauInput = new PlateauInput();
        CommandInput commandInput = new CommandInput();
        #endregion

        public string locationFormat(Rover rover)
        {
            string result = rover.xCoordinate.ToString() + " " + rover.yCoordinate.ToString() + " " + _SBase.Get_Enum_Description(rover.mainDirection);
            return result;
        }

        [Fact]
        public void setRoverLocationTest()
        {
            //Arrange
            Plateau plateau = new Plateau()
            {
                width = plateauInput.width,
                height = plateauInput.height
            };

            //Act
            var response = _SRover.setRoverLocation(plateau, roverInput.testXCoordinateInput, roverInput.testYCoordinateInput, roverInput.testDirection);

            //Assert
            Assert.True(response.FirstOrDefault().Value);
        }

        [Fact]
        public void updateRoverLocationTest()
        {
            //Arrange
            Plateau plateau = new Plateau()
            {
                width = plateauInput.width,
                height = plateauInput.height
            };

            Rover rover = new Rover()
            {
                xCoordinate = roverInput.testXCoordinateInput,
                yCoordinate = roverInput.testYCoordinateInput,
                mainDirection = roverInput.testDirection
            };

            //Act
            var response = _SRover.updateRoverLocation(plateau, rover, commandInput.command);

            //Response
            Assert.Equal(locationFormat(response.FirstOrDefault().Key),"1 4 N");
        }
    }
}

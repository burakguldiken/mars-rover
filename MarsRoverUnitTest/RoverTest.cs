using Business.Interfaces;
using Business.Services;
using Entity;
using MarsRoverUnitTest.TestInput;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MarsRoverUnitTest
{
    public class RoverTest
    {
        public static IBase _SBase = new SBase();
        public static ICommand _SCommand = new SCommand(_SBase);
        public static ILocation _SLocation = new SLocation(_SCommand);
        public static IRover _SRover = new SRover(_SCommand, _SBase, _SLocation);
        public static IPlateau _SPlateau = new SPlateau();

        [Fact]
        public void setRoverLocationTest()
        {
            //Arrange
            RoverInput roverInput = new RoverInput();
            PlateauInput plateauInput = new PlateauInput();

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
            RoverInput roverInput = new RoverInput();
            PlateauInput plateauInput = new PlateauInput();
            CommandInput commandInput = new CommandInput();

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
            Assert.True(response.FirstOrDefault().Value);
        }
    }
}

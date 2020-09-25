using Business.Interfaces;
using Core.Enum;
using Core.Message;
using Entity;
using System;

namespace Business.Services
{
    public class SCommand : ICommand
    {
        IBase _SBase;
        public SCommand(IBase _SBase)
        {
            this._SBase = _SBase;
        }

        public char[] createCommandArray(string command)
        {
            char[] commandArray = new char[command.Length];
            commandArray = command.ToCharArray();
            return commandArray;
        }

        public Rover directionTurnLeft(Rover rover)
        {
            var result = ((int)rover.mainDirection - 1) < (int)enumMainDirections.N ? enumMainDirections.W : (enumMainDirections)((int)rover.mainDirection - 1);
            rover.mainDirection = result;
            return rover;
        }

        public Rover directionTurnRight(Rover rover)
        {
            var result = ((int)rover.mainDirection + 1) > (int)enumMainDirections.W ? enumMainDirections.N : (enumMainDirections)((int)rover.mainDirection + 1);
            rover.mainDirection = result;
            return rover;
        }

        public Rover goForward(Rover rover)
        {
            switch(rover.mainDirection)
            {
                case enumMainDirections.N:
                    rover.yCoordinate += 1;
                    break;
                case enumMainDirections.S:
                    rover.yCoordinate -= 1;
                    break;
                case enumMainDirections.E:
                    rover.xCoordinate += 1;
                    break;
                case enumMainDirections.W:
                    rover.xCoordinate -= 1;
                    break;
            }

            return rover;
        }

        public void printRoverInfo(Rover rover)
        {
            Console.WriteLine(Messages.result + rover.xCoordinate + " " + rover.yCoordinate + " " + _SBase.Get_Enum_Description(rover.mainDirection));
        }
        public void printInvalidLocationOrDirection()
        {
            Console.WriteLine(Messages.invalidLocation);
        }
    }
}

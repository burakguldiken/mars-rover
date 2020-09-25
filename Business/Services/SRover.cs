using Business.Interfaces;
using Core.Enum;
using Core.Message;
using Entity;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class SRover : IRover
    {
        ICommand _SCommand;
        IBase _SBase;
        ILocation _SLocation;

        public SRover(ICommand _SCommand, IBase _SBase, ILocation _SLocation)
        {
            this._SCommand = _SCommand;
            this._SBase = _SBase;
            this._SLocation = _SLocation;
        }

        public Dictionary<Rover, bool> setRoverLocation(Plateau plateau, int xCoordinate, int yCoordinate, enumMainDirections mainDirection)
        {
            Dictionary<Rover, bool> response = new Dictionary<Rover, bool>();

            Rover rover = new Rover()
            {
                xCoordinate = xCoordinate,
                yCoordinate = yCoordinate,
                mainDirection = mainDirection
            };

            return _SLocation.isInvalidLocation(plateau, rover);
        }

        public Dictionary<Rover, bool> updateRoverLocation(Plateau plateau, Rover rover, string command)
        {
            char[] commandArr = _SCommand.createCommandArray(command);

            foreach (var comm in commandArr)
            {
                if (comm.ToString() == _SBase.Get_Enum_Description(enumControlDirections.Rigth))
                {
                    _SCommand.directionTurnRight(rover);
                }
                else if (comm.ToString() == _SBase.Get_Enum_Description(enumControlDirections.Left))
                {
                    _SCommand.directionTurnLeft(rover);
                }
                else if (comm.ToString() == _SBase.Get_Enum_Description(enumControlDirections.GoForward))
                {
                    _SCommand.goForward(rover);
                }
                else
                {
                    return _SLocation.isInvalidDirection();
                }
            }

            return _SLocation.isInvalidLocation(plateau, rover);

        }
    }
}

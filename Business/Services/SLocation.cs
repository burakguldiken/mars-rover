using Business.Interfaces;
using Core.Enum;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class SLocation : ILocation
    {
        ICommand _SCommand;

        public SLocation(ICommand _SCommand)
        {
            this._SCommand = _SCommand;
        }

        public Dictionary<Rover, bool> isInvalidLocation(Plateau plateau, Rover rover)
        {
            Dictionary<Rover, bool> keyValuePairs = new Dictionary<Rover, bool>();

            if (rover.xCoordinate > plateau.width || rover.yCoordinate > plateau.height)
                keyValuePairs.Add(new Rover(), false);
            else
                keyValuePairs.Add(rover, true);

            return keyValuePairs;
        }

        public Dictionary<Rover,bool> isInvalidDirection()
        {
            Dictionary<Rover, bool> keyValuePairs = new Dictionary<Rover, bool>();
            keyValuePairs.Add(new Rover(), false);
            return keyValuePairs;
        }

        public void roverResultLocation(Dictionary<Rover,bool> keyValuePairs)
        {
            if (keyValuePairs.FirstOrDefault().Value)
                _SCommand.printRoverInfo(keyValuePairs.FirstOrDefault().Key);
            else
                _SCommand.printInvalidLocationOrDirection();
        }
    }
}

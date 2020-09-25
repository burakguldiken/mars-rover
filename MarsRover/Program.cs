using Business.Interfaces;
using Business.Services;
using Core.Enum;
using Core.Message;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main()
        {
            #region Definations
            IBase _SBase = new SBase();
            ICommand _SCommand = new SCommand(_SBase);
            ILocation _SLocation = new SLocation(_SCommand);
            IRover _SRover = new SRover(_SCommand, _SBase,_SLocation);
            IPlateau _SPlateau = new SPlateau();
            #endregion

            #region Test Input One
            Plateau plateau = _SPlateau.createPlateau(5, 5);
            Dictionary<Rover, bool> firstRover = _SRover.setRoverLocation(plateau, 1, 2, enumMainDirections.N);

            if (firstRover.FirstOrDefault().Value)
            {
                Dictionary<Rover, bool> firstRoverResponse = _SRover.updateRoverLocation(plateau, firstRover.FirstOrDefault().Key, "LMLMLMLMM");
                _SLocation.roverResultLocation(firstRoverResponse);
            }
            else
                _SCommand.printInvalidLocationOrDirection();
            #endregion

            #region Test Input Two
            Dictionary<Rover, bool> secondRover = _SRover.setRoverLocation(plateau, 3, 3, enumMainDirections.E);
            if (firstRover.FirstOrDefault().Value)
            {
                Dictionary<Rover, bool> secondRoverResponse = _SRover.updateRoverLocation(plateau, secondRover.FirstOrDefault().Key, "MMRMMRMRRM");
                _SLocation.roverResultLocation(secondRoverResponse);
            }
            else
                _SCommand.printInvalidLocationOrDirection();
            #endregion

            Console.ReadLine();
        }
    }
}

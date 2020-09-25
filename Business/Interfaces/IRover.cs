using Core.Enum;
using Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IRover
    {
        /// <summary>
        /// Sets the rover position
        /// </summary>
        /// <param name="plateau"></param>
        /// <param name="xCoordinate"></param>
        /// <param name="yCoordinate"></param>
        /// <param name="mainDirection"></param>
        /// <returns></returns>
        Dictionary<Rover, bool> setRoverLocation(Plateau plateau, int xCoordinate, int yCoordinate, enumMainDirections mainDirection);
        /// <summary>
        /// Updates roaming location
        /// </summary>
        /// <param name="plateau"></param>
        /// <param name="rover"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        Dictionary<Rover, bool> updateRoverLocation(Plateau plateau,Rover rover, string command);
    }
}

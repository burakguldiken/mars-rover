using Core.Enum;
using Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ILocation
    {
        /// <summary>
        /// Queries the status of the location
        /// </summary>
        /// <param name="plateau"></param>
        /// <param name="rover"></param>
        /// <returns></returns>
        Dictionary<Rover, bool> isInvalidLocation(Plateau plateau, Rover rover);
        /// <summary>
        /// Checks for wrong direction
        /// </summary>
        /// <returns></returns>
        Dictionary<Rover, bool> isInvalidDirection();
        /// <summary>
        /// Return result location
        /// </summary>
        /// <param name="keyValuePairs"></param>
        void roverResultLocation(Dictionary<Rover, bool> keyValuePairs);
    }
}

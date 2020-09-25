using Entity;

namespace Business.Interfaces
{
    public interface ICommand
    {
        /// <summary>
        /// Converts the command to a char array
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        char[] createCommandArray(string command);
        /// <summary>
        /// Turning right operation
        /// </summary>
        /// <param name="rover"></param>
        /// <returns></returns>
        Rover directionTurnRight(Rover rover);
        /// <summary>
        /// Turning left operation
        /// </summary>
        /// <param name="rover"></param>
        /// <returns></returns>
        Rover directionTurnLeft(Rover rover);
        /// <summary>
        /// One unit of progress
        /// </summary>
        /// <param name="rover"></param>
        /// <returns></returns>
        Rover goForward(Rover rover);
        /// <summary>
        /// Prints rover response information
        /// </summary>
        /// <param name="rover"></param>
        void printRoverInfo(Rover rover);
        /// <summary>
        /// Print invalid location message
        /// </summary>
        void printInvalidLocationOrDirection();
    }
}

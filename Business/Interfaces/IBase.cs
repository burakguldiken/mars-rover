using System;

namespace Business.Interfaces
{
    public interface IBase
    {
        /// <summary>
        /// Gets the description of enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Get_Enum_Description(Enum value);
    }
}

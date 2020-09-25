using Business.Interfaces;
using System;
using System.ComponentModel;
using System.Reflection;

namespace Business.Services
{
    public class SBase : IBase
    {
        public string Get_Enum_Description(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}

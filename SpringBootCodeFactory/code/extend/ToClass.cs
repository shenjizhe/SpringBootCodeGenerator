using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace System
{
    public static class ToClass
    {
        public static Tout To<Tout>(this object obj)
        {
            Type type = typeof(Tout);
            //Type typeIn = typeof(obj);
            try
            {
                if (type.IsEnum)
                {
                    return (Tout)Enum.Parse(type, obj.ToString());
                }
                else
                {
                    return (Tout)Convert.ChangeType(obj, type);
                }
            }
            catch (Exception)
            {
                return default(Tout);
            }
        }
    }
}

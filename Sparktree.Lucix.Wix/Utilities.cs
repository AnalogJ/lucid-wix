using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//using Microsoft.Tools.WindowsInstallerXml.Serialize;

namespace Sparktree.Lucid.Wix
{
    public class Utilities
    {
        public static String StripSpecialCharacters(String input)
        {

            if (!String.IsNullOrEmpty(input))
            {
                return Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
            }
            return String.Empty;

        }

        public static string GenerateGuid()
        {
            return Guid.NewGuid().ToString("D");
        }

        public static string GeneratePackageId(String packageName)
        {
            return String.Format("PG_{0}", StripSpecialCharacters(packageName));
        }
        public static string GenerateBinaryId(String binaryName)
        {
            return String.Format("BIN_{0}", StripSpecialCharacters(binaryName));
        }
        public static string GenerateCustomActionId(String customActionName)
        {
            return String.Format("CA_{0}", StripSpecialCharacters(customActionName));
        }
        public static string GenerateDynamicPropertyName(String propertyName)
        {
            return String.Format("PROP_{0}", StripSpecialCharacters(propertyName));
        }

        public static T GenericEnumTypeConvert<T>(String genericStringVal) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            try
            {
                Type genericEnumType = typeof(T);
                return (T)Enum.Parse(genericEnumType, genericStringVal, true);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        public static T YesNoTypeConvert<T>(Boolean enumYesNoVal) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            try
            {
                Type genericEnumType = typeof (T);
                if (genericEnumType == typeof(Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoType))
                {
                    return (T)(Object)(enumYesNoVal ? Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoType.yes : Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoType.no);
                }

                return default(T);
            }
            catch(Exception ex)
            {
                return default(T);
            }
        }
        public static T YesNoDefaultTypeConvert<T>(Boolean? enumYesNoVal) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            try
            {
                Type genericEnumType = typeof(T);

                if (genericEnumType == typeof(Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoDefaultType))
                {
                    if (!enumYesNoVal.HasValue)
                    {
                        return (T)(Object)Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoDefaultType.@default;
                    }

                    return (T)(Object)(enumYesNoVal.Value ? Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoDefaultType.yes : Microsoft.Tools.WindowsInstallerXml.Serialize.YesNoDefaultType.no);
                }

                return default(T);

            }
            catch (Exception ex)
            {
                return default(T);
            }

        }
        

    }
}

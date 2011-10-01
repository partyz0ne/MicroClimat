using System;
using MicroClimat.Properties;

namespace MicroClimat.Classes
{
    public enum WindDirect
    {
        North, Northeast, East, Southeast,
        South, Southwest, West, Northwest
    }

    public static class Utils
    {
        public const double MMtoBar = 1.333;
        public const double BartoMm = 0.7508;

        /// <summary>
        /// Получить значение ресурса приложения.
        /// </summary>
        /// <param name="strProp">Имя ресурса.</param>
        /// <returns>Значение ресурса.</returns>
        public static String GetPropValue(String strProp)
        {
            return Resources.ResourceManager.GetString(strProp);
        }

        /// <summary>
        /// Получить направление ветра.
        /// </summary>
        /// <param name="nFlag">Флаг, определяющий направление.</param>
        /// <returns>Строка, идентифицирующая направление ветра.</returns>
        public static String GetWindDirect(int nFlag)
        {
            switch (nFlag)
            {
                case (int)WindDirect.Northwest:
                    return "с/з";
                case (int)WindDirect.North:
                    return "с";
                case (int)WindDirect.Northeast:
                    return "с/в";
                case (int)WindDirect.East:
                    return "в";
                case (int)WindDirect.Southeast:
                    return "ю/в";
                case (int)WindDirect.South:
                    return "ю";
                case (int)WindDirect.Southwest:
                    return "ю/з";
                case (int)WindDirect.West:
                    return "з";
                default:
                    return "-";
            }
        }

        public static bool SafeParseDouble(String strToParse, out double dblRes)
        {
            dblRes = 0;
            if (strToParse == String.Empty)
                return true;
            return double.TryParse(strToParse, out dblRes);
        }
    }
}

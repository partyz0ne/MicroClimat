using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MicroClimat.Classes
{
    /// <summary>
    /// Структура данных проекта.
    /// </summary>
    public struct ClimatData
    {
        /// <summary>
        /// Индекс записи в списке записей проекта.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Дата и время сделанного наблюдения.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Температура сухого термометра психрометра.
        /// </summary>
        public double TempDry { get; set; }

        /// <summary>
        /// Температура смоченного термометра психрометра.
        /// </summary>
        public double TempWet { get; set; }

        /// <summary>
        /// Лед на смоченном термометре
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Атмосферное давление.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// Относительная влажность воздуха.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// Недостаточность насыщения воздуха влагой.
        /// </summary>
        public double Saturation { get; set; }

        /// <summary>
        /// Скорость ветра.
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// Направление ветра.
        /// </summary>
        public int WindDirect { get; set; }

        /// <summary>
        /// Дежурные, сделавшие наблюдение.
        /// </summary>
        public string Duty { get; set; }
    }

    /// <summary>
    /// Класс для сериализации.
    /// </summary>
    public class CProject
    {
        String _strManager = String.Empty;
        String _strPlace = String.Empty;
        List<String> _lstMembers = new List<String>();
        // Данные наблюдений
        [XmlArray("Data")]
        public readonly List<ClimatData> StData = new List<ClimatData>();
        List<bool> _lstGadgets = new List<bool>();
        private const int Ver = 2;

        // Руководитель проекта
        public String Manager { get { return _strManager; } set { _strManager = value; } }
        // Место проведения наблюдения
        public String Place { get { return _strPlace; } set { _strPlace = value; } }
        // Список участников проекта.
        public List<String> Members
        {
            get { return _lstMembers; }
            set { _lstMembers.Clear(); _lstMembers = value; }
        }
        // Приборы, используемые в проекте.
        public List<bool> Gadgets
        {
            get { return _lstGadgets; }
            set { _lstGadgets.Clear(); _lstGadgets = value; }
        }
        // Версия проекта
        public int Version { get { return Ver; } }
    }
}

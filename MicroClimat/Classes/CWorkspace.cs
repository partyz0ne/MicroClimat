using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MicroClimat.Classes
{
    /// <summary>
    /// Класс проекта.
    /// </summary>
    public class CWorkspace
    {
        CProject _project = new CProject();
        String _strName = String.Empty;

        /// <summary>
        /// Количество записей в проекте.
        /// </summary>
        public int Length { get { return _project.StData.Count; } }

        /// <summary>
        /// Возвращает n-ый элемент списка записей проекта.
        /// </summary>
        /// <param name="i">Индекс данных.</param>
        /// <returns>Структура данных проекта.</returns>
        public ClimatData this[int i]
        {
            get
            {
                if (i >= 0 && i < Length)
                    return _project.StData[i];
                return _project.StData[0];
            }
        }

        /// <summary>
        /// Конструктор класса проекта.
        /// </summary>
        /// <param name="strFile">Путь к файлу проекта.</param>
        public CWorkspace(String strFile)
        {
            _strName = strFile;
        }

        /// <summary>
        /// Открытие проекта.
        /// </summary>
        /// <returns>True в случае удачного открытия и False - в случае неудачного.</returns>
        public bool Open()
        {
            bool bRes = false;
            try 
            {
                var reader = new StreamReader(_strName);
                try
                {
                    var ser = new XmlSerializer(typeof(CProject));
                    _project = (CProject)ser.Deserialize(reader);
                    reader.Close();
                    bRes = true;
                }
                catch (Exception ex)
                {
                    CLogger.AddException(ex);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                CLogger.AddException(ex);
            }
            return bRes;
        }

        /// <summary>
        /// Закрытие проекта.
        /// </summary>
        public void Close()
        {
            _strName = string.Empty;
        }

        private void SortList()
        {
            for (int i = 0; i < Length; ++i)
            {
                for (int j = Length - 1; j > i; --j)
                {
                    if (_project.StData[j - 1].Date > _project.StData[j].Date)
                    {
                        ClimatData stTemp = _project.StData[j - 1];
                        _project.StData[j - 1] = _project.StData[j];
                        _project.StData[j] = stTemp;
                    }
                }
            }
        }

        /// <summary>
        /// Сохранение проекта.
        /// </summary>
        public void Save()
        {
            SortList();
            var writer = new StreamWriter(_strName);
            var ser = new XmlSerializer(typeof(CProject));
            ser.Serialize(writer, _project);
            writer.Close();
        }

        /// <summary>
        /// Сохранение копии проекта.
        /// </summary>
        /// <param name="strNewFile">Путь к файлу проекта.</param>
        public void SaveAs(String strNewFile)
        {
            Close();
            _strName = strNewFile;
            Save();
        }

        /// <summary>
        /// Добавление данных в список данных проекта.
        /// </summary>
        /// <param name="stData">Структура данных наблюдения.</param>
        public void AddData(ClimatData stData)
        {
            _project.StData.Add(stData);
            SortList();
        }

        /// <summary>
        /// Удаление данных из списка данных проекта.
        /// </summary>
        /// <param name="nIndex">Индекс данных в списке.</param>
        public void DeleteData(int nIndex)
        {
            int nNum = FindItem(nIndex);
            if (nNum != -1)
                _project.StData.RemoveAt(nNum);
        }

        public ClimatData GetDatabyIndex(int nIndex)
        {
            int nPos = FindItem(nIndex);
            return _project.StData[nPos];
        }

        /// <summary>
        /// Редактирование данных проекта.
        /// </summary>
        /// <param name="stData">Структура данных наблюдения.</param>
        public void EditData(ClimatData stData)
        {
            int nPos = FindItem(stData.Index);
            _project.StData[nPos] = stData;
            SortList();
        }

        /// <summary>
        /// Поиск данных наблюдения в списке.
        /// </summary>
        /// <param name="nIndex">Индекс данных.</param>
        /// <returns>Структура данных наблюдения.</returns>
        private int FindItem(int nIndex)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_project.StData[i].Index == nIndex)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Имя проекта.
        /// </summary>
        public String Name
        {
            get { return _strName; }
        }

        /// <summary>
        /// Руководитель проекта.
        /// </summary>
        public String Manager
        {
            get { return _project.Manager; }
            set { _project.Manager = value; }
        }

/*
        /// <summary>
        /// Место ведения наблюдений.
        /// </summary>
        public String Place
        {
            get { return _project.Place; }
            set { _project.Place = value; }
        }
*/

        /// <summary>
        /// Список участников проекта.
        /// </summary>
        public List<String> Members
        {
            get { return _project.Members; }
            set { _project.Members.Clear(); _project.Members = value; }
        }

        /// <summary>
        /// Приборы, используемые в проекте.
        /// </summary>
        public List<bool> Gadgets
        {
            get { return _project.Gadgets; }
            set { _project.Gadgets.Clear(); _project.Gadgets = value; }
        }

        /// <summary>
        /// Проверяет, является ли участник активным участников проекта.
        /// </summary>
        /// <param name="strMember">Имя участника.</param>
        /// <returns>True, если является, False - если нет.</returns>
        public bool IsMemberActive(String strMember)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_project.StData[i].Duty.Contains(strMember))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Генерирует новый индекс для добавляемой записи в проект.
        /// </summary>
        /// <returns>Индекс записи.</returns>
        public int NewIndex()
        {
            int index = 1;
            bool bFound = false;
            while (!bFound)
            {
                if (Length == 0)
                    return index;
                for (int i = 0; i < Length; i++)
                {
                    if (index == _project.StData[i].Index)
                    {
                        index++;
                        break;
                    }
                    if (i == Length - 1)
                        bFound = true;
                }
            }
            return index;
        }
    }
}

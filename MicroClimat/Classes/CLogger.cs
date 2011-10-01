using System;
using System.IO;
using System.Diagnostics;
using MicroClimat.Properties;

namespace MicroClimat.Classes
{
    delegate void LogEventHandler();

    class CLogger
    {
        #region События
        public event LogEventHandler LogEvent;

        public void OnLogEvent()
        {
            if (LogEvent != null)
                LogEvent();
        }
        #endregion

        private static StackTrace _sTrace;
        private static string _strFilePath;

        /// <summary>
        /// Открытие логгера.
        /// </summary>
        /// <returns>true - в случае успешного открытия, иначе - false</returns>
        public static void Open()
        {
            string strFileName;
            if (Settings.Default.LogNum < 10)
                strFileName = "00" + Settings.Default.LogNum + ".txt";
            else if (Settings.Default.LogNum < 100)
                strFileName = "0" + Settings.Default.LogNum + ".txt";
            else
                strFileName = Settings.Default.LogNum + ".txt";
            if (string.IsNullOrEmpty(Settings.Default.LogPath))
            {
                Settings.Default.LogPath = Path.Combine(Environment.CurrentDirectory, "Log");
                Directory.CreateDirectory(Settings.Default.LogPath);
                Settings.Default.Save();
            }
            _strFilePath = Path.Combine(Settings.Default.LogPath, strFileName);
            if (File.Exists(_strFilePath))
            {
                FileInfo fi = new FileInfo(_strFilePath);
                if (fi.Length >= 51200)
                    Settings.Default.LogNum++;
            }
            _sTrace = new StackTrace();
        }

        /// <summary>
        /// Добавление события для записи в файл.
        /// </summary>
        /// <param name="strMessage">Текст сообщения.</param>
        public static void AddError(string strMessage)
        {
            string strCalling = _sTrace.GetFrame(0).GetMethod().Name;
            string strLogRow = DateTime.Now.ToLongTimeString() + ". [Ошибка] [" + strCalling + "] " + strMessage;
            StreamWriter swWriter = new StreamWriter(new FileStream(_strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
            swWriter.WriteLine(strLogRow);
            swWriter.Close();
        }

        /// <summary>
        /// Добавление события для записи в файл.
        /// </summary>
        /// <param name="strMessage">Текст сообщения.</param>
        public static void AddWarning(string strMessage)
        {
            string strCalling = _sTrace.GetFrame(1).GetMethod().ToString();
            string strLogRow = DateTime.Now.ToLongTimeString() + ". [Предупреждение] [" + strCalling + "] " + strMessage;
            StreamWriter swWriter = new StreamWriter(new FileStream(_strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
            swWriter.WriteLine(strLogRow);
            swWriter.Close();
        }

        /// <summary>
        /// Добавление события для записи в файл.
        /// </summary>
        /// <param name="strMessage">Текст сообщения.</param>
        public static void AddInfo(string strMessage)
        {
            string strLogRow = DateTime.Now.ToLongTimeString() + ". [Информация] " + strMessage;
            StreamWriter swWriter = new StreamWriter(new FileStream(_strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
            swWriter.WriteLine(strLogRow);
            swWriter.Close();
        }
        
        /// <summary>
        /// Добавление события типа Исключение с выводом сообщения на экран.
        /// </summary>
        /// <param name="ex">Перехваченное исключение.</param>
        public static void AddException(Exception ex)
        {
            string strCalling = _sTrace.GetFrame(0).GetMethod().Name;
            string strLogRow = DateTime.Now.ToLongTimeString() + ". [Исключение] [" + strCalling + "] " + ex.Message;
            StreamWriter swWriter = new StreamWriter(new FileStream(_strFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
            swWriter.WriteLine(strLogRow);
            swWriter.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GiftArium.Core.BLL.Logger
{
    public enum LogType
    {
        Insert,
        Update,
        Delete,
        Error,
        NotFound,
        NonValidation,
        Warning,
    }
    public static class GiftAriumLogger
    {
        public static void AddLog(string message,LogType logType)
        {
            FileStream fs = new FileStream("GiftAriumLogs.txt", FileMode.Append);//klosör oluşturlup kaybedildi
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{DateTime.Now} Log Türü:{logType},Log Mesajı:{message}");
            sw.Flush();
            sw.Close();

        }
    }
}

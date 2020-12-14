﻿using System;
using System.IO;

namespace TubeFeeder
{
    class IniFileManager
    {
        public const string INIFILE_PATH = "\\Flash Disk\\Settings.ini";

        public const string SECTION_COMPORT = "COMPORT";
        public const string SECTION_LOGFILE = "LOGFILE";
        
        public const string SECTION_COMPORT_COM = "COM";
        public const string SECTION_COMPORT_BAUDRATE = "BAUDRATE";

        public const string SECTION_LOGFILE_DIR = "LOGFILE_DIR";

        /* Default 값 */
        public const string SECTION_COMPORT_COM_DEFAULT = "COM4";
        public const int SECTION_COMPORT_BAUDRATE_DEFAULT = 115200;

        public const string SECTION_LOGFILE_DIR_DEFAULT = "\\Flash Disk\\ScanLog";

        public static string GetComport_COM()
        {
            return IniFile.ReadString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_COM, SECTION_COMPORT_COM_DEFAULT);
        }
        public static int GetComport_BaudRate()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_BAUDRATE, SECTION_COMPORT_BAUDRATE_DEFAULT);
        }

        public static string GetLogFIle_Dir()
        {
            return IniFile.ReadString(INIFILE_PATH, SECTION_LOGFILE, SECTION_LOGFILE_DIR, SECTION_LOGFILE_DIR_DEFAULT);
        }


        public static void IniFileExistCheckAndGenerateDefaultIniFIle()
        {
            if (IniFileExistCheck() == false)
                GenerateDefaultIniFile();
        }
        public static bool IniFileExistCheck()
        {
            FileInfo fileInfo = new FileInfo(INIFILE_PATH);
            return fileInfo.Exists;
        }
        public static void GenerateDefaultIniFile()
        {
            IniFile.WriteString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_COM, SECTION_COMPORT_COM_DEFAULT);
            IniFile.WriteInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_BAUDRATE, SECTION_COMPORT_BAUDRATE_DEFAULT);

            IniFile.WriteString(INIFILE_PATH, SECTION_LOGFILE, SECTION_LOGFILE_DIR, SECTION_LOGFILE_DIR_DEFAULT);
        }
    }
}

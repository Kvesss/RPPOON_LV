using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD2
{
    class FileLogger
    {
        private static FileLogger instance;
        private string filePath;
        private FileLogger()
        {
            filePath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV3\\Obrasci_Stvaranja\\ZAD2\\DefaultFile.txt";
        }

        public static FileLogger GetInstance()
        {
            if (instance == null)
            {
                return new FileLogger();
            }
            return instance;
        }

        public void SetFilepath(string filepath)
        {
            this.filePath = filepath;
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
            {
                writer.WriteLine(message);
            }
            /*Jednom kada je datoteka postavljena, logger će pisati tekst u istu datoteku neovisno o tome gdje je unutar teksta programa pozvan.
            Za promjenu datoteke nužno je ponovno postaviti atribut filePath za neku drugu datoteku.*/
        }
    }
}

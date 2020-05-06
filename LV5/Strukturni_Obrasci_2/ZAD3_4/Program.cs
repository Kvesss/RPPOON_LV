using System;

namespace ZAD3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zad3
            string filePath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV5\\Strukturni_Obrasci_2\\ZAD3_4\\numbers.txt";
            Dataset dataset = new Dataset(filePath);    //Dataset objekt instancira se odmah
            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset(filePath);    //dataset == null;
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(dataset);
            printer.Print(virtualProxyDataset);     //U ovom objektu dataset se instancira tek pozivom metode Print koja poziva GetData() na predanom objektu

            Console.WriteLine("*************************");
            User firstUser = User.GenerateUser("David");
            User secondUser = User.GenerateUser("Kvesic");
            ProtectionProxyDataset firstProxyDataset = new ProtectionProxyDataset(firstUser);
            ProtectionProxyDataset secondProxyDataset = new ProtectionProxyDataset(secondUser);
            printer.Print(firstProxyDataset);
            printer.Print(secondProxyDataset);




            //Zad4
            Console.WriteLine("*************************");
            LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset(filePath);
            printer.Print(loggingProxyDataset);
            System.Threading.Thread.Sleep(1000);
            printer.Print(loggingProxyDataset);


        }
    }
}

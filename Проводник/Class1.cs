using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    internal class Class1
    {
        public static void Disk()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Console.WriteLine("                                                     Этот Компьютер");
            Console.WriteLine("- - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            foreach (DriveInfo d in allDrives)
            {
                
                Console.WriteLine("  " + d.Name + d.TotalFreeSpace / 1073741824 + "ГБ свободно из " + d.TotalSize / 1073741824 + " ГБ");
            }


        }
    }
}

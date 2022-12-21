using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

DriveInfo[] allDrives = DriveInfo.GetDrives();
Console.WriteLine("                                                     Этот Компьютер");
Console.WriteLine("- - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

foreach (DriveInfo d in allDrives)
{

    Console.WriteLine("  " + d.Name + d.TotalFreeSpace / 1073741824 + "ГБ свободно из " + d.TotalSize / 1073741824 + " ГБ");
}

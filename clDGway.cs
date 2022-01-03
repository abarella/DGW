using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DGateWay
{
    
    class clDGway
    {
        string path = @"C:\DGWAY\";
        public void AddSch(string Name, string Desc, bool Schedule, bool Active, string Type, string Start, string End, string Day, string Loop, string Try, bool _0, bool _1, bool _2, bool _3, bool _4, bool _5, bool _6)
        {
            path += Name;
            DirectoryInfo di = Directory.CreateDirectory(path);
            using (FileStream f = new FileStream(path + @"\" + Name + ".dgprc", FileMode.Create, FileAccess.Write))
            using (StreamWriter s = new StreamWriter(f))
                s.WriteLine("NAME = " + Name + Environment.NewLine +
                     "DESCRIPTION = " + Desc + Environment.NewLine +
                     "SCHEDULE = " + Schedule.ToString() + Environment.NewLine +
                     "ACTIVE = " + Active.ToString() + Environment.NewLine +
                     "TYPE = " + Type + Environment.NewLine +
                     "START = " + Start + Environment.NewLine +
                     "END = " + End + Environment.NewLine +
                     "DAY = " + Day + Environment.NewLine +
                     "LOOP = " + Loop + Environment.NewLine +
                     "TRY = " + Try + Environment.NewLine +
                     "SUN = " + _0 + Environment.NewLine +
                     "MON = " + _1 + Environment.NewLine +
                     "TUE = " + _2 + Environment.NewLine +
                     "WED = " + _3 + Environment.NewLine +
                     "THU = " + _4 + Environment.NewLine +
                     "FRI = " + _5 + Environment.NewLine +
                     "SAT = " + _6 
                     );
        }

        public Array ReadSch()
        {
            string[] dirs = Directory.GetDirectories(path);

            return dirs;
        }

    }
}

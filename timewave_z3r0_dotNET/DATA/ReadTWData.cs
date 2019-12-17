using System.IO;

namespace timewave_z3r0_dotNET.DATA
{
    public class ReadTWData
    {
        public static string[] GetTimeWaveData()
        {
            return
                File.ReadAllLines("C:\\Users\\chuck\\source\\repos\\timewave_z3r0\\timewave_z3r0_dotNet\\DATA\\DATA.TW1");
        }
    }
}

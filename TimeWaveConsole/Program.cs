using System;
using timewave_z3r0_dotNET;

namespace TimeWaveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] retArray = timewave_z3r0_dotNET.DATA.ReadTWData.GetTimeWaveData();

            for (int i = 0; i < retArray.Length; i++)
            {
                
            }
        }
    }
}

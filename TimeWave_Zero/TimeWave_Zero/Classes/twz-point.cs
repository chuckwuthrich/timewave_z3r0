using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classes.DATA.DATA;

namespace Classes
{
    public class twz_point
    {
        /// <summary>
        /// 
        /// </summary>
        public const int NUM_SETS = 4;
        
        /// <summary>
        /// 
        /// </summary>
        public const int NUM_POWERS = 64;
        
        /// <summary>
        /// 
        /// </summary>
        public const int NUM_DATA_POINTS = 384;
        
        /// <summary>
        /// 
        /// </summary>
        public const int CALC_PREC = 1000000;

        /// <summary>
        /// 
        /// </summary>
        public const int PREC = 16;

        public const string USAGE = 
            "\nUse: twz-point dtz1 dtz2 dtz3 ... [wf=nn].\nwf = wave factor (default 64, range 2-10000)\n";


        public int wave_factor = 64;

        public int number_set { get; set; }

        public int stringchar { get; set; }

        public double[] powers = new double[NUM_POWERS];

        char[] temp = new char[32];

        public Dictionary<int,string> Set_Name { get; }

        public Dictionary<int, int[]> Working_Set { get; }

        public twz_point()
        {
            Set_Name.Add(1, "Kelley");
            Set_Name.Add(2, "Watkins");
            Set_Name.Add(3, "Sheliak");
            Set_Name.Add(4, "Huang Ti");

            Working_Set.Add(1, DATA_1);
            Working_Set.Add(2, DATA_2);
            Working_Set.Add(3, DATA_3);
            Working_Set.Add(4, DATA_4);


        }

        public void SetPowers()
        {
            powers[0] = 1;
            for (int i = 1; i < NUM_POWERS; i++)
            {
                powers[i] = wave_factor * powers[i - 1];
            }
        }
    }
}

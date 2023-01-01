using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Constants
    {
       
        //int[][] answers = new int[2][];
        //commemtssss
        //answers[0] = new int[15] {0, 0, 180, 0, 0, 0, 90, 0, 0, 180, 0, 180, 0, 0, 0, 90 };
    //, { 270, 0, 270, 0, 90, 270, 90, 0, 0, 0, 90, 0, 0, 90, 0, 180 } };
        //public static int[] answersk ={new int[,] { 0, 0, 180, 0, 0, 0, 90, 0, 0, 180, 0, 180, 0, 0, 0, 90 }, { 270, 0, 270, 0, 90, 270, 90, 0, 0, 0, 90, 0, 0, 90, 0, 180 } };
        //public int[] answers = new int[] { 270, 0, 270, 0, 90, 270, 90, 0, 0, 0, 90, 0, 0, 90, 0, 180 };
        public static int[] Getanswers(int dex)
        {
            switch (dex)
            {
                case 0: 
                    return new int[] { 0, 0, 180, 0, 0, 0, 90, 0, 0, 180, 0, 180, 0, 0, 0, 90 };
                    break;
                case 1:
                    return new int[] { 270, 0, 270, 0, 90, 270, 90, 0, 0, 0, 90, 0, 0, 90, 0, 180 };
                    break;
                case 2:
                    return new int[] { 0, 180, 270, 270, 270, 90, 270, 90, 0, 180, 270, 90, 0, 90, 90, 0 };
                default:
                    return new int[] { 270, 0, 270, 0, 90, 270, 90, 0, 0, 0, 90, 0, 0, 90, 0, 180 };
                    break;
            }
        }
        public static int[] GetInit(int dex)
        {
            switch (dex)
            {
                case 0:
                    return new int[] { 0, 0, 2, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 0, 1, 1 };
                    break;
                case 1:
                    return new int[] { 0, 0, 2, 0, 1, 0, 1, 0, 0, 0, 3, 0, 0, 2, 0, 0 };
                    break;
                case 2:
                    return new int[] { 0, 0, 1, 2, 3, 0, 1, 3, 0, 1, 2, 3, 0, 1, 0, 0 };
                default:
                    return new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    break;
            }
            
        }
    }
    
}

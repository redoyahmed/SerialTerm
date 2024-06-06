using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAV_Suit
{
    public class Globals
    {
        //Variables
        public static bool devMode = false;
        public static bool preFix = true;      // False = NONE; True = CTRL+A
        public static bool isReceived = false;
        public static bool isSent = false;
        public static string serialSendtData = null;
        //Constant Variable
        public const string CTRLA = "\x01"; //CTRL+A

        //ABout US Constant
        public const string softName = "DAV Suit ";
        public const string softVersion = "1.0";
        public const string softDes = "\n\nDAV Suit is a simple RS232 Communication tool\nwith User Control Interface and chat program\nonly uses for DAV Production Team\n\n";
        public const string comDes = "Redoy Ahmed\nDAV SRLS\nvia bruno pontecorvo 11, Rome, Italy";
    }
}

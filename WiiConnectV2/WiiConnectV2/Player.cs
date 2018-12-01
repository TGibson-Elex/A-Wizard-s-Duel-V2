using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Media;
using System.Windows.Controls;
using WiimoteLib;


namespace WiiConnectV2
{

    class Player 
    {

        public bool A = false;
        public bool B = false;
        public bool One = false;
        public bool two = false;
        public bool up = false;
        public bool down = false;
        public bool left = false;
        public bool right = false;




        public void UpdatePlayerStatus(WiimoteChangedEventArgs args)
        {
            WiimoteState ws = args.WiimoteState;

            A = ws.ButtonState.A;
            B = ws.ButtonState.B;
            One = ws.ButtonState.One;
            two = ws.ButtonState.Two;
            up = ws.ButtonState.Up;
            down = ws.ButtonState.Down;
            left = ws.ButtonState.Left;
            right = ws.ButtonState.Right;
        }
    }
}


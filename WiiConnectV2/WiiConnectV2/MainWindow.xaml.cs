using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
using WiimoteLib;


namespace WiiConnectV2
{


    public partial class MainWindow : Window
    {

        Dictionary<Guid, Player> playerID = new Dictionary<Guid, Player>();
        Dictionary<int, Player> playerN = new Dictionary<int, Player>();

       
       
        int var = 0;
        int speed = 10;

        public MainWindow()
        {
            InitializeComponent();

            Init_Controller();

            

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += updateChar;
            timer.Start();
                
            

        }

        public void Init_Controller()
        {
            WiimoteCollection wc = new WiimoteCollection();
            wc.FindAllWiimotes();


            foreach (Wiimote wm in wc)
            {
                wm.WiimoteChanged += WM_WiimoteChanged;

                Player px = new Player();

                playerID[wm.ID] = px;
                playerN[var] = px;

                wm.Connect();

                PlayerNum(wm);

                wm.SetReportType(InputReport.Buttons, false);


            }

            if (wc.Count == 2)
            {
                Console.Write("2 Players are conected\n");
            }
            else
            {
                Console.Write("Too little or too many players\n");
            }
        }


        public void PlayerNum(Wiimote wm)
        {
           
            if (var == 0)
            {
                wm.SetLEDs(true, false, false, false);
                var++;

            }
            else
            {
                wm.SetLEDs(false, true, false, true);
            }


        }

        public void WM_WiimoteChanged(Object sender, WiimoteChangedEventArgs args)
        {

            Player p = playerID[((Wiimote)sender).ID];
            p.UpdatePlayerStatus(args);


        }

        public void updateChar(Object sender, EventArgs args)
        {
            checkPlayer(Wiz1, 0);

        }

        public void checkPlayer(Image sprite, int index)
        {
            Player p = playerN[index];

            Arena1.Children.Remove(sprite);

            if (p.up == true)
            {
                if (Canvas.GetTop(sprite) < 0 + speed)
                {
                    Canvas.SetTop(sprite, 0);
                }
                else
                {
                    Canvas.SetTop(sprite, Canvas.GetTop(sprite) - speed);
                }
            }
            if (p.down == true)
            {
                if (Canvas.GetTop(sprite) > (Arena1.ActualHeight - speed - sprite.ActualHeight))
                {
                    Canvas.SetTop(sprite, Arena1.ActualHeight - sprite.ActualHeight);
                }
                else
                {
                    Canvas.SetTop(sprite, Canvas.GetTop(sprite) + speed);
                }
            }
            if (p.right == true)
            {

                if (index == 0 && Canvas.GetLeft(sprite) > (Arena1.ActualWidth / 2 - speed - sprite.ActualWidth))
                {
                    Canvas.SetLeft(sprite, Arena1.ActualWidth / 2 - sprite.ActualWidth);
                }
                else
                {
                    Canvas.SetLeft(sprite, Canvas.GetLeft(sprite) + speed);
                }


            }
            if (p.left == true)
            {
                if (index == 0 && Canvas.GetLeft(sprite) < speed)
                {
                    Canvas.SetLeft(sprite, 0);
                }
                else
                {
                    Canvas.SetLeft(sprite, Canvas.GetLeft(sprite) - speed);
                }
            }

            Arena1.Children.Add(sprite);

        }

        
       
    }



}





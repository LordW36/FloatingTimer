/*======================================================================================================================================================*\
|               .%#@+                                                                       *#%.                     ..    ..                     -*--@: |
|              -##+@.                                      +##.                             @##                    -###*  *#@                   -+:   *+ |
|             -###*                                      .##%*             +##%##+   -##*   =#=                   %#++%  :##%               -%=::.   .=+=|
|            :##:                                       :#@%+          -%#*   %##.  -##%   -##.                 .##.=%  .###.             .@%+@ -+. .. -+|
|       . -=###-                                       :###*         +##.    @##.  *##@.   @#-                 :#% #=   @##.             *@#=####:  ..=* |
|      %#=--##:                        **          :*--###-         .*:     %##. .@###.   %#.                 *#+*#:   +#%            +#@=+=%%@#%:*- *+  |
|         -##*           -@####=    -####*      :###%@##%                  %##. +#%##*   @#.  .%#+   .@#+.   -#@##.  .##%           =@+##@=:=#.  -@+.@.  |
|        +##*         .%###=  ##*.%#=.-##*   . @#=  *###.  :#.            @##.:##-*##. .#%  =####=  @###@. ..###+  .@##@  :@@.        %#@*.*=%#+--=+:@   |
|       =##@%%%%%+:-. --##-   @#-..  *#%  .%#:@#: -#*:#@ +#=             *##@##*  .##%##-    -##:.##.:##.:#%:#=   %#+##-@#*          =% +%++.+@:%@ :.@-  |
|  -+%@###:      .+###*.##  +#@.     @#=##@- -#@*#=   :@@:               %###-      .-       -####-  +###*  .#@*##::###+          .:##=:=%=#@.:@..%+=#+. |
|.%@=@##+            -.  *@=-         :+-     .+:                         ..                   ..     ..      ..   @#+#%          .*###+*%#:.##%*-=@*%:  |
|                   /\                                                                                            %#% :#*      .--=###-  ..#:.#+-%#-%#:  |
|                    \\ _____________________________________________________________________                    +#@ -#%    +#%. :..  *@@.  +=:*##:+@=-  |
|      (O)[\\\\\\\\\\(O)#####################################################################>                  -##..#+    . :@=-     .  :=-.+=+%**%#@   |
|                    //                                                                                         @#:+#.      .  .      ..-*+:.. -.*@.-..  |
|                   \/               © 2026 Lord Wulf — Licensed under the AGPL-3.0                            *##@-                ..      ..::.###:    |
\*======================================================================================================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FloatingStopWatch
{
    public partial class StopWatchFace : UserControl
    {
        public StopWatchFace()
        {
            InitializeComponent();
            //֎֍▲↑   ►‖  ↺

            DefBackground = this.BackColor;

            CountDownTimer.Interval = 1000;
            CountDownTimer.Tick += CountDownTimer_Tick;

            FlashTimer.Interval = 500;
            FlashTimer.Tick += FlashTimer_Tick;

            Btn_Reset_Click(this, EventArgs.Empty);
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            Flashing = !Flashing;
            this.BackColor = Flashing ? Color.Red : DefBackground;
            FlashInt--;
            if (FlashInt < 0)
            {
                FlashTimer.Stop();
                this.BackColor = DefBackground;
            }
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {

            if (TimeRemain.TotalSeconds <= 0)
            {
                CountDownTimer.Stop();
                Btn_PP.Text = Play;
                TimeRemain = TimeSpan.Zero;
                Lab_Time.Text = "00:00:00";

                FlashInt = 20;
                FlashTimer.Start();
                return;
            }

            TimeRemain = TimeRemain.Subtract(TimeSpan.FromSeconds(1));
            Lab_Time.Text = TimeRemain.ToString(@"hh\:mm\:ss");

        }

        private const string Play = "►";
        private const string Pause = "❚❚";

        public Color DefBackground { get; private set; }
        public int FlashInt { get; private set; } = 20;

        //public Stopwatch StopW { get; private set; } = new Stopwatch();
        public Timer CountDownTimer { get; private set; } = new Timer();
        public Timer FlashTimer { get; private set; } = new Timer();

        public TimeSpan TimeRemain { get; private set; }
        public TimeSpan TimeStart { get; private set; }

        public bool Flashing { get; private set; }
        public bool CTRunning { get; private set; } = false;

        private void Btn_PP_Click(object sender, EventArgs e)
        {
            if (CTRunning)
            {
                CountDownTimer.Stop();
                Btn_PP.Text = Play;
                CTRunning = false;
            }
            else
            {
                
                Btn_PP.Text = Pause;
                Lab_Time.Text = TimeRemain.ToString(@"hh\:mm\:ss");

                FlashTimer.Stop();
                Flashing = false;

                CTRunning = true;
                CountDownTimer.Start();
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {

            TimeSpan init;

            if (!TimeSpan.TryParseExact(
                        TxBx_StartTime.Text,
                        @"hh\:mm\:ss",
                        null,
                        out init))
            {
                MessageBox.Show(
                    "Please enter time in HH:mm:ss format",
                    "Invalid Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            TimeStart = init;
            TimeRemain = TimeStart;

            FlashTimer.Stop();

            TimeRemain = TimeStart;
            Lab_Time.Text = TimeRemain.ToString(@"hh\:mm\:ss");
            this.BackColor = DefBackground;

        }
    }
}

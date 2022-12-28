using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static _23._10._22.Form1;

namespace _23._10._22
{
    public class Engine
    {
        public DateTime end_time;
        public TimeSpan now;
        public void timer_tick(object sender, EventArgs e)
        {
            end_time = new DateTime(2022, 12, 31, 00, 00, 00);
            now = DateTime.Now.TimeOfDay;
        }

    }
}

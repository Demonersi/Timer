using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static _23._10._22.Engine;

namespace _23._10._22
{
    public partial class Form1 : Form
    {
       
        Engine engine=new Engine();
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += labelUpdate;
            timer1.Tick += engine.timer_tick;
            timer1.Interval = 1000;
        }
        private void bstart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            timer1.Start();
        }

        private void bstop_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
                return;
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void labelUpdate(object sender, EventArgs e)
        {
            TimeSpan d1 = (engine.end_time - engine.now).TimeOfDay;         // end_time изменяется в engine
            timertxt.Text = $"Осталось: {(int)d1.TotalHours} часов {(int)d1.TotalMinutes % 60} минут {(int)d1.TotalSeconds % 60} секунд"; 
        }
    }
}
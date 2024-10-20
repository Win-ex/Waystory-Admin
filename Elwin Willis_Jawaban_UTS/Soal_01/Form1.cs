using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Soal_01
{
    public partial class form1 : Form
    {
        System.Timers.Timer t;
        int r, q, w;

        private void form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            t.Start();
            lblPemain.Text = "Player - X";
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                w += 1;
                if (w == 60)
                {
                    w = 0;
                    q += 1;
                }
                if (q == 60)
                {
                    q = 0;
                    r += 1;
                }
                lblWaktu.Text = String.Format("{0}:{1}:{2}", r.ToString().PadLeft(2, '0'), q.ToString().PadLeft(2, '0'), w.ToString().PadLeft(2, '0'));
            }));

        }

        public form1()
        {
            InitializeComponent();
        }
    }
}

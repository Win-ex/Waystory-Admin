using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Soal_03
{
    public partial class GuessNumber : Form
    {
        System.Timers.Timer t;
        int r;
        int lose = 0;
        int win = 0;

        public GuessNumber()
        {
            InitializeComponent();
        }
        private void GuessNumber_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => 
            {
                r += 1;
                if (r == 9)
                {
                    r = 0;
                }
                lblRandom.Text = r.ToString();
            }));

        }

        private void txtAngka_Enter(object sender, EventArgs e)
        {
            txtAngka.BackColor = Color.LightGreen;
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            txtAngka.BackColor = SystemColors.Window;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //null 
            if (txtAngka.Text.Equals(""))
            {
                MessageBox.Show("Sorry, isi angka tebakan anda dulu...","Guess A Number !!! [Soal 03]",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            //change button text
            else{ 
                if (btnPlay.Text == "Play")
                {
                    t.Start();
                    btnPlay.Text = "Stop";
                    pbxFoto.Image = Properties.Resources.questionmark;
                    pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else 
                {
                    btnPlay.Text = "Play"; 
                    t.Stop();
                    //lose and win
                    if (lblRandom.Text != txtAngka.Text)
                    {
                        lose += 1;
                        lblLose.Text = Convert.ToString(lose);
                        pbxFoto.Image = Properties.Resources.lose;
                        pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (lblRandom.Text == txtAngka.Text)
                    {
                        win += 1;
                        lblWin.Text = Convert.ToString(win);
                        pbxFoto.Image = Properties.Resources.win;
                        pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                     
                }
            }
            

         //filter text box   
        }
        private void txtAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtAngka.Text.Equals(""))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
    }
}

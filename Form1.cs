using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        public int minutes { get; set; }
        public int seconds { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void Start()
        {
            timer1.Start();
            lblTimer.ForeColor = Color.White;
            //lblTimer.Text = minutes.ToString() + ":" + seconds.ToString();
            lblTimer.Text = string.Format("{0:00}:{1:00}", minutes, seconds); // minutes.ToString() + ":" + seconds.ToString();
            txtMinutes.Text = string.Format("{0:00}", minutes);
            txtSeconds.Text = string.Format("{0:00}", seconds);
            txtMinutes.ForeColor = Color.White;
            txtSeconds.ForeColor = Color.White;
            lblDots.ForeColor = Color.White;
        }

        public void Stop()
        {
            timer1.Stop();
            //menuStrip1.Visible = true;
        }

        private void Go()
        {
            Show();
            Start();
            //menuStrip1.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                seconds = 59;
                minutes--;
            }
            else
            {
                seconds--;
            }

            //if (seconds == 0)
            //{
            //    minutes--;
            //    seconds = 59;
            //    //if (minutes <= 0)
            //    //{
            //    //    timer1.Stop();
            //    //    minutes = 0;
            //    //    seconds = 0;
            //    //    lblTimer.Text = minutes.ToString() + ":" + seconds.ToString();
            //    //    lblTimer.ForeColor = Color.Red;
            //    //    menuStrip1.Visible = true;
            //    //    return;
            //    //}
            //}

            if ((minutes < 0) || (minutes <= 0 && seconds <= 0))
            {
                timer1.Stop();
                minutes = 0;
                seconds = 0;
                //lblTimer.Text = minutes.ToString() + ":" + seconds.ToString();
                lblTimer.Text = string.Format("{0:00}:{1:00}", minutes, seconds); // minutes.ToString() + ":" + seconds.ToString();
                lblTimer.ForeColor = Color.Red;
                txtMinutes.Text = string.Format("{0:00}", minutes);
                txtSeconds.Text = string.Format("{0:00}", seconds);
                txtMinutes.ForeColor = Color.Red;
                txtSeconds.ForeColor = Color.Red;
                lblDots.ForeColor = Color.Red;

                //menuStrip1.Visible = true;
                return;
            }

            //lblTimer.Text = minutes.ToString() + ":" + seconds.ToString();
            txtMinutes.Text = string.Format("{0:00}", minutes);
            txtSeconds.Text = string.Format("{0:00}", seconds);
            lblTimer.Text = string.Format("{0:00}:{1:00}", minutes, seconds); // minutes.ToString() + ":" + seconds.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x1B)
            {
                Stop();
            }
        }


        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //0 minuti
            timer1.Stop();
            minutes = 0;
            seconds = 0;
            lblTimer.Text = string.Format("{0:00}:{1:00}", minutes, seconds); // minutes.ToString() + ":" + seconds.ToString();
            lblTimer.ForeColor = Color.White;
            txtMinutes.Text = string.Format("{0:00}", minutes);
            txtSeconds.Text = string.Format("{0:00}", seconds);
            txtMinutes.ForeColor = Color.White;
            txtSeconds.ForeColor = Color.White;
            lblDots.ForeColor = Color.White;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //1 minuto
            minutes = 1;
            seconds = 0;
            Go();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //2 minuti
            minutes = 2;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //3 minuti
            minutes = 3;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //4 minuti
            minutes = 4;
            seconds = 0;
            Go();
        }

        private void toolStripMenu5_Click(object sender, EventArgs e)
        {
            //5 minuti
            //Form2 f2 = new Form2();
            //f2.minutes = 5;
            //f2.seconds = 0;
            //f2.Show();
            //this.WindowState = FormWindowState.Minimized;
            //f2.Start();

            minutes = 5;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //6 minuti
            minutes = 6;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //10 minuti
            minutes = 10;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //15 minuti
            minutes = 15;
            seconds = 0;
            Go();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //30 minuti
            minutes = 30;
            seconds = 0;
            Go();
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //bottone sinistro = start/stop timer
                if (timer1.Enabled)
                {
                    Stop();
                    //menuStrip1.Visible = true;
                }
                else
                {
                    Start();
                    //menuStrip1.Visible = false;
                }

                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                //bottone destro hide/show barra comandi
                //menuStrip1.Visible = !menuStrip1.Visible;
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Visible = true;
            txtMinutes.SelectionLength = 0;
            txtSeconds.SelectionLength = 0;
        }

        private void lblTimer_MouseClick(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            Int16 min = 0;
            if (Int16.TryParse(txtMinutes.Text, out min))
            {
                minutes = min;
            }
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {
            Int16 sec = 0;
            if (Int16.TryParse(txtSeconds.Text, out sec))
            {
                seconds = sec;
            }
        }

        private void txtMinutes_Enter(object sender, EventArgs e)
        {
            Stop();
        }

        private void txtSeconds_Enter(object sender, EventArgs e)
        {
            Stop();
        }

        private void txtMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            Stop();

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Start();
            }
            if (e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtSeconds.Focus();
            }

        }

        private void txtSeconds_KeyDown(object sender, KeyEventArgs e)
        {
            Stop();

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Start();
            }
        }

        private void txtSeconds_MouseClick(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void txtMinutes_MouseClick(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            //Altri valori da inserire manualmente
            txtMinutes.Focus();
            txtMinutes.SelectionStart = 0;
            txtMinutes.SelectionLength = 2;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(this.Location.X + this.Width + 20, this.Location.Y);
            frm2.Show(this);
        }
    }
}

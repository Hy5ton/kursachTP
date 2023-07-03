using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Midi;

namespace WinFormsApp1
{
    public partial class Form111 : Form
    {
        int duration = 127;
        int a, b, u, p;
        int []oct = { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

        public Form111()
        {
            InitializeComponent();
        }
        private readonly MidiOut midiOut = new MidiOut(0);
        async Task Play()
        {
            await Task.Factory.StartNew(() => midiOut.Send(MidiMessage.StartNote(oct[u], duration, 1).RawData));
        }

        private void NOct_Click(object sender, EventArgs e) 
        {
            a = Int32.Parse(maskedTextBox1.Text);
            if (a < 10)
            {
                for (b = a; b > 1; b--)
                {
                    for (int i = 11; i >= 0; i--)
                    {
                        oct[i] = oct[i] + 12;
                    }
                }
                Do.Enabled = true;
                Re.Enabled = true;
                Mi.Enabled = true;
                Fa.Enabled = true;
                Sol.Enabled = true;
                La.Enabled = true;
                Si.Enabled = true;
                Dodiez.Enabled = true;
                Rediez.Enabled = true;
                Fadiez.Enabled = true;
                Soldiez.Enabled = true;
                Ladiez.Enabled = true;
                NOct.Enabled = false;
                Do.BackColor = Color.White;
                Re.BackColor = Color.White;
                Mi.BackColor = Color.White;
                Fa.BackColor = Color.White;
                Sol.BackColor = Color.White;
                La.BackColor = Color.White;
                Si.BackColor = Color.White;
            }
            else MessageBox.Show("Такой октавы не существует");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Do_Click_1(object sender, EventArgs e)
        {
            u = 0;
            Task.Run(Play);
        }

        private void Re_Click(object sender, EventArgs e)
        {
            u = 2;
            Task.Run(Play);
        }

        private void Mi_Click(object sender, EventArgs e)
        {
            u = 4;
            Task.Run(Play);
        }

        private void Fa_Click(object sender, EventArgs e)
        {
            u = 5;
            Task.Run(Play);
        }

        private void Sol_Click(object sender, EventArgs e)
        {
            u = 7;
            Task.Run(Play);
        }

        private void La_Click(object sender, EventArgs e)
        {
            u = 9;
            Task.Run(Play);
        }

        private void Si_Click(object sender, EventArgs e)
        {
            u = 11;
            Task.Run(Play);
        }

        private void Dodiez_Click(object sender, EventArgs e)
        {
            u = 1;
            Task.Run(Play);
        }

        private void Rediez_Click(object sender, EventArgs e)
        {
            u = 3;
            Task.Run(Play);
        }

        private void Fadiez_Click(object sender, EventArgs e)
        {
            u = 6;
            Task.Run(Play);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            NOct.Enabled = true;
            Do.Enabled = false;
            Re.Enabled = false;
            Mi.Enabled = false;
            Fa.Enabled = false;
            Sol.Enabled = false;
            La.Enabled = false;
            Si.Enabled = false;
            Dodiez.Enabled = false;
            Rediez.Enabled = false;
            Fadiez.Enabled = false;
            Soldiez.Enabled = false;
            Ladiez.Enabled = false;
            for (b = a; b > 1; b--)
            {
                for (int i = 0; i < 12; i++)
                {
                    oct[0] = 12;
                    oct[i] = oct[i] + i;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (p == 0)
            {
                pictureBox1.Show();
                p++;
            }
            else
            {
                pictureBox1.Visible = false;
                p = 0;
            }
        }

        private void Soldiez_Click(object sender, EventArgs e)
        {
            u = 8;
            Task.Run(Play);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ladiez_Click(object sender, EventArgs e)
        {
            u = 10;
            Task.Run(Play);
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if ((keyData & Keys.D) == Keys.D)
            {
                u = 0;
                Task.Run(Play);
            }
            if((keyData & Keys.E) == Keys.E)
            {
                u = 1;
                Task.Run(Play);
            }
            if ((keyData & Keys.S) == Keys.S)
            {
                u = 2;
                Task.Run(Play);
            }
            if ((keyData & Keys.R) == Keys.R)
            {
                u = 3;
                Task.Run(Play);
            }
            if ((keyData & Keys.F) == Keys.F)
            {
                u = 4;
                Task.Run(Play);
            }
            if ((keyData & Keys.G) == Keys.G)
            {
                u = 5;
                Task.Run(Play);
            }
            if ((keyData & Keys.Y) == Keys.Y)
            {
                u = 6;
                Task.Run(Play);
            }
            if ((keyData & Keys.H) == Keys.H)
            {
                u = 7;
                Task.Run(Play);
            }
            if ((keyData & Keys.U) == Keys.U)
            {
                u = 8;
                Task.Run(Play);
            }
            if ((keyData & Keys.J) == Keys.J)
            {
                u = 9;
                Task.Run(Play);
            }
            if ((keyData & Keys.I) == Keys.I)
            {
                u = 10;
                Task.Run(Play);
            }
            if ((keyData & Keys.K) == Keys.K)
            {
                u = 11;
                Task.Run(Play);
            }
            return base.ProcessCmdKey(ref message, keyData);
        }
    }
}

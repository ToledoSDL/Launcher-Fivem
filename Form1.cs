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

namespace Launcher_Complexo_do_Acre
{
    public partial class AcreRP : Form
    {
        public AcreRP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/complexodoacre.com.br");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/complexodoacre");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/complexodoacre/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/XsSaMGW");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"ts3server://complexodoacre.go4host.com.br");
        }
    }
}

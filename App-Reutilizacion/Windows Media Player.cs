using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Reutilizacion
{
    public partial class Windows_Media_Player : Form
    {
        public Windows_Media_Player()
        {
            InitializeComponent();
        }

        private void btn_cargar_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtBox_ruta.Text = openFileDialog1.FileName;
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = txtBox_ruta.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }

}

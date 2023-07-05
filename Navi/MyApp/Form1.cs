using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyApp
{
    public partial class Form1 : Form
    {
        private List<string> playlist;
        private int currentSongIndex;
        private bool isPlaying;

        public Form1()
        {
            InitializeComponent();
            playlist = new List<string>();
            currentSongIndex = -1;
            isPlaying = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoopButton(object sender, EventArgs e)
        {

        }

        private void PreviousButton(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                PlaySong();
            }
        }

        private void PlaySong()
        {
            if (currentSongIndex >= 0 && currentSongIndex < playlist.Count)
            {
                SoundPlayer player = new SoundPlayer(playlist[currentSongIndex]);
                player.Play();
                isPlaying = true;
            }
        }

        private void PauseButton(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                SoundPlayer player = new SoundPlayer();
                player.Stop();
                isPlaying = false;
            }
            else
            {
                if (currentSongIndex >= 0 && currentSongIndex < playlist.Count)
                {
                    PlaySong();
                }
            }
        }

        private void NextButton(object sender, EventArgs e)
        {
            if (currentSongIndex < playlist.Count - 1)
            {
                currentSongIndex++;
                PlaySong();
            }
        }

        private void PlaylistButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Wav Files (*.wav|*.wav";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedSong = openFileDialog.FileName;
                playlist.Add(selectedSong);

                if (!isPlaying)
                {
                    currentSongIndex = 0;
                    PlaySong();
                }
            }
        }
    }
}

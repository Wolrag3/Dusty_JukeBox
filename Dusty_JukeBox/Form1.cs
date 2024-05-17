using NAudio;
using NAudio.Wave;
using System.Windows.Forms;

namespace Dusty_JukeBox
{
    public partial class _playButton : Form
    {
        public _playButton()
        {
            InitializeComponent();
        }

        public int Song_index = 0;

        public int Song_count;

        private WaveOut waveOut;

        private void _openFiledialog_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    _songsList.Items.Add(fileName);
                }
            }
        }
        private void _songsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //       public class _playing() { 

        //     }
        private void _play_button_Click(object sender, EventArgs e)
        {
            _playing();
        }
        public void _playing()
        {
            if (_songsList.SelectedItem != null)
            {
                string selectedFilePath = _songsList.SelectedItem.ToString();
                Song_index = _songsList.SelectedItems.IndexOf(selectedFilePath);
                Song_count = _songsList.Items.Count;

                using (var audioFileReader = new AudioFileReader(selectedFilePath))
                {
                    if (waveOut == null)
                    {
                        waveOut = new WaveOut(); // Create the WaveOut object if it's null
                        waveOut.PlaybackStopped += WaveOut_PlaybackStopped; // Subscribe to the PlaybackStopped event
                    }

                    waveOut.Init(audioFileReader);
                    waveOut.Play();
                }
            }
            else
            {
                MessageBox.Show("Please select a file");
            }
        }
/*
        public void _Play(int index)
        {
            string selectedFilePath = _songsList.Items[index].ToString();

            using (var audioFileReader = new AudioFileReader(selectedFilePath))
            {
                using (var waveOut = new WaveOut())
                {
                    waveOut.Init(audioFileReader);
                    waveOut.Play();

                    waveOut.PlaybackStopped += (sender, args) =>
                    {
                        // Playback stopped, perform any cleanup or additional actions here
                        waveOut.Dispose(); // Dispose the WaveOut object to release resources
                    };

                    // Note: This method will return immediately, and playback will occur asynchronously
                }
            }
        }
  */
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Playback stopped, perform any cleanup or additional actions here
            waveOut.Dispose(); // Dispose the WaveOut object to release resources
            waveOut = null; // Set the WaveOut object to null
        }

        private void _stop_Click(object sender, EventArgs e)
        {
            if (waveOut != null && (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused))
            {
                waveOut.Stop();
            }
        }

        private void _previous_button_Click(object sender, EventArgs e)
        {
            if (waveOut != null && (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused))
            {
                //waveOut.

            }
        }

        private void _next_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void _repeat_button_Click(object sender, EventArgs e)
        {
            while (true)
            {

            }
        }

        private void _shuffle_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next();
            if (randomNumber >= Song_count)
            {
                randomNumber = random.Next();
            }
            else
            {
                
            }

        }

        private void _playButton_Load(object sender, EventArgs e)
        {

        }
    }
}

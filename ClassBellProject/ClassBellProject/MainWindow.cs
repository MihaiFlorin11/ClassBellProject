using ClassBellProject.Gymnasium;
using ClassBellProject.Primary;
using System.Media;

namespace ClassBellProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SoundPlayer soundPlayerForATonePrimary = new SoundPlayer();
        SoundPlayer soundPlayerForAToneGymnasium = new SoundPlayer();

        public string[] GetAllTonesPrimary()
        {
            string[] names = Directory.GetCurrentDirectory().Split("\\");
            string namesComposed = string.Empty;
            foreach (string name in names)
            {
                if (name.Contains("bin"))
                {
                    break;
                }
                namesComposed = namesComposed + name + "\\";
            }
            namesComposed = namesComposed + "Tones Primary";
            string[] files = Directory.GetFiles(namesComposed);

            return files;
        }

        public string[] GetAllTonesGymnasium()
        {
            string[] names = Directory.GetCurrentDirectory().Split("\\");
            string namesComposed = string.Empty;
            foreach (string name in names)
            {
                if (name.Contains("bin"))
                {
                    break;
                }
                namesComposed = namesComposed + name + "\\";
            }
            namesComposed = namesComposed + "Tones Gymnasium";
            string[] files = Directory.GetFiles(namesComposed);

            return files;
        }

        public decimal GetNumberOfSecondsOfATonePrimary(string toneLength)
        {
            FileInfo fileInfo = new FileInfo(toneLength);
            int sample_rate = 44100;
            int bit_depth = 16;
            int channels = 2;
            long file_size = fileInfo.Length;
            decimal duration = file_size / (sample_rate * (bit_depth / 8) * channels);
            decimal result = Math.Round(duration);

            return result;
        }

        public decimal GetNumberOfSecondsOfAToneGymnasium(string toneLength)
        {
            FileInfo fileInfo = new FileInfo(toneLength);
            int sample_rate = 44100;
            int bit_depth = 16;
            int channels = 2;
            long file_size = fileInfo.Length;
            decimal duration = file_size / (sample_rate * (bit_depth / 8) * channels);
            decimal result = Math.Round(duration);

            return result;
        }

        public async Task StartAToneByPositionPrimaryAsync(int position)
        {
            string[] tonesPrimary = GetAllTonesPrimary();
            soundPlayerForATonePrimary.SoundLocation = tonesPrimary[position];
            decimal songDuration = GetNumberOfSecondsOfATonePrimary(tonesPrimary[position]);
            int interval = (int)(songDuration * 1000);
            soundPlayerForATonePrimary.Play();
            await Task.Delay(5000);
        }

        public async Task StartAToneByPositionGymnasiumAsync(int position)
        {
            string[] tonesGymnasium = GetAllTonesGymnasium();
            soundPlayerForAToneGymnasium.SoundLocation = tonesGymnasium[position];
            decimal songDuration = GetNumberOfSecondsOfAToneGymnasium(tonesGymnasium[position]);
            int interval = (int)(songDuration * 1000);
            soundPlayerForAToneGymnasium.Play();
            await Task.Delay(5000);
        }

        private void buttonPrimary_Click(object sender, EventArgs e)
        {
            PrimaryMainWindow primaryMainWindow = new PrimaryMainWindow();
            if (!primaryMainWindow.Visible)
            {
                primaryMainWindow.Show();
                buttonPrimary.Enabled = false;
            }
            primaryMainWindow.FormClosed += delegate
            {
                buttonPrimary.Enabled = true;
            };
        }

        private void buttonGymnasium_Click(object sender, EventArgs e)
        {
            GymnasiumMainWindow gymnasiumMainWindow = new GymnasiumMainWindow();
            if (!gymnasiumMainWindow.Visible)
            {
                gymnasiumMainWindow.Show();
                buttonGymnasium.Enabled = false;
            }
            gymnasiumMainWindow.FormClosed += delegate
            {
                buttonGymnasium.Enabled = true;
            };
        }

        private async void buttonStartEntranceTonePrimary_Click(object sender, EventArgs e)
        {
            await StartAToneByPositionPrimaryAsync(0);
        }

        private async void buttonStartExitTonePrimary_Click(object sender, EventArgs e)
        {
            await StartAToneByPositionPrimaryAsync(1);
        }

        private async void buttonStartEntranceToneGymnasium_Click(object sender, EventArgs e)
        {
            await StartAToneByPositionGymnasiumAsync(0);
        }

        private async void buttonStartExitToneGymnasium_Click(object sender, EventArgs e)
        {
            await StartAToneByPositionGymnasiumAsync(1);
        }
    }
}

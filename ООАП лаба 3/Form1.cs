using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;
namespace ООАП_лаба_3
{
    public partial class Form1 : Form
    {
        private TrackEnumerator trackEnumerator;
        SoundPlayer play = null;
        string fileName = string.Empty;

        private WaveOutEvent outputDevice; // Объект для воспроизведения аудио с помощью NAudio.
        private AudioFileReader audioFile; // Объект для чтения аудиофайла из файла и передачи его на воспроизведение.

        private TimeSpan currentPosition; // Переменная для хранения текущей позиции воспроизведения аудио.
        public Form1()
        {
            InitializeComponent();
            Start();
        }


        // Объявление класса TrackEnumerator.
        public class TrackEnumerator
        {
            private readonly List<Track> tracks;
            // Приватное поле tracks типа List<Track>, которое хранит список треков.
            private int currentPosition;
            // Приватное поле currentPosition типа int, которое хранит текущую позицию в списке треков.

            public TrackEnumerator(List<Track> tracks)
            {
                this.tracks = tracks;
                currentPosition = -1;
                // Устанавливаем начальное значение currentPosition равным -1, что обозначает, что текущая позиция в списке треков не определена.
            }

            public Track Current
            {
                // Свойство Current типа Track.
                get // Геттер свойства Current.
                {
                    if (currentPosition >= 0 && currentPosition < tracks.Count)
                    {
                        // Проверяем, находится ли currentPosition в пределах допустимого диапазона индексов треков.
                        return tracks[currentPosition];
                        // Если currentPosition находится в пределах допустимого диапазона, возвращаем трек с соответствующим индексом из списка треков.
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public bool MoveNext()
            {
                if (currentPosition < tracks.Count - 1)
                {
                    // Проверяем, не находимся ли мы на последней позиции в списке треков.
                    currentPosition++;
                    return true;
                    // Возвращаем true, чтобы указать, что перемещение выполнено успешно.
                }
                return false;
            }


            public bool MovePrevious()
            {
                if (currentPosition > 0)
                {
                    // Уменьшаем currentPosition на 1, чтобы переместиться к предыдущему треку в списке.
                    currentPosition--;
                    return true;
                }
                return false;
            }
        }
        public class Track
        {
            public string singer { get; }
            public string name { get; }
            public string time { get; }

            public Track(string singer, string name, string time)
            {
                this.singer = singer;
                this.name = name;
                this.time = time;
            }


        }

        public class Player
        {
            public List<Track> Tracks { get; } = new List<Track>();

            public void AddTrack(string singer, string name, string time)
            {
                Tracks.Add(new Track(singer, name, time));
            }
        }

        public void Start()
        {
            play = new SoundPlayer();
            Player player = new Player();
            player.AddTrack("Alla Pugacheva", "Leto", "2:23");
            player.AddTrack("Alliance", "Na zare", "3:35");
            player.AddTrack("Forum", "Belaya noch'", "1:56");

            trackEnumerator = new TrackEnumerator(player.Tracks);

            //DisplayCurrentTrack();
        }
        private void DisplayCurrentTrack()
        {
            // Выводим название текущего трека на экран формы
            singer_label.Text = trackEnumerator.Current.singer;
            name_label.Text = trackEnumerator.Current.name;
            time_label.Text = trackEnumerator.Current.time;
            fileName = "C:\\Users\\slava\\source\\repos\\mucis\\" + trackEnumerator.Current.name + ".wav";
            //play.SoundLocation = fileName;

            PlayAudio(fileName);
            //play.Play();


        }

        private void PlayAudio(string fileName)
        {
            if (System.IO.File.Exists(fileName))
            {
                if (outputDevice != null)
                {
                    outputDevice.Dispose(); // Освобождаем ресурсы текущего outputDevice, если он существует.
                }

                audioFile = new AudioFileReader(fileName); // Создаем новый объект AudioFileReader для чтения аудио из файла.
                outputDevice = new WaveOutEvent();  // Создаем новый объект WaveOutEvent для воспроизведения аудио.
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
            else
            {
                MessageBox.Show("Аудиофайл не найден.");
            }
        }

        private void back_butt_Click(object sender, EventArgs e)
        {
            if (trackEnumerator.MovePrevious())
            {
                DisplayCurrentTrack();
            }
            else
            {
                MessageBox.Show("Это первый трек в плейлисте.");
            }

        }

        private void forward_butt_Click(object sender, EventArgs e)
        {
            if (trackEnumerator.MoveNext())
            {
                DisplayCurrentTrack();
            }
            else
            {
                MessageBox.Show("Это последний трек в плейлисте.");
            }

        }

        private void stop_button_Click(object sender, EventArgs e)
        {

            if (outputDevice != null)
            {
                outputDevice.Stop();
                currentPosition = audioFile.CurrentTime;
            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {

            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Stopped)
            {
                audioFile.CurrentTime = currentPosition;
                outputDevice.Play();
            }
        }

       
    }
}










/*using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ООАП_лаба_3
{
    public partial class Form1 : Form
    {
        SoundPlayer play = null;
        string fileName = string.Empty;
        private Player player;
        private int currentPosition;

        public Form1()
        {
            play = new SoundPlayer();
            InitializeComponent();
            Start();
        }

        public class Track
        {
            public string singer { get; }
            public string name { get; }
            public string time { get; }

            public Track(string singer, string name, string time)
            {
                this.singer = singer;
                this.name = name;
                this.time = time;
            }
        }

        public class Player
        {
            public List<Track> Tracks { get; } = new List<Track>();

            public void AddTrack(string singer, string name, string time)
            {
                Tracks.Add(new Track(singer, name, time));
            }
        }

        private void Start()
        {
            player = new Player();
            player.AddTrack("artist 1", "song1", "2:23");
            player.AddTrack("artist 2", "song2", "3:35");
            player.AddTrack("artist 3", "song3", "1:56");

            currentPosition = 0;

            //DisplayCurrentTrack();
        }

        private void DisplayCurrentTrack()
        {
            if (currentPosition >= 0 && currentPosition < player.Tracks.Count)
            {
                singer_label.Text = player.Tracks[currentPosition].singer;
                name_label.Text = player.Tracks[currentPosition].name;
                time_label.Text = player.Tracks[currentPosition].time;
                fileName = "C:\\Users\\slava\\source\\repos\\mucis\\" + player.Tracks[currentPosition].name + ".wav";
                play.SoundLocation = fileName;
                play.Play();
            }
        }

        private void back_butt_Click(object sender, EventArgs e)
        {
            if (currentPosition > 0)
            {
                currentPosition--;
                DisplayCurrentTrack();
            }
            else
            {
                MessageBox.Show("Это первый трек в плейлисте.");
            }
        }

        private void forward_butt_Click(object sender, EventArgs e)
        {
            if (currentPosition < player.Tracks.Count - 1)
            {
                currentPosition++;
                DisplayCurrentTrack();
            }
            else
            {
                MessageBox.Show("Это последний трек в плейлисте.");
            }
        }
        private void stop_button_Click(object sender, EventArgs e)
        {
            play.Stop();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            play.Play();
        }
    }
}
*/
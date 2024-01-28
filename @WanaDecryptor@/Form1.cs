using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _WanaDecryptor_
{
    public partial class Form1 : Form
    {
        public string napis = "";

        /// <summary>
        /// Film https://www.youtube.com/watch?v=UTHxSoydWpk
        /// </summary>

        public DateTime past_time;
        public Form1()
        {
            InitializeComponent();

            checking_payment_box.Hide();
            time_left_timer.Start();

            read_date();
            time_left(new object(), new EventArgs());

            lang_list.SelectedIndex = 0;

            new Thread(() => 
            {
                Thread.Sleep(10000);
            }).Start();
        }

        public static class data_converting
        {
            public static string encrypting(DateTime time)
            {
                Random random = new();
                int randomNumber = random.Next(1, 10);

                string output = time.Day.ToString("D2") + time.Month.ToString("D2") + time.Year.ToString() + time.Hour.ToString("D2") + time.Minute.ToString("D2") + time.Second.ToString("D2");
                output = szyfr_cezara.Encrypt(output, randomNumber);
                output += randomNumber.ToString();

                return output;
            }

            public static DateTime decrypting(string text)
            {
                string date = text[..^1];
                int key = Int32.Parse(text[^1..]);

                date = szyfr_cezara.Decrypt(date, key);

                return DateTime.ParseExact(date, "ddMMyyyyHHmmss", null);
            }
        };

        public static class szyfr_cezara
        {
            public static string Encrypt(string input, int shift)
            {
                string result = "";

                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                    {
                        int num = (int)char.GetNumericValue(c);
                        num = (num + shift) % 10;
                        result += num.ToString();
                    }
                    else result += c;
                }
                return result;
            }

            public static string Decrypt(string input, int shift)
            {
                string result = "";

                foreach (char c in input)
                {
                    if (char.IsDigit(c))
                    {
                        int num = (int)char.GetNumericValue(c);
                        num = (num - shift + 10) % 10;
                        result += num.ToString();
                    }
                    else result += c;
                }
                return result;
            }
        };

        void set_labels(DateTime first, DateTime second, DateTime past_time_)
        {
            date1.Text = first.Day.ToString("D2") + "/" + first.Month.ToString("D2") + "/" + first.Year.ToString("D2") + "   " + first.Hour.ToString("D2") + ":" + first.Minute.ToString("D2") + ":" + first.Second.ToString("D2");
            date2.Text = second.Day.ToString("D2") + "/" + second.Month.ToString("D2") + "/" + second.Year.ToString("D2") + "   " + second.Hour.ToString("D2") + ":" + second.Minute.ToString("D2") + ":" + second.Second.ToString("D2");

            past_time = past_time_;
        }

        void read_date()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string taskDataPath = Path.Combine(folderPath, "TaskData");
            string filePath = Path.Combine(taskDataPath, "rev_t.wncry");

            if (!Directory.Exists(taskDataPath))
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(taskDataPath);
                directoryInfo.Attributes |= FileAttributes.Hidden;

            }
            if (!File.Exists(filePath))
            {
                DateTime time = DateTime.Now;
                set_labels(time.AddDays(3), time.AddDays(7), time);

                File.WriteAllText(filePath, data_converting.encrypting(time));
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
            }
            else
            {
                DateTime time = data_converting.decrypting(File.ReadAllText(filePath));

                set_labels(time.AddDays(3), time.AddDays(7), time);
            }
        }

        private void check_payment(object sender, EventArgs e)
        {
            timer.Start();
            label8.Text = "";
            checking_payment_box.Show();
            connecting_bar.Value = 0;
            timer.Interval = 225;
        }

        private void decrypt_files(object sender, EventArgs e)
        {
            Form form = new()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                TopMost = true,
                Text = "Decrypt",
                BackColor = Color.FromArgb(255, 133, 27, 16),

                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X + 130, this.Location.Y),

                ShowIcon = false,
                MinimizeBox = false,
                MaximizeBox = false,

                Size = new Size(580, 618)
            };

            ///////////////////////////

            Label label1 = new()
            {
                Text = "Select a host to decrypt and click Start",
                BackColor = Color.FromArgb(133, 27, 16),
                ForeColor = Color.FromArgb(240, 240, 240),

                Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold),
                Size = new Size(300, 30),
                Location = new Point(4, 7)
            };

            form.Controls.Add(label1);

            ///////////////////////////

            ComboBox comboBox = new();

            comboBox.Items.Add("My Computer");
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.Size = new Size(380, 5);
            comboBox.Location = new Point(7, 40);

            form.Controls.Add(comboBox);

            ///////////////////////////

            Button start_btn = przycisk_decrypt("Start", new Point(399, 35));

            start_btn.Size = new Size(160, 35);
            form.Controls.Add(start_btn);

            Button close_btn = przycisk_decrypt("Cancel", new Point(385, 535));

            close_btn.Click += new EventHandler((sender, e) => form.Close());
            form.Controls.Add(close_btn);

            Button copy_clipboard_btn = przycisk_decrypt("Copy to clipboard", new Point(185, 535));
            form.Controls.Add(copy_clipboard_btn);

            ///////////////////////////

            Label label2 = new()
            {
                Font = new Font("Segoe UI", 8),
                Text = "Path",

                BackColor = Color.FromArgb(249, 250, 251),

                Location = new Point(12, 86),
                Size = new Size(30, 13)
            };

            form.Controls.Add(label2);

            //////////////////////////

            PictureBox pictureBox = new()
            {
                BackColor = Color.White,
                BackgroundImage = Properties.Resources.header_picture,
                BackgroundImageLayout = ImageLayout.Stretch,

                Size = new Size(550, 25),
                Location = new Point(7, 81)
            };
            pictureBox.BringToFront();

            form.Controls.Add(pictureBox);

            ///////////////////////////

            ListBox listBox = new()
            {
                SelectionMode = SelectionMode.None,

                Size = new Size(552, 439),
                Location = new Point(6, 80)
            };

            form.Controls.Add(listBox);

            ///////////////////////////

            form.ShowDialog();
            removing_files(false);
        }

        static Button przycisk_decrypt(string text, Point location)
        {
            Button btn = new()
            {
                FlatStyle = FlatStyle.Popup,
                BackColor = Color.FromArgb(230, 230, 230),
                Size = new Size(170, 35),

                Location = location,
                Text = text,

                Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold)
            };

            return btn;
        }

        private void copy_wallet(object sender, EventArgs e) { Clipboard.SetText("AbCdEfGhIjKlMnOpRsTuVwXyZAbC"); }

        private void cancel_checking_Click(object sender, EventArgs e)
        {
            checking_payment_box.Hide();
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 225)
            {
                timer.Interval = 1325;
                label8.Text = "Connecting to server...";
            }
            else if (timer.Interval == 3475)
            {
                cancel_checking_Click(sender, e);
                MessageBox.Show("Cannot connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (connecting_bar.Value < 14)
            {
                connecting_bar.Value += 3;
                if (connecting_bar.Value == 6) timer.Interval = 1525;
                else if (connecting_bar.Value == 9)
                {
                    timer.Interval = 1850;
                    connecting_bar.Value += 5;
                }
            }
            else timer.Interval = 3475;
        }

        private void links(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Label label = (dynamic)sender;
            string url;

            if (label.Text == "About bitcoin") url = "https://en.wikipedia.org/wiki/Bitcoin";
            else if (label.Text == "How to buy bitcoin?") url = "https://www.forbes.com/advisor/investing/cryptocurrency/how-to-buy-bitcoin/";
            else url = "https://github.com/Zakrzewiaczek";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void time_left(object sender, EventArgs e)
        {
            TimeSpan raise_time_left = past_time.AddDays(3) - DateTime.Now;
            TimeSpan lost_time_left = past_time.AddDays(7) - DateTime.Now;

            bar1.Size = (raise_time_left > TimeSpan.Zero) ? new Size(bar1.Size.Width, map(raise_time_left.TotalSeconds, 0, 259200, 110, 10) + 10) : new Size(bar1.Size.Width, 120);
            bar2.Size = (raise_time_left > TimeSpan.Zero) ? new Size(bar1.Size.Width, map(lost_time_left.TotalSeconds, 0, 604800, 110, 10) + 10) : new Size(bar1.Size.Width, 120);

            if (raise_time_left <= TimeSpan.Zero)
            {
                raise_time_left = TimeSpan.Zero;
                label1.Text = "Send 600$ worth of bitcoin to this adress:";
            }
            if (lost_time_left <= TimeSpan.Zero) removing_files(true);

            label10.Text = string.Format("{0:dd\\:hh\\:mm\\:ss}", raise_time_left);
            label11.Text = string.Format("{0:dd\\:hh\\:mm\\:ss}", lost_time_left);
        }

        public static int map(double value, int in_min, int in_max, int out_min, int out_max)
        {
            return (int)((value - in_min) * (out_max - out_min) / (in_max - in_min) + out_min);
        }

        private static void removing_files(bool all_files)
        //if all_files == true => Delete all files
        //if all_files == false => Delete some random files (preferably from the visible desktop)
        {
            
        }
    }
}

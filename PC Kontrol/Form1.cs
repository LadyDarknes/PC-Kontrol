using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
using System.Linq;
using System.Net.NetworkInformation;

namespace PC_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(224, 206, 255);
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kodunuz
        }
        private void ramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get total memory size
                var memorySize = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
                double memorySizeInGB = memorySize / (1024.0 * 1024.0 * 1024.0);

                // Get available memory size
                var availableMemory = new PerformanceCounter("Memory", "Available Bytes");
                availableMemory.NextValue();
                System.Threading.Thread.Sleep(1000);
                double availableMemoryInMB = availableMemory.NextValue() / (1024.0 * 1024.0);

                // Show results
                richTextBox1.Text += string.Format("Toplam Bellek Boyutu: {0:F2} GB\nKullanılabilir Bellek: {1:F2} MB\n", memorySizeInGB, availableMemoryInMB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bellek bilgisi alınamadı. Hata mesajı: " + ex.Message);
            }
        }

        private void işlemciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get processor name
                string processorName = "";
                var searcher = new System.Management.ManagementObjectSearcher("select * from Win32_Processor");
                foreach (var obj in searcher.Get())
                {
                    processorName = obj["Name"].ToString();
                    break;
                }

                // Get processor usage
                var usageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                usageCounter.NextValue();
                System.Threading.Thread.Sleep(1000);
                double usagePercent = usageCounter.NextValue();

                // Show results
                richTextBox1.Text += string.Format("İşlemci: {0}\nİşlemci Kullanımı: {1:F2}%\n", processorName, usagePercent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlemci bilgisi alınamadı. Hata mesajı: " + ex.Message);
            }
        }


        private void ekranKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get GPU name
                string gpuName = "";
                var searcher = new System.Management.ManagementObjectSearcher("select * from Win32_VideoController");
                foreach (var obj in searcher.Get())
                {
                    gpuName = obj["Name"].ToString();
                    break;
                }

                // Show results
                richTextBox1.Text += string.Format("Ekran Kartı: {0}\n", gpuName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekran kartı bilgisi alınamadı. Hata mesajı: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void ramTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of the Process class
                Process process = new Process();

                // Set the StartInfo properties of the process
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c echo 1 > /proc/sys/kernel/sysrq && echo s > /proc/sysrq-trigger && echo u > /proc/sysrq-trigger && echo b > /proc/sysrq-trigger";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;

                // Start the process
                process.Start();

                // Display success message
                MessageBox.Show("RAM temizlendi!");

                // Clear the rich text box
                richTextBox1.Clear();

                Application.Exit();
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("RAM temizlenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void ramAnalizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ramAnalizForm = new Form2();

            // Formu görüntüleyin
            ramAnalizForm.Show();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Ping the localhost
                var pingSender = new System.Net.NetworkInformation.Ping();
                var reply = pingSender.Send("localhost");

                // Get the local IP address
                string localIP = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                    .SelectMany(n => n.GetIPProperties().UnicastAddresses)
                    .Where(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !System.Net.IPAddress.IsLoopback(a.Address))
                    .Select(a => a.Address.ToString())
                    .FirstOrDefault();

                // Construct the message to send to Discord webhook
                string message = string.Format("Bilgisayarın IP adresi: {0}\nPing süresi: {1} ms\nTarih-zaman: {2}", localIP, reply.RoundtripTime, DateTime.Now);

                // Create an anonymous object to hold the message content
                var payload = new { content = message };

                // Serialize the object to JSON
                string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);

                // Send the JSON payload to Discord webhook
                using (var client = new System.Net.WebClient())
                {
                    client.Headers.Add("Content-Type", "application/json");
                    var response = client.UploadString("https://discord.com/api/webhooks/1102574827447005204/az9S6zQ97IVcDfFEX4ds4NmMkeyN6Dk0vZlMVqvS36FSA115NATi2MSvXm8ErSOpDgiw", "POST", jsonPayload);
                }

                // Display success message
                MessageBox.Show("Ping değeri Discord webhook'a gönderildi!");

            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Ping değeri gönderilirken bir hata oluştu: " + ex.Message);
            }
        }


    }
}

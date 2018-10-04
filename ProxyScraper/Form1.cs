using System;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace ProxyScraper
{
    public partial class ProxyScraper : Form
    {
        private class MyWebClient : WebClient //Sets the default attributes for the WebClient class
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 600;
                return w;
            }
        }

        int count = 0;
        int sourceCount = 0;
        List<string> goodURLS = new List<string>();

        protected override void WndProc(ref Message m) // Make the window draggable
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public ProxyScraper() // Initialize and remove old file
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            if (File.Exists("ScrapedProxies.txt"))
                File.Delete("ScrapedProxies.txt");
        }

        private void BTN_Load_Click(object sender, EventArgs e) // Open file dialog to select sources.txt file (1 URL per line)
        {
            string sourcesTxtFile;

            OpenFileDialog fileDialog = new OpenFileDialog();

            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);

            fileDialog.InitialDirectory = currentPath;
            fileDialog.Filter = "txt files (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            fileDialog.FileName = "Proxy Sources";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                sourcesTxtFile = fileDialog.FileName;
                TB_Sources.Text = sourcesTxtFile;
                using (StreamReader r = new StreamReader(sourcesTxtFile))
                {
                    sourceCount = 0;
                    while (r.ReadLine() != null) { sourceCount++; }
                }
                LABEL_NumberOfSources.Text = sourceCount.ToString();
                BTN_Gather.Enabled = true;
            }
            else
            {
                TB_Sources.Text = "NO SOURCES SELECTED";
            }
        }
    
        private async void BTN_Gather_Click(object sender, EventArgs e) // Loop through the sources list & call 'GetProxy' for each URL
        {
            count = 0;
            BTN_Gather.Enabled = false;
            TB_Proxies.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(TB_Sources.Text))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        await Task.Run(() => GetProxy(line));
                        sourceCount--;
                        LABEL_NumberOfSources.Text = sourceCount.ToString();
                    }
                }
            }
            catch (Exception)
            {
                TB_Sources.Text = "NO SOURCES SELECTED";
            }
        }

        public void GetProxy(string url) // GetProxy downloads the URL site data via HTTP and uses regex to extract proxies
        {    
            MyWebClient wc = new MyWebClient();
            try
            {
                string data = wc.DownloadString(url);

                string pattern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\:\d{1,5}";

                MatchCollection matches = Regex.Matches(data, pattern);
                if (matches.Count > 0)
                {
                    string prox = "";
                    foreach (Match match in matches)
                    {
                        prox = prox + match.Groups[0].Value + Environment.NewLine;
                        count++;
                    }
                    LABEL_NumberOfProxies.Text = count.ToString();
                    TB_Proxies.AppendText(prox);
                    goodURLS.Add(url);
                }
                wc.Dispose();
            }
            catch (Exception)
            {
                wc.Dispose();
            }            
        }

        private void BTN_Quit_Click(object sender, EventArgs e) // Saves & exits
        {
            BTN_Save_Click(sender, e);
            Application.Exit();
        }

        private void BTN_Save_Click(object sender, EventArgs e) //Saves scraped proxies to file & remove duplicates
        {
            if (!File.Exists("ScrapedProxies.txt"))
            {
                var proxies = TB_Proxies.Lines.Distinct();
                File.WriteAllLines("ScrapedProxies.txt", proxies);
            }
        }

        private void BTN_saveurls_Click(object sender, EventArgs e)
        {
            if (!File.Exists("GoodURLS.txt"))
            {
                var urls = goodURLS.Distinct();
                File.WriteAllLines("GoodURLS.txt", urls);
            }
        }
    }
}
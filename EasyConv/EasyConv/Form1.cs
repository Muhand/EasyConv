using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyConv
{
    public partial class EasyConv : Form
    {
        //Properties
        Stream fileStream;
        OpenFileDialog m3u8Dialog;
        string[] fileLines;
        List<Channel> channels;

        //private int progrMax;

        //public int ProgrMax
        //{
        //    get { return progrMax; }
        //    set
        //    {
        //        progrMax = value;
        //        progrValue = string.Format("{0}/{1}", progrCurrent, ProgrMax);
        //        progressBar1.Maximum = value;
        //    }
        //}

        //private int progrCurrent;

        //public int ProgrCurrent
        //{
        //    get { return progrCurrent; }
        //    set
        //    {
        //        progrCurrent = value;
        //        //PropValue = propCurrent + "/" + propmax
        //        progrValue = string.Format("{0}/{1}",progrCurrent,ProgrMax);
        //        progressBar1.Value = value;
        //    }
        //}

        //private string progrValue;

        //public string ProgrValue
        //{
        //    get { return progrValue; }
        //    set
        //    {
        //        progrValue = value;
        //        progress.Text = value;
        //    }
        //}

        BackgroundWorker congfigureBg;
        BackgroundWorker writeToFileBg;



        public EasyConv()
        {
            InitializeComponent();
            fileStream = null;
            m3u8Dialog = new OpenFileDialog();
            fileLines = null;
            //ProgrMax = 0;
            //progrCurrent = 0;
            channels = new List<Channel>();

            congfigureBg = new BackgroundWorker();
            congfigureBg.DoWork += congfigureBg_DoWork;
            congfigureBg.ProgressChanged += congfigureBg_ProgressChanged;
            congfigureBg.RunWorkerCompleted += CongfigureBg_RunWorkerCompleted;
            congfigureBg.WorkerReportsProgress = true;

            writeToFileBg = new BackgroundWorker();
            writeToFileBg.DoWork += writeToFileBg_DoWork;
            writeToFileBg.ProgressChanged += writeToFileBg_ProgressChanged;
            writeToFileBg.WorkerReportsProgress = true;


            m3u8Dialog.InitialDirectory = "c:\\";
            //m3u8Dialog.InitialDirectory = @"C:\Users\Muhand\Desktop\IPTV Channels\arabic.m3u";
            m3u8Dialog.Filter = "m3u files (*.m3u)|*.m3u|m3u8 files (*.m3u8)|*.m3u8";
            m3u8Dialog.FilterIndex = 1;
            m3u8Dialog.RestoreDirectory = true;
            m3u8Dialog.Multiselect = false;
        }

        private void CongfigureBg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = channels.Count;
            writeToFileBg.RunWorkerAsync();
        }

        private void congfigureBg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //progress.Text = e.ProgressPercentage.ToString();
            progress.Text = string.Format("{0}/{1}", e.ProgressPercentage, progressBar1.Maximum);
        }

        private void congfigureBg_DoWork(object sender, DoWorkEventArgs e)
        {
            configure();
        }

        private void writeToFileBg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //progress.Text = e.ProgressPercentage.ToString();
            progress.Text = string.Format("{0}/{1}",e.ProgressPercentage,progressBar1.Maximum);
        }

        private void writeToFileBg_DoWork(object sender, DoWorkEventArgs e)
        {
            writeToFile();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if(m3u8Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = m3u8Dialog.OpenFile()) != null)
                    {
                        dirTxt.Text = m3u8Dialog.FileName;
                        writeToLog(dirTxt.Text + " was opened successfuly.");
                        convertBtn.Enabled = true;
                        fileLines = File.ReadAllLines(dirTxt.Text);
                        writeToLog("Read: "+fileLines.Length + " lines."+Environment.NewLine);
                    }
                    else
                    {
                        convertBtn.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    //log.Text += ("Error: Could not read file from disk. Original error: "+ex.Message);
                    writeToLog("Error: Could not read file from disk. Original error: " + ex.Message);
                    convertBtn.Enabled = false;
                }
                finally
                {
                    fileStream.Close();
                }
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            congfigureBg.RunWorkerAsync();
        }

        private void writeToLog(string message)
        {
            Action action = () => log.AppendText(message + Environment.NewLine);
            log.Invoke(action);
            //log.AppendText(message + Environment.NewLine);
            //log.ScrollToCaret();
            action = () => log.ScrollToCaret();
            log.Invoke(action);
        }

        private void configure()
        {
            writeToLog("Configuring channels..." + Environment.NewLine);
            //progressBar1.Maximum = fileLines.Length;
            //ProgrMax = fileLines.Length;
            //congfigureBg.ReportProgress(0);

            if (fileLines[0] != "#EXTM3U" && fileLines[0] != "#EXTM3U8")
            {
                writeToLog("Error, wrong heading, this file must include #EXTM3U or #EXTM3U8 as the first line.");
                convertBtn.Enabled = false;
                return;
            }

            //progrCurrent = 1;
            
            Action action = () => progressBar1.Maximum = fileLines.Length;
            log.Invoke(action);
            congfigureBg.ReportProgress(1);
            int errors = 0;
            int inc = 1;
            string URLagent = null;

            for (int i = 1; i < fileLines.Length; i += inc)
            {
                string newline = fileLines[i];
                if (newline != "" && newline != "#EXTM3U")
                {
                    inc = 2;
                    Channel temp = new Channel();
                    string[] trimmed = newline.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine("Configuring channel #" + i);

                    //Check if this is a URL or info
                    if (trimmed.Length > 0)
                    {
                        if (trimmed[0] == "#EXTINF")
                        {
                            string[] channelInfo = trimmed[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            string channelName = channelInfo[1];
                            temp.ChannelName = channelName;
                            temp.ChannelURL = fileLines[i + 1] + URLagent;
                            channels.Add(temp);
                            writeToLog("Configuring channel #" + i + " (" + channelName + ") was successful.");
                            URLagent = null;
                        }
                        else if (trimmed[0] == "#EXTVLCOPT")
                        {
                            URLagent = trimmed[1];
                            inc = 1;
                        }
                        else
                        {
                            errors++;
                            Console.WriteLine("Configuring channel #" + i + " had an error");
                            URLagent = null;
                        }
                    }
                }
                else
                    inc = 1;

                congfigureBg.ReportProgress(i);
            }

            writeToLog(Environment.NewLine + "Configuration is finised" + Environment.NewLine + Environment.NewLine +
                "*********************************************************************");

            writeToLog(channels.Count + " channels have been configured successfully.");
            writeToLog(errors + " channels were not configured successfully." + Environment.NewLine);
            writeToLog("***********************************************************************");

            //congfigureBg.ReportProgress(100);
        }

        private void writeToFile()
        {
            writeToLog("Now writing to channels.mama" + Environment.NewLine);
            //progrCurrent = 0;
            //ProgrMax = channels.Count;
            writeToFileBg.ReportProgress(0);
            try
            {
                //StreamWriter w = new StreamWriter("channels_" + DateTime.Now.ToString("dd-MM-yyyy") + ".mama");
                StreamWriter w = new StreamWriter(fileName.Text);

                using (w)
                {
                    for (int i = 0; i < channels.Count; i++)
                    {
                        writeToLog(channels[i].ToString());

                        //w.WriteLine(string.Format("{0}\n{1}\n---------------------"), channels[i].ChannelName, channels[i].ChannelURL);
                        w.WriteLine(channels[i].ChannelName + Environment.NewLine + channels[i].ChannelURL + Environment.NewLine + "---------------------");

                        writeToLog("Written successfully");
                        writeToLog("----------------------------------------------" + Environment.NewLine);
                        writeToFileBg.ReportProgress(i+1);
                    }
                }
                w.Close();
                writeToLog(channels.Count+ " channels were written to channels.mama successfully");
            }
            catch (Exception ex)
            {
                writeToLog(String.Format("There was an error writing to channels.mama, original error is: {0}", ex.Message));
            }
        }

        private void resetFileName_Click(object sender, EventArgs e)
        {
            fileName.Text = "channels.mama";
        }
    }
}

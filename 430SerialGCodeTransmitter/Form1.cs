using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace _430SerialGCodeTransmitter
{
    public partial class Form1 : Form
    {
        static public string[] GcodeLines;
        static bool fileLoaded = false;
        static int lineIndex = 0;
        static SerialPort spMCU;
        static bool LineStarted = false;
        static bool AutoSend = false;
        static bool SendAll = false;
        static bool RoundValues = false;
        static int ObjectCount = 0;
        static int ObjectsSent = 0;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPorts.DataSource = SerialPort.GetPortNames();
            cboBaudRate.SelectedIndex = 0;
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            cbPorts.DataSource = SerialPort.GetPortNames();
            if (spMCU != null)
            {
                if (cbPorts.Items.Contains(spMCU.PortName))
                    cbPorts.SelectedValue = spMCU.PortName;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            fdSourceFile.ShowDialog();
        }

        private void fdSourceFile_FileOk(object sender, CancelEventArgs e)
        {
            fileLoaded = false;
            lineIndex = 0;
            this.txtFile.Text = fdSourceFile.FileName;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {

                GcodeLines = System.IO.File.ReadAllLines(this.txtFile.Text.Trim());
                fileLoaded = true;
                lineIndex = 0;
                txtOutput.Clear();
                txtOutput.Text += "File loaded: " + this.txtFile.Text.Trim() + "\r\n";
                //for (int i = 0; i < GcodeLines.Length; i++)
                //{
                //    txtOutput.Text += GcodeLines[i] + "\r\n";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alert while opening: " + ex.ToString());

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbPorts.SelectedValue.ToString()))
            {
                if (spMCU != null)
                    if (spMCU.IsOpen)
                    {
                        spMCU.Dispose();
                        spMCU = null;
                    }
                int baudRate;
                if (!int.TryParse(cboBaudRate.SelectedText.ToString(), out baudRate))
                    baudRate = 9600;

                spMCU = new SerialPort(cbPorts.SelectedValue.ToString(), baudRate);
                PrepSerial();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (spMCU != null)
                if (spMCU.IsOpen)
                {
                    spMCU.Dispose();
                    spMCU = null;
                }
        }
        static private bool SendLine()
        {
            bool success = false;
            try
            {
                if (spMCU != null)
                {
                    if (fileLoaded)
                    {
                        if (!spMCU.IsOpen)
                            spMCU.Open();
                        while (lineIndex < GcodeLines.Length && !(GcodeLines[lineIndex].StartsWith("G")))
                        {
                            lineIndex++;
                        }
                        if (lineIndex < GcodeLines.Length)
                        {
                            if (GcodeLines[lineIndex].StartsWith("G01"))
                                LineStarted = true;
                            else if (GcodeLines[lineIndex].StartsWith("G00") && LineStarted == true)
                            {
                                LineStarted = false;
                                ObjectsSent++;
                            }
                            GcodeLines[lineIndex] = GcodeLines[lineIndex].Trim() + " "; //faster transmission without whitespace
                            if (RoundValues && GcodeLines[lineIndex].StartsWith("G0"))
                            {
                                string[] splitVals = GcodeLines[lineIndex].Split(' ');
                                double tmpStorage;
                                for (int i = 0; i < splitVals.Length; i++)
                                {
                                    //find any decimal values and round to whole integers before transmission
                                    if(double.TryParse(splitVals[i],out tmpStorage))
                                    {
                                        splitVals[i] = Convert.ToInt32(tmpStorage).ToString();
                                    }
                                }
                                string toRet = string.Join(" ", splitVals).Trim() + " ";
                                spMCU.WriteLine(toRet);
                                System.Diagnostics.Debug.WriteLine(toRet);
                            }
                            else
                            {
                                spMCU.WriteLine(GcodeLines[lineIndex]);
                                System.Diagnostics.Debug.WriteLine(GcodeLines[lineIndex]);
                            }
                            
                            success = true;
                            lineIndex++;
                        }
                        else
                            LineStarted = false;
                    }
                    else
                        MessageBox.Show("File not loaded");
                }
                else
                {
                    if (fileLoaded)
                    {
                        MessageBox.Show("not connected");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on sending : " + ex.ToString());
            }
            return success;
        }
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (spMCU == null)
                MessageBox.Show("Not connected");
            else
            {
                txtOutput.Text += "Sending object " + ObjectsSent.ToString() + "\r\n";
                SendLine();
            }
        }
        private void PrepSerial()
        {
            spMCU.BaudRate = 9600;
            //rest of the default settings should be fine
            spMCU.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            //MessageBox.Show(indata);
            System.Diagnostics.Debug.WriteLine(indata);
            if (((AutoSend && LineStarted) | SendAll) && lineIndex < GcodeLines.Length)
                SendLine();
        }

        private void chkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            AutoSend = chkAutoSend.Checked;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            int objects = 0, lines = 0;
            bool inObject = false;
            for (int i = 0; i < GcodeLines.Length; i++)
            {
                if (GcodeLines[i].StartsWith("G"))
                {
                    lines++;
                    if (GcodeLines[i].StartsWith("G01"))
                    {
                        inObject = true;
                    }
                    else if (inObject == true)
                    {
                        objects++;
                        inObject = false;
                    }
                }
            }
            ObjectCount = objects;
            ObjectsSent = 0;
            this.txtOutput.Text += string.Format("Code lines: {0}.  Objects: {1}", lines, objects);
            this.txtOutput.Text += "\r\n";
        }

        private void chkSendAll_CheckedChanged(object sender, EventArgs e)
        {
            SendAll = chkSendAll.Checked;
        }

        private void chkRound_CheckedChanged(object sender, EventArgs e)
        {
            RoundValues = chkRound.Checked;
        }
    }
}

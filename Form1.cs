using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;
using NAudio.CoreAudioApi;

using System.Runtime.InteropServices;
//using VolumeControl.Library.Constants;
//using VolumeControl.Library.Structs;


namespace Xterra2Input
{
    public partial class Form1 : Form
    {
        float _dbLevel = 0;
        float _threshold = 0.4f;

        MMDeviceEnumerator deviceEnumerator;
        MMDeviceCollection devices;
        MMDevice microphone;

        SendInputs si;

        public Form1()
        {
            InitializeComponent();

            si = new SendInputs();
            PopulateKeyList();
            var waveIn = new WaveIn();
            waveIn.StartRecording();
            loopWorker.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (devices != null)
            {
                microphone = devices.FirstOrDefault();
            }

            if (microphone == null)
            {
                deviceEnumerator = new MMDeviceEnumerator();
                devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);

                if (devices != null)
                {
                    microphone = devices.FirstOrDefault();
                }

                if (microphone == null)
                {
                    Application.Exit();
                }
            }

            while (microphone != null)
            {
                _dbLevel = microphone.AudioMeterInformation.MasterPeakValue;

                if (_dbLevel > _threshold)
                {
                    loopWorker.ReportProgress((int)(_dbLevel * 100));
                    System.Threading.Thread.Sleep((int)inputDelay.Value);
                }
                else
                {
                    loopWorker.ReportProgress(0);
                }
                System.Threading.Thread.Sleep(5);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((enableButtonPresses.Checked) && (keyComboBox.SelectedItem != null) && ((_dbLevel > _threshold)))
            {
                si.SendKeyInput(((keyComboBoxItem)keyComboBox.SelectedItem).value);
                System.Threading.Thread.Sleep(50);
                si.SendKeyUpInput(((keyComboBoxItem)keyComboBox.SelectedItem).value);
            }

            _threshold = (float)threshhold.Value;
            peakValue.Text = string.Format("{0} - {1}", _dbLevel.ToString(), e.ProgressPercentage);

            if (micDb.Value < e.ProgressPercentage)
                micDb.Value = 101;
            micDb.Value = Math.Min(101, Math.Max(0, e.ProgressPercentage));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }

        private void PopulateKeyList()
        {
            //foreach (SendInputs.ScanCodeShort keyCode in (SendInputs.ScanCodeShort[]) Enum.GetValues(typeof(SendInputs.ScanCodeShort)))
            //{
            //    keyComboBox.Items.Add(new keyComboBoxItem() { name = Enum.GetName(typeof(SendInputs.ScanCodeShort), keyCode), value = keyCode });
            //}

            SendInputs.ScanCodeShort[] scanCodes = (SendInputs.ScanCodeShort[])Enum.GetValues(typeof(SendInputs.ScanCodeShort));

            foreach (string keyName in Enum.GetNames(typeof(SendInputs.ScanCodeShort)))
            {
                if ((keyName.Length >= 4) && (keyName.Substring(0, 4) == "KEY_"))
                {
                    keyComboBox.Items.Add(new keyComboBoxItem() { name = keyName, value = scanCodes.Where(p => p.ToString() == keyName).FirstOrDefault() });
                }
            }

            keyComboBox.Sorted = true;
        }

        internal class keyComboBoxItem
        {
            internal string name;
            internal SendInputs.ScanCodeShort value;

            public override string ToString()
            {
                return name;
            }
        }
    }
}

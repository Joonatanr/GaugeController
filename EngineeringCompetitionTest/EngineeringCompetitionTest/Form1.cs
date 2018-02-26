using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCompetitionTest.ScriptHandler;

namespace EngineeringCompetitionTest
{
    public partial class GaugeSimulator : Form
    {
        private SerialPort portMSSIM;
        private SerialPort portPSP;
        private ScriptReader myScriptReader;

        private const Decimal SpeedConversionFactor = 0.1M;
        private const Decimal RPMConversionFactor = 700M;

        private int myFrequency = 0;
        private Decimal myVoltage;

        public GaugeSimulator()
        {
            InitializeComponent();
            populateCOMPorts();
            
            /* Voltage gauge */

            GaugeControl.GaugeTickMarker marker = new GaugeControl.GaugeTickMarker(gaugeVoltage.ArcRadius);

            marker.BeginAngle = gaugeVoltage.ArcStartAngle;
            marker.EndAngle = gaugeVoltage.ArcEndAngle;
            marker.Width = 2;
            marker.Height = 7;
            marker.markerColor = Color.White;
            marker.IntervalAngle = gaugeVoltage.NumberMarkerAngleInterval / 2;
            gaugeVoltage.AddMarker(marker);
            

            /* RPM gauge */

            GaugeControl.GaugeTickMarker rpm_marker = new GaugeControl.GaugeTickMarker(gaugeRPM.ArcRadius + 8);
            rpm_marker.BeginAngle = gaugeRPM.ArcStartAngle;
            rpm_marker.EndAngle = gaugeRPM.ArcEndAngle;
            rpm_marker.Width = 3;
            rpm_marker.Height = 8;
            rpm_marker.markerColor = Color.White;
            rpm_marker.IntervalAngle = gaugeRPM.NumberMarkerAngleInterval;

            GaugeControl.GaugeTickMarker rpm_secondary_marker = new GaugeControl.GaugeTickMarker(gaugeRPM.ArcRadius + 5);
            rpm_secondary_marker.BeginAngle = gaugeRPM.ArcStartAngle;
            rpm_secondary_marker.EndAngle = gaugeRPM.ArcEndAngle;
            rpm_secondary_marker.Width = 2;
            rpm_secondary_marker.Height = 5;
            rpm_secondary_marker.markerColor = Color.White;
            rpm_secondary_marker.IntervalAngle = gaugeRPM.NumberMarkerAngleInterval / 5;

            gaugeRPM.AddMarker(rpm_marker);
            gaugeRPM.AddMarker(rpm_secondary_marker);
        }

        private void populateCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            string[] secondports = new string[ports.Length];
            ports.CopyTo(secondports, 0);

            comboBoxPSPPortSelect.DataSource = ports; 
            comboBoxMSSIM2Port.DataSource = secondports;
        }

        private void buttonOpenPSPPort_Click(object sender, EventArgs e)
        {
            if(comboBoxPSPPortSelect.SelectedItem != null)
            {
                try
                {
                    portPSP = new SerialPort(comboBoxPSPPortSelect.SelectedItem.ToString(), 2400);
                    portPSP.NewLine = "\r\n";
                    portPSP.Open();

                    printLine("Opened COM port for PSP : "+ portPSP.PortName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Got exception : ", ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("No COM port selected");
            }
        }

        private void buttonOpenMSSIMPort_Click(object sender, EventArgs e)
        {
            if (comboBoxMSSIM2Port.SelectedItem != null)
            {
                try
                {
                    portMSSIM = new SerialPort(comboBoxMSSIM2Port.SelectedItem.ToString(), 115200);
                    portMSSIM.NewLine = "\r\n";
                    portMSSIM.Open();
                    printLine("Opened COM port for MSSIM2 : " + portMSSIM.PortName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Got exception : ", ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("No COM port selected");
            }
        }

        private void buttonClosePSPPort_Click(object sender, EventArgs e)
        {
            if (portPSP != null)
            {
                portPSP.Close();
            }
        }

        private void buttonCloseMSSIMPort_Click(object sender, EventArgs e)
        {
            if(portMSSIM != null)
            {
                portMSSIM.Close();
            }
        }

        private void numericUpDownVoltage_ValueChanged(object sender, EventArgs e)
        {
            UpdateRpmValues(numericUpDownVoltage.Value);
            /*
            if (portPSP != null)
            {
                if (portPSP.IsOpen)
                {
                    string command = String.Format("SV {0}", numericUpDownVoltage.Value.ToString("00.00"));
                    command = command.Replace(',', '.');
                    gaugeVoltage.Value = numericUpDownVoltage.Value;
                    gaugeRPM.Value = getRPMFromVoltage(numericUpDownVoltage.Value);
                    portPSP.WriteLine(command);
                }
                else
                {
                    printLine("Error : PSP port not open");
                }
            }
            else
            {
                printLine("Error : PSP port not set");
            }
            */
        }



        private void numericUpDownFrequency_ValueChanged(object sender, EventArgs e)
        {
            UpdateSpeedValues(numericUpDownFrequency.Value);
            /*
            if (portMSSIM != null)
            {
                if (portMSSIM.IsOpen)
                {
                    Decimal freq = numericUpDownFrequency.Value;
                    gaugeFrequency.Value = freq;
                    gaugeSpeed.Value = getSpeedFromFrequency(freq);
                    string command = "F:" + freq;
                    portMSSIM.WriteLine(command);
                }
                else
                {
                    printLine("Error : MSSIM2 port not open");
                }
            }
            else
            {
                printLine("Error : MSSIM2 port not set");
            }
            */
        }

        private Decimal getRPMFromVoltage(Decimal voltage)
        {
            //voltage 0.0 - 5.0V
            //RPM 0 - 3000 RPM.
            return voltage * RPMConversionFactor;
        }

        private Decimal getVoltageFromRPM(Decimal RPM)
        {
            return RPM / RPMConversionFactor;
        }

        private Decimal getSpeedFromFrequency(Decimal freq)
        {
            //Frequency 0 - 2000 Hz
            //Speed 0-200 km/H
            //return freq / 10;
            return freq * SpeedConversionFactor;
        }

        private Decimal getFrequencyFromSpeed(Decimal speed)
        {
            return speed / SpeedConversionFactor;
        }

        private void UpdateGaugesFromMeasurement(Measurement m)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Measurement>(UpdateGaugesFromMeasurement), new object[] { m } );
            }
            else
            {
                Decimal frequency = getFrequencyFromSpeed(m.SpeedValue);
                Decimal voltage = getVoltageFromRPM(m.RPMValue);

                UpdateRpmValues(voltage);
                UpdateSpeedValues(frequency);
                
            }
        }


        //We use voltage as "master" value.
        private void UpdateRpmValues(Decimal voltage)
        {
            Decimal rpm_value = getRPMFromVoltage(voltage);

            gaugeRPM.Value = rpm_value;
            gaugeVoltage.Value = voltage;

            /* Hopefully using these if clauses will prevent infinite calls. */
            if (numericUpDownRPM.Value != rpm_value)
            {
                numericUpDownRPM.Value = rpm_value;
            }

            if (numericUpDownVoltage.Value != voltage)
            {
                numericUpDownVoltage.Value = voltage;
            }

            sendVoltageCommand(voltage);
        }

        private void UpdateSpeedValues(Decimal frequency)
        {
            Decimal speed_value = getSpeedFromFrequency(frequency);
            gaugeSpeed.Value = speed_value;
            gaugeFrequency.Value = frequency;

            if (numericUpDownFrequency.Value != frequency)
            {
                numericUpDownFrequency.Value = frequency;
            }

            if (numericUpDownSpeed.Value != speed_value)
            {
                numericUpDownSpeed.Value = speed_value;
            }

            sendFrequencyCommand(frequency);
        }


        private void buttonRunScript_Click(object sender, EventArgs e)
        {
            printLine("Starting script.");
            if (textBoxFileName.Text == null)
            {
                printLine("Error : No script file selected");
                return;
            }

            //myScriptReader = new ScriptReader("Script1.csv");
            myScriptReader = new ScriptReader(textBoxFileName.Text);

            int numberOfPoints = myScriptReader.ReadMeasurementsFromFile();
            printLine("Read :" + numberOfPoints + " points");

            
            SetNumericButtons(false);

            myScriptReader.Listener = new ScriptReader.MeasurementListener(UpdateGaugesFromMeasurement);
            myScriptReader.CompleteListener = new ScriptReader.ScriptCompleteListener(ScriptComplete);
            myScriptReader.PlayScript();
        }

        private void ScriptComplete()
        {
            this.Invoke(new Action<bool>(SetNumericButtons), new object[] { true });
        }

        private void SetNumericButtons(bool mode)
        {
            numericUpDownFrequency.Enabled = mode;
            numericUpDownRPM.Enabled = mode;
            numericUpDownSpeed.Enabled = mode;
            numericUpDownVoltage.Enabled = mode;
        }

        private void sendFrequencyCommand(Decimal frequency)
        {
            if (myFrequency != (int)frequency)
            {
                string command = "F" + (int)frequency;
                try
                {
                    //printLine("Sent command : " + command);
                    portMSSIM.WriteLine(command);
                }
                catch (Exception ex)
                {
                    printLine(ex.Message);
                }
                myFrequency = (int)frequency;
            }
        }

        private void sendVoltageCommand(Decimal voltage)
        {
            if (voltage != myVoltage)
            {
                string command = String.Format("SV {0}", voltage.ToString("00.00"));
                command = command.Replace(',', '.');
                try
                {
                    portPSP.WriteLine(command);
                }
                catch (Exception ex)
                {
                    printLine(ex.Message);
                }
                myVoltage = voltage;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myScriptReader != null)
            {
                myScriptReader.StopScript();
            }

            if (portMSSIM != null)
            {
                portMSSIM.Close();
            }

            if (portPSP != null)
            {
                portPSP.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadScriptFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.FileName;
            }
        }

        private void gaugeVoltage_Load(object sender, EventArgs e)
        {

        }

        private void printLine(String line)
        {
            if (richTextBox1.InvokeRequired)
            {
                this.Invoke(new Action<string>(printLine), new object[] { line });
            }
            else
            {
                richTextBox1.AppendText(line + Environment.NewLine);
            }
        }

        private void numericUpDownRPM_ValueChanged(object sender, EventArgs e)
        {   
            UpdateRpmValues(getVoltageFromRPM(numericUpDownRPM.Value));
        }

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            UpdateSpeedValues(getFrequencyFromSpeed(numericUpDownSpeed.Value));
        }
    }
}

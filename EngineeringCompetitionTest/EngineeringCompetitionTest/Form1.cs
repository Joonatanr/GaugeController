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

            /* Initialize these to empty values. */
            portPSP = new SerialPort();
            portMSSIM = new SerialPort();
            
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

        private void DiscoverDevicesOnCom()
        {
            String [] names = SerialPort.GetPortNames();
            Boolean isPSPFound = false;
            Boolean isMSSIMFound = false;

            try
            {
                portMSSIM.Close();
            }
            catch (Exception)
            {
                printLine("Could not close MSSIM COM port");
            }

            try
            {
                portPSP.Close();
            }
            catch (Exception)
            {
                printLine("Could not close PSP COM port");
            }

            foreach (String name in names)
            {
                printLine("Checking port " + name);
                if (isPSPFound == false)
                {
                    if (isPortPSP(name, ref portPSP))
                    {
                        printLine("Found PSP on port: " + name);
                        isPSPFound = true;
                        continue;
                    }
                }

                if (isMSSIMFound == false)
                {
                    if (isPortMSSIM2(name, ref portMSSIM))
                    {
                        printLine("Found MSSIM2 on port: " + name);
                        isMSSIMFound = true;
                    }
                }
            }
        }

        private Boolean isPortMSSIM2(String name, ref SerialPort output)
        {
            Boolean result = false;
            SerialPort myPort = new SerialPort(name, 115200);
            myPort.ReadTimeout = 500;
            myPort.WriteTimeout = 500;
            myPort.NewLine = "\r\n";
            myPort.DtrEnable = true;

            try
            {
                myPort.Open();
                /* Lets clear any existing data from the buffer */
                myPort.WriteLine(" ");
                try
                {
                    myPort.ReadLine();
                }
                catch (TimeoutException)
                {

                }

                myPort.WriteLine("RF");

                try
                {
                    String response = myPort.ReadLine();
                    //printLine("Response is : " + response);
                    if (response.Contains("- RTSS f"))
                    {
                        output = myPort;
                        result = true;
                    }
                }
                catch (TimeoutException)
                {
                    
                }
            }
            catch (Exception ex)
            {
                printLine("Exception : " + ex.Message);
            }

            if (myPort.IsOpen && result == false)
            {
                /* TODO - Should actually use this port... */
                myPort.Close();
            }
            return result;
        }

        private Boolean isPortPSP(String name, ref SerialPort Output)
        {
            Boolean result = false;
            SerialPort myPort = new SerialPort(name, 2400);
            String response;

            myPort.ReadTimeout = 1500;
            myPort.WriteTimeout = 1000;
            myPort.NewLine = "\r";
            myPort.DtrEnable = true;

            /* Check if this is the PSP */
            try
            {
                myPort.Open();
                myPort.WriteLine("L");
                try
                {
                    response = myPort.ReadLine();
                    if (isResponseFromPSP(response))
                    {
                        Output = myPort;
                        result = true;
                    }

                }
                catch (TimeoutException)
                {
                    //printLine("Timed out");
                }
            }
            catch (Exception ex)
            {
                printLine("Exception : " + ex.Message);
            }

            if (myPort.IsOpen && result == false)
            {
                myPort.Close();
            }
            return result;
        }

        private Boolean isResponseFromPSP(String response)
        {
            List<char> prefixCharacters = new List<char>() { 'V', 'A', 'W', 'U', 'I', 'P', 'F' };
            //printLine("Got response " + response);

            foreach (char c in prefixCharacters)
            {
                if (!response.Contains<char>(c))
                {
                    return false;
                }
            }

            return true;
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
        }



        private void numericUpDownFrequency_ValueChanged(object sender, EventArgs e)
        {
            UpdateSpeedValues(numericUpDownFrequency.Value);
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

            if (rpm_value >= 3000)
            {
                RedLamp.Value = true;
                AmberLamp.Value = false;
                greenLamp.Value = false;
            }
            else if(rpm_value >= 2500)
            {
                RedLamp.Value = false;
                AmberLamp.Value = true;
                greenLamp.Value = false;
            }
            else
            {
                RedLamp.Value = false;
                AmberLamp.Value = false;
                greenLamp.Value = true; //This is not actually in the solution, just want to test green lamp-
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
            if (!portMSSIM.IsOpen || !portPSP.IsOpen)
            {
                printLine("Devices not connected, cannot start script, press autoconnect to automatically discover connected devices");
                return;
            }

            if (String.IsNullOrEmpty(textBoxFileName.Text))
            {
                printLine("Error : No script file selected");
                return;
            }

            myScriptReader = new ScriptReader(textBoxFileName.Text);

            try
            {
                int numberOfPoints = myScriptReader.ReadMeasurementsFromFile();
                printLine("Read :" + numberOfPoints + " points");
            }
            catch (NullReferenceException)
            {
                printLine("Failed to read measurement points from file");
                return;
            }

            try
            { 
                SetNumericButtons(false);
                printLine("Starting script.");
                myScriptReader.Listener = new ScriptReader.MeasurementListener(UpdateGaugesFromMeasurement);
                myScriptReader.CompleteListener = new ScriptReader.ScriptCompleteListener(ScriptComplete);
                myScriptReader.PlayScript();
            }
            catch (Exception ex)
            {
                printLine("Could not load script " + ex.Message);
            }
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

        private void GaugeSimulator_Load(object sender, EventArgs e)
        {
            //DiscoverDevicesOnCom();
        }

        private void GaugeSimulator_Shown(object sender, EventArgs e)
        {
            //DiscoverDevicesOnCom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscoverDevicesOnCom();
        }
    }
}

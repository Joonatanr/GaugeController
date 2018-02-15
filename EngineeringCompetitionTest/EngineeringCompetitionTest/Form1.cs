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
    public partial class Form1 : Form
    {
        private SerialPort portMSSIM;
        private SerialPort portPSP;

        private ScriptReader myScriptReader;

        public Form1()
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

            
            GaugeControl.GaugeLabel voltageText = new GaugeControl.GaugeLabel("Voltage");
            voltageText.Text = "V-DC";
            voltageText.Offset = new PointF(0, 20);
            voltageText.TextColor = Color.OrangeRed;

            gaugeVoltage.AddGaugeLabel(voltageText);
            

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

            /* Frequency gauge */

            /* TODO : Add markers. */

            /* Speed gauge*/
            GaugeControl.GaugeTickMarker speed_marker = new GaugeControl.GaugeTickMarker(gaugeSpeed.ArcRadius - 3);
            speed_marker.BeginAngle = gaugeSpeed.ArcStartAngle;
            speed_marker.EndAngle = gaugeSpeed.ArcEndAngle;
            speed_marker.Width = 2;
            speed_marker.Height = 6;
            speed_marker.markerColor = Color.White;
            speed_marker.IntervalAngle = gaugeSpeed.NumberMarkerAngleInterval / 5;

            gaugeSpeed.AddMarker(speed_marker);
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
                    printLine("Opened COM port for MSSIM2 : " + portPSP.PortName);
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
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

        private void numericUpDownFrequency_ValueChanged(object sender, EventArgs e)
        {
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
        }

        private Decimal getRPMFromVoltage(Decimal voltage)
        {
            //voltage 0.0 - 5.0V
            //RPM 0 - 3000 RPM.
            return voltage * 600;
        }

        private Decimal getSpeedFromFrequency(Decimal freq)
        {
            //Frequency 0 - 2000 Hz
            //Speed 0-200 km/H
            return freq / 10;
        }

        private void UpdateGaugesFromMeasurement(Measurement m)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Measurement>(UpdateGaugesFromMeasurement), new object[] { m } );
            }
            else
            {
                int frequency = m.SpeedValue * 10;
                Decimal voltage = (Decimal)m.RPMValue / 600;
                
                gaugeFrequency.Value = frequency;
                gaugeVoltage.Value = voltage;
                gaugeRPM.Value = m.RPMValue;
                gaugeSpeed.Value = m.SpeedValue;

                sendVoltageCommand(voltage);
                /* TODO : Uncomment this. */
                //sendFrequencyCommand(frequency);
            }
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
            myScriptReader.Listener = new ScriptReader.MeasurementListener(UpdateGaugesFromMeasurement);
            myScriptReader.PlayScript();
        }


        private void sendFrequencyCommand(int frequency)
        {
            string command = "F:" + frequency;
            try
            {
                portMSSIM.WriteLine(command);
            }
            catch (Exception ex)
            {
                printLine(ex.Message);
            }
        }

        private void sendVoltageCommand(Decimal voltage)
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myScriptReader != null)
            {
                myScriptReader.StopScript();
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
    }
}

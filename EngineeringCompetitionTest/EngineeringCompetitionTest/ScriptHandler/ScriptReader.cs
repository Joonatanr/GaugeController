using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EngineeringCompetitionTest.ScriptHandler
{
    /// <summary>
    /// Purpose of this class is to read RPM and Speed data from csv files.
    /// </summary>
    public class Measurement
    {
        public int DeltaTimeValue;
        public int SpeedValue;
        public int RPMValue;

        public Measurement(int TimeValue, int SpeedValue, int RPMValue)
        {
            this.DeltaTimeValue = TimeValue;
            this.SpeedValue = SpeedValue;
            this.RPMValue = RPMValue;
        }

        public override string ToString()
        {
            return "T: " + DeltaTimeValue + " Speed : " + SpeedValue + " RPM: " + RPMValue;
        }
    }


    public class ScriptReader
    {
        public delegate void MeasurementListener(Measurement m);
        public delegate void ScriptCompleteListener();

        public List<Measurement> Measurements = new List<Measurement>();

        public MeasurementListener Listener = null;
        public ScriptCompleteListener CompleteListener = null;

        private String filePath;
        private Thread myThread;

        public ScriptReader(String filePath)
        {
            this.filePath = filePath;
        }

        public int ReadMeasurementsFromFile()
        {
            using (var reader = new StreamReader(filePath))
            {
                Measurements = new List<Measurement>();
                int lineNum = 0;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] lines = line.Split(';');
                    lineNum++;

                    if (lines[0] == "Time")
                    {
                        //This is the header line, do nothing
                    }
                    else
                    {
                        int time;
                        int speed;
                        int rpm;

                        if (int.TryParse(lines[0], out time) == false)
                        {
                            throw new Exception("Failed to parse time on line" + lineNum);
                        }

                        if (int.TryParse(lines[1], out speed) == false)
                        {
                            throw new Exception("Failed to parse speed on line" + lineNum);
                        }

                        if (int.TryParse(lines[2], out rpm) == false)
                        {
                            throw new Exception("Failed to parse time" + lineNum);
                        }

                        Measurement m = new Measurement(time, speed, rpm);
                        Measurements.Add(m);
                    }
                }
            }

            return Measurements.Count;
        }

        public void PlayScript()
        {
            myThread = new Thread(new ThreadStart(MyThreadMethod));
            myThread.Start();
        }

        public void StopScript()
        {
            if (myThread != null)
            {
                myThread.Abort();
            }
        }


        private void MyThreadMethod()
        {
            if (Measurements == null)
            {
                return;
            }

            if (Measurements.Count == 0)
            {
                return;
            }

            foreach (Measurement m in Measurements)
            {
                Thread.Sleep(m.DeltaTimeValue);
                if (Listener != null)
                {
                    Listener.Invoke(m);
                }
            }

            //Script has finished here.
            CompleteListener?.Invoke();
        }
    }
}

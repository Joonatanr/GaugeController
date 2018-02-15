using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCompetitionTest.ScriptHandler
{
    /// <summary>
    /// Purpose of this class is to read RPM and Speed data from csv files.
    /// </summary>
    public class Measurement
    {
        public int TimeValue;
        public int SpeedValue;
        public int RPMValue;

        public Measurement(int TimeValue, int SpeedValue, int RPMValue)
        {
            this.TimeValue = TimeValue;
            this.SpeedValue = SpeedValue;
            this.RPMValue = RPMValue;
        }
    }


    public class ScriptReader
    {
        public List<Measurement> Measurements = new List<Measurement>();

        private String filePath;

        public ScriptReader(String filePath)
        {
            this.filePath = filePath;
        }

        public void ReadMeasurementsFromFile()
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
        }
    }
}

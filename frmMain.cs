using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumSharp.Core;


namespace Keithley2461
{
    public partial class frmMain : Form
    {
        public int intChart = 1;
        public NDArray arrData;
        public int intNumberOfEntries;

        public frmMain()
        {
            InitializeComponent();
        }

        private void CalculateRs()
        {
            double k = 1.3806488 * Math.Pow(10, -23); //units = J/K
            double q = 1.602 * Math.Pow(10, -19); //units = coulomb
            double T = Convert.ToDouble(txtTemp.Text) + 273.15; //converts temperature from degC to deg K
            int n = Convert.ToInt16(txtNCells.Text); //number of cells in the module
            double Ilow = Convert.ToDouble(txtRsCalculateLow.Text); //Low current to use to calculate the Rs
            double Ihigh = Convert.ToDouble(txtRsCalculateHigh.Text);//High current to use to calculate the Rs
            double Iavg = (Ilow + Ihigh) / 2; //Iaverage to use to calculate the Rs
            double Vlow = -1;
            double Vhigh = -1;

            //=====================================
            //Calculate Rs
            //=====================================
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                //Find Ilow
                if (Convert.ToDouble(arrData[1, i]) == Ilow)
                {
                    Vlow = Convert.ToDouble(arrData[2, i]);

                }
                else if ((Convert.ToDouble(arrData[1, i]) < Ilow) && (Convert.ToDouble(arrData[1, i + 1]) > Ilow))
                {
                    double slope = ((Convert.ToDouble(arrData[2, i + 1]) - Convert.ToDouble(arrData[2, i])) / (Convert.ToDouble(arrData[1, i + 1]) - Convert.ToDouble(arrData[1, i])));
                    Vlow = slope * (Ilow - Convert.ToDouble(arrData[1, i])) + Convert.ToDouble(arrData[2, i]);
                }

                //Find Ihigh
                if (Convert.ToDouble(arrData[1, i]) == Ihigh)
                {
                    Vhigh = Convert.ToDouble(arrData[2, i]);

                }
                else if ((Convert.ToDouble(arrData[1, i]) < Ihigh) && (Convert.ToDouble(arrData[1, i + 1]) > Ihigh))
                {
                    double slope = ((Convert.ToDouble(arrData[2, i + 1]) - Convert.ToDouble(arrData[2, i])) / (Convert.ToDouble(arrData[1, i + 1]) - Convert.ToDouble(arrData[1, i])));
                    Vhigh = slope * (Ihigh - Convert.ToDouble(arrData[1, i])) + Convert.ToDouble(arrData[2, i]);
                }



            }

            //Calculate Rs
            double Rs = (Vhigh - Vlow) / (Ihigh - Ilow) - (Convert.ToDouble(n) * k * T) / (q * Iavg);
            lblRsEstimate.Text = Math.Round(Rs, 4).ToString();

            //=====================================
            //Write Rs File
            //=====================================

            var RsTitle = new StringBuilder();
            var DataAppend = new StringBuilder();

            var header = "Sample Name, Date time, Series Resistance (Ohms), Bias limit, Bias voltage, Delay, Limit Value, N cells, Number of Pulses, Off Time, " +
                "Pulse Width, RsCalculateHigh, RsCalculateLow, Start Value, Stop Value, Temperature, Timeout";
            string timestamp = DateTime.Now.ToString();

            var txtAppend = txtSampleName.Text + ", " + timestamp + ", " + lblRsEstimate.Text + ", " + txtBiasLimit.Text + ", " + txtBiasVoltage.Text + ", " + txtDelay.Text + ", " +
                txtLimitValue.Text + ", " + txtNCells.Text + ", " + txtNumberPulses.Text + ", " + txtOffTime.Text + ", " +
                txtPulseWidth.Text + ", " + txtRsCalculateHigh.Text + ", " + txtRsCalculateLow.Text + ", " +
                txtStartValue.Text + ", " + txtStopValue.Text + ", " + txtTemp.Text + ", " +
                txtTimeOut.Text + "\n";

            RsTitle.AppendLine(header);
            DataAppend.Append(txtAppend);

            //Checks to see if the file already exist
            if (File.Exists(txtFilePath.Text + "Keithley2461_FileOutput.csv") == false)
            {
                //Creates the file header
                File.WriteAllText(txtFilePath.Text + "Keithley2461_FileOutput.csv", RsTitle.ToString());

            }

            //Appends file data
            File.AppendAllText(txtFilePath.Text + "Keithley2461_FileOutput.csv", DataAppend.ToString());
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRunSweep_Click(object sender, EventArgs e)
        {
            //=====================================
            //Performs sweep and gets data back
            //=====================================
            string resourceName = "USB0::0x05E6::0x2461::04403896::INSTR"; // See NI MAX for resource name
            string sourcename = "";
            string measurename = "";
            double k = 1.3806488 * Math.Pow(10, -23); //units = J/K
            double q = 1.602 * Math.Pow(10, -19); //units = coulomb
            double T = Convert.ToDouble(txtTemp.Text) + 273.15; //converts temperature from degC to deg K
            int n = Convert.ToInt16(txtNCells.Text); //number of cells in the module
            double Ilow = Convert.ToDouble(txtRsCalculateLow.Text); //Low current to use to calculate the Rs
            double Ihigh = Convert.ToDouble(txtRsCalculateHigh.Text);//High current to use to calculate the Rs
            double Iavg = (Ilow + Ihigh) / 2; //Iaverage to use to calculate the Rs
            double Vlow = -1;
            double Vhigh = -1;


            var visa = new NationalInstruments.VisaNS.MessageBasedSession(resourceName);



            //Disable the runs sweep button
            btnRunSweep.Enabled = false;


            //Writes the settings to run sweep
            visa.Write("localnode.prompts = localnode.DISABLE");
            visa.Write("currentLevel = 10");
            visa.Write("vLimit = 2"); //+ txtBiasLimit.Text);
            visa.Write("vPulseLimit = 100"); // + txtLimitValue.Text);
            visa.Write("pulseWidth = " + txtPulseWidth.Text);
            visa.Write("pulsePeriod = 0.05");
            visa.Write("point = "+txtNumberPulses.Text);
            visa.Write("reset()");
            visa.Write("eventlog.clear()");
            visa.Write("defbuffer1.clear()");
            visa.Write("vLimit = 2"); // + txtBiasVoltage.Text);
            visa.Write("bias_level = " + txtBiasVoltage.Text);
            visa.Write("start = "+txtStartValue.Text);
            visa.Write("stop = "+txtStopValue.Text);
            visa.Write("points = "+txtNumberPulses.Text);
            visa.Write("pw = 0.00091");
            visa.Write("offTime = "+txtOffTime.Text);
            visa.Write("sdly = " + txtDelay.Text);
            if (radCurrentSweep.Checked == true)
            {
                sourcename = "FUNC_DC_CURRENT";
                measurename = "FUNC_DC_VOLTAGE";
            }
            else
            {
                sourcename = "FUNC_DC_VOLTAGE";
                measurename = "FUNC_DC_CURRENT";
            }
            visa.Write("smu.source.func = smu.FUNC_DC_CURRENT");// + sourcename);
            visa.Write("smu.source.autorange = smu.OFF");
            visa.Write("smu.source.range = 1");  //do not use EOA range
            visa.Write("smu.source.level = 0");
            visa.Write("smu.source.readback = smu.OFF");
            visa.Write("smu.source.autodelay = smu.OFF");
            visa.Write("smu.source.vlimit.level = 100"); //+ txtLimitValue.Text);
            visa.Write("if eventlog.getcount() > 0 then exit() end");
            visa.Write("smu.measure.func = smu.FUNC_DC_VOLTAGE");// + measurename);
            visa.Write("smu.measure.autorange = smu.OFF");
            visa.Write("smu.measure.range = 100");// + txtLimitValue.Text);
            visa.Write("smu.measure.nplc = 0.01");
            visa.Write("smu.measure.sense = smu.SENSE_4WIRE");
            visa.Write("smu.measure.terminals = smu.TERMINALS_FRONT");
            visa.Write("smu.measure.autozero.enable = smu.OFF");
            //visa.Write("smu.source.pulsesweeplinear(\"CurrPulse\"," + txtBiasVoltage.Text + "," + txtStartValue.Text +
            //    "," + txtStopValue.Text + "," + txtNumberPulses.Text + "," + txtPulseWidth.Text + "," + "smu.ON, " +
            //    "defbuffer1," + txtDelay.Text + "," + 
            //    txtOffTime.Text + ",1,"+ txtBiasLimit.Text + "," + txtLimitValue.Text + ",smu.OFF,smu.OFF)");
            visa.Write("smu.source.pulsesweeplinear(\"CurrPulse\", bias_level, start, stop, points, pw, smu.ON, defbuffer1, " +
                "sdly, offTime, 1, vLimit, vPulseLimit, smu.OFF, smu.OFF)");
            //visa.Write("smu.source.pulsesweeplinear(\"CurrPulse\", 0, 0, 10, 21, 0.00091, smu.ON, defbuffer1, " +
            //    "0, 0.1, 1, 2, 100, smu.OFF, smu.OFF)");
            visa.Write("if eventlog.getcount(eventlog.SEV_WARN | eventlog.SEV_ERROR) > 0 then print(\"error with pulse api\") exit() end");
            visa.Write("trigger.model.initiate()");
            visa.Write("waitcomplete()");
            visa.Write("printbuffer(1, points, defbuffer1.sourcevalues, defbuffer1.readings)");

            //Reads the data back
            Console.WriteLine("Printing Data");
            int visatimeout = int.Parse(txtTimeOut.Text);
            visa.Timeout = visatimeout;
            string strIVData = visa.ReadString();
            Console.WriteLine(strIVData);
            visa.Write("prompting = localnode.ENABLE");

            //Enables the sweep button again
            btnRunSweep.Enabled = true;


            //=====================================
            //Plots the graph
            //=====================================           

            //Splits the IV curve into an array
            string[] arrIVData = strIVData.Split(',');

            //Finds the number of IV entires in the data
            intNumberOfEntries = arrIVData.Length / 2;

            //Creates the IV curve array
            var npIVCurve = np.zeros(2, intNumberOfEntries+1);

            //Copies array into global array
            arrData = npIVCurve;


            //Loops through the string, parsing the data as we go along
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                //Fills in the current
                npIVCurve[1, i] = Convert.ToDouble(arrIVData[i*2]);


                //Fills in the voltage
                npIVCurve[2, i] = Convert.ToDouble(arrIVData[i*2+1]);
            }

            //Plots the IV curve data
            chtIVCurve.Series.Add("Sample " + intChart.ToString());
            chtIVCurve.Series["Sample " + intChart.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                chtIVCurve.Series["Sample " + intChart.ToString()].Points.AddXY(npIVCurve[2, i], npIVCurve[1, i]);
            }

            //Increments the chart number
            intChart++;

            //Formats the X axis so that we only have a sane number of digits
            chtIVCurve.ChartAreas[0].AxisX.LabelStyle.Format = "#";

            //Calculates series resistance
            CalculateRs();

            //=====================================
            //Export to CSV and JPG
            //=====================================

            //Exports file to CSV
            var csv = new StringBuilder();

            //Writes the title of the IV curve data
            var firstLine = string.Format("{0},{1}", "Voltage[V]", "Current [i]");
            csv.AppendLine(firstLine);

            //Writes the IV curve data
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                var newLine = string.Format("{0},{1}", npIVCurve[2, i], npIVCurve[1, i]);
                csv.AppendLine(newLine);
            }       

            //Writes the CSV files
            File.WriteAllText(txtFilePath.Text + txtSampleName.Text+".csv", csv.ToString());
            

            //Exports JPG
            chtIVCurve.SaveImage(txtFilePath.Text + txtSampleName.Text + ".jpg", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void txtRsCalculateHigh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReDoAnalysis_Click(object sender, EventArgs e)
        {
            //Calculates series resistance
            CalculateRs();
        }
    }
}

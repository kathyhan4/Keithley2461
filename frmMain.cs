using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnRunSweep_Click(object sender, EventArgs e)
        {
            string resourceName = "USB0::0x05E6::0x2461::04403896::INSTR"; // See NI MAX for resource name
            string sourcename = "";
            string measurename = "";
            var visa = new NationalInstruments.VisaNS.MessageBasedSession(resourceName);


            //Disable the runs sweep button
            btnRunSweep.Enabled = false;


            //Writes the settings to run sweep
            visa.Write("localnode.prompts = localnode.DISABLE");
            visa.Write("local currentLevel = 10");
            visa.Write("local vLimit = 2"); //+ txtBiasLimit.Text);
            visa.Write("local vPulseLimit = 100"); // + txtLimitValue.Text);
            visa.Write("local pulseWidth = 0.001"); // + txtPulseWidth.Text);
            visa.Write("local pulsePeriod = 0.05");
            visa.Write("local point = 21"); // + txtNumberPulses.Text);
            visa.Write("reset()");
            visa.Write("eventlog.clear()");
            visa.Write("defbuffer1.clear()");
            visa.Write("vLimit = 2"); // + txtBiasVoltage.Text);
            visa.Write("bias_level = " + txtBiasVoltage.Text);
            visa.Write("start = " + txtStartValue.Text);
            visa.Write("stop = " + txtStopValue.Text);
            visa.Write("points = " + txtNumberPulses.Text);
            visa.Write("pw = 0.00091");
            visa.Write("offTime = " + txtOffTime.Text);
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
            //visa.Write("smu.source.pulsesweeplinear(\"CurrPulse\", bias_level, start, stop, points, pw, smu.ON, defbuffer1, " +
            //    "sdly, offTime, 1, vLimit, vPulseLimit, smu.OFF, smu.OFF)");
            visa.Write("smu.source.pulsesweeplinear(\"CurrPulse\", 0, 0, 10, 21, 0.00091, smu.ON, defbuffer1, " +
                "0, 0.1, 1, 2, 100, smu.OFF, smu.OFF)");
            visa.Write("if eventlog.getcount(eventlog.SEV_WARN | eventlog.SEV_ERROR) > 0 then print(\"error with pulse api\") exit() end");
            visa.Write("trigger.model.initiate()");
            visa.Write("waitcomplete()");
            visa.Write("printbuffer(1, 21, defbuffer1.sourcevalues, defbuffer1.readings)");

            //Reads the data back
            Console.WriteLine("Printing Data");
            visa.Timeout = 4000;
            string strIVData = visa.ReadString();
            Console.WriteLine(strIVData);
            visa.Write("prompting = localnode.ENABLE");

            //Enables the sweep button again
            btnRunSweep.Enabled = true;


            //Playground

            

            //Splits the IV curve into an array
            string[] arrIVData = strIVData.Split(',');

            //Finds the number of IV entires in the data
            int intNumberOfEntries = arrIVData.Length / 2;

            //Creates the IV curve array
            var npIVCurve = np.zeros(2, intNumberOfEntries+1);

            //Loops through the string, parsing the data as we go along
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                //Fills in the current
                npIVCurve[1, i] = Convert.ToDouble(arrIVData[i*2]);

                //Fills in the voltage
                npIVCurve[2, i] = Convert.ToDouble(arrIVData[i*2+1]);
            }

            //Plots the IV curve data
            for (int i = 0; i < intNumberOfEntries; i++)
            {
                chtIVCurve.Series["serIV"].Points.AddXY(npIVCurve[2, i], npIVCurve[1, i]);
            }

        }
    }
}

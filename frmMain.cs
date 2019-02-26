using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //string debug3 = visa.ReadString();
            //Console.WriteLine(debug3);

            visa.Write("localnode.prompts = localnode.DISABLE");
            //visa.Write("*IDN?"); // write to instrument
            visa.Write("print(localnode.serialno)");
            string res = visa.ReadString(); // read from instrument
            Console.WriteLine(res);

            lblIDN.Text = res;


            visa.Write("local currentLevel = 10");
            Console.WriteLine("testing1");
            visa.Write("print (currentLevel)");
            string debug2 = visa.ReadString(); // read from instrument
            Console.WriteLine(debug2);

            Console.WriteLine("testing2");

            visa.Write("local vLimit = 2"); //+ txtBiasLimit.Text);
            visa.Write("local vPulseLimit = 100"); // + txtLimitValue.Text);
            visa.Write("local pulseWidth = 0.001"); // + txtPulseWidth.Text);
            visa.Write("local pulsePeriod = 0.05");
            visa.Write("local point = 21"); // + txtNumberPulses.Text);

            visa.Write("reset()");
            visa.Write("eventlog.clear()");
            visa.Write("defbuffer1.clear()");
            //visa.Write("configListName = \"CurrPulse\"");

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

            //visa.Write("if eventlog.getcount(eventlog.SEV_WARN | eventlog.SEV_ERROR) > 0 then print(\"error with source / measure set up\") exit() end");


            visa.Write("print (vLimit)");
            string debug1 = visa.ReadString(); // read from instrument
            Console.WriteLine(debug1);

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
            Console.WriteLine("step 0");
            //System.Threading.Thread.Sleep(3000);

            visa.Write("waitcomplete()");
            //visa.Write("if eventlog.getcount(eventlog.SEV_WARN | eventlog.SEV_ERROR) > 0 then print(\"error during trigger model execution\") exit() end");

            //for (int i = 1; i == Convert.ToInt32(txtNumberPulses.Text); i++)
            //{
            //    visa.Write("print(\"Pt \","+i.ToString()+ ", \"val(V)\",  defbuffer1[" + i.ToString() + "], \"source(A)\", " +
            //        "defbuffer1.sourcevalues[" + i.ToString() + "])");
            //    System.Threading.Thread.Sleep(10);
            //    string data = visa.ReadString(); // read from instrument
            //    Console.WriteLine(data);
            //}

            //visa.Write("smu.read(defbuffer1)");
            //visa.Write("for i = 1, defbuffer1.n do");
            //visa.Write("print(defbuffer1.relativetimestamps[i], defbuffer1[i])");
            //visa.Write("end");
            //visa.Write("smu.source.output = smu.OFF");

            //Console.WriteLine("step 1");
            System.Threading.Thread.Sleep(2000);
            //Console.WriteLine("step 2");
            visa.Write("printbuffer(1, 21, defbuffer1.sourcevalues, defbuffer1.readings)");

            //visa.Write("for i = 1, points do ");
            //visa.Write("print(\"Pt \",i, \"val(V)\",  defbuffer1[i], \"source(A)\", defbuffer1.sourcevalues[i])");
            //visa.Write("end");

            Console.WriteLine("step 3");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("step 4");
            //for (int i = 1; i == Convert.ToInt32(txtNumberPulses.Text); i++)
            //{
            //    string data1 = visa.ReadString();
            //    Console.WriteLine(data1);
            //}
            Console.WriteLine("step 5");
            //System.Threading.Thread.Sleep(2000);
            Console.WriteLine("step 6");
            // "+ txtNumberPulses.Text+"
            string data5 = visa.ReadString();
            Console.WriteLine(data5);

            //visa.Write("printbuffer(1," + txtNumberPulses.Text + ", defbuffer1.sourcevalues, defbuffer1.readings)");
            //visa.Write("print(\"Pt\", i, \"val (V)\", defbuffer1[i], \"source (A)\", defbuffer1.sourcevalues[i])");

            visa.Write("prompting = localnode.ENABLE");
        }
    }
}

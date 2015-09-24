using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            double Input1 = 0;
            double Input2 = 0;
            double Output = 0;

            Input1 = Convert.ToDouble(tbE1.Text);
            Input2 = Convert.ToDouble(tbE2.Text);

            Output = Input1 - Input2;       
            if (Output < 0)
            {
                Output = Input2 - Input1;
            }
            lbOut.Text = Output.ToString();



        }

        private void btM_Click(object sender, EventArgs e)
        {
            double Input = 0;
            double InputMeter = 0;
            double OutputStecke = 0;            

            Input = Convert.ToDouble(tbM1.Text);

            //Eingabe erster Wert
            if (rbvFuß.Checked)
            {
                if (rbFuß.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 0.3048;
            }
            if (rbvZoll.Checked)
            {
                if (rbZoll.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 0.0254;
            }
            if (rbvYard.Checked)
            {
                if (rbYard.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 0.9144;
            }
            if (rbvFathom.Checked)
            {
                if (rbFathom.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 0.546806649;
            }
            if (rbvRod.Checked)
            {
                if (rbRod.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 5.0292;
            }
            if (rbvLichtjahre.Checked)
            {
                InputMeter = Input * 9460528000000000;
            }
            if (rbvparsec.Checked)
            {
                if (rbvparsec.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 30856780000000000;
            }
            if (rbvÅngström.Checked)
            {
                if(rbÅngström.Checked)
                {
                    OutputStecke = Input;
                    goto Ende;
                }
                InputMeter = Input * 0.0000000001;
            }
            //Eingabe zweiter Wert
            if (rbvMeter.Checked)
            {
                InputMeter = Input;
            }
            if (rbFuß.Checked)
            {
                OutputStecke = InputMeter * 3.2808398950131;
            }
            if (rbZoll.Checked)
            {
                OutputStecke = InputMeter * 39.3700787;
            }
            if (rbYard.Checked)
            {
                OutputStecke = InputMeter * 1.09361;
            }
            if (rbFathom.Checked)
            {
                OutputStecke = InputMeter * 0.546807;
            }
            if (rbRod.Checked)
            {
                OutputStecke = InputMeter * 0.198839;
            }
            if (rbLichtjahre.Checked)
            {
                OutputStecke = InputMeter * 0.0000000000105702;
            }
            if (rbparsec.Checked)
            {
                OutputStecke = InputMeter * 0.00000000000324078;
            }
            if (rbÅngström.Checked)
            {
                OutputStecke = InputMeter * 10000000000;
            }
            if (rbMeter.Checked)
            {
                OutputStecke = InputMeter;
            }
            //Ausgabe des Ergebinnis
            goto Ende;
            Ende:
            {
                OutputStecke = Math.Round(OutputStecke, 6);
                lbMout.Text = OutputStecke.ToString();
            }                     
            
        }

    }
}

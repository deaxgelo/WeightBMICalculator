using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightCalculator
{
    public partial class WeightCalculator : Form
    {
       


        public WeightCalculator()
        {
            InitializeComponent();
        }

        private void lblWaist_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

            //Labels change when male is checked

            lblWaist.Text = "WAIST - Measure at greatest circumference: relaxed and comfortable.";
            lblThighs.Text = "HIPS - Feet 4 inches apart. Measure greatest circumference around hips and butt";
            lblCalf.Text = "FOREARM - Clench fist. Measure widest part between wrist and elbow.";
            lblWrist.Text = "WRIST - Measure just above bony protuberance towards the hand.";
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblWaist.Text = "HIPS - Feet 4 inches apart. measure greatest circumference around hips and butt.";
            lblThighs.Text = "THIGH - Stand with feet 12 inches apart. measure part of upper thigh.";
            lblCalf.Text = "CALF - Stand with weight on both feet. Widest part midway between knee and ankle";
            lblWrist.Text = "WRIST - Measure just above bony protuberance towards the hand.";


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Wrist;
            double Waist;
            double Weight;
            double Thigh;
            double Forearm;
            double Calf;
            double Hips;
            double Bodyfat;
            double Fat;
            double lean;
            double IdealWeight;

            //men under 30
            if ((rdoMale.Checked == true) && (rdo30aU.Checked == true))
            {
                lblResults.Text = "";

                double.TryParse(txtWaist.Text, out Waist);
                //double.TryParse(txtThigh.Text, out Thigh);
                // double.TryParse(txtCalf.Text, out Calf);
                double.TryParse(txtWrist.Text, out Wrist);
                double.TryParse(txtWeight.Text, out Weight);
                double.TryParse(txtThigh.Text, out Hips);
                double.TryParse(txtCalf.Text, out Forearm);



                Bodyfat = Waist + (0.5 * Hips) - (3 * Forearm) - Wrist;
                Fat = (Bodyfat * 0.01) * Weight;
                lean = Weight - Fat;
                IdealWeight = lean / 0.85;

                lblResults.Text = ("You have about " + lean.ToString("0") + "Ibs of lean body weight with " + Fat.ToString("0") +
                    " Ibs of fat (" + Bodyfat.ToString("0") +
                    "%). " +
                    "You should weigh no more than 172 Ibs (15% fat)");

            }


            //men over 30
            if ((rdoMale.Checked == true) && (rdoOver30.Checked == true))
            {
                lblResults.Text = "";

                double.TryParse(txtWaist.Text, out Waist);
                // double.TryParse(txtThigh.Text,out Thigh);
                // dont need  double.TryParse(txtCalf.Text,out Calf)
                double.TryParse(txtWrist.Text, out Wrist);
                double.TryParse(txtWeight.Text, out Weight);
                double.TryParse(txtThigh.Text, out Hips);
                double.TryParse(txtCalf.Text, out Forearm);

                //double BodyFatOver2;
                // BodyFatOver2 = Waist + (.5 * Hips) - (2.7 * Forearm) - Wrist;

                //double Bodyfatpounds;
                // Bodyfatpounds = Weight * (BodyFatOver2 * 0.1);

                // double leanOver30;
                // leanOver30 = Weight - Bodyfatpounds;

                //int percent15;
                // percent15 = 15;

                double
                BodyfatMenOver30 = Waist + (.5 * Hips) - (2.7 * Forearm) - Wrist;
                double MenFatOver30 = (BodyfatMenOver30 * .01) * Weight;
                double leanMenOver30 = (Weight - MenFatOver30);
                double IdealWeightMenOver30 = leanMenOver30 / .85;

                lblResults.Text = ("You have about " + leanMenOver30.ToString("0") + "Ibs of lean body weight with " + MenFatOver30.ToString("0") +
                    " Ibs of fat (" + BodyfatMenOver30.ToString("0") +
                    "%). " +
                    "You should weight no more than 172 Ibs (15% fat)");


              
                //lblResults.Text = ("You have about " + leanMenOver30.ToString("0") + "Ibs of lean body weight with " + Bodyfatpound.ToString("0") +
                    //" Ibs of fat (" + BodyFatOver2.ToString("0") +
                   // "%)." +
                   // " You should weigh no more than " + IdealWeight.ToString("0") + "Ibs" + " (" + percent15.ToString("0"));
            }
            //women over 30
            if ((rdoFemale.Checked == true) && (rdo30aU.Checked == true))
            {
                lblResults.Text = "";

                double.TryParse(txtWrist.Text, out Wrist);
                double.TryParse(txtWeight.Text, out Weight);
                double.TryParse(txtWaist.Text, out Hips);
                double.TryParse(txtCalf.Text, out Calf);
                double.TryParse(txtThigh.Text, out Thigh);

                double BodyFatFemaleOver30 = (Hips + Thigh) - (2 * Calf) - Wrist;
                double FemaleFatOver30 = (BodyFatFemaleOver30 * 0.01) * Weight;
                double leanFemaleOver30 = (Weight - FemaleFatOver30);
                double IdealWeightFemaleOver30 = leanFemaleOver30 / 0.78;

                lblResults.Text = ("You have about " + leanFemaleOver30.ToString("0") + "Ibs of lean body weight with " + FemaleFatOver30.ToString("0") +
                    " Ibs of fat (" + BodyFatFemaleOver30.ToString("0") +
                    "%)." +
                    " You should weigh no more than 168 Ibs (22% fat)");

            
            }
           // women under 30
            if ((rdoFemale.Checked == true) && (rdoOver30.Checked == true))
            {
                lblResults.Text = "";
                double.TryParse(txtWrist.Text, out Wrist);
                double.TryParse(txtWeight.Text, out Weight);
                double.TryParse(txtWaist.Text, out Hips);
                double.TryParse(txtCalf.Text, out Calf);
                double.TryParse(txtThigh.Text, out Thigh);

                double BodyFatFemaleUnder30 = Hips + (.80 * Thigh) - (2 * Calf) - Wrist;
                double FemaleFatUnder30 = (BodyFatFemaleUnder30 * 0.01) * Weight;
                double leanFemaleUnder30 = (Weight - FemaleFatUnder30);
                double IdealWeightFemaleUnder30 = leanFemaleUnder30 / 0.78;

                lblResults.Text = ("You have about " + leanFemaleUnder30.ToString("0") + "Ibs of lean body weight with " + FemaleFatUnder30.ToString("0") +
                    " Ibs of fat (" + BodyFatFemaleUnder30.ToString("0") +
                    "%)." +
                    " You should weigh no more than 168 Ibs (22% fat)");
            }
                
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCalf.Text = "";
            txtThigh.Text = "";
            txtWaist.Text = "";
            txtWeight.Text = "";
            txtWrist.Text = "";
            lblResults.Text = "";

            rdo30aU.Checked = true;
            rdoMale.Checked = true;
        }
    }
}
